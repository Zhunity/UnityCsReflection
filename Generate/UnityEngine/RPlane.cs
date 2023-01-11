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
		protected static RSystem.RInt32 r_size;
		public static RSystem.RInt32 Rsize
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
		protected RSystem.RSingle r_m_Distance;
		public virtual RSystem.RSingle Rm_Distance
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
		protected RSystem.RSingle r_distance;
		public virtual RSystem.RSingle Rdistance
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
		protected RMethod r_SetNormalAndPosition_Vector3_Vector3;
		public virtual RMethod RSetNormalAndPosition_Vector3_Vector3
		{
			get
			{
				if(r_SetNormalAndPosition_Vector3_Vector3 == null)
				{
					r_SetNormalAndPosition_Vector3_Vector3 = new(this, "SetNormalAndPosition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_SetNormalAndPosition_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_SetNormalAndPosition_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Set3Points(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_Set3Points_Vector3_Vector3_Vector3;
		public virtual RMethod RSet3Points_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_Set3Points_Vector3_Vector3_Vector3 == null)
				{
					r_Set3Points_Vector3_Vector3_Vector3 = new(this, "Set3Points", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_Set3Points_Vector3_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_Set3Points_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Flip()
		/// </summary>
		protected RMethod r_Flip;
		public virtual RMethod RFlip
		{
			get
			{
				if(r_Flip == null)
				{
					r_Flip = new(this, "Flip", 0);
					r_Flip.SetBelong(this.instance);
				}
				return r_Flip;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_Translate_Vector3;
		public virtual RMethod RTranslate_Vector3
		{
			get
			{
				if(r_Translate_Vector3 == null)
				{
					r_Translate_Vector3 = new(this, "Translate", 0, typeof(UnityEngine.Vector3));
					r_Translate_Vector3.SetBelong(this.instance);
				}
				return r_Translate_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Plane Translate(UnityEngine.Plane, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_Translate_Plane_Vector3;
		public static RMethod RTranslate_Plane_Vector3
		{
			get
			{
				if(r_Translate_Plane_Vector3 == null)
				{
					r_Translate_Plane_Vector3 = new(typeof(UnityEngine.Plane), "Translate", 0, typeof(UnityEngine.Plane), typeof(UnityEngine.Vector3));
					r_Translate_Plane_Vector3.SetBelong(null);
				}
				return r_Translate_Plane_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_ClosestPointOnPlane_Vector3;
		public virtual RMethod RClosestPointOnPlane_Vector3
		{
			get
			{
				if(r_ClosestPointOnPlane_Vector3 == null)
				{
					r_ClosestPointOnPlane_Vector3 = new(this, "ClosestPointOnPlane", 0, typeof(UnityEngine.Vector3));
					r_ClosestPointOnPlane_Vector3.SetBelong(this.instance);
				}
				return r_ClosestPointOnPlane_Vector3;
			}
		}

		/// <summary>
		/// Single GetDistanceToPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_GetDistanceToPoint_Vector3;
		public virtual RMethod RGetDistanceToPoint_Vector3
		{
			get
			{
				if(r_GetDistanceToPoint_Vector3 == null)
				{
					r_GetDistanceToPoint_Vector3 = new(this, "GetDistanceToPoint", 0, typeof(UnityEngine.Vector3));
					r_GetDistanceToPoint_Vector3.SetBelong(this.instance);
				}
				return r_GetDistanceToPoint_Vector3;
			}
		}

		/// <summary>
		/// Boolean GetSide(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_GetSide_Vector3;
		public virtual RMethod RGetSide_Vector3
		{
			get
			{
				if(r_GetSide_Vector3 == null)
				{
					r_GetSide_Vector3 = new(this, "GetSide", 0, typeof(UnityEngine.Vector3));
					r_GetSide_Vector3.SetBelong(this.instance);
				}
				return r_GetSide_Vector3;
			}
		}

		/// <summary>
		/// Boolean SameSide(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_SameSide_Vector3_Vector3;
		public virtual RMethod RSameSide_Vector3_Vector3
		{
			get
			{
				if(r_SameSide_Vector3_Vector3 == null)
				{
					r_SameSide_Vector3_Vector3 = new(this, "SameSide", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_SameSide_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_SameSide_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Boolean Raycast(UnityEngine.Ray, Single ByRef)
		/// </summary>
		protected RMethod r_Raycast_Ray_Out_Single;
		public virtual RMethod RRaycast_Ray_Out_Single
		{
			get
			{
				if(r_Raycast_Ray_Out_Single == null)
				{
					r_Raycast_Ray_Out_Single = new(this, "Raycast", 0, typeof(UnityEngine.Ray), typeof(System.Single).MakeByRefType());
					r_Raycast_Ray_Out_Single.SetBelong(this.instance);
				}
				return r_Raycast_Ray_Out_Single;
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

        public virtual void SetNormalAndPosition(UnityEngine.Vector3 @inNormal, UnityEngine.Vector3 @inPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormal, @inPoint};
            var ___result = RSetNormalAndPosition_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Set3Points(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, UnityEngine.Vector3 @c)
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


        public virtual void Translate(UnityEngine.Vector3 @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation};
            var ___result = RTranslate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Plane Translate(UnityEngine.Plane @plane, UnityEngine.Vector3 @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@plane, @translation};
            var ___result = RTranslate_Plane_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RClosestPointOnPlane_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual System.Single GetDistanceToPoint(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RGetDistanceToPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetSide(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RGetSide_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SameSide(UnityEngine.Vector3 @inPt0, UnityEngine.Vector3 @inPt1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inPt0, @inPt1};
            var ___result = RSameSide_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Raycast(UnityEngine.Ray @ray, out System.Single @enter)
        {
			@enter = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @enter};
            var ___result = RRaycast_Ray_Out_Single.Invoke(___genericsType, ___parameters);
			@enter = (System.Single)___parameters[1];

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


        public virtual System.Boolean Equals(System.Object @obj)
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
