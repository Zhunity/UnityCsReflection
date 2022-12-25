using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.GradientSettings
	/// </summary>
    public partial class RGradientSettings : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.GradientType gradientType
		/// </summary>
		protected RField r_gradientType;
		public virtual RField RgradientType
		{
			get
			{
				if(r_gradientType == null)
				{
					r_gradientType = new(this, "gradientType");
					r_gradientType.SetBelong(this.instance);
				}
				return r_gradientType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AddressMode addressMode
		/// </summary>
		protected RField r_addressMode;
		public virtual RField RaddressMode
		{
			get
			{
				if(r_addressMode == null)
				{
					r_addressMode = new(this, "addressMode");
					r_addressMode.SetBelong(this.instance);
				}
				return r_addressMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 radialFocus
		/// </summary>
		protected RUnityEngine.RVector2 r_radialFocus;
		public virtual RUnityEngine.RVector2 RradialFocus
		{
			get
			{
				if(r_radialFocus == null)
				{
					r_radialFocus = new(this, "radialFocus");
					r_radialFocus.SetBelong(this.instance);
				}
				return r_radialFocus;
			}
		}

		/// <summary>
		/// UnityEngine.RectInt location
		/// </summary>
		protected RUnityEngine.RRectInt r_location;
		public virtual RUnityEngine.RRectInt Rlocation
		{
			get
			{
				if(r_location == null)
				{
					r_location = new(this, "location");
					r_location.SetBelong(this.instance);
				}
				return r_location;
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


        public RGradientSettings() : base("UnityEngine.UIElements.GradientSettings")
        {
        }

        public RGradientSettings(System.Object instance) : base("UnityEngine.UIElements.GradientSettings")
		{
            SetInstance(instance);
		}

        public RGradientSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGradientSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
