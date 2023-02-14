
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Plane
	/// </summary>
    public partial class RPlane : RMember //
    {

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fsize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFsize
		{
			get
			{
				if(r_Fsize == null)
				{
					r_Fsize = new(typeof(UnityEngine.Plane), "size");
					r_Fsize.SetBelong(null);
				}
				return r_Fsize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Normal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Normal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Normal
		{
			get
			{
				if(r_Fm_Normal == null)
				{
					r_Fm_Normal = new(this, "m_Normal");
					r_Fm_Normal.SetBelong(this.instance);
				}
				return r_Fm_Normal;
			}
		}

		/// <summary>
		/// System.Single m_Distance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Distance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Distance
		{
			get
			{
				if(r_Fm_Distance == null)
				{
					r_Fm_Distance = new(this, "m_Distance");
					r_Fm_Distance.SetBelong(this.instance);
				}
				return r_Fm_Distance;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 normal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pnormal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPnormal
		{
			get
			{
				if(r_Pnormal == null)
				{
					r_Pnormal = new(this, "normal", -1);
					r_Pnormal.SetBelong(this.instance);
				}
				return r_Pnormal;
			}
		}

		/// <summary>
		/// Single distance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pdistance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPdistance
		{
			get
			{
				if(r_Pdistance == null)
				{
					r_Pdistance = new(this, "distance", -1);
					r_Pdistance.SetBelong(this.instance);
				}
				return r_Pdistance;
			}
		}

		/// <summary>
		/// UnityEngine.Plane flipped
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPlane r_Pflipped;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPlane RPflipped
		{
			get
			{
				if(r_Pflipped == null)
				{
					r_Pflipped = new(this, "flipped", -1);
					r_Pflipped.SetBelong(this.instance);
				}
				return r_Pflipped;
			}
		}

		/// <summary>
		/// Void SetNormalAndPosition(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSetNormalAndPosition_Vector3_Vector3;
		public virtual RMethod RMSetNormalAndPosition_Vector3_Vector3
		{
			get
			{
				if(r_MSetNormalAndPosition_Vector3_Vector3 == null)
				{
					r_MSetNormalAndPosition_Vector3_Vector3 = new(this, "SetNormalAndPosition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MSetNormalAndPosition_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_MSetNormalAndPosition_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Set3Points(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSet3Points_Vector3_Vector3_Vector3;
		public virtual RMethod RMSet3Points_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_MSet3Points_Vector3_Vector3_Vector3 == null)
				{
					r_MSet3Points_Vector3_Vector3_Vector3 = new(this, "Set3Points", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MSet3Points_Vector3_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_MSet3Points_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void Flip()
		/// </summary>
		protected RMethod r_MFlip;
		public virtual RMethod RMFlip
		{
			get
			{
				if(r_MFlip == null)
				{
					r_MFlip = new(this, "Flip", 0);
					r_MFlip.SetBelong(this.instance);
				}
				return r_MFlip;
			}
		}

		/// <summary>
		/// Void Translate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MTranslate_Vector3;
		public virtual RMethod RMTranslate_Vector3
		{
			get
			{
				if(r_MTranslate_Vector3 == null)
				{
					r_MTranslate_Vector3 = new(this, "Translate", 0, typeof(UnityEngine.Vector3));
					r_MTranslate_Vector3.SetBelong(this.instance);
				}
				return r_MTranslate_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Plane Translate(UnityEngine.Plane, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MTranslate_Plane_Vector3;
		public static RMethod RMTranslate_Plane_Vector3
		{
			get
			{
				if(r_MTranslate_Plane_Vector3 == null)
				{
					r_MTranslate_Plane_Vector3 = new(typeof(UnityEngine.Plane), "Translate", 0, typeof(UnityEngine.Plane), typeof(UnityEngine.Vector3));
					r_MTranslate_Plane_Vector3.SetBelong(null);
				}
				return r_MTranslate_Plane_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MClosestPointOnPlane_Vector3;
		public virtual RMethod RMClosestPointOnPlane_Vector3
		{
			get
			{
				if(r_MClosestPointOnPlane_Vector3 == null)
				{
					r_MClosestPointOnPlane_Vector3 = new(this, "ClosestPointOnPlane", 0, typeof(UnityEngine.Vector3));
					r_MClosestPointOnPlane_Vector3.SetBelong(this.instance);
				}
				return r_MClosestPointOnPlane_Vector3;
			}
		}

		/// <summary>
		/// Single GetDistanceToPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MGetDistanceToPoint_Vector3;
		public virtual RMethod RMGetDistanceToPoint_Vector3
		{
			get
			{
				if(r_MGetDistanceToPoint_Vector3 == null)
				{
					r_MGetDistanceToPoint_Vector3 = new(this, "GetDistanceToPoint", 0, typeof(UnityEngine.Vector3));
					r_MGetDistanceToPoint_Vector3.SetBelong(this.instance);
				}
				return r_MGetDistanceToPoint_Vector3;
			}
		}

		/// <summary>
		/// Boolean GetSide(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MGetSide_Vector3;
		public virtual RMethod RMGetSide_Vector3
		{
			get
			{
				if(r_MGetSide_Vector3 == null)
				{
					r_MGetSide_Vector3 = new(this, "GetSide", 0, typeof(UnityEngine.Vector3));
					r_MGetSide_Vector3.SetBelong(this.instance);
				}
				return r_MGetSide_Vector3;
			}
		}

		/// <summary>
		/// Boolean SameSide(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_MSameSide_Vector3_Vector3;
		public virtual RMethod RMSameSide_Vector3_Vector3
		{
			get
			{
				if(r_MSameSide_Vector3_Vector3 == null)
				{
					r_MSameSide_Vector3_Vector3 = new(this, "SameSide", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_MSameSide_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_MSameSide_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Boolean Raycast(UnityEngine.Ray, Single ByRef)
		/// </summary>
		protected RMethod r_MRaycast_Ray_Out_Single;
		public virtual RMethod RMRaycast_Ray_Out_Single
		{
			get
			{
				if(r_MRaycast_Ray_Out_Single == null)
				{
					r_MRaycast_Ray_Out_Single = new(this, "Raycast", 0, typeof(UnityEngine.Ray), typeof(System.Single).MakeByRefType());
					r_MRaycast_Ray_Out_Single.SetBelong(this.instance);
				}
				return r_MRaycast_Ray_Out_Single;
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
            var ___result = RMSetNormalAndPosition_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Set3Points(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, UnityEngine.Vector3 @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c};
            var ___result = RMSet3Points_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Translate(UnityEngine.Vector3 @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translation};
            var ___result = RMTranslate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Plane Translate(UnityEngine.Plane @plane, UnityEngine.Vector3 @translation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@plane, @translation};
            var ___result = RMTranslate_Plane_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Plane)___result;
        }


        public virtual UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMClosestPointOnPlane_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual System.Single GetDistanceToPoint(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMGetDistanceToPoint_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetSide(UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMGetSide_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SameSide(UnityEngine.Vector3 @inPt0, UnityEngine.Vector3 @inPt1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inPt0, @inPt1};
            var ___result = RMSameSide_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Raycast(UnityEngine.Ray @ray, out System.Single @enter)
        {
			@enter = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ray, @enter};
            var ___result = RMRaycast_Ray_Out_Single.Invoke(___genericsType, ___parameters);
			@enter = (System.Single)___parameters[1];

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
