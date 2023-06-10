
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Ray
	/// </summary>
    public partial class RRay : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Ray);
            }
        }

        public RRay() : base("UnityEngine.Ray")
        {
        }

        public RRay(System.Object instance) : base("UnityEngine.Ray")
		{
            SetInstance(instance);
		}

        public RRay(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRay(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Vector3 m_Origin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Origin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Origin
		{
			get
			{
				if(r_Fm_Origin == null)
				{
					r_Fm_Origin = new(this, "m_Origin");
				}
				return r_Fm_Origin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Direction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_Direction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_Direction
		{
			get
			{
				if(r_Fm_Direction == null)
				{
					r_Fm_Direction = new(this, "m_Direction");
				}
				return r_Fm_Direction;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 origin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Porigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPorigin
		{
			get
			{
				if(r_Porigin == null)
				{
					r_Porigin = new(this, "origin", -1);
				}
				return r_Porigin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 direction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pdirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPdirection
		{
			get
			{
				if(r_Pdirection == null)
				{
					r_Pdirection = new(this, "direction", -1);
				}
				return r_Pdirection;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetPoint(Single)
		/// </summary>
		protected RMethod r_MGetPoint_Single;
		public virtual RMethod RMGetPoint_Single
		{
			get
			{
				if(r_MGetPoint_Single == null)
				{
					r_MGetPoint_Single = new(this, "GetPoint", 0, typeof(System.Single));
				}
				return r_MGetPoint_Single;
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


        public virtual UnityEngine.Vector3 GetPoint(System.Single @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@distance};
            var ___result = RMGetPoint_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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
