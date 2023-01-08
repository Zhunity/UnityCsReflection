using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RMeshBuilderNative
{
	
	/// <summary>
	/// UnityEngine.UIElements.MeshBuilderNative+NativeBorderParams
	/// </summary>
    public partial class RNativeBorderParams : RMember //
    {

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_rect;
		public virtual RUnityEngine.RRect Rrect
		{
			get
			{
				if(r_rect == null)
				{
					r_rect = new(this, "rect");
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// UnityEngine.Color leftColor
		/// </summary>
		protected RUnityEngine.RColor r_leftColor;
		public virtual RUnityEngine.RColor RleftColor
		{
			get
			{
				if(r_leftColor == null)
				{
					r_leftColor = new(this, "leftColor");
					r_leftColor.SetBelong(this.instance);
				}
				return r_leftColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color topColor
		/// </summary>
		protected RUnityEngine.RColor r_topColor;
		public virtual RUnityEngine.RColor RtopColor
		{
			get
			{
				if(r_topColor == null)
				{
					r_topColor = new(this, "topColor");
					r_topColor.SetBelong(this.instance);
				}
				return r_topColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color rightColor
		/// </summary>
		protected RUnityEngine.RColor r_rightColor;
		public virtual RUnityEngine.RColor RrightColor
		{
			get
			{
				if(r_rightColor == null)
				{
					r_rightColor = new(this, "rightColor");
					r_rightColor.SetBelong(this.instance);
				}
				return r_rightColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color bottomColor
		/// </summary>
		protected RUnityEngine.RColor r_bottomColor;
		public virtual RUnityEngine.RColor RbottomColor
		{
			get
			{
				if(r_bottomColor == null)
				{
					r_bottomColor = new(this, "bottomColor");
					r_bottomColor.SetBelong(this.instance);
				}
				return r_bottomColor;
			}
		}

		/// <summary>
		/// System.Single leftWidth
		/// </summary>
		protected RField r_leftWidth;
		public virtual RField RleftWidth
		{
			get
			{
				if(r_leftWidth == null)
				{
					r_leftWidth = new(this, "leftWidth");
					r_leftWidth.SetBelong(this.instance);
				}
				return r_leftWidth;
			}
		}

		/// <summary>
		/// System.Single topWidth
		/// </summary>
		protected RField r_topWidth;
		public virtual RField RtopWidth
		{
			get
			{
				if(r_topWidth == null)
				{
					r_topWidth = new(this, "topWidth");
					r_topWidth.SetBelong(this.instance);
				}
				return r_topWidth;
			}
		}

		/// <summary>
		/// System.Single rightWidth
		/// </summary>
		protected RField r_rightWidth;
		public virtual RField RrightWidth
		{
			get
			{
				if(r_rightWidth == null)
				{
					r_rightWidth = new(this, "rightWidth");
					r_rightWidth.SetBelong(this.instance);
				}
				return r_rightWidth;
			}
		}

		/// <summary>
		/// System.Single bottomWidth
		/// </summary>
		protected RField r_bottomWidth;
		public virtual RField RbottomWidth
		{
			get
			{
				if(r_bottomWidth == null)
				{
					r_bottomWidth = new(this, "bottomWidth");
					r_bottomWidth.SetBelong(this.instance);
				}
				return r_bottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topLeftRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_topLeftRadius;
		public virtual RUnityEngine.RVector2 RtopLeftRadius
		{
			get
			{
				if(r_topLeftRadius == null)
				{
					r_topLeftRadius = new(this, "topLeftRadius");
					r_topLeftRadius.SetBelong(this.instance);
				}
				return r_topLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topRightRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_topRightRadius;
		public virtual RUnityEngine.RVector2 RtopRightRadius
		{
			get
			{
				if(r_topRightRadius == null)
				{
					r_topRightRadius = new(this, "topRightRadius");
					r_topRightRadius.SetBelong(this.instance);
				}
				return r_topRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomRightRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_bottomRightRadius;
		public virtual RUnityEngine.RVector2 RbottomRightRadius
		{
			get
			{
				if(r_bottomRightRadius == null)
				{
					r_bottomRightRadius = new(this, "bottomRightRadius");
					r_bottomRightRadius.SetBelong(this.instance);
				}
				return r_bottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomLeftRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_bottomLeftRadius;
		public virtual RUnityEngine.RVector2 RbottomLeftRadius
		{
			get
			{
				if(r_bottomLeftRadius == null)
				{
					r_bottomLeftRadius = new(this, "bottomLeftRadius");
					r_bottomLeftRadius.SetBelong(this.instance);
				}
				return r_bottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage leftColorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_leftColorPage;
		public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RleftColorPage
		{
			get
			{
				if(r_leftColorPage == null)
				{
					r_leftColorPage = new(this, "leftColorPage");
					r_leftColorPage.SetBelong(this.instance);
				}
				return r_leftColorPage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage topColorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_topColorPage;
		public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RtopColorPage
		{
			get
			{
				if(r_topColorPage == null)
				{
					r_topColorPage = new(this, "topColorPage");
					r_topColorPage.SetBelong(this.instance);
				}
				return r_topColorPage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage rightColorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_rightColorPage;
		public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RrightColorPage
		{
			get
			{
				if(r_rightColorPage == null)
				{
					r_rightColorPage = new(this, "rightColorPage");
					r_rightColorPage.SetBelong(this.instance);
				}
				return r_rightColorPage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage bottomColorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_bottomColorPage;
		public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RbottomColorPage
		{
			get
			{
				if(r_bottomColorPage == null)
				{
					r_bottomColorPage = new(this, "bottomColorPage");
					r_bottomColorPage.SetBelong(this.instance);
				}
				return r_bottomColorPage;
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


        public RNativeBorderParams() : base("UnityEngine.UIElements.MeshBuilderNative+NativeBorderParams")
        {
        }

        public RNativeBorderParams(System.Object instance) : base("UnityEngine.UIElements.MeshBuilderNative+NativeBorderParams")
		{
            SetInstance(instance);
		}

        public RNativeBorderParams(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNativeBorderParams(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}