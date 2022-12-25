using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Bounds
	/// </summary>
    public partial class RBounds : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 m_Center
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Center;
		public virtual RUnityEngine.RVector3 Rm_Center
		{
			get
			{
				if(r_m_Center == null)
				{
					r_m_Center = new(this, "m_Center");
					r_m_Center.SetBelong(this.instance);
				}
				return r_m_Center;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Extents
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Extents;
		public virtual RUnityEngine.RVector3 Rm_Extents
		{
			get
			{
				if(r_m_Extents == null)
				{
					r_m_Extents = new(this, "m_Extents");
					r_m_Extents.SetBelong(this.instance);
				}
				return r_m_Extents;
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
		/// UnityEngine.Vector3 size
		/// </summary>
		protected RUnityEngine.RVector3 r_size;
		public virtual RUnityEngine.RVector3 Rsize
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
		/// UnityEngine.Vector3 extents
		/// </summary>
		protected RUnityEngine.RVector3 r_extents;
		public virtual RUnityEngine.RVector3 Rextents
		{
			get
			{
				if(r_extents == null)
				{
					r_extents = new(this, "extents", -1);
					r_extents.SetBelong(this.instance);
				}
				return r_extents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 min
		/// </summary>
		protected RUnityEngine.RVector3 r_min;
		public virtual RUnityEngine.RVector3 Rmin
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
		/// UnityEngine.Vector3 max
		/// </summary>
		protected RUnityEngine.RVector3 r_max;
		public virtual RUnityEngine.RVector3 Rmax
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
		/// Boolean Equals(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_REquals_Bounds;
		public virtual RMethod REquals_Bounds
		{
			get
			{
				if(r_REquals_Bounds == null)
				{
					r_REquals_Bounds = new(this, "Equals", 0, typeof(UnityEngine.Bounds));
					r_REquals_Bounds.SetBelong(this.instance);
				}
				return r_REquals_Bounds;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Bounds, UnityEngine.Bounds)
		/// </summary>
		protected static RMethod r_Rop_Equality_Bounds_Bounds;
		public static RMethod Rop_Equality_Bounds_Bounds
		{
			get
			{
				if(r_Rop_Equality_Bounds_Bounds == null)
				{
					r_Rop_Equality_Bounds_Bounds = new(typeof(UnityEngine.Bounds), "op_Equality", 0, typeof(UnityEngine.Bounds), typeof(UnityEngine.Bounds));
					r_Rop_Equality_Bounds_Bounds.SetBelong(null);
				}
				return r_Rop_Equality_Bounds_Bounds;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Bounds, UnityEngine.Bounds)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Bounds_Bounds;
		public static RMethod Rop_Inequality_Bounds_Bounds
		{
			get
			{
				if(r_Rop_Inequality_Bounds_Bounds == null)
				{
					r_Rop_Inequality_Bounds_Bounds = new(typeof(UnityEngine.Bounds), "op_Inequality", 0, typeof(UnityEngine.Bounds), typeof(UnityEngine.Bounds));
					r_Rop_Inequality_Bounds_Bounds.SetBelong(null);
				}
				return r_Rop_Inequality_Bounds_Bounds;
			}
		}

		/// <summary>
		/// Void SetMinMax(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetMinMax_Vector3_Vector3;
		public virtual RMethod RSetMinMax_Vector3_Vector3
		{
			get
			{
				if(r_RSetMinMax_Vector3_Vector3 == null)
				{
					r_RSetMinMax_Vector3_Vector3 = new(this, "SetMinMax", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RSetMinMax_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RSetMinMax_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Encapsulate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_REncapsulate_Vector3;
		public virtual RMethod REncapsulate_Vector3
		{
			get
			{
				if(r_REncapsulate_Vector3 == null)
				{
					r_REncapsulate_Vector3 = new(this, "Encapsulate", 0, typeof(UnityEngine.Vector3));
					r_REncapsulate_Vector3.SetBelong(this.instance);
				}
				return r_REncapsulate_Vector3;
			}
		}

		/// <summary>
		/// Void Encapsulate(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_REncapsulate_Bounds;
		public virtual RMethod REncapsulate_Bounds
		{
			get
			{
				if(r_REncapsulate_Bounds == null)
				{
					r_REncapsulate_Bounds = new(this, "Encapsulate", 0, typeof(UnityEngine.Bounds));
					r_REncapsulate_Bounds.SetBelong(this.instance);
				}
				return r_REncapsulate_Bounds;
			}
		}

		/// <summary>
		/// Void Expand(Single)
		/// </summary>
		protected RMethod r_RExpand_Single;
		public virtual RMethod RExpand_Single
		{
			get
			{
				if(r_RExpand_Single == null)
				{
					r_RExpand_Single = new(this, "Expand", 0, typeof(System.Single));
					r_RExpand_Single.SetBelong(this.instance);
				}
				return r_RExpand_Single;
			}
		}

		/// <summary>
		/// Void Expand(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RExpand_Vector3;
		public virtual RMethod RExpand_Vector3
		{
			get
			{
				if(r_RExpand_Vector3 == null)
				{
					r_RExpand_Vector3 = new(this, "Expand", 0, typeof(UnityEngine.Vector3));
					r_RExpand_Vector3.SetBelong(this.instance);
				}
				return r_RExpand_Vector3;
			}
		}

		/// <summary>
		/// Boolean Intersects(UnityEngine.Bounds)
		/// </summary>
		protected RMethod r_RIntersects_Bounds;
		public virtual RMethod RIntersects_Bounds
		{
			get
			{
				if(r_RIntersects_Bounds == null)
				{
					r_RIntersects_Bounds = new(this, "Intersects", 0, typeof(UnityEngine.Bounds));
					r_RIntersects_Bounds.SetBelong(this.instance);
				}
				return r_RIntersects_Bounds;
			}
		}

		/// <summary>
		/// Boolean IntersectRay(UnityEngine.Ray)
		/// </summary>
		protected RMethod r_RIntersectRay_Ray;
		public virtual RMethod RIntersectRay_Ray
		{
			get
			{
				if(r_RIntersectRay_Ray == null)
				{
					r_RIntersectRay_Ray = new(this, "IntersectRay", 0, typeof(UnityEngine.Ray));
					r_RIntersectRay_Ray.SetBelong(this.instance);
				}
				return r_RIntersectRay_Ray;
			}
		}

		/// <summary>
		/// Boolean IntersectRay(UnityEngine.Ray, Single ByRef)
		/// </summary>
		protected RMethod r_RIntersectRay_Ray_Out_Single;
		public virtual RMethod RIntersectRay_Ray_Out_Single
		{
			get
			{
				if(r_RIntersectRay_Ray_Out_Single == null)
				{
					r_RIntersectRay_Ray_Out_Single = new(this, "IntersectRay", 0, typeof(UnityEngine.Ray), typeof(System.Single).MakeByRefType());
					r_RIntersectRay_Ray_Out_Single.SetBelong(this.instance);
				}
				return r_RIntersectRay_Ray_Out_Single;
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
		/// Single SqrDistance(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSqrDistance_Vector3;
		public virtual RMethod RSqrDistance_Vector3
		{
			get
			{
				if(r_RSqrDistance_Vector3 == null)
				{
					r_RSqrDistance_Vector3 = new(this, "SqrDistance", 0, typeof(UnityEngine.Vector3));
					r_RSqrDistance_Vector3.SetBelong(this.instance);
				}
				return r_RSqrDistance_Vector3;
			}
		}

		/// <summary>
		/// Boolean IntersectRayAABB(UnityEngine.Ray, UnityEngine.Bounds, Single ByRef)
		/// </summary>
		protected static RMethod r_RIntersectRayAABB_Ray_Bounds_Out_Single;
		public static RMethod RIntersectRayAABB_Ray_Bounds_Out_Single
		{
			get
			{
				if(r_RIntersectRayAABB_Ray_Bounds_Out_Single == null)
				{
					r_RIntersectRayAABB_Ray_Bounds_Out_Single = new(typeof(UnityEngine.Bounds), "IntersectRayAABB", 0, typeof(UnityEngine.Ray), typeof(UnityEngine.Bounds), typeof(System.Single).MakeByRefType());
					r_RIntersectRayAABB_Ray_Bounds_Out_Single.SetBelong(null);
				}
				return r_RIntersectRayAABB_Ray_Bounds_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RClosestPoint_Vector3;
		public virtual RMethod RClosestPoint_Vector3
		{
			get
			{
				if(r_RClosestPoint_Vector3 == null)
				{
					r_RClosestPoint_Vector3 = new(this, "ClosestPoint", 0, typeof(UnityEngine.Vector3));
					r_RClosestPoint_Vector3.SetBelong(this.instance);
				}
				return r_RClosestPoint_Vector3;
			}
		}

		/// <summary>
		/// Boolean Contains_Injected(UnityEngine.Bounds ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_RContains_Injected_Ref_Bounds_Ref_Vector3;
		public static RMethod RContains_Injected_Ref_Bounds_Ref_Vector3
		{
			get
			{
				if(r_RContains_Injected_Ref_Bounds_Ref_Vector3 == null)
				{
					r_RContains_Injected_Ref_Bounds_Ref_Vector3 = new(typeof(UnityEngine.Bounds), "Contains_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RContains_Injected_Ref_Bounds_Ref_Vector3.SetBelong(null);
				}
				return r_RContains_Injected_Ref_Bounds_Ref_Vector3;
			}
		}

		/// <summary>
		/// Single SqrDistance_Injected(UnityEngine.Bounds ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_RSqrDistance_Injected_Ref_Bounds_Ref_Vector3;
		public static RMethod RSqrDistance_Injected_Ref_Bounds_Ref_Vector3
		{
			get
			{
				if(r_RSqrDistance_Injected_Ref_Bounds_Ref_Vector3 == null)
				{
					r_RSqrDistance_Injected_Ref_Bounds_Ref_Vector3 = new(typeof(UnityEngine.Bounds), "SqrDistance_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RSqrDistance_Injected_Ref_Bounds_Ref_Vector3.SetBelong(null);
				}
				return r_RSqrDistance_Injected_Ref_Bounds_Ref_Vector3;
			}
		}

		/// <summary>
		/// Boolean IntersectRayAABB_Injected(UnityEngine.Ray ByRef, UnityEngine.Bounds ByRef, Single ByRef)
		/// </summary>
		protected static RMethod r_RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single;
		public static RMethod RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single
		{
			get
			{
				if(r_RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single == null)
				{
					r_RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single = new(typeof(UnityEngine.Bounds), "IntersectRayAABB_Injected", 0, typeof(UnityEngine.Ray).MakeByRefType(), typeof(UnityEngine.Bounds).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single.SetBelong(null);
				}
				return r_RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single;
			}
		}

		/// <summary>
		/// Void ClosestPoint_Injected(UnityEngine.Bounds ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected static RMethod r_RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3;
		public static RMethod RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3 == null)
				{
					r_RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3 = new(typeof(UnityEngine.Bounds), "ClosestPoint_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3.SetBelong(null);
				}
				return r_RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3;
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


        public virtual System.Boolean Equals(UnityEngine.Bounds  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Bounds  @lhs, UnityEngine.Bounds  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Bounds_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Bounds  @lhs, UnityEngine.Bounds  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Bounds_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetMinMax(UnityEngine.Vector3  @min, UnityEngine.Vector3  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RSetMinMax_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Encapsulate(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = REncapsulate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Encapsulate(UnityEngine.Bounds  @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = REncapsulate_Bounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Expand(System.Single  @amount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@amount};
            var ___result = RExpand_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Expand(UnityEngine.Vector3  @amount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@amount};
            var ___result = RExpand_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Intersects(UnityEngine.Bounds  @bounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bounds};
            var ___result = RIntersects_Bounds.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IntersectRay(UnityEngine.Ray  @ray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray};
            var ___result = RIntersectRay_Ray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IntersectRay(UnityEngine.Ray  @ray, out System.Single  @distance)
        {
			distance = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @distance};
            var ___result = RIntersectRay_Ray_Out_Single.Invoke(___genericsType, ___parameters);
			distance = (System.Single)___parameters[1];

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


        public virtual System.Boolean Contains(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RContains_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single SqrDistance(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RSqrDistance_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Boolean IntersectRayAABB(UnityEngine.Ray  @ray, UnityEngine.Bounds  @bounds, out System.Single  @dist)
        {
			dist = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @bounds, @dist};
            var ___result = RIntersectRayAABB_Ray_Bounds_Out_Single.Invoke(___genericsType, ___parameters);
			dist = (System.Single)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RClosestPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean Contains_Injected(ref UnityEngine.Bounds  @_unity_self, ref UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @point};
            var ___result = RContains_Injected_Ref_Bounds_Ref_Vector3.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Bounds)___parameters[0];
			point = (UnityEngine.Vector3)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Single SqrDistance_Injected(ref UnityEngine.Bounds  @_unity_self, ref UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @point};
            var ___result = RSqrDistance_Injected_Ref_Bounds_Ref_Vector3.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Bounds)___parameters[0];
			point = (UnityEngine.Vector3)___parameters[1];

            return (System.Single)___result;
        }


        public static System.Boolean IntersectRayAABB_Injected(ref UnityEngine.Ray  @ray, ref UnityEngine.Bounds  @bounds, out System.Single  @dist)
        {
			dist = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @bounds, @dist};
            var ___result = RIntersectRayAABB_Injected_Ref_Ray_Ref_Bounds_Out_Single.Invoke(___genericsType, ___parameters);
			ray = (UnityEngine.Ray)___parameters[0];
			bounds = (UnityEngine.Bounds)___parameters[1];
			dist = (System.Single)___parameters[2];

            return (System.Boolean)___result;
        }


        public static void ClosestPoint_Injected(ref UnityEngine.Bounds  @_unity_self, ref UnityEngine.Vector3  @point, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @point, @ret};
            var ___result = RClosestPoint_Injected_Ref_Bounds_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Bounds)___parameters[0];
			point = (UnityEngine.Vector3)___parameters[1];
			ret = (UnityEngine.Vector3)___parameters[2];

            
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
