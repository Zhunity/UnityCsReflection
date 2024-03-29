
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.StyleSheets.ImageSource
	/// </summary>
    public partial class RImageSource : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.ImageSource");
            }
        }

        public RImageSource() : base("UnityEngine.UIElements.StyleSheets.ImageSource")
        {
        }

        public RImageSource(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.ImageSource")
		{
            SetInstance(instance);
		}

        public RImageSource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RImageSource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Ftexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RFtexture
		{
			get
			{
				if(r_Ftexture == null)
				{
					r_Ftexture = new(this, "texture");
				}
				return r_Ftexture;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite sprite
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSprite r_Fsprite;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSprite RFsprite
		{
			get
			{
				if(r_Fsprite == null)
				{
					r_Fsprite = new(this, "sprite");
				}
				return r_Fsprite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VectorImage vectorImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage r_FvectorImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage RFvectorImage
		{
			get
			{
				if(r_FvectorImage == null)
				{
					r_FvectorImage = new(this, "vectorImage");
				}
				return r_FvectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture renderTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_FrenderTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RFrenderTexture
		{
			get
			{
				if(r_FrenderTexture == null)
				{
					r_FrenderTexture = new(this, "renderTexture");
				}
				return r_FrenderTexture;
			}
		}

		/// <summary>
		/// Boolean IsNull()
		/// </summary>
		protected RMethod r_MIsNull;
		public virtual RMethod RMIsNull
		{
			get
			{
				if(r_MIsNull == null)
				{
					r_MIsNull = new(this, "IsNull", 0);
				}
				return r_MIsNull;
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


        public virtual System.Boolean IsNull()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNull.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
