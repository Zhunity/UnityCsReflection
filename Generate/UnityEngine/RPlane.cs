using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Plane
	/// </summary>
    public partial class RPlane : RMember //
    {

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected static RField r_size;
		public static RField Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(typeof(UnityEngine.Plane), "size");
					r_size.SetBelong(null);
				}
				return r_size;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Normal
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Normal;
		public virtual RUnityEngine.RVector3 Rm_Normal
		{
			get
			{
				if(r_m_Normal == null)
				{
					r_m_Normal = new(this, "m_Normal");
					r_m_Normal.SetBelong(this.instance);
				}
				return r_m_Normal;
			}
		}

		/// <summary>
		/// System.Single m_Distance
		/// </summary>
		protected RField r_m_Distance;
		public virtual RField Rm_Distance
		{
			get
			{
				if(r_m_Distance == null)
				{
					r_m_Distance = new(this, "m_Distance");
					r_m_Distance.SetBelong(this.instance);
				}
				return r_m_Distance;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 normal
		/// </summary>
		protected RUnityEngine.RVector3 r_normal;
		public virtual RUnityEngine.RVector3 Rnormal
		{
			get
			{
				if(r_normal == null)
				{
					r_normal = new(this, "normal", -1);
					r_normal.SetBelong(this.instance);
				}
				return r_normal;
			}
		}

		/// <summary>
		/// Single distance
		/// </summary>
		protected RProperty r_distance;
		public virtual RProperty Rdistance
		{
			get
			{
				if(r_distance == null)
				{
					r_distance = new(this, "distance", -1);
					r_distance.SetBelong(this.instance);
				}
				return r_distance;
			}
		}

		/// <summary>
		/// UnityEngine.Plane flipped
		/// </summary>
		protected RUnityEngine.RPlane r_flipped;
		public virtual RUnityEngine.RPlane Rflipped
		{
			get
			{
				if(r_flipped == null)
				{
					r_flipped = new(this, "flipped", -1);
					r_flipped.SetBelong(this.instance);
				}
				return r_flipped;
			}
		}

		/// <summary>
		/// Void SetNormalAndPosition(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetNormalAndPosition_Vector3_Vector3;
		public virtual RMethod RSetNormalAndPosition_Vector3_Vector3
		{
			get
			{
				if(r_RSetNormalAndPosition_Vector3_Vector3 == null)
				{
					r_RSetNormalAndPosition_Vector3_Vector3 = new(this, "SetNormalAndPosition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RSetNormalAndPosition_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RSetNormalAndPosition_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Set3Points(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSet3Points_Vector3_Vector3_Vector3;
		public virtual RMethod RSet3Points_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_RSet3Points_Vector3_Vector3_Vector3 == null)
				{
					r_RSet3Points_Vector3_Vector3_Vector3 = new(this, "Set3Points", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RSet3Points_Vector3_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RSet3Points_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Flip()
		/// </summary>
		protected RMethod r_RFlip;
		public virtual RMethod RFlip
		{
			get
			{
				if(r_RFlip == null)
				{
					r_RFlip = new(this, "Flip", 0);
					r_RFlip.SetBelong(this.instance);
				}
				return r_RFlip;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RTranslate_Vector3;
		public virtual RMethod RTranslate_Vector3
		{
			get
			{
				if(r_RTranslate_Vector3 == null)
				{
					r_RTranslate_Vector3 = new(this, "Translate", 0, typeof(UnityEngine.Vector3));
					r_RTranslate_Vector3.SetBelong(this.instance);
				}
				return r_RTranslate_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Plane Translate(UnityEngine.Plane, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RTranslate_Plane_Vector3;
		public static RMethod RTranslate_Plane_Vector3
		{
			get
			{
				if(r_RTranslate_Plane_Vector3 == null)
				{
					r_RTranslate_Plane_Vector3 = new(typeof(UnityEngine.Plane), "Translate", 0, typeof(UnityEngine.Plane), typeof(UnityEngine.Vector3));
					r_RTranslate_Plane_Vector3.SetBelong(null);
				}
				return r_RTranslate_Plane_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RClosestPointOnPlane_Vector3;
		public virtual RMethod RClosestPointOnPlane_Vector3
		{
			get
			{
				if(r_RClosestPointOnPlane_Vector3 == null)
				{
					r_RClosestPointOnPlane_Vector3 = new(this, "ClosestPointOnPlane", 0, typeof(UnityEngine.Vector3));
					r_RClosestPointOnPlane_Vector3.SetBelong(this.instance);
				}
				return r_RClosestPointOnPlane_Vector3;
			}
		}

		/// <summary>
		/// Single GetDistanceToPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RGetDistanceToPoint_Vector3;
		public virtual RMethod RGetDistanceToPoint_Vector3
		{
			get
			{
				if(r_RGetDistanceToPoint_Vector3 == null)
				{
					r_RGetDistanceToPoint_Vector3 = new(this, "GetDistanceToPoint", 0, typeof(UnityEngine.Vector3));
					r_RGetDistanceToPoint_Vector3.SetBelong(this.instance);
				}
				return r_RGetDistanceToPoint_Vector3;
			}
		}

		/// <summary>
		/// Boolean GetSide(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RGetSide_Vector3;
		public virtual RMethod RGetSide_Vector3
		{
			get
			{
				if(r_RGetSide_Vector3 == null)
				{
					r_RGetSide_Vector3 = new(this, "GetSide", 0, typeof(UnityEngine.Vector3));
					r_RGetSide_Vector3.SetBelong(this.instance);
				}
				return r_RGetSide_Vector3;
			}
		}

		/// <summary>
		/// Boolean SameSide(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSameSide_Vector3_Vector3;
		public virtual RMethod RSameSide_Vector3_Vector3
		{
			get
			{
				if(r_RSameSide_Vector3_Vector3 == null)
				{
					r_RSameSide_Vector3_Vector3 = new(this, "SameSide", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RSameSide_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RSameSide_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Boolean Raycast(UnityEngine.Ray, Single ByRef)
		/// </summary>
		protected RMethod r_RRaycast_Ray_Out_Single;
		public virtual RMethod RRaycast_Ray_Out_Single
		{
			get
			{
				if(r_RRaycast_Ray_Out_Single == null)
				{
					r_RRaycast_Ray_Out_Single = new(this, "Raycast", 0, typeof(UnityEngine.Ray), typeof(System.Single).MakeByRefType());
					r_RRaycast_Ray_Out_Single.SetBelong(this.instance);
				}
				return r_RRaycast_Ray_Out_Single;
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


        public RPlane() : base("UnityEngine.Plane")
        {
        }

        public RPlane(System.Object instance) : base("UnityEngine.Plane")
		{
            SetInstance(instance);
		}

        public RPlane(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPlane(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetNormalAndPosition(UnityEngine.Vector3  @inNormal, UnityEngine.Vector3  @inPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormal, @inPoint};
            var ___result = RSetNormalAndPosition_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Set3Points(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, UnityEngine.Vector3  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c};
            var ___result = RSet3Points_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(UnityEngine.Vector3  @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation};
            var ___result = RTranslate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Plane Translate(UnityEngine.Plane  @plane, UnityEngine.Vector3  @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@plane, @translation};
            var ___result = RTranslate_Plane_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RClosestPointOnPlane_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual System.Single GetDistanceToPoint(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RGetDistanceToPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetSide(UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RGetSide_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SameSide(UnityEngine.Vector3  @inPt0, UnityEngine.Vector3  @inPt1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inPt0, @inPt1};
            var ___result = RSameSide_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Raycast(UnityEngine.Ray  @ray, out System.Single  @enter)
        {
			enter = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @enter};
            var ___result = RRaycast_Ray_Out_Single.Invoke(___genericsType, ___parameters);
			enter = (System.Single)___parameters[1];

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
