using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Rect
	/// </summary>
    public partial class RRect : RMember //
    {

		/// <summary>
		/// System.Single m_XMin
		/// </summary>
		protected RField r_m_XMin;
		public virtual RField Rm_XMin
		{
			get
			{
				if(r_m_XMin == null)
				{
					r_m_XMin = new(this, "m_XMin");
					r_m_XMin.SetBelong(this.instance);
				}
				return r_m_XMin;
			}
		}

		/// <summary>
		/// System.Single m_YMin
		/// </summary>
		protected RField r_m_YMin;
		public virtual RField Rm_YMin
		{
			get
			{
				if(r_m_YMin == null)
				{
					r_m_YMin = new(this, "m_YMin");
					r_m_YMin.SetBelong(this.instance);
				}
				return r_m_YMin;
			}
		}

		/// <summary>
		/// System.Single m_Width
		/// </summary>
		protected RField r_m_Width;
		public virtual RField Rm_Width
		{
			get
			{
				if(r_m_Width == null)
				{
					r_m_Width = new(this, "m_Width");
					r_m_Width.SetBelong(this.instance);
				}
				return r_m_Width;
			}
		}

		/// <summary>
		/// System.Single m_Height
		/// </summary>
		protected RField r_m_Height;
		public virtual RField Rm_Height
		{
			get
			{
				if(r_m_Height == null)
				{
					r_m_Height = new(this, "m_Height");
					r_m_Height.SetBelong(this.instance);
				}
				return r_m_Height;
			}
		}

		/// <summary>
		/// UnityEngine.Rect zero
		/// </summary>
		protected static RUnityEngine.RRect r_zero;
		public static RUnityEngine.RRect Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Rect), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// Single x
		/// </summary>
		protected RProperty r_x;
		public virtual RProperty Rx
		{
			get
			{
				if(r_x == null)
				{
					r_x = new(this, "x", -1);
					r_x.SetBelong(this.instance);
				}
				return r_x;
			}
		}

		/// <summary>
		/// Single y
		/// </summary>
		protected RProperty r_y;
		public virtual RProperty Ry
		{
			get
			{
				if(r_y == null)
				{
					r_y = new(this, "y", -1);
					r_y.SetBelong(this.instance);
				}
				return r_y;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 position
		/// </summary>
		protected RUnityEngine.RVector2 r_position;
		public virtual RUnityEngine.RVector2 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 center
		/// </summary>
		protected RUnityEngine.RVector2 r_center;
		public virtual RUnityEngine.RVector2 Rcenter
		{
			get
			{
				if(r_center == null)
				{
					r_center = new(this, "center", -1);
					r_center.SetBelong(this.instance);
				}
				return r_center;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 min
		/// </summary>
		protected RUnityEngine.RVector2 r_min;
		public virtual RUnityEngine.RVector2 Rmin
		{
			get
			{
				if(r_min == null)
				{
					r_min = new(this, "min", -1);
					r_min.SetBelong(this.instance);
				}
				return r_min;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 max
		/// </summary>
		protected RUnityEngine.RVector2 r_max;
		public virtual RUnityEngine.RVector2 Rmax
		{
			get
			{
				if(r_max == null)
				{
					r_max = new(this, "max", -1);
					r_max.SetBelong(this.instance);
				}
				return r_max;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected RUnityEngine.RVector2 r_size;
		public virtual RUnityEngine.RVector2 Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size", -1);
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// Single xMin
		/// </summary>
		protected RProperty r_xMin;
		public virtual RProperty RxMin
		{
			get
			{
				if(r_xMin == null)
				{
					r_xMin = new(this, "xMin", -1);
					r_xMin.SetBelong(this.instance);
				}
				return r_xMin;
			}
		}

		/// <summary>
		/// Single yMin
		/// </summary>
		protected RProperty r_yMin;
		public virtual RProperty RyMin
		{
			get
			{
				if(r_yMin == null)
				{
					r_yMin = new(this, "yMin", -1);
					r_yMin.SetBelong(this.instance);
				}
				return r_yMin;
			}
		}

		/// <summary>
		/// Single xMax
		/// </summary>
		protected RProperty r_xMax;
		public virtual RProperty RxMax
		{
			get
			{
				if(r_xMax == null)
				{
					r_xMax = new(this, "xMax", -1);
					r_xMax.SetBelong(this.instance);
				}
				return r_xMax;
			}
		}

		/// <summary>
		/// Single yMax
		/// </summary>
		protected RProperty r_yMax;
		public virtual RProperty RyMax
		{
			get
			{
				if(r_yMax == null)
				{
					r_yMax = new(this, "yMax", -1);
					r_yMax.SetBelong(this.instance);
				}
				return r_yMax;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected RProperty r_left;
		public virtual RProperty Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left", -1);
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected RProperty r_right;
		public virtual RProperty Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right", -1);
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected RProperty r_top;
		public virtual RProperty Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top", -1);
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected RProperty r_bottom;
		public virtual RProperty Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom", -1);
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// UnityEngine.Rect MinMaxRect(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_RMinMaxRect_Single_Single_Single_Single;
		public static RMethod RMinMaxRect_Single_Single_Single_Single
		{
			get
			{
				if(r_RMinMaxRect_Single_Single_Single_Single == null)
				{
					r_RMinMaxRect_Single_Single_Single_Single = new(typeof(UnityEngine.Rect), "MinMaxRect", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RMinMaxRect_Single_Single_Single_Single.SetBelong(null);
				}
				return r_RMinMaxRect_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void Set(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_RSet_Single_Single_Single_Single;
		public virtual RMethod RSet_Single_Single_Single_Single
		{
			get
			{
				if(r_RSet_Single_Single_Single_Single == null)
				{
					r_RSet_Single_Single_Single_Single = new(this, "Set", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RSet_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RSet_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RContains_Vector2;
		public virtual RMethod RContains_Vector2
		{
			get
			{
				if(r_RContains_Vector2 == null)
				{
					r_RContains_Vector2 = new(this, "Contains", 0, typeof(UnityEngine.Vector2));
					r_RContains_Vector2.SetBelong(this.instance);
				}
				return r_RContains_Vector2;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RContains_Vector3;
		public virtual RMethod RContains_Vector3
		{
			get
			{
				if(r_RContains_Vector3 == null)
				{
					r_RContains_Vector3 = new(this, "Contains", 0, typeof(UnityEngine.Vector3));
					r_RContains_Vector3.SetBelong(this.instance);
				}
				return r_RContains_Vector3;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_RContains_Vector3_Boolean;
		public virtual RMethod RContains_Vector3_Boolean
		{
			get
			{
				if(r_RContains_Vector3_Boolean == null)
				{
					r_RContains_Vector3_Boolean = new(this, "Contains", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RContains_Vector3_Boolean.SetBelong(this.instance);
				}
				return r_RContains_Vector3_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect OrderMinMax(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_ROrderMinMax_Rect;
		public static RMethod ROrderMinMax_Rect
		{
			get
			{
				if(r_ROrderMinMax_Rect == null)
				{
					r_ROrderMinMax_Rect = new(typeof(UnityEngine.Rect), "OrderMinMax", 0, typeof(UnityEngine.Rect));
					r_ROrderMinMax_Rect.SetBelong(null);
				}
				return r_ROrderMinMax_Rect;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROverlaps_Rect;
		public virtual RMethod ROverlaps_Rect
		{
			get
			{
				if(r_ROverlaps_Rect == null)
				{
					r_ROverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_ROverlaps_Rect.SetBelong(this.instance);
				}
				return r_ROverlaps_Rect;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_ROverlaps_Rect_Boolean;
		public virtual RMethod ROverlaps_Rect_Boolean
		{
			get
			{
				if(r_ROverlaps_Rect_Boolean == null)
				{
					r_ROverlaps_Rect_Boolean = new(this, "Overlaps", 0, typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_ROverlaps_Rect_Boolean.SetBelong(this.instance);
				}
				return r_ROverlaps_Rect_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RNormalizedToPoint_Rect_Vector2;
		public static RMethod RNormalizedToPoint_Rect_Vector2
		{
			get
			{
				if(r_RNormalizedToPoint_Rect_Vector2 == null)
				{
					r_RNormalizedToPoint_Rect_Vector2 = new(typeof(UnityEngine.Rect), "NormalizedToPoint", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RNormalizedToPoint_Rect_Vector2.SetBelong(null);
				}
				return r_RNormalizedToPoint_Rect_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RPointToNormalized_Rect_Vector2;
		public static RMethod RPointToNormalized_Rect_Vector2
		{
			get
			{
				if(r_RPointToNormalized_Rect_Vector2 == null)
				{
					r_RPointToNormalized_Rect_Vector2 = new(typeof(UnityEngine.Rect), "PointToNormalized", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RPointToNormalized_Rect_Vector2.SetBelong(null);
				}
				return r_RPointToNormalized_Rect_Vector2;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Rect_Rect;
		public static RMethod Rop_Inequality_Rect_Rect
		{
			get
			{
				if(r_Rop_Inequality_Rect_Rect == null)
				{
					r_Rop_Inequality_Rect_Rect = new(typeof(UnityEngine.Rect), "op_Inequality", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_Rop_Inequality_Rect_Rect.SetBelong(null);
				}
				return r_Rop_Inequality_Rect_Rect;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_Rop_Equality_Rect_Rect;
		public static RMethod Rop_Equality_Rect_Rect
		{
			get
			{
				if(r_Rop_Equality_Rect_Rect == null)
				{
					r_Rop_Equality_Rect_Rect = new(typeof(UnityEngine.Rect), "op_Equality", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_Rop_Equality_Rect_Rect.SetBelong(null);
				}
				return r_Rop_Equality_Rect_Rect;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_REquals_Rect;
		public virtual RMethod REquals_Rect
		{
			get
			{
				if(r_REquals_Rect == null)
				{
					r_REquals_Rect = new(this, "Equals", 0, typeof(UnityEngine.Rect));
					r_REquals_Rect.SetBelong(this.instance);
				}
				return r_REquals_Rect;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_RToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_RToString_String == null)
				{
					r_RToString_String = new(this, "ToString", 0, typeof(System.String));
					r_RToString_String.SetBelong(this.instance);
				}
				return r_RToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_RToString_String_IFormatProvider == null)
				{
					r_RToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public static UnityEngine.Rect MinMaxRect(System.Single  @xmin, System.Single  @ymin, System.Single  @xmax, System.Single  @ymax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmin, @ymin, @xmax, @ymax};
            var ___result = RMinMaxRect_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Set(System.Single  @x, System.Single  @y, System.Single  @width, System.Single  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @width, @height};
            var ___result = RSet_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RContains_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RContains_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3  @point, System.Boolean  @allowInverse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @allowInverse};
            var ___result = RContains_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Rect OrderMinMax(UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = ROrderMinMax_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = ROverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect  @other, System.Boolean  @allowInverse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other, @allowInverse};
            var ___result = ROverlaps_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect  @rectangle, UnityEngine.Vector2  @normalizedRectCoordinates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle, @normalizedRectCoordinates};
            var ___result = RNormalizedToPoint_Rect_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect  @rectangle, UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle, @point};
            var ___result = RPointToNormalized_Rect_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rect  @lhs, UnityEngine.Rect  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rect  @lhs, UnityEngine.Rect  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rect  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format, System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

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
