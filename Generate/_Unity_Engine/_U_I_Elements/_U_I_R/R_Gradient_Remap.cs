
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.GradientRemap
	/// </summary>
    public partial class RGradientRemap : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientRemap");
            }
        }

        public RGradientRemap() : base("UnityEngine.UIElements.UIR.GradientRemap")
        {
        }

        public RGradientRemap(System.Object instance) : base("UnityEngine.UIElements.UIR.GradientRemap")
		{
            SetInstance(instance);
		}

        public RGradientRemap(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGradientRemap(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 origIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_ForigIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RForigIndex
		{
			get
			{
				if(r_ForigIndex == null)
				{
					r_ForigIndex = new(this, "origIndex");
				}
				return r_ForigIndex;
			}
		}

		/// <summary>
		/// System.Int32 destIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FdestIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFdestIndex
		{
			get
			{
				if(r_FdestIndex == null)
				{
					r_FdestIndex = new(this, "destIndex");
				}
				return r_FdestIndex;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt location
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectInt r_Flocation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectInt RFlocation
		{
			get
			{
				if(r_Flocation == null)
				{
					r_Flocation = new(this, "location");
				}
				return r_Flocation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemap next
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap r_Fnext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId r_Fatlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId RFatlas
		{
			get
			{
				if(r_Fatlas == null)
				{
					r_Fatlas = new(this, "atlas");
				}
				return r_Fatlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemap poolNext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap r_FpoolNext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap RFpoolNext
		{
			get
			{
				if(r_FpoolNext == null)
				{
					r_FpoolNext = new(this, "poolNext");
				}
				return r_FpoolNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
