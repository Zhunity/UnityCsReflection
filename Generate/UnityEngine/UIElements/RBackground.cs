using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Background
	/// </summary>
    public partial class RBackground : RMember //
    {

		/// <summary>
		/// UnityEngine.Texture2D m_Texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_Texture;
		public virtual RUnityEngine.RTexture2D Rm_Texture
		{
			get
			{
				if(r_m_Texture == null)
				{
					r_m_Texture = new(this, "m_Texture");
					r_m_Texture.SetBelong(this.instance);
				}
				return r_m_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite m_Sprite
		/// </summary>
		protected RUnityEngine.RSprite r_m_Sprite;
		public virtual RUnityEngine.RSprite Rm_Sprite
		{
			get
			{
				if(r_m_Sprite == null)
				{
					r_m_Sprite = new(this, "m_Sprite");
					r_m_Sprite.SetBelong(this.instance);
				}
				return r_m_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture m_RenderTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_m_RenderTexture;
		public virtual RUnityEngine.RRenderTexture Rm_RenderTexture
		{
			get
			{
				if(r_m_RenderTexture == null)
				{
					r_m_RenderTexture = new(this, "m_RenderTexture");
					r_m_RenderTexture.SetBelong(this.instance);
				}
				return r_m_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VectorImage m_VectorImage
		/// </summary>
		protected RUnityEngine.RUIElements.RVectorImage r_m_VectorImage;
		public virtual RUnityEngine.RUIElements.RVectorImage Rm_VectorImage
		{
			get
			{
				if(r_m_VectorImage == null)
				{
					r_m_VectorImage = new(this, "m_VectorImage");
					r_m_VectorImage.SetBelong(this.instance);
				}
				return r_m_VectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_texture;
		public virtual RUnityEngine.RTexture2D Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite sprite
		/// </summary>
		protected RUnityEngine.RSprite r_sprite;
		public virtual RUnityEngine.RSprite Rsprite
		{
			get
			{
				if(r_sprite == null)
				{
					r_sprite = new(this, "sprite", -1);
					r_sprite.SetBelong(this.instance);
				}
				return r_sprite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture renderTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_renderTexture;
		public virtual RUnityEngine.RRenderTexture RrenderTexture
		{
			get
			{
				if(r_renderTexture == null)
				{
					r_renderTexture = new(this, "renderTexture", -1);
					r_renderTexture.SetBelong(this.instance);
				}
				return r_renderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VectorImage vectorImage
		/// </summary>
		protected RUnityEngine.RUIElements.RVectorImage r_vectorImage;
		public virtual RUnityEngine.RUIElements.RVectorImage RvectorImage
		{
			get
			{
				if(r_vectorImage == null)
				{
					r_vectorImage = new(this, "vectorImage", -1);
					r_vectorImage.SetBelong(this.instance);
				}
				return r_vectorImage;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] allowedAssetTypes
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_allowedAssetTypes;
		public static RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RallowedAssetTypes
		{
			get
			{
				if(r_allowedAssetTypes == null)
				{
					r_allowedAssetTypes = new(typeof(UnityEngine.UIElements.Background), "allowedAssetTypes", -1);
					r_allowedAssetTypes.SetBelong(null);
				}
				return r_allowedAssetTypes;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_FromTexture2D_Texture2D;
		public static RMethod RFromTexture2D_Texture2D
		{
			get
			{
				if(r_FromTexture2D_Texture2D == null)
				{
					r_FromTexture2D_Texture2D = new(typeof(UnityEngine.UIElements.Background), "FromTexture2D", 0, typeof(UnityEngine.Texture2D));
					r_FromTexture2D_Texture2D.SetBelong(null);
				}
				return r_FromTexture2D_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_FromRenderTexture_RenderTexture;
		public static RMethod RFromRenderTexture_RenderTexture
		{
			get
			{
				if(r_FromRenderTexture_RenderTexture == null)
				{
					r_FromRenderTexture_RenderTexture = new(typeof(UnityEngine.UIElements.Background), "FromRenderTexture", 0, typeof(UnityEngine.RenderTexture));
					r_FromRenderTexture_RenderTexture.SetBelong(null);
				}
				return r_FromRenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite)
		/// </summary>
		protected static RMethod r_FromSprite_Sprite;
		public static RMethod RFromSprite_Sprite
		{
			get
			{
				if(r_FromSprite_Sprite == null)
				{
					r_FromSprite_Sprite = new(typeof(UnityEngine.UIElements.Background), "FromSprite", 0, typeof(UnityEngine.Sprite));
					r_FromSprite_Sprite.SetBelong(null);
				}
				return r_FromSprite_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage)
		/// </summary>
		protected static RMethod r_FromVectorImage_VectorImage;
		public static RMethod RFromVectorImage_VectorImage
		{
			get
			{
				if(r_FromVectorImage_VectorImage == null)
				{
					r_FromVectorImage_VectorImage = new(typeof(UnityEngine.UIElements.Background), "FromVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage));
					r_FromVectorImage_VectorImage.SetBelong(null);
				}
				return r_FromVectorImage_VectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background FromObject(System.Object)
		/// </summary>
		protected static RMethod r_FromObject_Object;
		public static RMethod RFromObject_Object
		{
			get
			{
				if(r_FromObject_Object == null)
				{
					r_FromObject_Object = new(typeof(UnityEngine.UIElements.Background), "FromObject", 0, typeof(System.Object));
					r_FromObject_Object.SetBelong(null);
				}
				return r_FromObject_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.Background, UnityEngine.UIElements.Background)
		/// </summary>
		protected static RMethod r_op_Equality_Background_Background;
		public static RMethod Rop_Equality_Background_Background
		{
			get
			{
				if(r_op_Equality_Background_Background == null)
				{
					r_op_Equality_Background_Background = new(typeof(UnityEngine.UIElements.Background), "op_Equality", 0, typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background));
					r_op_Equality_Background_Background.SetBelong(null);
				}
				return r_op_Equality_Background_Background;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.Background, UnityEngine.UIElements.Background)
		/// </summary>
		protected static RMethod r_op_Inequality_Background_Background;
		public static RMethod Rop_Inequality_Background_Background
		{
			get
			{
				if(r_op_Inequality_Background_Background == null)
				{
					r_op_Inequality_Background_Background = new(typeof(UnityEngine.UIElements.Background), "op_Inequality", 0, typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background));
					r_op_Inequality_Background_Background.SetBelong(null);
				}
				return r_op_Inequality_Background_Background;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background op_Implicit(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_op_Implicit_Texture2D;
		public static RMethod Rop_Implicit_Texture2D
		{
			get
			{
				if(r_op_Implicit_Texture2D == null)
				{
					r_op_Implicit_Texture2D = new(typeof(UnityEngine.UIElements.Background), "op_Implicit", 0, typeof(UnityEngine.Texture2D));
					r_op_Implicit_Texture2D.SetBelong(null);
				}
				return r_op_Implicit_Texture2D;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.Background)
		/// </summary>
		protected RMethod r_Equals_Background;
		public virtual RMethod REquals_Background
		{
			get
			{
				if(r_Equals_Background == null)
				{
					r_Equals_Background = new(this, "Equals", 0, typeof(UnityEngine.UIElements.Background));
					r_Equals_Background.SetBelong(this.instance);
				}
				return r_Equals_Background;
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

        public static UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RFromTexture2D_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public static UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RFromRenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public static UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RFromSprite_Sprite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public static UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage @vi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi};
            var ___result = RFromVectorImage_VectorImage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public static UnityEngine.UIElements.Background FromObject(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RFromObject_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.Background @lhs, UnityEngine.UIElements.Background @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Background_Background.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.Background @lhs, UnityEngine.UIElements.Background @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Background_Background.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.Background op_Implicit(UnityEngine.Texture2D @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.Background @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Background.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
