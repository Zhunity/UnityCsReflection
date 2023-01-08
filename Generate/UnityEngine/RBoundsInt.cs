using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BoundsInt
	/// </summary>
    public partial class RBoundsInt : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3Int m_Position
		/// </summary>
		protected RUnityEngine.RVector3Int r_m_Position;
		public virtual RUnityEngine.RVector3Int Rm_Position
		{
			get
			{
				if(r_m_Position == null)
				{
					r_m_Position = new(this, "m_Position");
					r_m_Position.SetBelong(this.instance);
				}
				return r_m_Position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int m_Size
		/// </summary>
		protected RUnityEngine.RVector3Int r_m_Size;
		public virtual RUnityEngine.RVector3Int Rm_Size
		{
			get
			{
				if(r_m_Size == null)
				{
					r_m_Size = new(this, "m_Size");
					r_m_Size.SetBelong(this.instance);
				}
				return r_m_Size;
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
		/// Int32 z
		/// </summary>
		protected RProperty r_z;
		public virtual RProperty Rz
		{
			get
			{
				if(r_z == null)
				{
					r_z = new(this, "z", -1);
					r_z.SetBelong(this.instance);
				}
				return r_z;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 center
		/// </summary>
		protected RUnityEngine.RVector3 r_center;
		public virtual RUnityEngine.RVector3 Rcenter
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
		/// UnityEngine.Vector3Int min
		/// </summary>
		protected RUnityEngine.RVector3Int r_min;
		public virtual RUnityEngine.RVector3Int Rmin
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
		/// UnityEngine.Vector3Int max
		/// </summary>
		protected RUnityEngine.RVector3Int r_max;
		public virtual RUnityEngine.RVector3Int Rmax
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
		/// Int32 zMin
		/// </summary>
		protected RProperty r_zMin;
		public virtual RProperty RzMin
		{
			get
			{
				if(r_zMin == null)
				{
					r_zMin = new(this, "zMin", -1);
					r_zMin.SetBelong(this.instance);
				}
				return r_zMin;
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
		/// Int32 zMax
		/// </summary>
		protected RProperty r_zMax;
		public virtual RProperty RzMax
		{
			get
			{
				if(r_zMax == null)
				{
					r_zMax = new(this, "zMax", -1);
					r_zMax.SetBelong(this.instance);
				}
				return r_zMax;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int position
		/// </summary>
		protected RUnityEngine.RVector3Int r_position;
		public virtual RUnityEngine.RVector3Int Rposition
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
		/// UnityEngine.Vector3Int size
		/// </summary>
		protected RUnityEngine.RVector3Int r_size;
		public virtual RUnityEngine.RVector3Int Rsize
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
		protected RUnityEngine.RBoundsInt.RPositionEnumerator r_allPositionsWithin;
		public virtual RUnityEngine.RBoundsInt.RPositionEnumerator RallPositionsWithin
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
		/// Void SetMinMax(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_SetMinMax_Vector3Int_Vector3Int;
		public virtual RMethod RSetMinMax_Vector3Int_Vector3Int
		{
			get
			{
				if(r_SetMinMax_Vector3Int_Vector3Int == null)
				{
					r_SetMinMax_Vector3Int_Vector3Int = new(this, "SetMinMax", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_SetMinMax_Vector3Int_Vector3Int.SetBelong(this.instance);
				}
				return r_SetMinMax_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// Void ClampToBounds(UnityEngine.BoundsInt)
		/// </summary>
		protected RMethod r_ClampToBounds_BoundsInt;
		public virtual RMethod RClampToBounds_BoundsInt
		{
			get
			{
				if(r_ClampToBounds_BoundsInt == null)
				{
					r_ClampToBounds_BoundsInt = new(this, "ClampToBounds", 0, typeof(UnityEngine.BoundsInt));
					r_ClampToBounds_BoundsInt.SetBelong(this.instance);
				}
				return r_ClampToBounds_BoundsInt;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_Contains_Vector3Int;
		public virtual RMethod RContains_Vector3Int
		{
			get
			{
				if(r_Contains_Vector3Int == null)
				{
					r_Contains_Vector3Int = new(this, "Contains", 0, typeof(UnityEngine.Vector3Int));
					r_Contains_Vector3Int.SetBelong(this.instance);
				}
				return r_Contains_Vector3Int;
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

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.BoundsInt, UnityEngine.BoundsInt)
		/// </summary>
		protected static RMethod r_op_Equality_BoundsInt_BoundsInt;
		public static RMethod Rop_Equality_BoundsInt_BoundsInt
		{
			get
			{
				if(r_op_Equality_BoundsInt_BoundsInt == null)
				{
					r_op_Equality_BoundsInt_BoundsInt = new(typeof(UnityEngine.BoundsInt), "op_Equality", 0, typeof(UnityEngine.BoundsInt), typeof(UnityEngine.BoundsInt));
					r_op_Equality_BoundsInt_BoundsInt.SetBelong(null);
				}
				return r_op_Equality_BoundsInt_BoundsInt;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.BoundsInt, UnityEngine.BoundsInt)
		/// </summary>
		protected static RMethod r_op_Inequality_BoundsInt_BoundsInt;
		public static RMethod Rop_Inequality_BoundsInt_BoundsInt
		{
			get
			{
				if(r_op_Inequality_BoundsInt_BoundsInt == null)
				{
					r_op_Inequality_BoundsInt_BoundsInt = new(typeof(UnityEngine.BoundsInt), "op_Inequality", 0, typeof(UnityEngine.BoundsInt), typeof(UnityEngine.BoundsInt));
					r_op_Inequality_BoundsInt_BoundsInt.SetBelong(null);
				}
				return r_op_Inequality_BoundsInt_BoundsInt;
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
		/// Boolean Equals(UnityEngine.BoundsInt)
		/// </summary>
		protected RMethod r_Equals_BoundsInt;
		public virtual RMethod REquals_BoundsInt
		{
			get
			{
				if(r_Equals_BoundsInt == null)
				{
					r_Equals_BoundsInt = new(this, "Equals", 0, typeof(UnityEngine.BoundsInt));
					r_Equals_BoundsInt.SetBelong(this.instance);
				}
				return r_Equals_BoundsInt;
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


        public RBoundsInt() : base("UnityEngine.BoundsInt")
        {
        }

        public RBoundsInt(System.Object instance) : base("UnityEngine.BoundsInt")
		{
            SetInstance(instance);
		}

        public RBoundsInt(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBoundsInt(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetMinMax(UnityEngine.Vector3Int @minPosition, UnityEngine.Vector3Int @maxPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minPosition, @maxPosition};
            var ___result = RSetMinMax_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClampToBounds(UnityEngine.BoundsInt @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RClampToBounds_BoundsInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3Int @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RContains_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.BoundsInt @lhs, UnityEngine.BoundsInt @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_BoundsInt_BoundsInt.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.BoundsInt @lhs, UnityEngine.BoundsInt @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_BoundsInt_BoundsInt.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.BoundsInt @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_BoundsInt.Invoke(___genericsType, ___parameters);

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
