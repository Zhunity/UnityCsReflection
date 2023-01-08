using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.RenderChainCommand
	/// </summary>
    public partial class RRenderChainCommand : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement owner
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_owner;
		public virtual RUnityEngine.RUIElements.RVisualElement Rowner
		{
			get
			{
				if(r_owner == null)
				{
					r_owner = new(this, "owner");
					r_owner.SetBelong(this.instance);
				}
				return r_owner;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand prev
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_prev;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand Rprev
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
		/// UnityEngine.UIElements.UIR.RenderChainCommand next
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_next;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand Rnext
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
		/// System.Boolean closing
		/// </summary>
		protected RField r_closing;
		public virtual RField Rclosing
		{
			get
			{
				if(r_closing == null)
				{
					r_closing = new(this, "closing");
					r_closing.SetBelong(this.instance);
				}
				return r_closing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.State state
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RState r_state;
		public virtual RUnityEngine.RUIElements.RUIR.RState Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle mesh
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_mesh;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle Rmesh
		{
			get
			{
				if(r_mesh == null)
				{
					r_mesh = new(this, "mesh");
					r_mesh.SetBelong(this.instance);
				}
				return r_mesh;
			}
		}

		/// <summary>
		/// System.Int32 indexOffset
		/// </summary>
		protected RField r_indexOffset;
		public virtual RField RindexOffset
		{
			get
			{
				if(r_indexOffset == null)
				{
					r_indexOffset = new(this, "indexOffset");
					r_indexOffset.SetBelong(this.instance);
				}
				return r_indexOffset;
			}
		}

		/// <summary>
		/// System.Int32 indexCount
		/// </summary>
		protected RField r_indexCount;
		public virtual RField RindexCount
		{
			get
			{
				if(r_indexCount == null)
				{
					r_indexCount = new(this, "indexCount");
					r_indexCount.SetBelong(this.instance);
				}
				return r_indexCount;
			}
		}

		/// <summary>
		/// System.Action callback
		/// </summary>
		protected RSystem.RAction r_callback;
		public virtual RSystem.RAction Rcallback
		{
			get
			{
				if(r_callback == null)
				{
					r_callback = new(this, "callback");
					r_callback.SetBelong(this.instance);
				}
				return r_callback;
			}
		}

		/// <summary>
		/// System.Int32 k_ID_MainTex
		/// </summary>
		protected static RField r_k_ID_MainTex;
		public static RField Rk_ID_MainTex
		{
			get
			{
				if(r_k_ID_MainTex == null)
				{
					r_k_ID_MainTex = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), "k_ID_MainTex");
					r_k_ID_MainTex.SetBelong(null);
				}
				return r_k_ID_MainTex;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_ImmediateOverheadMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_ImmediateOverheadMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_ImmediateOverheadMarker
		{
			get
			{
				if(r_s_ImmediateOverheadMarker == null)
				{
					r_s_ImmediateOverheadMarker = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), "s_ImmediateOverheadMarker");
					r_s_ImmediateOverheadMarker.SetBelong(null);
				}
				return r_s_ImmediateOverheadMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand poolNext
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_poolNext;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RpoolNext
		{
			get
			{
				if(r_poolNext == null)
				{
					r_poolNext = new(this, "poolNext");
					r_poolNext.SetBelong(this.instance);
				}
				return r_poolNext;
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
		/// Void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams, Single, System.Exception ByRef)
		/// </summary>
		protected RMethod r_ExecuteNonDrawMesh_DrawParams_Single_Ref_Exception;
		public virtual RMethod RExecuteNonDrawMesh_DrawParams_Single_Ref_Exception
		{
			get
			{
				if(r_ExecuteNonDrawMesh_DrawParams_Single_Ref_Exception == null)
				{
					r_ExecuteNonDrawMesh_DrawParams_Single_Ref_Exception = new(this, "ExecuteNonDrawMesh", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawParams"), typeof(System.Single), typeof(System.Exception).MakeByRefType());
					r_ExecuteNonDrawMesh_DrawParams_Single_Ref_Exception.SetBelong(this.instance);
				}
				return r_ExecuteNonDrawMesh_DrawParams_Single_Ref_Exception;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.RenderTexture, Single)
		/// </summary>
		protected RMethod r_Blit_Texture_RenderTexture_Single;
		public virtual RMethod RBlit_Texture_RenderTexture_Single
		{
			get
			{
				if(r_Blit_Texture_RenderTexture_Single == null)
				{
					r_Blit_Texture_RenderTexture_Single = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(System.Single));
					r_Blit_Texture_RenderTexture_Single.SetBelong(this.instance);
				}
				return r_Blit_Texture_RenderTexture_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 RectToClipSpace(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RectToClipSpace_Rect;
		public static RMethod RRectToClipSpace_Rect
		{
			get
			{
				if(r_RectToClipSpace_Rect == null)
				{
					r_RectToClipSpace_Rect = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), "RectToClipSpace", 0, typeof(UnityEngine.Rect));
					r_RectToClipSpace_Rect.SetBelong(null);
				}
				return r_RectToClipSpace_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CombineScissorRects(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_CombineScissorRects_Rect_Rect;
		public static RMethod RCombineScissorRects_Rect_Rect
		{
			get
			{
				if(r_CombineScissorRects_Rect_Rect == null)
				{
					r_CombineScissorRects_Rect_Rect = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), "CombineScissorRects", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_CombineScissorRects_Rect_Rect.SetBelong(null);
				}
				return r_CombineScissorRects_Rect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect, Single)
		/// </summary>
		protected static RMethod r_RectPointsToPixelsAndFlipYAxis_Rect_Single;
		public static RMethod RRectPointsToPixelsAndFlipYAxis_Rect_Single
		{
			get
			{
				if(r_RectPointsToPixelsAndFlipYAxis_Rect_Single == null)
				{
					r_RectPointsToPixelsAndFlipYAxis_Rect_Single = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"), "RectPointsToPixelsAndFlipYAxis", 0, typeof(UnityEngine.Rect), typeof(System.Single));
					r_RectPointsToPixelsAndFlipYAxis_Rect_Single.SetBelong(null);
				}
				return r_RectPointsToPixelsAndFlipYAxis_Rect_Single;
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


        public RRenderChainCommand() : base("UnityEngine.UIElements.UIR.RenderChainCommand")
        {
        }

        public RRenderChainCommand(System.Object instance) : base("UnityEngine.UIElements.UIR.RenderChainCommand")
		{
            SetInstance(instance);
		}

        public RRenderChainCommand(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderChainCommand(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Blit(UnityEngine.Texture  @source, UnityEngine.RenderTexture  @destination, System.Single  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destination, @depth};
            var ___result = RBlit_Texture_RenderTexture_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector4 RectToClipSpace(UnityEngine.Rect  @rc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rc};
            var ___result = RRectToClipSpace_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Rect CombineScissorRects(UnityEngine.Rect  @r0, UnityEngine.Rect  @r1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r0, @r1};
            var ___result = RCombineScissorRects_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect  @rect, System.Single  @pixelsPerPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pixelsPerPoint};
            var ___result = RRectPointsToPixelsAndFlipYAxis_Rect_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RectInt)___result;
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
