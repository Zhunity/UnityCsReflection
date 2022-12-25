using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RectInt
	/// </summary>
    public partial class RRectInt : RMember //
    {

		/// <summary>
		/// System.Int32 m_XMin
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
		/// System.Int32 m_YMin
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
		/// System.Int32 m_Width
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
		/// System.Int32 m_Height
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
		/// Int32 x
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
		/// Int32 y
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
		/// UnityEngine.Vector2Int min
		/// </summary>
		protected RUnityEngine.RVector2Int r_min;
		public virtual RUnityEngine.RVector2Int Rmin
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
		/// UnityEngine.Vector2Int max
		/// </summary>
		protected RUnityEngine.RVector2Int r_max;
		public virtual RUnityEngine.RVector2Int Rmax
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
		/// Int32 width
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
		/// Int32 height
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
		/// Int32 xMin
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
		/// Int32 yMin
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
		/// Int32 xMax
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
		/// Int32 yMax
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
		/// UnityEngine.Vector2Int position
		/// </summary>
		protected RUnityEngine.RVector2Int r_position;
		public virtual RUnityEngine.RVector2Int Rposition
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
		/// UnityEngine.Vector2Int size
		/// </summary>
		protected RUnityEngine.RVector2Int r_size;
		public virtual RUnityEngine.RVector2Int Rsize
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
		/// PositionEnumerator allPositionsWithin
		/// </summary>
		protected RUnityEngine.RRectInt.RPositionEnumerator r_allPositionsWithin;
		public virtual RUnityEngine.RRectInt.RPositionEnumerator RallPositionsWithin
		{
			get
			{
				if(r_allPositionsWithin == null)
				{
					r_allPositionsWithin = new(this, "allPositionsWithin", -1);
					r_allPositionsWithin.SetBelong(this.instance);
				}
				return r_allPositionsWithin;
			}
		}

		/// <summary>
		/// Void SetMinMax(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_RSetMinMax_Vector2Int_Vector2Int;
		public virtual RMethod RSetMinMax_Vector2Int_Vector2Int
		{
			get
			{
				if(r_RSetMinMax_Vector2Int_Vector2Int == null)
				{
					r_RSetMinMax_Vector2Int_Vector2Int = new(this, "SetMinMax", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_RSetMinMax_Vector2Int_Vector2Int.SetBelong(this.instance);
				}
				return r_RSetMinMax_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// Void ClampToBounds(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_RClampToBounds_RectInt;
		public virtual RMethod RClampToBounds_RectInt
		{
			get
			{
				if(r_RClampToBounds_RectInt == null)
				{
					r_RClampToBounds_RectInt = new(this, "ClampToBounds", 0, typeof(UnityEngine.RectInt));
					r_RClampToBounds_RectInt.SetBelong(this.instance);
				}
				return r_RClampToBounds_RectInt;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_RContains_Vector2Int;
		public virtual RMethod RContains_Vector2Int
		{
			get
			{
				if(r_RContains_Vector2Int == null)
				{
					r_RContains_Vector2Int = new(this, "Contains", 0, typeof(UnityEngine.Vector2Int));
					r_RContains_Vector2Int.SetBelong(this.instance);
				}
				return r_RContains_Vector2Int;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_ROverlaps_RectInt;
		public virtual RMethod ROverlaps_RectInt
		{
			get
			{
				if(r_ROverlaps_RectInt == null)
				{
					r_ROverlaps_RectInt = new(this, "Overlaps", 0, typeof(UnityEngine.RectInt));
					r_ROverlaps_RectInt.SetBelong(this.instance);
				}
				return r_ROverlaps_RectInt;
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
		/// Boolean Equals(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_REquals_RectInt;
		public virtual RMethod REquals_RectInt
		{
			get
			{
				if(r_REquals_RectInt == null)
				{
					r_REquals_RectInt = new(this, "Equals", 0, typeof(UnityEngine.RectInt));
					r_REquals_RectInt.SetBelong(this.instance);
				}
				return r_REquals_RectInt;
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


        public RRectInt() : base("UnityEngine.RectInt")
        {
        }

        public RRectInt(System.Object instance) : base("UnityEngine.RectInt")
		{
            SetInstance(instance);
		}

        public RRectInt(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRectInt(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetMinMax(UnityEngine.Vector2Int  @minPosition, UnityEngine.Vector2Int  @maxPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minPosition, @maxPosition};
            var ___result = RSetMinMax_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClampToBounds(UnityEngine.RectInt  @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RClampToBounds_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.Vector2Int  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RContains_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.RectInt  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = ROverlaps_RectInt.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean Equals(UnityEngine.RectInt  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_RectInt.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
