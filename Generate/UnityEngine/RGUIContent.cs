using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUIContent
	/// </summary>
    public partial class RGUIContent : RMember //
    {

		/// <summary>
		/// System.String m_Text
		/// </summary>
		protected RField r_m_Text;
		public virtual RField Rm_Text
		{
			get
			{
				if(r_m_Text == null)
				{
					r_m_Text = new(this, "m_Text");
					r_m_Text.SetBelong(this.instance);
				}
				return r_m_Text;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_Image
		/// </summary>
		protected RUnityEngine.RTexture r_m_Image;
		public virtual RUnityEngine.RTexture Rm_Image
		{
			get
			{
				if(r_m_Image == null)
				{
					r_m_Image = new(this, "m_Image");
					r_m_Image.SetBelong(this.instance);
				}
				return r_m_Image;
			}
		}

		/// <summary>
		/// System.String m_Tooltip
		/// </summary>
		protected RField r_m_Tooltip;
		public virtual RField Rm_Tooltip
		{
			get
			{
				if(r_m_Tooltip == null)
				{
					r_m_Tooltip = new(this, "m_Tooltip");
					r_m_Tooltip.SetBelong(this.instance);
				}
				return r_m_Tooltip;
			}
		}

		/// <summary>
		/// System.Action OnTextChanged
		/// </summary>
		protected RSystem.RAction r_OnTextChanged;
		public virtual RSystem.RAction ROnTextChanged
		{
			get
			{
				if(r_OnTextChanged == null)
				{
					r_OnTextChanged = new(this, "OnTextChanged");
					r_OnTextChanged.SetBelong(this.instance);
				}
				return r_OnTextChanged;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_Text
		/// </summary>
		protected static RUnityEngine.RGUIContent r_s_Text;
		public static RUnityEngine.RGUIContent Rs_Text
		{
			get
			{
				if(r_s_Text == null)
				{
					r_s_Text = new(typeof(UnityEngine.GUIContent), "s_Text");
					r_s_Text.SetBelong(null);
				}
				return r_s_Text;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_Image
		/// </summary>
		protected static RUnityEngine.RGUIContent r_s_Image;
		public static RUnityEngine.RGUIContent Rs_Image
		{
			get
			{
				if(r_s_Image == null)
				{
					r_s_Image = new(typeof(UnityEngine.GUIContent), "s_Image");
					r_s_Image.SetBelong(null);
				}
				return r_s_Image;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_TextImage
		/// </summary>
		protected static RUnityEngine.RGUIContent r_s_TextImage;
		public static RUnityEngine.RGUIContent Rs_TextImage
		{
			get
			{
				if(r_s_TextImage == null)
				{
					r_s_TextImage = new(typeof(UnityEngine.GUIContent), "s_TextImage");
					r_s_TextImage.SetBelong(null);
				}
				return r_s_TextImage;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent none
		/// </summary>
		protected static RUnityEngine.RGUIContent r_none;
		public static RUnityEngine.RGUIContent Rnone
		{
			get
			{
				if(r_none == null)
				{
					r_none = new(typeof(UnityEngine.GUIContent), "none");
					r_none.SetBelong(null);
				}
				return r_none;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RProperty r_text;
		public virtual RProperty Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text", -1);
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// UnityEngine.Texture image
		/// </summary>
		protected RUnityEngine.RTexture r_image;
		public virtual RUnityEngine.RTexture Rimage
		{
			get
			{
				if(r_image == null)
				{
					r_image = new(this, "image", -1);
					r_image.SetBelong(this.instance);
				}
				return r_image;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RProperty r_tooltip;
		public virtual RProperty Rtooltip
		{
			get
			{
				if(r_tooltip == null)
				{
					r_tooltip = new(this, "tooltip", -1);
					r_tooltip.SetBelong(this.instance);
				}
				return r_tooltip;
			}
		}

		/// <summary>
		/// Int32 hash
		/// </summary>
		protected RProperty r_hash;
		public virtual RProperty Rhash
		{
			get
			{
				if(r_hash == null)
				{
					r_hash = new(this, "hash", -1);
					r_hash.SetBelong(this.instance);
				}
				return r_hash;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(System.String)
		/// </summary>
		protected static RMethod r_RTemp_String;
		public static RMethod RTemp_String
		{
			get
			{
				if(r_RTemp_String == null)
				{
					r_RTemp_String = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String));
					r_RTemp_String.SetBelong(null);
				}
				return r_RTemp_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(System.String, System.String)
		/// </summary>
		protected static RMethod r_RTemp_String_String;
		public static RMethod RTemp_String_String
		{
			get
			{
				if(r_RTemp_String_String == null)
				{
					r_RTemp_String_String = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String), typeof(System.String));
					r_RTemp_String_String.SetBelong(null);
				}
				return r_RTemp_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_RTemp_Texture;
		public static RMethod RTemp_Texture
		{
			get
			{
				if(r_RTemp_Texture == null)
				{
					r_RTemp_Texture = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(UnityEngine.Texture));
					r_RTemp_Texture.SetBelong(null);
				}
				return r_RTemp_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(UnityEngine.Texture, System.String)
		/// </summary>
		protected static RMethod r_RTemp_Texture_String;
		public static RMethod RTemp_Texture_String
		{
			get
			{
				if(r_RTemp_Texture_String == null)
				{
					r_RTemp_Texture_String = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(UnityEngine.Texture), typeof(System.String));
					r_RTemp_Texture_String.SetBelong(null);
				}
				return r_RTemp_Texture_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(System.String, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_RTemp_String_Texture;
		public static RMethod RTemp_String_Texture
		{
			get
			{
				if(r_RTemp_String_Texture == null)
				{
					r_RTemp_String_Texture = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_RTemp_String_Texture.SetBelong(null);
				}
				return r_RTemp_String_Texture;
			}
		}

		/// <summary>
		/// Void ClearStaticCache()
		/// </summary>
		protected static RMethod r_RClearStaticCache;
		public static RMethod RClearStaticCache
		{
			get
			{
				if(r_RClearStaticCache == null)
				{
					r_RClearStaticCache = new(typeof(UnityEngine.GUIContent), "ClearStaticCache", 0);
					r_RClearStaticCache.SetBelong(null);
				}
				return r_RClearStaticCache;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent[] Temp(System.String[])
		/// </summary>
		protected static RMethod r_RTemp_StringArray;
		public static RMethod RTemp_StringArray
		{
			get
			{
				if(r_RTemp_StringArray == null)
				{
					r_RTemp_StringArray = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String).MakeArrayType());
					r_RTemp_StringArray.SetBelong(null);
				}
				return r_RTemp_StringArray;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent[] Temp(UnityEngine.Texture[])
		/// </summary>
		protected static RMethod r_RTemp_TextureArray;
		public static RMethod RTemp_TextureArray
		{
			get
			{
				if(r_RTemp_TextureArray == null)
				{
					r_RTemp_TextureArray = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(UnityEngine.Texture).MakeArrayType());
					r_RTemp_TextureArray.SetBelong(null);
				}
				return r_RTemp_TextureArray;
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


        public RGUIContent() : base("UnityEngine.GUIContent")
        {
        }

        public RGUIContent(System.Object instance) : base("UnityEngine.GUIContent")
		{
            SetInstance(instance);
		}

        public RGUIContent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIContent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.GUIContent Temp(System.String  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RTemp_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(System.String  @t, System.String  @tooltip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @tooltip};
            var ___result = RTemp_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(UnityEngine.Texture  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RTemp_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(UnityEngine.Texture  @i, System.String  @tooltip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @tooltip};
            var ___result = RTemp_Texture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(System.String  @t, UnityEngine.Texture  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @i};
            var ___result = RTemp_String_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static void ClearStaticCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearStaticCache.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GUIContent[] Temp(System.String[]  @texts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texts};
            var ___result = RTemp_StringArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent[])___result;
        }


        public static UnityEngine.GUIContent[] Temp(UnityEngine.Texture[]  @images)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@images};
            var ___result = RTemp_TextureArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
