
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.Background
	/// </summary>
    public partial class RBackground : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Background);
            }
        }

        public RBackground() : base("UnityEngine.UIElements.Background")
        {
        }

        public RBackground(System.Object instance) : base("UnityEngine.UIElements.Background")
		{
            SetInstance(instance);
		}

        public RBackground(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBackground(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Texture2D m_Texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Fm_Texture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RFm_Texture
		{
			get
			{
				if(r_Fm_Texture == null)
				{
					r_Fm_Texture = new(this, "m_Texture");
				}
				return r_Fm_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite m_Sprite
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSprite r_Fm_Sprite;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSprite RFm_Sprite
		{
			get
			{
				if(r_Fm_Sprite == null)
				{
					r_Fm_Sprite = new(this, "m_Sprite");
				}
				return r_Fm_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture m_RenderTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_Fm_RenderTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RFm_RenderTexture
		{
			get
			{
				if(r_Fm_RenderTexture == null)
				{
					r_Fm_RenderTexture = new(this, "m_RenderTexture");
				}
				return r_Fm_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VectorImage m_VectorImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage r_Fm_VectorImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage RFm_VectorImage
		{
			get
			{
				if(r_Fm_VectorImage == null)
				{
					r_Fm_VectorImage = new(this, "m_VectorImage");
				}
				return r_Fm_VectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Ptexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPtexture
		{
			get
			{
				if(r_Ptexture == null)
				{
					r_Ptexture = new(this, "texture", -1);
				}
				return r_Ptexture;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite sprite
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSprite r_Psprite;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSprite RPsprite
		{
			get
			{
				if(r_Psprite == null)
				{
					r_Psprite = new(this, "sprite", -1);
				}
				return r_Psprite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture renderTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_PrenderTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPrenderTexture
		{
			get
			{
				if(r_PrenderTexture == null)
				{
					r_PrenderTexture = new(this, "renderTexture", -1);
				}
				return r_PrenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VectorImage vectorImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage r_PvectorImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage RPvectorImage
		{
			get
			{
				if(r_PvectorImage == null)
				{
					r_PvectorImage = new(this, "vectorImage", -1);
				}
				return r_PvectorImage;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] allowedAssetTypes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> r_PallowedAssetTypes;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> RPallowedAssetTypes
		{
			get
			{
				if(r_PallowedAssetTypes == null)
				{
					r_PallowedAssetTypes = new(Type, "allowedAssetTypes", -1);
				}
				return r_PallowedAssetTypes;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MFromTexture2D_Texture2D;
		public static RMethod RMFromTexture2D_Texture2D
		{
			get
			{
				if(r_MFromTexture2D_Texture2D == null)
				{
					r_MFromTexture2D_Texture2D = new(Type, "FromTexture2D", 0, typeof(UnityEngine.Texture2D));
				}
				return r_MFromTexture2D_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_MFromRenderTexture_RenderTexture;
		public static RMethod RMFromRenderTexture_RenderTexture
		{
			get
			{
				if(r_MFromRenderTexture_RenderTexture == null)
				{
					r_MFromRenderTexture_RenderTexture = new(Type, "FromRenderTexture", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MFromRenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite)
		/// </summary>
		protected static RMethod r_MFromSprite_Sprite;
		public static RMethod RMFromSprite_Sprite
		{
			get
			{
				if(r_MFromSprite_Sprite == null)
				{
					r_MFromSprite_Sprite = new(Type, "FromSprite", 0, typeof(UnityEngine.Sprite));
				}
				return r_MFromSprite_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage)
		/// </summary>
		protected static RMethod r_MFromVectorImage_VectorImage;
		public static RMethod RMFromVectorImage_VectorImage
		{
			get
			{
				if(r_MFromVectorImage_VectorImage == null)
				{
					r_MFromVectorImage_VectorImage = new(Type, "FromVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage));
				}
				return r_MFromVectorImage_VectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromObject(System.Object)
		/// </summary>
		protected static RMethod r_MFromObject_Object;
		public static RMethod RMFromObject_Object
		{
			get
			{
				if(r_MFromObject_Object == null)
				{
					r_MFromObject_Object = new(Type, "FromObject", 0, typeof(System.Object));
				}
				return r_MFromObject_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Background, UnityEngine.UIElements.Background)
		/// </summary>
		protected static RMethod r_Mop_Equality_Background_Background;
		public static RMethod RMop_Equality_Background_Background
		{
			get
			{
				if(r_Mop_Equality_Background_Background == null)
				{
					r_Mop_Equality_Background_Background = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background));
				}
				return r_Mop_Equality_Background_Background;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Background, UnityEngine.UIElements.Background)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Background_Background;
		public static RMethod RMop_Inequality_Background_Background
		{
			get
			{
				if(r_Mop_Inequality_Background_Background == null)
				{
					r_Mop_Inequality_Background_Background = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background));
				}
				return r_Mop_Inequality_Background_Background;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background op_Implicit(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Texture2D;
		public static RMethod RMop_Implicit_Texture2D
		{
			get
			{
				if(r_Mop_Implicit_Texture2D == null)
				{
					r_Mop_Implicit_Texture2D = new(Type, "op_Implicit", 0, typeof(UnityEngine.Texture2D));
				}
				return r_Mop_Implicit_Texture2D;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Background)
		/// </summary>
		protected RMethod r_MEquals_Background;
		public virtual RMethod RMEquals_Background
		{
			get
			{
				if(r_MEquals_Background == null)
				{
					r_MEquals_Background = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Background));
				}
				return r_MEquals_Background;
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


        public static UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMFromTexture2D_Texture2D.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Background>(___result);
        }


        public static UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMFromRenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Background>(___result);
        }


        public static UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMFromSprite_Sprite.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Background>(___result);
        }


        public static UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage @vi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi};
            var ___result = RMFromVectorImage_VectorImage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Background>(___result);
        }


        public static UnityEngine.UIElements.Background FromObject(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMFromObject_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Background>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Background @lhs, UnityEngine.UIElements.Background @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Background_Background.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Background @lhs, UnityEngine.UIElements.Background @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Background_Background.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.UIElements.Background op_Implicit(UnityEngine.Texture2D @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Texture2D.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Background>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Background @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Background.Invoke(___genericsType, ___parameters);

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
