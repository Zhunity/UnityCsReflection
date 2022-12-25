using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextColorGradient
	/// </summary>
    public partial class RTextColorGradient : RMember //
    {

		/// <summary>
		/// UnityEngine.TextCore.Text.ColorGradientMode colorMode
		/// </summary>
		protected RField r_colorMode;
		public virtual RField RcolorMode
		{
			get
			{
				if(r_colorMode == null)
				{
					r_colorMode = new(this, "colorMode");
					r_colorMode.SetBelong(this.instance);
				}
				return r_colorMode;
			}
		}

		/// <summary>
		/// UnityEngine.Color topLeft
		/// </summary>
		protected RUnityEngine.RColor r_topLeft;
		public virtual RUnityEngine.RColor RtopLeft
		{
			get
			{
				if(r_topLeft == null)
				{
					r_topLeft = new(this, "topLeft");
					r_topLeft.SetBelong(this.instance);
				}
				return r_topLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Color topRight
		/// </summary>
		protected RUnityEngine.RColor r_topRight;
		public virtual RUnityEngine.RColor RtopRight
		{
			get
			{
				if(r_topRight == null)
				{
					r_topRight = new(this, "topRight");
					r_topRight.SetBelong(this.instance);
				}
				return r_topRight;
			}
		}

		/// <summary>
		/// UnityEngine.Color bottomLeft
		/// </summary>
		protected RUnityEngine.RColor r_bottomLeft;
		public virtual RUnityEngine.RColor RbottomLeft
		{
			get
			{
				if(r_bottomLeft == null)
				{
					r_bottomLeft = new(this, "bottomLeft");
					r_bottomLeft.SetBelong(this.instance);
				}
				return r_bottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Color bottomRight
		/// </summary>
		protected RUnityEngine.RColor r_bottomRight;
		public virtual RUnityEngine.RColor RbottomRight
		{
			get
			{
				if(r_bottomRight == null)
				{
					r_bottomRight = new(this, "bottomRight");
					r_bottomRight.SetBelong(this.instance);
				}
				return r_bottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.ColorGradientMode k_DefaultColorMode
		/// </summary>
		protected static RField r_k_DefaultColorMode;
		public static RField Rk_DefaultColorMode
		{
			get
			{
				if(r_k_DefaultColorMode == null)
				{
					r_k_DefaultColorMode = new(typeof(UnityEngine.TextCore.Text.TextColorGradient), "k_DefaultColorMode");
					r_k_DefaultColorMode.SetBelong(null);
				}
				return r_k_DefaultColorMode;
			}
		}

		/// <summary>
		/// UnityEngine.Color k_DefaultColor
		/// </summary>
		protected static RUnityEngine.RColor r_k_DefaultColor;
		public static RUnityEngine.RColor Rk_DefaultColor
		{
			get
			{
				if(r_k_DefaultColor == null)
				{
					r_k_DefaultColor = new(typeof(UnityEngine.TextCore.Text.TextColorGradient), "k_DefaultColor");
					r_k_DefaultColor.SetBelong(null);
				}
				return r_k_DefaultColor;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RTextColorGradient() : base("UnityEngine.TextCore.Text.TextColorGradient")
        {
        }

        public RTextColorGradient(System.Object instance) : base("UnityEngine.TextCore.Text.TextColorGradient")
		{
            SetInstance(instance);
		}

        public RTextColorGradient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextColorGradient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
