
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Bounds
	/// </summary>
    public partial class RBounds : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 m_Center
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Center;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Center
		{
			get
			{
				if(r_Fm_Center == null)
				{
					r_Fm_Center = new(this, "m_Center");
					r_Fm_Center.SetBelong(this.instance);
				}
				return r_Fm_Center;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Extents
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Extents;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Extents
		{
			get
			{
				if(r_Fm_Extents == null)
				{
					r_Fm_Extents = new(this, "m_Extents");
					r_Fm_Extents.SetBelong(this.instance);
				}
				return r_Fm_Extents;
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
					r_Pcenter.SetBelong(this.instance);
				}
				return r_Pcenter;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Psize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPsize
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
		/// UnityEngine.Vector3 extents
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pextents;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPextents
		{
			get
			{
				if(r_Pextents == null)
				{
					r_Pextents = new(this, "extents", -1);
					r_Pextents.SetBelong(this.instance);
				}
				return r_Pextents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 min
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pmin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPmin
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
		/// UnityEngine.Vector3 max
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pmax;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPmax
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
		/// Boolean Equals(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_MEquals_Bounds;
		public virtual RMethod RMEquals_Bounds
		{
			get
			{
				if(r_MEquals_Bounds == null)
				{
					r_MEquals_Bounds = new(this, "Equals", 0, typeof(UnityEngine.Bounds));
					r_MEquals_Bounds.SetBelong(this.instance);
				}
				return r_MEquals_Bounds;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Bounds, UnityEngine.Bounds)
		/// </summary>
		protected static RMethod r_Mop_Equality_Bounds_Bounds;
		public static RMethod RMop_Equality_Bounds_Bounds
		{
			get
			{
				if(r_Mop_Equality_Bounds_Bounds == null)
				{
					r_Mop_Equality_Bounds_Bounds = new(typeof(UnityEngine.Bounds), "op_Equality", 0, typeof(UnityEngine.Bounds), typeof(UnityEngine.Bounds));
					r_Mop_Equality_Bounds_Bounds.SetBelong(null);
				}
				return r_Mop_Equality_Bounds_Bounds;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Bounds, UnityEngine.Bounds)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Bounds_Bounds;
		public static RMethod RMop_Inequality_Bounds_Bounds
		{
			get
			{
				if(r_Mop_Inequality_Bounds_Bounds == null)
				{
					r_Mop_Inequality_Bounds_Bounds = new(typeof(UnityEngine.Bounds), "op_Inequality", 0, typeof(UnityEngine.Bounds), typeof(UnityEngine.Bounds));
					r_Mop_Inequality_Bounds_Bounds.SetBelong(null);
				}
				return r_Mop_Inequality_Bounds_Bounds;
			}
		}

		/// <summary>
		/// Void SetMinMax(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetMinMax_Vector3_Vector3;
		public virtual RMethod RMSetMinMax_Vector3_Vector3
		{
			get
			{
				if(r_MSetMinMax_Vector3_Vector3 == null)
				{
					r_MSetMinMax_Vector3_Vector3 = new(this, "SetMinMax", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MSetMinMax_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_MSetMinMax_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Encapsulate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MEncapsulate_Vector3;
		public virtual RMethod RMEncapsulate_Vector3
		{
			get
			{
				if(r_MEncapsulate_Vector3 == null)
				{
					r_MEncapsulate_Vector3 = new(this, "Encapsulate", 0, typeof(UnityEngine.Vector3));
					r_MEncapsulate_Vector3.SetBelong(this.instance);
				}
				return r_MEncapsulate_Vector3;
			}
		}

		/// <summary>
		/// Void Encapsulate(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_MEncapsulate_Bounds;
		public virtual RMethod RMEncapsulate_Bounds
		{
			get
			{
				if(r_MEncapsulate_Bounds == null)
				{
					r_MEncapsulate_Bounds = new(this, "Encapsulate", 0, typeof(UnityEngine.Bounds));
					r_MEncapsulate_Bounds.SetBelong(this.instance);
				}
				return r_MEncapsulate_Bounds;
			}
		}

		/// <summary>
		/// Void Expand(Single)
		/// </summary>
		protected RMethod r_MExpand_Single;
		public virtual RMethod RMExpand_Single
		{
			get
			{
				if(r_MExpand_Single == null)
				{
					r_MExpand_Single = new(this, "Expand", 0, typeof(System.Single));
					r_MExpand_Single.SetBelong(this.instance);
				}
				return r_MExpand_Single;
			}
		}

		/// <summary>
		/// Void Expand(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MExpand_Vector3;
		public virtual RMethod RMExpand_Vector3
		{
			get
			{
				if(r_MExpand_Vector3 == null)
				{
					r_MExpand_Vector3 = new(this, "Expand", 0, typeof(UnityEngine.Vector3));
					r_MExpand_Vector3.SetBelong(this.instance);
				}
				return r_MExpand_Vector3;
			}
		}

		/// <summary>
		/// Boolean Intersects(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_MIntersects_Bounds;
		public virtual RMethod RMIntersects_Bounds
		{
			get
			{
				if(r_MIntersects_Bounds == null)
				{
					r_MIntersects_Bounds = new(this, "Intersects", 0, typeof(UnityEngine.Bounds));
					r_MIntersects_Bounds.SetBelong(this.instance);
				}
				return r_MIntersects_Bounds;
			}
		}

		/// <summary>
		/// Boolean IntersectRay(UnityEngine.Ray)
		/// </summary>
		protected RMethod r_MIntersectRay_Ray;
		public virtual RMethod RMIntersectRay_Ray
		{
			get
			{
				if(r_MIntersectRay_Ray == null)
				{
					r_MIntersectRay_Ray = new(this, "IntersectRay", 0, typeof(UnityEngine.Ray));
					r_MIntersectRay_Ray.SetBelong(this.instance);
				}
				return r_MIntersectRay_Ray;
			}
		}

		/// <summary>
		/// Boolean IntersectRay(UnityEngine.Ray, Single ByRef)
		/// </summary>
		protected RMethod r_MIntersectRay_Ray_Out_Single;
		public virtual RMethod RMIntersectRay_Ray_Out_Single
		{
			get
			{
				if(r_MIntersectRay_Ray_Out_Single == null)
				{
					r_MIntersectRay_Ray_Out_Single = new(this, "IntersectRay", 0, typeof(UnityEngine.Ray), typeof(System.Single).MakeByRefType());
					r_MIntersectRay_Ray_Out_Single.SetBelong(this.instance);
				}
				return r_MIntersectRay_Ray_Out_Single;
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
					r_MContains_Vector3.SetBelong(this.instance);
				}
				return r_MContains_Vector3;
			}
		}

		/// <summary>
		/// Single SqrDistance(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSqrDistance_Vector3;
		public virtual RMethod RMSqrDistance_Vector3
		{
			get
			{
				if(r_MSqrDistance_Vector3 == null)
				{
					r_MSqrDistance_Vector3 = new(this, "SqrDistance", 0, typeof(UnityEngine.Vector3));
					r_MSqrDistance_Vector3.SetBelong(this.instance);
				}
				return r_MSqrDistance_Vector3;
			}
		}

		/// <summary>
		/// Boolean IntersectRayAABB(UnityEngine.Ray, UnityEngine.Bounds, Single ByRef)
		/// </summary>
		protected static RMethod r_MIntersectRayAABB_Ray_Bounds_Out_Single;
		public static RMethod RMIntersectRayAABB_Ray_Bounds_Out_Single
		{
			get
			{
				if(r_MIntersectRayAABB_Ray_Bounds_Out_Single == null)
				{
					r_MIntersectRayAABB_Ray_Bounds_Out_Single = new(typeof(UnityEngine.Bounds), "IntersectRayAABB", 0, typeof(UnityEngine.Ray), typeof(UnityEngine.Bounds), typeof(System.Single).MakeByRefType());
					r_MIntersectRayAABB_Ray_Bounds_Out_Single.SetBelong(null);
				}
				return r_MIntersectRayAABB_Ray_Bounds_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MClosestPoint_Vector3;
		public virtual RMethod RMClosestPoint_Vector3
		{
			get
			{
				if(r_MClosestPoint_Vector3 == null)
				{
					r_MClosestPoint_Vector3 = new(this, "ClosestPoint", 0, typeof(UnityEngine.Vector3));
					r_MClosestPoint_Vector3.SetBelong(this.instance);
				}
				return r_MClosestPoint_Vector3;
			}
		}

		/// <summary>
		/// Boolean Contains_Injected(UnityEngine.Bounds ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MContains_Injected_Ref_Bounds_Ref_Vector3;
		public static RMethod RMContains_Injected_Ref_Bounds_Ref_Vector3
		{
			get
			{
				if(r_MContains_Injected_Ref_Bounds_Ref_Vector3 == null)
				{
					r_MContains_Injected_Ref_Bounds_Ref_Vector3 = new(typeof(UnityEngine.Bounds), "Contains_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MContains_Injected_Ref_Bounds_Ref_Vector3.SetBelong(null);
				}
				return r_MContains_Injected_Ref_Bounds_Ref_Vector3;
			}
		}

		/// <summary>
		/// Single SqrDistance_Injected(UnityEngine.Bounds ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MSqrDistance_Injected_Ref_Bounds_Ref_Vector3;
		public static RMethod RMSqrDistance_Injected_Ref_Bounds_Ref_Vector3
		{
			get
			{
				if(r_MSqrDistance_Injected_Ref_Bounds_Ref_Vector3 == null)
				{
					r_MSqrDistance_Injected_Ref_Bounds_Ref_Vector3 = new(typeof(UnityEngine.Bounds), "SqrDistance_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MSqrDistance_Injected_Ref_Bounds_Ref_Vector3.SetBelong(null);
				}
				return r_MSqrDistance_Injected_Ref_Bounds_Ref_Vector3;
			}
		}

		/// <summary>
		/// Boolean IntersectRayAABB_Injected(UnityEngine.Ray ByRef, UnityEngine.Bounds ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_MIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single;
		public static RMethod RMIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single
		{
			get
			{
				if(r_MIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single == null)
				{
					r_MIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single = new(typeof(UnityEngine.Bounds), "IntersectRayAABB_Injected", 0, typeof(UnityEngine.Ray).MakeByRefType(), typeof(UnityEngine.Bounds).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_MIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single.SetBelong(null);
				}
				return r_MIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single;
			}
		}

		/// <summary>
		/// Void ClosestPoint_Injected(UnityEngine.Bounds ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_MClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3;
		public static RMethod RMClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_MClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3 == null)
				{
					r_MClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3 = new(typeof(UnityEngine.Bounds), "ClosestPoint_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_MClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3.SetBelong(null);
				}
				return r_MClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3;
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


        public RBounds() : base("UnityEngine.Bounds")
        {
        }

        public RBounds(System.Object instance) : base("UnityEngine.Bounds")
		{
            SetInstance(instance);
		}

        public RBounds(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBounds(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Boolean Equals(UnityEngine.Bounds @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Bounds @lhs, UnityEngine.Bounds @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Bounds_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Bounds @lhs, UnityEngine.Bounds @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Bounds_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetMinMax(UnityEngine.Vector3 @min, UnityEngine.Vector3 @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMSetMinMax_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Encapsulate(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMEncapsulate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Encapsulate(UnityEngine.Bounds @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RMEncapsulate_Bounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Expand(System.Single @amount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@amount};
            var ___result = RMExpand_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Expand(UnityEngine.Vector3 @amount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@amount};
            var ___result = RMExpand_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Intersects(UnityEngine.Bounds @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RMIntersects_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IntersectRay(UnityEngine.Ray @ray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray};
            var ___result = RMIntersectRay_Ray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IntersectRay(UnityEngine.Ray @ray, out System.Single @distance)
        {
			@distance = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @distance};
            var ___result = RMIntersectRay_Ray_Out_Single.Invoke(___genericsType, ___parameters);
			@distance = (System.Single)___parameters[1];

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


        public virtual System.Boolean Contains(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMContains_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single SqrDistance(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMSqrDistance_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Boolean IntersectRayAABB(UnityEngine.Ray @ray, UnityEngine.Bounds @bounds, out System.Single @dist)
        {
			@dist = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @bounds, @dist};
            var ___result = RMIntersectRayAABB_Ray_Bounds_Out_Single.Invoke(___genericsType, ___parameters);
			@dist = (System.Single)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMClosestPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean Contains_Injected(ref UnityEngine.Bounds @_unity_self, ref UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @point};
            var ___result = RMContains_Injected_Ref_Bounds_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Bounds)___parameters[0];
			@point = (UnityEngine.Vector3)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Single SqrDistance_Injected(ref UnityEngine.Bounds @_unity_self, ref UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @point};
            var ___result = RMSqrDistance_Injected_Ref_Bounds_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Bounds)___parameters[0];
			@point = (UnityEngine.Vector3)___parameters[1];

            return (System.Single)___result;
        }


        public static System.Boolean IntersectRayAABB_Injected(ref UnityEngine.Ray @ray, ref UnityEngine.Bounds @bounds, out System.Single @dist)
        {
			@dist = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @bounds, @dist};
            var ___result = RMIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single.Invoke(___genericsType, ___parameters);
			@ray = (UnityEngine.Ray)___parameters[0];
			@bounds = (UnityEngine.Bounds)___parameters[1];
			@dist = (System.Single)___parameters[2];

            return (System.Boolean)___result;
        }


        public static void ClosestPoint_Injected(ref UnityEngine.Bounds @_unity_self, ref UnityEngine.Vector3 @point, out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @point, @ret};
            var ___result = RMClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Bounds)___parameters[0];
			@point = (UnityEngine.Vector3)___parameters[1];
			@ret = (UnityEngine.Vector3)___parameters[2];

            
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
