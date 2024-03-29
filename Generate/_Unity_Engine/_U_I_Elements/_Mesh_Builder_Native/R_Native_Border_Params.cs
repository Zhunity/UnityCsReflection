
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RMeshBuilderNative
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.MeshBuilderNative+NativeBorderParams
	/// </summary>
    public partial class RNativeBorderParams : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.MeshBuilderNative+NativeBorderParams");
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


		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Frect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFrect
		{
			get
			{
				if(r_Frect == null)
				{
					r_Frect = new(this, "rect");
				}
				return r_Frect;
			}
		}

		/// <summary>
		/// UnityEngine.Color leftColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FleftColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFleftColor
		{
			get
			{
				if(r_FleftColor == null)
				{
					r_FleftColor = new(this, "leftColor");
				}
				return r_FleftColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color topColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FtopColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFtopColor
		{
			get
			{
				if(r_FtopColor == null)
				{
					r_FtopColor = new(this, "topColor");
				}
				return r_FtopColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color rightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FrightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFrightColor
		{
			get
			{
				if(r_FrightColor == null)
				{
					r_FrightColor = new(this, "rightColor");
				}
				return r_FrightColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color bottomColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FbottomColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFbottomColor
		{
			get
			{
				if(r_FbottomColor == null)
				{
					r_FbottomColor = new(this, "bottomColor");
				}
				return r_FbottomColor;
			}
		}

		/// <summary>
		/// System.Single leftWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FleftWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFleftWidth
		{
			get
			{
				if(r_FleftWidth == null)
				{
					r_FleftWidth = new(this, "leftWidth");
				}
				return r_FleftWidth;
			}
		}

		/// <summary>
		/// System.Single topWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FtopWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFtopWidth
		{
			get
			{
				if(r_FtopWidth == null)
				{
					r_FtopWidth = new(this, "topWidth");
				}
				return r_FtopWidth;
			}
		}

		/// <summary>
		/// System.Single rightWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FrightWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFrightWidth
		{
			get
			{
				if(r_FrightWidth == null)
				{
					r_FrightWidth = new(this, "rightWidth");
				}
				return r_FrightWidth;
			}
		}

		/// <summary>
		/// System.Single bottomWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FbottomWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFbottomWidth
		{
			get
			{
				if(r_FbottomWidth == null)
				{
					r_FbottomWidth = new(this, "bottomWidth");
				}
				return r_FbottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FtopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFtopLeftRadius
		{
			get
			{
				if(r_FtopLeftRadius == null)
				{
					r_FtopLeftRadius = new(this, "topLeftRadius");
				}
				return r_FtopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FtopRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFtopRightRadius
		{
			get
			{
				if(r_FtopRightRadius == null)
				{
					r_FtopRightRadius = new(this, "topRightRadius");
				}
				return r_FtopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FbottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFbottomRightRadius
		{
			get
			{
				if(r_FbottomRightRadius == null)
				{
					r_FbottomRightRadius = new(this, "bottomRightRadius");
				}
				return r_FbottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FbottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFbottomLeftRadius
		{
			get
			{
				if(r_FbottomLeftRadius == null)
				{
					r_FbottomLeftRadius = new(this, "bottomLeftRadius");
				}
				return r_FbottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage leftColorPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_FleftColorPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RFleftColorPage
		{
			get
			{
				if(r_FleftColorPage == null)
				{
					r_FleftColorPage = new(this, "leftColorPage");
				}
				return r_FleftColorPage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage topColorPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_FtopColorPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RFtopColorPage
		{
			get
			{
				if(r_FtopColorPage == null)
				{
					r_FtopColorPage = new(this, "topColorPage");
				}
				return r_FtopColorPage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage rightColorPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_FrightColorPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RFrightColorPage
		{
			get
			{
				if(r_FrightColorPage == null)
				{
					r_FrightColorPage = new(this, "rightColorPage");
				}
				return r_FrightColorPage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage bottomColorPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_FbottomColorPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RFbottomColorPage
		{
			get
			{
				if(r_FbottomColorPage == null)
				{
					r_FbottomColorPage = new(this, "bottomColorPage");
				}
				return r_FbottomColorPage;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
}