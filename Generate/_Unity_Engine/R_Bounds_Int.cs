
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BoundsInt
	/// </summary>
    public partial class RBoundsInt : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.BoundsInt);
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


		/// <summary>
		/// UnityEngine.Vector3Int m_Position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fm_Position;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFm_Position
		{
			get
			{
				if(r_Fm_Position == null)
				{
					r_Fm_Position = new(this, "m_Position");
				}
				return r_Fm_Position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int m_Size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fm_Size;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFm_Size
		{
			get
			{
				if(r_Fm_Size == null)
				{
					r_Fm_Size = new(this, "m_Size");
				}
				return r_Fm_Size;
			}
		}

		/// <summary>
		/// Int32 x
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Px;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
				}
				return r_Px;
			}
		}

		/// <summary>
		/// Int32 y
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Py;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
				}
				return r_Py;
			}
		}

		/// <summary>
		/// Int32 z
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pz;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPz
		{
			get
			{
				if(r_Pz == null)
				{
					r_Pz = new(this, "z", -1);
				}
				return r_Pz;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 center
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pcenter;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPcenter
		{
			get
			{
				if(r_Pcenter == null)
				{
					r_Pcenter = new(this, "center", -1);
				}
				return r_Pcenter;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int min
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pmin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPmin
		{
			get
			{
				if(r_Pmin == null)
				{
					r_Pmin = new(this, "min", -1);
				}
				return r_Pmin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int max
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pmax;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPmax
		{
			get
			{
				if(r_Pmax == null)
				{
					r_Pmax = new(this, "max", -1);
				}
				return r_Pmax;
			}
		}

		/// <summary>
		/// Int32 xMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PxMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPxMin
		{
			get
			{
				if(r_PxMin == null)
				{
					r_PxMin = new(this, "xMin", -1);
				}
				return r_PxMin;
			}
		}

		/// <summary>
		/// Int32 yMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PyMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPyMin
		{
			get
			{
				if(r_PyMin == null)
				{
					r_PyMin = new(this, "yMin", -1);
				}
				return r_PyMin;
			}
		}

		/// <summary>
		/// Int32 zMin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PzMin;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPzMin
		{
			get
			{
				if(r_PzMin == null)
				{
					r_PzMin = new(this, "zMin", -1);
				}
				return r_PzMin;
			}
		}

		/// <summary>
		/// Int32 xMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PxMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPxMax
		{
			get
			{
				if(r_PxMax == null)
				{
					r_PxMax = new(this, "xMax", -1);
				}
				return r_PxMax;
			}
		}

		/// <summary>
		/// Int32 yMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PyMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPyMax
		{
			get
			{
				if(r_PyMax == null)
				{
					r_PyMax = new(this, "yMax", -1);
				}
				return r_PyMax;
			}
		}

		/// <summary>
		/// Int32 zMax
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PzMax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPzMax
		{
			get
			{
				if(r_PzMax == null)
				{
					r_PzMax = new(this, "zMax", -1);
				}
				return r_PzMax;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Psize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// PositionEnumerator allPositionsWithin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBoundsInt.RPositionEnumerator r_PallPositionsWithin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBoundsInt.RPositionEnumerator RPallPositionsWithin
		{
			get
			{
				if(r_PallPositionsWithin == null)
				{
					r_PallPositionsWithin = new(this, "allPositionsWithin", -1);
				}
				return r_PallPositionsWithin;
			}
		}

		/// <summary>
		/// Void SetMinMax(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_MSetMinMax_Vector3Int_Vector3Int;
		public virtual RMethod RMSetMinMax_Vector3Int_Vector3Int
		{
			get
			{
				if(r_MSetMinMax_Vector3Int_Vector3Int == null)
				{
					r_MSetMinMax_Vector3Int_Vector3Int = new(this, "SetMinMax", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_MSetMinMax_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// Void ClampToBounds(UnityEngine.BoundsInt)
		/// </summary>
		protected RMethod r_MClampToBounds_BoundsInt;
		public virtual RMethod RMClampToBounds_BoundsInt
		{
			get
			{
				if(r_MClampToBounds_BoundsInt == null)
				{
					r_MClampToBounds_BoundsInt = new(this, "ClampToBounds", 0, typeof(UnityEngine.BoundsInt));
				}
				return r_MClampToBounds_BoundsInt;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_MContains_Vector3Int;
		public virtual RMethod RMContains_Vector3Int
		{
			get
			{
				if(r_MContains_Vector3Int == null)
				{
					r_MContains_Vector3Int = new(this, "Contains", 0, typeof(UnityEngine.Vector3Int));
				}
				return r_MContains_Vector3Int;
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
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.BoundsInt, UnityEngine.BoundsInt)
		/// </summary>
		protected static RMethod r_Mop_Equality_BoundsInt_BoundsInt;
		public static RMethod RMop_Equality_BoundsInt_BoundsInt
		{
			get
			{
				if(r_Mop_Equality_BoundsInt_BoundsInt == null)
				{
					r_Mop_Equality_BoundsInt_BoundsInt = new(typeof(UnityEngine.BoundsInt), "op_Equality", 0, typeof(UnityEngine.BoundsInt), typeof(UnityEngine.BoundsInt));
				}
				return r_Mop_Equality_BoundsInt_BoundsInt;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.BoundsInt, UnityEngine.BoundsInt)
		/// </summary>
		protected static RMethod r_Mop_Inequality_BoundsInt_BoundsInt;
		public static RMethod RMop_Inequality_BoundsInt_BoundsInt
		{
			get
			{
				if(r_Mop_Inequality_BoundsInt_BoundsInt == null)
				{
					r_Mop_Inequality_BoundsInt_BoundsInt = new(typeof(UnityEngine.BoundsInt), "op_Inequality", 0, typeof(UnityEngine.BoundsInt), typeof(UnityEngine.BoundsInt));
				}
				return r_Mop_Inequality_BoundsInt_BoundsInt;
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
		/// Boolean Equals(UnityEngine.BoundsInt)
		/// </summary>
		protected RMethod r_MEquals_BoundsInt;
		public virtual RMethod RMEquals_BoundsInt
		{
			get
			{
				if(r_MEquals_BoundsInt == null)
				{
					r_MEquals_BoundsInt = new(this, "Equals", 0, typeof(UnityEngine.BoundsInt));
				}
				return r_MEquals_BoundsInt;
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


        public virtual void SetMinMax(UnityEngine.Vector3Int @minPosition, UnityEngine.Vector3Int @maxPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minPosition, @maxPosition};
            var ___result = RMSetMinMax_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClampToBounds(UnityEngine.BoundsInt @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RMClampToBounds_BoundsInt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(UnityEngine.Vector3Int @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMContains_Vector3Int.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean op_Equality(UnityEngine.BoundsInt @lhs, UnityEngine.BoundsInt @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_BoundsInt_BoundsInt.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.BoundsInt @lhs, UnityEngine.BoundsInt @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_BoundsInt_BoundsInt.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.BoundsInt @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_BoundsInt.Invoke(___genericsType, ___parameters);

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
