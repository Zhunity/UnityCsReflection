
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Rect
	/// </summary>
    public partial class RRect : RMember //
    {

		/// <summary>
		/// System.Single m_XMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_XMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_XMin
		{
			get
			{
				if(r_Fm_XMin == null)
				{
					r_Fm_XMin = new(this, "m_XMin");
					r_Fm_XMin.SetBelong(this.GetValue());
				}
				return r_Fm_XMin;
			}
		}

		/// <summary>
		/// System.Single m_YMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_YMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_YMin
		{
			get
			{
				if(r_Fm_YMin == null)
				{
					r_Fm_YMin = new(this, "m_YMin");
					r_Fm_YMin.SetBelong(this.GetValue());
				}
				return r_Fm_YMin;
			}
		}

		/// <summary>
		/// System.Single m_Width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Width;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Width
		{
			get
			{
				if(r_Fm_Width == null)
				{
					r_Fm_Width = new(this, "m_Width");
					r_Fm_Width.SetBelong(this.GetValue());
				}
				return r_Fm_Width;
			}
		}

		/// <summary>
		/// System.Single m_Height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Height;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Height
		{
			get
			{
				if(r_Fm_Height == null)
				{
					r_Fm_Height = new(this, "m_Height");
					r_Fm_Height.SetBelong(this.GetValue());
				}
				return r_Fm_Height;
			}
		}

		/// <summary>
		/// UnityEngine.Rect zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRect r_Pzero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRect RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.Rect), "zero", -1);
					r_Pzero.SetBelong(null);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// Single x
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Px;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
					r_Px.SetBelong(this.GetValue());
				}
				return r_Px;
			}
		}

		/// <summary>
		/// Single y
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Py;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
					r_Py.SetBelong(this.GetValue());
				}
				return r_Py;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.GetValue());
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 center
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pcenter;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPcenter
		{
			get
			{
				if(r_Pcenter == null)
				{
					r_Pcenter = new(this, "center", -1);
					r_Pcenter.SetBelong(this.GetValue());
				}
				return r_Pcenter;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 min
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pmin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmin
		{
			get
			{
				if(r_Pmin == null)
				{
					r_Pmin = new(this, "min", -1);
					r_Pmin.SetBelong(this.GetValue());
				}
				return r_Pmin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 max
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pmax;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmax
		{
			get
			{
				if(r_Pmax == null)
				{
					r_Pmax = new(this, "max", -1);
					r_Pmax.SetBelong(this.GetValue());
				}
				return r_Pmax;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
					r_Pwidth.SetBelong(this.GetValue());
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
					r_Pheight.SetBelong(this.GetValue());
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Psize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
					r_Psize.SetBelong(this.GetValue());
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// Single xMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PxMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPxMin
		{
			get
			{
				if(r_PxMin == null)
				{
					r_PxMin = new(this, "xMin", -1);
					r_PxMin.SetBelong(this.GetValue());
				}
				return r_PxMin;
			}
		}

		/// <summary>
		/// Single yMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PyMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPyMin
		{
			get
			{
				if(r_PyMin == null)
				{
					r_PyMin = new(this, "yMin", -1);
					r_PyMin.SetBelong(this.GetValue());
				}
				return r_PyMin;
			}
		}

		/// <summary>
		/// Single xMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PxMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPxMax
		{
			get
			{
				if(r_PxMax == null)
				{
					r_PxMax = new(this, "xMax", -1);
					r_PxMax.SetBelong(this.GetValue());
				}
				return r_PxMax;
			}
		}

		/// <summary>
		/// Single yMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PyMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPyMax
		{
			get
			{
				if(r_PyMax == null)
				{
					r_PyMax = new(this, "yMax", -1);
					r_PyMax.SetBelong(this.GetValue());
				}
				return r_PyMax;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pleft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
					r_Pleft.SetBelong(this.GetValue());
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pright;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
					r_Pright.SetBelong(this.GetValue());
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ptop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
					r_Ptop.SetBelong(this.GetValue());
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pbottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
					r_Pbottom.SetBelong(this.GetValue());
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// UnityEngine.Rect MinMaxRect(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MMinMaxRect_Single_Single_Single_Single;
		public static RMethod RMMinMaxRect_Single_Single_Single_Single
		{
			get
			{
				if(r_MMinMaxRect_Single_Single_Single_Single == null)
				{
					r_MMinMaxRect_Single_Single_Single_Single = new(typeof(UnityEngine.Rect), "MinMaxRect", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MMinMaxRect_Single_Single_Single_Single.SetBelong(null);
				}
				return r_MMinMaxRect_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_MSet_Single_Single_Single_Single;
		public virtual RMethod RMSet_Single_Single_Single_Single
		{
			get
			{
				if(r_MSet_Single_Single_Single_Single == null)
				{
					r_MSet_Single_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MSet_Single_Single_Single_Single.SetBelong(this.GetValue());
				}
				return r_MSet_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MContains_Vector2;
		public virtual RMethod RMContains_Vector2
		{
			get
			{
				if(r_MContains_Vector2 == null)
				{
					r_MContains_Vector2 = new(this, "Contains", 0, typeof(UnityEngine.Vector2));
					r_MContains_Vector2.SetBelong(this.GetValue());
				}
				return r_MContains_Vector2;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MContains_Vector3;
		public virtual RMethod RMContains_Vector3
		{
			get
			{
				if(r_MContains_Vector3 == null)
				{
					r_MContains_Vector3 = new(this, "Contains", 0, typeof(UnityEngine.Vector3));
					r_MContains_Vector3.SetBelong(this.GetValue());
				}
				return r_MContains_Vector3;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_MContains_Vector3_Boolean;
		public virtual RMethod RMContains_Vector3_Boolean
		{
			get
			{
				if(r_MContains_Vector3_Boolean == null)
				{
					r_MContains_Vector3_Boolean = new(this, "Contains", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_MContains_Vector3_Boolean.SetBelong(this.GetValue());
				}
				return r_MContains_Vector3_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect OrderMinMax(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MOrderMinMax_Rect;
		public static RMethod RMOrderMinMax_Rect
		{
			get
			{
				if(r_MOrderMinMax_Rect == null)
				{
					r_MOrderMinMax_Rect = new(typeof(UnityEngine.Rect), "OrderMinMax", 0, typeof(UnityEngine.Rect));
					r_MOrderMinMax_Rect.SetBelong(null);
				}
				return r_MOrderMinMax_Rect;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOverlaps_Rect;
		public virtual RMethod RMOverlaps_Rect
		{
			get
			{
				if(r_MOverlaps_Rect == null)
				{
					r_MOverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_MOverlaps_Rect.SetBelong(this.GetValue());
				}
				return r_MOverlaps_Rect;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_MOverlaps_Rect_Boolean;
		public virtual RMethod RMOverlaps_Rect_Boolean
		{
			get
			{
				if(r_MOverlaps_Rect_Boolean == null)
				{
					r_MOverlaps_Rect_Boolean = new(this, "Overlaps", 0, typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_MOverlaps_Rect_Boolean.SetBelong(this.GetValue());
				}
				return r_MOverlaps_Rect_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MNormalizedToPoint_Rect_Vector2;
		public static RMethod RMNormalizedToPoint_Rect_Vector2
		{
			get
			{
				if(r_MNormalizedToPoint_Rect_Vector2 == null)
				{
					r_MNormalizedToPoint_Rect_Vector2 = new(typeof(UnityEngine.Rect), "NormalizedToPoint", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_MNormalizedToPoint_Rect_Vector2.SetBelong(null);
				}
				return r_MNormalizedToPoint_Rect_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MPointToNormalized_Rect_Vector2;
		public static RMethod RMPointToNormalized_Rect_Vector2
		{
			get
			{
				if(r_MPointToNormalized_Rect_Vector2 == null)
				{
					r_MPointToNormalized_Rect_Vector2 = new(typeof(UnityEngine.Rect), "PointToNormalized", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_MPointToNormalized_Rect_Vector2.SetBelong(null);
				}
				return r_MPointToNormalized_Rect_Vector2;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Rect_Rect;
		public static RMethod RMop_Inequality_Rect_Rect
		{
			get
			{
				if(r_Mop_Inequality_Rect_Rect == null)
				{
					r_Mop_Inequality_Rect_Rect = new(typeof(UnityEngine.Rect), "op_Inequality", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_Mop_Inequality_Rect_Rect.SetBelong(null);
				}
				return r_Mop_Inequality_Rect_Rect;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_Mop_Equality_Rect_Rect;
		public static RMethod RMop_Equality_Rect_Rect
		{
			get
			{
				if(r_Mop_Equality_Rect_Rect == null)
				{
					r_Mop_Equality_Rect_Rect = new(typeof(UnityEngine.Rect), "op_Equality", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_Mop_Equality_Rect_Rect.SetBelong(null);
				}
				return r_Mop_Equality_Rect_Rect;
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
		/// Boolean Equals(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MEquals_Rect;
		public virtual RMethod RMEquals_Rect
		{
			get
			{
				if(r_MEquals_Rect == null)
				{
					r_MEquals_Rect = new(this, "Equals", 0, typeof(UnityEngine.Rect));
					r_MEquals_Rect.SetBelong(this.GetValue());
				}
				return r_MEquals_Rect;
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

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.GetValue());
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_String_IFormatProvider;
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


        public RRect() : base("UnityEngine.Rect")
        {
        }

        public RRect(System.Object instance) : base("UnityEngine.Rect")
		{
            SetInstance(instance);
		}

        public RRect(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRect(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Rect MinMaxRect(System.Single @xmin, System.Single @ymin, System.Single @xmax, System.Single @ymax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmin, @ymin, @xmax, @ymax};
            var ___result = RMMinMaxRect_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Set(System.Single @x, System.Single @y, System.Single @width, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @width, @height};
            var ___result = RMSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMContains_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMContains_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3 @point, System.Boolean @allowInverse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @allowInverse};
            var ___result = RMContains_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Rect OrderMinMax(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMOrderMinMax_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMOverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @other, System.Boolean @allowInverse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @allowInverse};
            var ___result = RMOverlaps_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect @rectangle, UnityEngine.Vector2 @normalizedRectCoordinates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle, @normalizedRectCoordinates};
            var ___result = RMNormalizedToPoint_Rect_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect @rectangle, UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle, @point};
            var ___result = RMPointToNormalized_Rect_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rect @lhs, UnityEngine.Rect @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rect @lhs, UnityEngine.Rect @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rect @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

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
