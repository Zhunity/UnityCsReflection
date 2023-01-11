using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Painter2D
	/// </summary>
    public partial class RPainter2D : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.MeshGenerationContext m_Ctx
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshGenerationContext r_m_Ctx;
		public virtual RUnityEngine.RUIElements.RMeshGenerationContext Rm_Ctx
		{
			get
			{
				if(r_m_Ctx == null)
				{
					r_m_Ctx = new(this, "m_Ctx");
					r_m_Ctx.SetBelong(this.instance);
				}
				return r_m_Ctx;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.DetachedAllocator m_DetachedAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RDetachedAllocator r_m_DetachedAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RDetachedAllocator Rm_DetachedAllocator
		{
			get
			{
				if(r_m_DetachedAllocator == null)
				{
					r_m_DetachedAllocator = new(this, "m_DetachedAllocator");
					r_m_DetachedAllocator.SetBelong(this.instance);
				}
				return r_m_DetachedAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.SafeHandleAccess m_Handle
		/// </summary>
		protected RUnityEngine.RUIElements.RSafeHandleAccess r_m_Handle;
		public virtual RUnityEngine.RUIElements.RSafeHandleAccess Rm_Handle
		{
			get
			{
				if(r_m_Handle == null)
				{
					r_m_Handle = new(this, "m_Handle");
					r_m_Handle.SetBelong(this.instance);
				}
				return r_m_Handle;
			}
		}

		/// <summary>
		/// System.Boolean m_Disposed
		/// </summary>
		protected RSystem.RBoolean r_m_Disposed;
		public virtual RSystem.RBoolean Rm_Disposed
		{
			get
			{
				if(r_m_Disposed == null)
				{
					r_m_Disposed = new(this, "m_Disposed");
					r_m_Disposed.SetBelong(this.instance);
				}
				return r_m_Disposed;
			}
		}

		/// <summary>
		/// System.Boolean <isPainterActive>k__BackingField
		/// </summary>
		protected static RSystem.RBoolean r___0__isPainterActive__1__k__BackingField;
		public static RSystem.RBoolean R__0__isPainterActive__1__k__BackingField
		{
			get
			{
				if(r___0__isPainterActive__1__k__BackingField == null)
				{
					r___0__isPainterActive__1__k__BackingField = new(typeof(UnityEngine.UIElements.Painter2D), "<isPainterActive>k__BackingField");
					r___0__isPainterActive__1__k__BackingField.SetBelong(null);
				}
				return r___0__isPainterActive__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single s_MaxArcRadius
		/// </summary>
		protected static RSystem.RSingle r_s_MaxArcRadius;
		public static RSystem.RSingle Rs_MaxArcRadius
		{
			get
			{
				if(r_s_MaxArcRadius == null)
				{
					r_s_MaxArcRadius = new(typeof(UnityEngine.UIElements.Painter2D), "s_MaxArcRadius");
					r_s_MaxArcRadius.SetBelong(null);
				}
				return r_s_MaxArcRadius;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_StrokeMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_StrokeMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_StrokeMarker
		{
			get
			{
				if(r_s_StrokeMarker == null)
				{
					r_s_StrokeMarker = new(typeof(UnityEngine.UIElements.Painter2D), "s_StrokeMarker");
					r_s_StrokeMarker.SetBelong(null);
				}
				return r_s_StrokeMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_FillMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_FillMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_FillMarker
		{
			get
			{
				if(r_s_FillMarker == null)
				{
					r_s_FillMarker = new(typeof(UnityEngine.UIElements.Painter2D), "s_FillMarker");
					r_s_FillMarker.SetBelong(null);
				}
				return r_s_FillMarker;
			}
		}

		/// <summary>
		/// Boolean isDetached
		/// </summary>
		protected RSystem.RBoolean r_isDetached;
		public virtual RSystem.RBoolean RisDetached
		{
			get
			{
				if(r_isDetached == null)
				{
					r_isDetached = new(this, "isDetached", -1);
					r_isDetached.SetBelong(this.instance);
				}
				return r_isDetached;
			}
		}

		/// <summary>
		/// Single lineWidth
		/// </summary>
		protected RSystem.RSingle r_lineWidth;
		public virtual RSystem.RSingle RlineWidth
		{
			get
			{
				if(r_lineWidth == null)
				{
					r_lineWidth = new(this, "lineWidth", -1);
					r_lineWidth.SetBelong(this.instance);
				}
				return r_lineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color strokeColor
		/// </summary>
		protected RUnityEngine.RColor r_strokeColor;
		public virtual RUnityEngine.RColor RstrokeColor
		{
			get
			{
				if(r_strokeColor == null)
				{
					r_strokeColor = new(this, "strokeColor", -1);
					r_strokeColor.SetBelong(this.instance);
				}
				return r_strokeColor;
			}
		}

		/// <summary>
		/// UnityEngine.Gradient strokeGradient
		/// </summary>
		protected RUnityEngine.RGradient r_strokeGradient;
		public virtual RUnityEngine.RGradient RstrokeGradient
		{
			get
			{
				if(r_strokeGradient == null)
				{
					r_strokeGradient = new(this, "strokeGradient", -1);
					r_strokeGradient.SetBelong(this.instance);
				}
				return r_strokeGradient;
			}
		}

		/// <summary>
		/// UnityEngine.Color fillColor
		/// </summary>
		protected RUnityEngine.RColor r_fillColor;
		public virtual RUnityEngine.RColor RfillColor
		{
			get
			{
				if(r_fillColor == null)
				{
					r_fillColor = new(this, "fillColor", -1);
					r_fillColor.SetBelong(this.instance);
				}
				return r_fillColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LineJoin lineJoin
		/// </summary>
		protected RProperty r_lineJoin;
		public virtual RProperty RlineJoin
		{
			get
			{
				if(r_lineJoin == null)
				{
					r_lineJoin = new(this, "lineJoin", -1);
					r_lineJoin.SetBelong(this.instance);
				}
				return r_lineJoin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LineCap lineCap
		/// </summary>
		protected RProperty r_lineCap;
		public virtual RProperty RlineCap
		{
			get
			{
				if(r_lineCap == null)
				{
					r_lineCap = new(this, "lineCap", -1);
					r_lineCap.SetBelong(this.instance);
				}
				return r_lineCap;
			}
		}

		/// <summary>
		/// Single miterLimit
		/// </summary>
		protected RSystem.RSingle r_miterLimit;
		public virtual RSystem.RSingle RmiterLimit
		{
			get
			{
				if(r_miterLimit == null)
				{
					r_miterLimit = new(this, "miterLimit", -1);
					r_miterLimit.SetBelong(this.instance);
				}
				return r_miterLimit;
			}
		}

		/// <summary>
		/// Boolean isPainterActive
		/// </summary>
		protected static RSystem.RBoolean r_isPainterActive;
		public static RSystem.RBoolean RisPainterActive
		{
			get
			{
				if(r_isPainterActive == null)
				{
					r_isPainterActive = new(typeof(UnityEngine.UIElements.Painter2D), "isPainterActive", -1);
					r_isPainterActive.SetBelong(null);
				}
				return r_isPainterActive;
			}
		}

		/// <summary>
		/// Single maxArcRadius
		/// </summary>
		protected static RSystem.RSingle r_maxArcRadius;
		public static RSystem.RSingle RmaxArcRadius
		{
			get
			{
				if(r_maxArcRadius == null)
				{
					r_maxArcRadius = new(typeof(UnityEngine.UIElements.Painter2D), "maxArcRadius", -1);
					r_maxArcRadius.SetBelong(null);
				}
				return r_maxArcRadius;
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
		/// UnityEngine.UIElements.MeshWriteData Allocate(Int32, Int32)
		/// </summary>
		protected RMethod r_Allocate_Int32_Int32;
		public virtual RMethod RAllocate_Int32_Int32
		{
			get
			{
				if(r_Allocate_Int32_Int32 == null)
				{
					r_Allocate_Int32_Int32 = new(this, "Allocate", 0, typeof(System.Int32), typeof(System.Int32));
					r_Allocate_Int32_Int32.SetBelong(this.instance);
				}
				return r_Allocate_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// Boolean ValidateState()
		/// </summary>
		protected RMethod r_ValidateState;
		public virtual RMethod RValidateState
		{
			get
			{
				if(r_ValidateState == null)
				{
					r_ValidateState = new(this, "ValidateState", 0);
					r_ValidateState.SetBelong(this.instance);
				}
				return r_ValidateState;
			}
		}

		/// <summary>
		/// Void BeginPath()
		/// </summary>
		protected RMethod r_BeginPath;
		public virtual RMethod RBeginPath
		{
			get
			{
				if(r_BeginPath == null)
				{
					r_BeginPath = new(this, "BeginPath", 0);
					r_BeginPath.SetBelong(this.instance);
				}
				return r_BeginPath;
			}
		}

		/// <summary>
		/// Void ClosePath()
		/// </summary>
		protected RMethod r_ClosePath;
		public virtual RMethod RClosePath
		{
			get
			{
				if(r_ClosePath == null)
				{
					r_ClosePath = new(this, "ClosePath", 0);
					r_ClosePath.SetBelong(this.instance);
				}
				return r_ClosePath;
			}
		}

		/// <summary>
		/// Void MoveTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MoveTo_Vector2;
		public virtual RMethod RMoveTo_Vector2
		{
			get
			{
				if(r_MoveTo_Vector2 == null)
				{
					r_MoveTo_Vector2 = new(this, "MoveTo", 0, typeof(UnityEngine.Vector2));
					r_MoveTo_Vector2.SetBelong(this.instance);
				}
				return r_MoveTo_Vector2;
			}
		}

		/// <summary>
		/// Void LineTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_LineTo_Vector2;
		public virtual RMethod RLineTo_Vector2
		{
			get
			{
				if(r_LineTo_Vector2 == null)
				{
					r_LineTo_Vector2 = new(this, "LineTo", 0, typeof(UnityEngine.Vector2));
					r_LineTo_Vector2.SetBelong(this.instance);
				}
				return r_LineTo_Vector2;
			}
		}

		/// <summary>
		/// Void ArcTo(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected RMethod r_ArcTo_Vector2_Vector2_Single;
		public virtual RMethod RArcTo_Vector2_Vector2_Single
		{
			get
			{
				if(r_ArcTo_Vector2_Vector2_Single == null)
				{
					r_ArcTo_Vector2_Vector2_Single = new(this, "ArcTo", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_ArcTo_Vector2_Vector2_Single.SetBelong(this.instance);
				}
				return r_ArcTo_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// Void Arc(UnityEngine.Vector2, Single, UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle, UnityEngine.UIElements.ArcDirection)
		/// </summary>
		protected RMethod r_Arc_Vector2_Single_Angle_Angle_ArcDirection;
		public virtual RMethod RArc_Vector2_Single_Angle_Angle_ArcDirection
		{
			get
			{
				if(r_Arc_Vector2_Single_Angle_Angle_ArcDirection == null)
				{
					r_Arc_Vector2_Single_Angle_Angle_ArcDirection = new(this, "Arc", 0, typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.ArcDirection));
					r_Arc_Vector2_Single_Angle_Angle_ArcDirection.SetBelong(this.instance);
				}
				return r_Arc_Vector2_Single_Angle_Angle_ArcDirection;
			}
		}

		/// <summary>
		/// Void BezierCurveTo(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_BezierCurveTo_Vector2_Vector2_Vector2;
		public virtual RMethod RBezierCurveTo_Vector2_Vector2_Vector2
		{
			get
			{
				if(r_BezierCurveTo_Vector2_Vector2_Vector2 == null)
				{
					r_BezierCurveTo_Vector2_Vector2_Vector2 = new(this, "BezierCurveTo", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_BezierCurveTo_Vector2_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_BezierCurveTo_Vector2_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void QuadraticCurveTo(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_QuadraticCurveTo_Vector2_Vector2;
		public virtual RMethod RQuadraticCurveTo_Vector2_Vector2
		{
			get
			{
				if(r_QuadraticCurveTo_Vector2_Vector2 == null)
				{
					r_QuadraticCurveTo_Vector2_Vector2 = new(this, "QuadraticCurveTo", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_QuadraticCurveTo_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_QuadraticCurveTo_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Stroke()
		/// </summary>
		protected RMethod r_Stroke;
		public virtual RMethod RStroke
		{
			get
			{
				if(r_Stroke == null)
				{
					r_Stroke = new(this, "Stroke", 0);
					r_Stroke.SetBelong(this.instance);
				}
				return r_Stroke;
			}
		}

		/// <summary>
		/// Void Fill(UnityEngine.UIElements.FillRule)
		/// </summary>
		protected RMethod r_Fill_FillRule;
		public virtual RMethod RFill_FillRule
		{
			get
			{
				if(r_Fill_FillRule == null)
				{
					r_Fill_FillRule = new(this, "Fill", 0, typeof(UnityEngine.UIElements.FillRule));
					r_Fill_FillRule.SetBelong(this.instance);
				}
				return r_Fill_FillRule;
			}
		}

		/// <summary>
		/// Boolean SaveToVectorImage(UnityEngine.UIElements.VectorImage)
		/// </summary>
		protected RMethod r_SaveToVectorImage_VectorImage;
		public virtual RMethod RSaveToVectorImage_VectorImage
		{
			get
			{
				if(r_SaveToVectorImage_VectorImage == null)
				{
					r_SaveToVectorImage_VectorImage = new(this, "SaveToVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage));
					r_SaveToVectorImage_VectorImage.SetBelong(this.instance);
				}
				return r_SaveToVectorImage_VectorImage;
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


        public RPainter2D() : base("UnityEngine.UIElements.Painter2D")
        {
        }

        public RPainter2D(System.Object instance) : base("UnityEngine.UIElements.Painter2D")
		{
            SetInstance(instance);
		}

        public RPainter2D(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPainter2D(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.Int32 @vertexCount, System.Int32 @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount};
            var ___result = RAllocate_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValidateState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void BeginPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClosePath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClosePath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTo(UnityEngine.Vector2 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMoveTo_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LineTo(UnityEngine.Vector2 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RLineTo_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ArcTo(UnityEngine.Vector2 @p1, UnityEngine.Vector2 @p2, System.Single @radius)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2, @radius};
            var ___result = RArcTo_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Arc(UnityEngine.Vector2 @center, System.Single @radius, UnityEngine.UIElements.Angle @startAngle, UnityEngine.UIElements.Angle @endAngle, UnityEngine.UIElements.ArcDirection @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@center, @radius, @startAngle, @endAngle, @direction};
            var ___result = RArc_Vector2_Single_Angle_Angle_ArcDirection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BezierCurveTo(UnityEngine.Vector2 @p1, UnityEngine.Vector2 @p2, UnityEngine.Vector2 @p3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2, @p3};
            var ___result = RBezierCurveTo_Vector2_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void QuadraticCurveTo(UnityEngine.Vector2 @p1, UnityEngine.Vector2 @p2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2};
            var ___result = RQuadraticCurveTo_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stroke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStroke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Fill(UnityEngine.UIElements.FillRule @fillRule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fillRule};
            var ___result = RFill_FillRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SaveToVectorImage(UnityEngine.UIElements.VectorImage @vectorImage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage};
            var ___result = RSaveToVectorImage_VectorImage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
