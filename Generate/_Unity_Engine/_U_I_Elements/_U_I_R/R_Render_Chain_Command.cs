
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.RenderChainCommand
	/// </summary>
    public partial class RRenderChainCommand : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand");
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


		/// <summary>
		/// UnityEngine.UIElements.VisualElement owner
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fowner;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFowner
		{
			get
			{
				if(r_Fowner == null)
				{
					r_Fowner = new(this, "owner");
				}
				return r_Fowner;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand prev
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_Fprev;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFprev
		{
			get
			{
				if(r_Fprev == null)
				{
					r_Fprev = new(this, "prev");
				}
				return r_Fprev;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand next
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_Fnext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// System.Boolean closing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fclosing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFclosing
		{
			get
			{
				if(r_Fclosing == null)
				{
					r_Fclosing = new(this, "closing");
				}
				return r_Fclosing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_Ftype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.State state
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RState r_Fstate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RState RFstate
		{
			get
			{
				if(r_Fstate == null)
				{
					r_Fstate = new(this, "state");
				}
				return r_Fstate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle mesh
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshHandle r_Fmesh;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshHandle RFmesh
		{
			get
			{
				if(r_Fmesh == null)
				{
					r_Fmesh = new(this, "mesh");
				}
				return r_Fmesh;
			}
		}

		/// <summary>
		/// System.Int32 indexOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FindexOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFindexOffset
		{
			get
			{
				if(r_FindexOffset == null)
				{
					r_FindexOffset = new(this, "indexOffset");
				}
				return r_FindexOffset;
			}
		}

		/// <summary>
		/// System.Int32 indexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FindexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFindexCount
		{
			get
			{
				if(r_FindexCount == null)
				{
					r_FindexCount = new(this, "indexCount");
				}
				return r_FindexCount;
			}
		}

		/// <summary>
		/// System.Action callback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Fcallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFcallback
		{
			get
			{
				if(r_Fcallback == null)
				{
					r_Fcallback = new(this, "callback");
				}
				return r_Fcallback;
			}
		}

		/// <summary>
		/// System.Int32 k_ID_MainTex
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_ID_MainTex;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_ID_MainTex
		{
			get
			{
				if(r_Fk_ID_MainTex == null)
				{
					r_Fk_ID_MainTex = new(Type, "k_ID_MainTex");
				}
				return r_Fk_ID_MainTex;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_ImmediateOverheadMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_ImmediateOverheadMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_ImmediateOverheadMarker
		{
			get
			{
				if(r_Fs_ImmediateOverheadMarker == null)
				{
					r_Fs_ImmediateOverheadMarker = new(Type, "s_ImmediateOverheadMarker");
				}
				return r_Fs_ImmediateOverheadMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand poolNext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FpoolNext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFpoolNext
		{
			get
			{
				if(r_FpoolNext == null)
				{
					r_FpoolNext = new(this, "poolNext");
				}
				return r_FpoolNext;
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
		/// Void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams, Single, System.Exception ByRef)
		/// </summary>
		protected RMethod r_MExecuteNonDrawMesh_DrawParams_Single_Ref_Exception;
		public virtual RMethod RMExecuteNonDrawMesh_DrawParams_Single_Ref_Exception
		{
			get
			{
				if(r_MExecuteNonDrawMesh_DrawParams_Single_Ref_Exception == null)
				{
					r_MExecuteNonDrawMesh_DrawParams_Single_Ref_Exception = new(this, "ExecuteNonDrawMesh", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawParams"), typeof(System.Single), typeof(System.Exception).MakeByRefType());
				}
				return r_MExecuteNonDrawMesh_DrawParams_Single_Ref_Exception;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture, UnityEngine.RenderTexture, Single)
		/// </summary>
		protected RMethod r_MBlit_Texture_RenderTexture_Single;
		public virtual RMethod RMBlit_Texture_RenderTexture_Single
		{
			get
			{
				if(r_MBlit_Texture_RenderTexture_Single == null)
				{
					r_MBlit_Texture_RenderTexture_Single = new(this, "Blit", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(System.Single));
				}
				return r_MBlit_Texture_RenderTexture_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 RectToClipSpace(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MRectToClipSpace_Rect;
		public static RMethod RMRectToClipSpace_Rect
		{
			get
			{
				if(r_MRectToClipSpace_Rect == null)
				{
					r_MRectToClipSpace_Rect = new(Type, "RectToClipSpace", 0, typeof(UnityEngine.Rect));
				}
				return r_MRectToClipSpace_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CombineScissorRects(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MCombineScissorRects_Rect_Rect;
		public static RMethod RMCombineScissorRects_Rect_Rect
		{
			get
			{
				if(r_MCombineScissorRects_Rect_Rect == null)
				{
					r_MCombineScissorRects_Rect_Rect = new(Type, "CombineScissorRects", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
				}
				return r_MCombineScissorRects_Rect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect, Single)
		/// </summary>
		protected static RMethod r_MRectPointsToPixelsAndFlipYAxis_Rect_Single;
		public static RMethod RMRectPointsToPixelsAndFlipYAxis_Rect_Single
		{
			get
			{
				if(r_MRectPointsToPixelsAndFlipYAxis_Rect_Single == null)
				{
					r_MRectPointsToPixelsAndFlipYAxis_Rect_Single = new(Type, "RectPointsToPixelsAndFlipYAxis", 0, typeof(UnityEngine.Rect), typeof(System.Single));
				}
				return r_MRectPointsToPixelsAndFlipYAxis_Rect_Single;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteNonDrawMesh(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RDrawParams @drawParams, System.Single @pixelsPerPoint, ref System.Exception @immediateException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@drawParams.Value, @pixelsPerPoint, @immediateException};
            var ___result = RMExecuteNonDrawMesh_DrawParams_Single_Ref_Exception.Invoke(___genericsType, ___parameters);
			@immediateException = ReflectionUtils.Convert<System.Exception>(___parameters[2]);

            
        }


        public virtual void Blit(UnityEngine.Texture @source, UnityEngine.RenderTexture @destination, System.Single @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destination, @depth};
            var ___result = RMBlit_Texture_RenderTexture_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector4 RectToClipSpace(UnityEngine.Rect @rc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rc};
            var ___result = RMRectToClipSpace_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector4>(___result);
        }


        public static UnityEngine.Rect CombineScissorRects(UnityEngine.Rect @r0, UnityEngine.Rect @r1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r0, @r1};
            var ___result = RMCombineScissorRects_Rect_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect @rect, System.Single @pixelsPerPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pixelsPerPoint};
            var ___result = RMRectPointsToPixelsAndFlipYAxis_Rect_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RectInt>(___result);
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
