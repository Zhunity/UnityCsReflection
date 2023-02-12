
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_XMin;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_XMin
		{
			get
			{
				if(r_Fm_XMin == null)
				{
					r_Fm_XMin = new(this, "m_XMin");
					r_Fm_XMin.SetBelong(this.instance);
				}
				return r_Fm_XMin;
			}
		}

		/// <summary>
		/// System.Int32 m_YMin
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_YMin;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_YMin
		{
			get
			{
				if(r_Fm_YMin == null)
				{
					r_Fm_YMin = new(this, "m_YMin");
					r_Fm_YMin.SetBelong(this.instance);
				}
				return r_Fm_YMin;
			}
		}

		/// <summary>
		/// System.Int32 m_Width
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_Width;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_Width
		{
			get
			{
				if(r_Fm_Width == null)
				{
					r_Fm_Width = new(this, "m_Width");
					r_Fm_Width.SetBelong(this.instance);
				}
				return r_Fm_Width;
			}
		}

		/// <summary>
		/// System.Int32 m_Height
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_Height;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_Height
		{
			get
			{
				if(r_Fm_Height == null)
				{
					r_Fm_Height = new(this, "m_Height");
					r_Fm_Height.SetBelong(this.instance);
				}
				return r_Fm_Height;
			}
		}

		/// <summary>
		/// Int32 x
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Px;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
					r_Px.SetBelong(this.instance);
				}
				return r_Px;
			}
		}

		/// <summary>
		/// Int32 y
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Py;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
					r_Py.SetBelong(this.instance);
				}
				return r_Py;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 center
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_Pcenter;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RPcenter
		{
			get
			{
				if(r_Pcenter == null)
				{
					r_Pcenter = new(this, "center", -1);
					r_Pcenter.SetBelong(this.instance);
				}
				return r_Pcenter;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int min
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pmin;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPmin
		{
			get
			{
				if(r_Pmin == null)
				{
					r_Pmin = new(this, "min", -1);
					r_Pmin.SetBelong(this.instance);
				}
				return r_Pmin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int max
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pmax;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPmax
		{
			get
			{
				if(r_Pmax == null)
				{
					r_Pmax = new(this, "max", -1);
					r_Pmax.SetBelong(this.instance);
				}
				return r_Pmax;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pwidth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
					r_Pwidth.SetBelong(this.instance);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pheight;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
					r_Pheight.SetBelong(this.instance);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// Int32 xMin
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PxMin;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPxMin
		{
			get
			{
				if(r_PxMin == null)
				{
					r_PxMin = new(this, "xMin", -1);
					r_PxMin.SetBelong(this.instance);
				}
				return r_PxMin;
			}
		}

		/// <summary>
		/// Int32 yMin
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PyMin;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPyMin
		{
			get
			{
				if(r_PyMin == null)
				{
					r_PyMin = new(this, "yMin", -1);
					r_PyMin.SetBelong(this.instance);
				}
				return r_PyMin;
			}
		}

		/// <summary>
		/// Int32 xMax
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PxMax;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPxMax
		{
			get
			{
				if(r_PxMax == null)
				{
					r_PxMax = new(this, "xMax", -1);
					r_PxMax.SetBelong(this.instance);
				}
				return r_PxMax;
			}
		}

		/// <summary>
		/// Int32 yMax
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PyMax;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPyMax
		{
			get
			{
				if(r_PyMax == null)
				{
					r_PyMax = new(this, "yMax", -1);
					r_PyMax.SetBelong(this.instance);
				}
				return r_PyMax;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int position
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pposition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.instance);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int size
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Psize;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
					r_Psize.SetBelong(this.instance);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// PositionEnumerator allPositionsWithin
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRectInt.RPositionEnumerator r_PallPositionsWithin;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRectInt.RPositionEnumerator RPallPositionsWithin
		{
			get
			{
				if(r_PallPositionsWithin == null)
				{
					r_PallPositionsWithin = new(this, "allPositionsWithin", -1);
					r_PallPositionsWithin.SetBelong(this.instance);
				}
				return r_PallPositionsWithin;
			}
		}

		/// <summary>
		/// Void SetMinMax(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_MSetMinMax_Vector2Int_Vector2Int;
		public virtual RMethod RMSetMinMax_Vector2Int_Vector2Int
		{
			get
			{
				if(r_MSetMinMax_Vector2Int_Vector2Int == null)
				{
					r_MSetMinMax_Vector2Int_Vector2Int = new(this, "SetMinMax", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_MSetMinMax_Vector2Int_Vector2Int.SetBelong(this.instance);
				}
				return r_MSetMinMax_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// Void ClampToBounds(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_MClampToBounds_RectInt;
		public virtual RMethod RMClampToBounds_RectInt
		{
			get
			{
				if(r_MClampToBounds_RectInt == null)
				{
					r_MClampToBounds_RectInt = new(this, "ClampToBounds", 0, typeof(UnityEngine.RectInt));
					r_MClampToBounds_RectInt.SetBelong(this.instance);
				}
				return r_MClampToBounds_RectInt;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_MContains_Vector2Int;
		public virtual RMethod RMContains_Vector2Int
		{
			get
			{
				if(r_MContains_Vector2Int == null)
				{
					r_MContains_Vector2Int = new(this, "Contains", 0, typeof(UnityEngine.Vector2Int));
					r_MContains_Vector2Int.SetBelong(this.instance);
				}
				return r_MContains_Vector2Int;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_MOverlaps_RectInt;
		public virtual RMethod RMOverlaps_RectInt
		{
			get
			{
				if(r_MOverlaps_RectInt == null)
				{
					r_MOverlaps_RectInt = new(this, "Overlaps", 0, typeof(UnityEngine.RectInt));
					r_MOverlaps_RectInt.SetBelong(this.instance);
				}
				return r_MOverlaps_RectInt;
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
					r_MToString.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.RectInt)
		/// </summary>
		protected RMethod r_MEquals_RectInt;
		public virtual RMethod RMEquals_RectInt
		{
			get
			{
				if(r_MEquals_RectInt == null)
				{
					r_MEquals_RectInt = new(this, "Equals", 0, typeof(UnityEngine.RectInt));
					r_MEquals_RectInt.SetBelong(this.instance);
				}
				return r_MEquals_RectInt;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual void SetMinMax(UnityEngine.Vector2Int @minPosition, UnityEngine.Vector2Int @maxPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minPosition, @maxPosition};
            var ___result = RMSetMinMax_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClampToBounds(UnityEngine.RectInt @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RMClampToBounds_RectInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.Vector2Int @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMContains_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.RectInt @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMOverlaps_RectInt.Invoke(___genericsType, ___parameters);

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


        public virtual System.Boolean Equals(UnityEngine.RectInt @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_RectInt.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
