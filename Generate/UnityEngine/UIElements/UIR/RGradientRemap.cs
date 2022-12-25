using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.GradientRemap
	/// </summary>
    public partial class RGradientRemap : RMember //
    {

		/// <summary>
		/// System.Int32 origIndex
		/// </summary>
		protected RField r_origIndex;
		public virtual RField RorigIndex
		{
			get
			{
				if(r_origIndex == null)
				{
					r_origIndex = new(this, "origIndex");
					r_origIndex.SetBelong(this.instance);
				}
				return r_origIndex;
			}
		}

		/// <summary>
		/// System.Int32 destIndex
		/// </summary>
		protected RField r_destIndex;
		public virtual RField RdestIndex
		{
			get
			{
				if(r_destIndex == null)
				{
					r_destIndex = new(this, "destIndex");
					r_destIndex.SetBelong(this.instance);
				}
				return r_destIndex;
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
		/// UnityEngine.UIElements.UIR.GradientRemap next
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGradientRemap r_next;
		public virtual RUnityEngine.RUIElements.RUIR.RGradientRemap Rnext
		{
			get
			{
				if(r_next == null)
				{
					r_next = new(this, "next");
					r_next.SetBelong(this.instance);
				}
				return r_next;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId atlas
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureId r_atlas;
		public virtual RUnityEngine.RUIElements.RTextureId Ratlas
		{
			get
			{
				if(r_atlas == null)
				{
					r_atlas = new(this, "atlas");
					r_atlas.SetBelong(this.instance);
				}
				return r_atlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemap poolNext
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGradientRemap r_poolNext;
		public virtual RUnityEngine.RUIElements.RUIR.RGradientRemap RpoolNext
		{
			get
			{
				if(r_poolNext == null)
				{
					r_poolNext = new(this, "poolNext");
					r_poolNext.SetBelong(this.instance);
				}
				return r_poolNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
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

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
