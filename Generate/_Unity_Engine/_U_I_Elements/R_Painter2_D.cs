
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.Painter2D
	/// </summary>
    public partial class RPainter2D : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Painter2D);
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


		/// <summary>
		/// UnityEngine.UIElements.MeshGenerationContext m_Ctx
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext r_Fm_Ctx;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext RFm_Ctx
		{
			get
			{
				if(r_Fm_Ctx == null)
				{
					r_Fm_Ctx = new(this, "m_Ctx");
				}
				return r_Fm_Ctx;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.DetachedAllocator m_DetachedAllocator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RDetachedAllocator r_Fm_DetachedAllocator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RDetachedAllocator RFm_DetachedAllocator
		{
			get
			{
				if(r_Fm_DetachedAllocator == null)
				{
					r_Fm_DetachedAllocator = new(this, "m_DetachedAllocator");
				}
				return r_Fm_DetachedAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.SafeHandleAccess m_Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSafeHandleAccess r_Fm_Handle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSafeHandleAccess RFm_Handle
		{
			get
			{
				if(r_Fm_Handle == null)
				{
					r_Fm_Handle = new(this, "m_Handle");
				}
				return r_Fm_Handle;
			}
		}

		/// <summary>
		/// System.Boolean m_Disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Disposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Disposed
		{
			get
			{
				if(r_Fm_Disposed == null)
				{
					r_Fm_Disposed = new(this, "m_Disposed");
				}
				return r_Fm_Disposed;
			}
		}

		/// <summary>
		/// System.Boolean <isPainterActive>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__isPainterActive__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__isPainterActive__1__k__BackingField
		{
			get
			{
				if(r_F__0__isPainterActive__1__k__BackingField == null)
				{
					r_F__0__isPainterActive__1__k__BackingField = new(Type, "<isPainterActive>k__BackingField");
				}
				return r_F__0__isPainterActive__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single s_MaxArcRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fs_MaxArcRadius;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFs_MaxArcRadius
		{
			get
			{
				if(r_Fs_MaxArcRadius == null)
				{
					r_Fs_MaxArcRadius = new(Type, "s_MaxArcRadius");
				}
				return r_Fs_MaxArcRadius;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_StrokeMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_StrokeMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_StrokeMarker
		{
			get
			{
				if(r_Fs_StrokeMarker == null)
				{
					r_Fs_StrokeMarker = new(Type, "s_StrokeMarker");
				}
				return r_Fs_StrokeMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_FillMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_FillMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_FillMarker
		{
			get
			{
				if(r_Fs_FillMarker == null)
				{
					r_Fs_FillMarker = new(Type, "s_FillMarker");
				}
				return r_Fs_FillMarker;
			}
		}

		/// <summary>
		/// Boolean isDetached
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDetached;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDetached
		{
			get
			{
				if(r_PisDetached == null)
				{
					r_PisDetached = new(this, "isDetached", -1);
				}
				return r_PisDetached;
			}
		}

		/// <summary>
		/// Single lineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PlineWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPlineWidth
		{
			get
			{
				if(r_PlineWidth == null)
				{
					r_PlineWidth = new(this, "lineWidth", -1);
				}
				return r_PlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color strokeColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PstrokeColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPstrokeColor
		{
			get
			{
				if(r_PstrokeColor == null)
				{
					r_PstrokeColor = new(this, "strokeColor", -1);
				}
				return r_PstrokeColor;
			}
		}

		/// <summary>
		/// UnityEngine.Gradient strokeGradient
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGradient r_PstrokeGradient;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGradient RPstrokeGradient
		{
			get
			{
				if(r_PstrokeGradient == null)
				{
					r_PstrokeGradient = new(this, "strokeGradient", -1);
				}
				return r_PstrokeGradient;
			}
		}

		/// <summary>
		/// UnityEngine.Color fillColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PfillColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPfillColor
		{
			get
			{
				if(r_PfillColor == null)
				{
					r_PfillColor = new(this, "fillColor", -1);
				}
				return r_PfillColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LineJoin lineJoin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLineJoin r_PlineJoin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLineJoin RPlineJoin
		{
			get
			{
				if(r_PlineJoin == null)
				{
					r_PlineJoin = new(this, "lineJoin", -1);
				}
				return r_PlineJoin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LineCap lineCap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLineCap r_PlineCap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLineCap RPlineCap
		{
			get
			{
				if(r_PlineCap == null)
				{
					r_PlineCap = new(this, "lineCap", -1);
				}
				return r_PlineCap;
			}
		}

		/// <summary>
		/// Single miterLimit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmiterLimit;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmiterLimit
		{
			get
			{
				if(r_PmiterLimit == null)
				{
					r_PmiterLimit = new(this, "miterLimit", -1);
				}
				return r_PmiterLimit;
			}
		}

		/// <summary>
		/// Boolean isPainterActive
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPainterActive;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPisPainterActive
		{
			get
			{
				if(r_PisPainterActive == null)
				{
					r_PisPainterActive = new(Type, "isPainterActive", -1);
				}
				return r_PisPainterActive;
			}
		}

		/// <summary>
		/// Single maxArcRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_PmaxArcRadius;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RPmaxArcRadius
		{
			get
			{
				if(r_PmaxArcRadius == null)
				{
					r_PmaxArcRadius = new(Type, "maxArcRadius", -1);
				}
				return r_PmaxArcRadius;
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
		/// UnityEngine.UIElements.MeshWriteData Allocate(Int32, Int32)
		/// </summary>
		protected RMethod r_MAllocate_Int32_Int32;
		public virtual RMethod RMAllocate_Int32_Int32
		{
			get
			{
				if(r_MAllocate_Int32_Int32 == null)
				{
					r_MAllocate_Int32_Int32 = new(this, "Allocate", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAllocate_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Boolean ValidateState()
		/// </summary>
		protected RMethod r_MValidateState;
		public virtual RMethod RMValidateState
		{
			get
			{
				if(r_MValidateState == null)
				{
					r_MValidateState = new(this, "ValidateState", 0);
				}
				return r_MValidateState;
			}
		}

		/// <summary>
		/// Void BeginPath()
		/// </summary>
		protected RMethod r_MBeginPath;
		public virtual RMethod RMBeginPath
		{
			get
			{
				if(r_MBeginPath == null)
				{
					r_MBeginPath = new(this, "BeginPath", 0);
				}
				return r_MBeginPath;
			}
		}

		/// <summary>
		/// Void ClosePath()
		/// </summary>
		protected RMethod r_MClosePath;
		public virtual RMethod RMClosePath
		{
			get
			{
				if(r_MClosePath == null)
				{
					r_MClosePath = new(this, "ClosePath", 0);
				}
				return r_MClosePath;
			}
		}

		/// <summary>
		/// Void MoveTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MMoveTo_Vector2;
		public virtual RMethod RMMoveTo_Vector2
		{
			get
			{
				if(r_MMoveTo_Vector2 == null)
				{
					r_MMoveTo_Vector2 = new(this, "MoveTo", 0, typeof(UnityEngine.Vector2));
				}
				return r_MMoveTo_Vector2;
			}
		}

		/// <summary>
		/// Void LineTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MLineTo_Vector2;
		public virtual RMethod RMLineTo_Vector2
		{
			get
			{
				if(r_MLineTo_Vector2 == null)
				{
					r_MLineTo_Vector2 = new(this, "LineTo", 0, typeof(UnityEngine.Vector2));
				}
				return r_MLineTo_Vector2;
			}
		}

		/// <summary>
		/// Void ArcTo(UnityEngine.Vector2, UnityEngine.Vector2, Single)
		/// </summary>
		protected RMethod r_MArcTo_Vector2_Vector2_Single;
		public virtual RMethod RMArcTo_Vector2_Vector2_Single
		{
			get
			{
				if(r_MArcTo_Vector2_Vector2_Single == null)
				{
					r_MArcTo_Vector2_Vector2_Single = new(this, "ArcTo", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Single));
				}
				return r_MArcTo_Vector2_Vector2_Single;
			}
		}

		/// <summary>
		/// Void Arc(UnityEngine.Vector2, Single, UnityEngine.UIElements.Angle, UnityEngine.UIElements.Angle, UnityEngine.UIElements.ArcDirection)
		/// </summary>
		protected RMethod r_MArc_Vector2_Single_Angle_Angle_ArcDirection;
		public virtual RMethod RMArc_Vector2_Single_Angle_Angle_ArcDirection
		{
			get
			{
				if(r_MArc_Vector2_Single_Angle_Angle_ArcDirection == null)
				{
					r_MArc_Vector2_Single_Angle_Angle_ArcDirection = new(this, "Arc", 0, typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.UIElements.ArcDirection));
				}
				return r_MArc_Vector2_Single_Angle_Angle_ArcDirection;
			}
		}

		/// <summary>
		/// Void BezierCurveTo(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MBezierCurveTo_Vector2_Vector2_Vector2;
		public virtual RMethod RMBezierCurveTo_Vector2_Vector2_Vector2
		{
			get
			{
				if(r_MBezierCurveTo_Vector2_Vector2_Vector2 == null)
				{
					r_MBezierCurveTo_Vector2_Vector2_Vector2 = new(this, "BezierCurveTo", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MBezierCurveTo_Vector2_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void QuadraticCurveTo(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MQuadraticCurveTo_Vector2_Vector2;
		public virtual RMethod RMQuadraticCurveTo_Vector2_Vector2
		{
			get
			{
				if(r_MQuadraticCurveTo_Vector2_Vector2 == null)
				{
					r_MQuadraticCurveTo_Vector2_Vector2 = new(this, "QuadraticCurveTo", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
				}
				return r_MQuadraticCurveTo_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Stroke()
		/// </summary>
		protected RMethod r_MStroke;
		public virtual RMethod RMStroke
		{
			get
			{
				if(r_MStroke == null)
				{
					r_MStroke = new(this, "Stroke", 0);
				}
				return r_MStroke;
			}
		}

		/// <summary>
		/// Void Fill(UnityEngine.UIElements.FillRule)
		/// </summary>
		protected RMethod r_MFill_FillRule;
		public virtual RMethod RMFill_FillRule
		{
			get
			{
				if(r_MFill_FillRule == null)
				{
					r_MFill_FillRule = new(this, "Fill", 0, typeof(UnityEngine.UIElements.FillRule));
				}
				return r_MFill_FillRule;
			}
		}

		/// <summary>
		/// Boolean SaveToVectorImage(UnityEngine.UIElements.VectorImage)
		/// </summary>
		protected RMethod r_MSaveToVectorImage_VectorImage;
		public virtual RMethod RMSaveToVectorImage_VectorImage
		{
			get
			{
				if(r_MSaveToVectorImage_VectorImage == null)
				{
					r_MSaveToVectorImage_VectorImage = new(this, "SaveToVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage));
				}
				return r_MSaveToVectorImage_VectorImage;
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


        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.Int32 @vertexCount, System.Int32 @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount};
            var ___result = RMAllocate_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.MeshWriteData>(___result);
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValidateState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateState.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void BeginPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClosePath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClosePath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTo(UnityEngine.Vector2 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMMoveTo_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LineTo(UnityEngine.Vector2 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMLineTo_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ArcTo(UnityEngine.Vector2 @p1, UnityEngine.Vector2 @p2, System.Single @radius)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2, @radius};
            var ___result = RMArcTo_Vector2_Vector2_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Arc(UnityEngine.Vector2 @center, System.Single @radius, UnityEngine.UIElements.Angle @startAngle, UnityEngine.UIElements.Angle @endAngle, UnityEngine.UIElements.ArcDirection @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@center, @radius, @startAngle, @endAngle, @direction};
            var ___result = RMArc_Vector2_Single_Angle_Angle_ArcDirection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BezierCurveTo(UnityEngine.Vector2 @p1, UnityEngine.Vector2 @p2, UnityEngine.Vector2 @p3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2, @p3};
            var ___result = RMBezierCurveTo_Vector2_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void QuadraticCurveTo(UnityEngine.Vector2 @p1, UnityEngine.Vector2 @p2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2};
            var ___result = RMQuadraticCurveTo_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stroke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStroke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Fill(UnityEngine.UIElements.FillRule @fillRule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fillRule};
            var ___result = RMFill_FillRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SaveToVectorImage(UnityEngine.UIElements.VectorImage @vectorImage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage};
            var ___result = RMSaveToVectorImage_VectorImage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
