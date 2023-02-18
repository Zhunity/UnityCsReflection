
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUIContent
	/// </summary>
    public partial class RGUIContent : RMember //
    {

		/// <summary>
		/// System.Action OnTextChanged
		/// </summary>
		protected REvent r_EOnTextChanged;
		public virtual REvent REOnTextChanged
		{
			get
			{
				if(r_EOnTextChanged == null)
				{
					r_EOnTextChanged = new(this, "OnTextChanged");
					r_EOnTextChanged.SetBelong(this.GetValue());
				}
				return r_EOnTextChanged;
			}
		}

		/// <summary>
		/// System.String m_Text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Text;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Text
		{
			get
			{
				if(r_Fm_Text == null)
				{
					r_Fm_Text = new(this, "m_Text");
					r_Fm_Text.SetBelong(this.GetValue());
				}
				return r_Fm_Text;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_Image
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_Fm_Image;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RFm_Image
		{
			get
			{
				if(r_Fm_Image == null)
				{
					r_Fm_Image = new(this, "m_Image");
					r_Fm_Image.SetBelong(this.GetValue());
				}
				return r_Fm_Image;
			}
		}

		/// <summary>
		/// System.String m_Tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Tooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Tooltip
		{
			get
			{
				if(r_Fm_Tooltip == null)
				{
					r_Fm_Tooltip = new(this, "m_Tooltip");
					r_Fm_Tooltip.SetBelong(this.GetValue());
				}
				return r_Fm_Tooltip;
			}
		}

		/// <summary>
		/// System.Action OnTextChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FOnTextChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFOnTextChanged
		{
			get
			{
				if(r_FOnTextChanged == null)
				{
					r_FOnTextChanged = new(this, "OnTextChanged");
					r_FOnTextChanged.SetBelong(this.GetValue());
				}
				return r_FOnTextChanged;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_Text
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fs_Text;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFs_Text
		{
			get
			{
				if(r_Fs_Text == null)
				{
					r_Fs_Text = new(typeof(UnityEngine.GUIContent), "s_Text");
					r_Fs_Text.SetBelong(null);
				}
				return r_Fs_Text;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_Image
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fs_Image;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFs_Image
		{
			get
			{
				if(r_Fs_Image == null)
				{
					r_Fs_Image = new(typeof(UnityEngine.GUIContent), "s_Image");
					r_Fs_Image.SetBelong(null);
				}
				return r_Fs_Image;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_TextImage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fs_TextImage;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFs_TextImage
		{
			get
			{
				if(r_Fs_TextImage == null)
				{
					r_Fs_TextImage = new(typeof(UnityEngine.GUIContent), "s_TextImage");
					r_Fs_TextImage.SetBelong(null);
				}
				return r_Fs_TextImage;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fnone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFnone
		{
			get
			{
				if(r_Fnone == null)
				{
					r_Fnone = new(typeof(UnityEngine.GUIContent), "none");
					r_Fnone.SetBelong(null);
				}
				return r_Fnone;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.GetValue());
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// UnityEngine.Texture image
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_Pimage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RPimage
		{
			get
			{
				if(r_Pimage == null)
				{
					r_Pimage = new(this, "image", -1);
					r_Pimage.SetBelong(this.GetValue());
				}
				return r_Pimage;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.GetValue());
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Int32 hash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Phash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPhash
		{
			get
			{
				if(r_Phash == null)
				{
					r_Phash = new(this, "hash", -1);
					r_Phash.SetBelong(this.GetValue());
				}
				return r_Phash;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(System.String)
		/// </summary>
		protected static RMethod r_MTemp_String;
		public static RMethod RMTemp_String
		{
			get
			{
				if(r_MTemp_String == null)
				{
					r_MTemp_String = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String));
					r_MTemp_String.SetBelong(null);
				}
				return r_MTemp_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(System.String, System.String)
		/// </summary>
		protected static RMethod r_MTemp_String_String;
		public static RMethod RMTemp_String_String
		{
			get
			{
				if(r_MTemp_String_String == null)
				{
					r_MTemp_String_String = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String), typeof(System.String));
					r_MTemp_String_String.SetBelong(null);
				}
				return r_MTemp_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_MTemp_Texture;
		public static RMethod RMTemp_Texture
		{
			get
			{
				if(r_MTemp_Texture == null)
				{
					r_MTemp_Texture = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(UnityEngine.Texture));
					r_MTemp_Texture.SetBelong(null);
				}
				return r_MTemp_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(UnityEngine.Texture, System.String)
		/// </summary>
		protected static RMethod r_MTemp_Texture_String;
		public static RMethod RMTemp_Texture_String
		{
			get
			{
				if(r_MTemp_Texture_String == null)
				{
					r_MTemp_Texture_String = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(UnityEngine.Texture), typeof(System.String));
					r_MTemp_Texture_String.SetBelong(null);
				}
				return r_MTemp_Texture_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent Temp(System.String, UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_MTemp_String_Texture;
		public static RMethod RMTemp_String_Texture
		{
			get
			{
				if(r_MTemp_String_Texture == null)
				{
					r_MTemp_String_Texture = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_MTemp_String_Texture.SetBelong(null);
				}
				return r_MTemp_String_Texture;
			}
		}

		/// <summary>
		/// Void ClearStaticCache()
		/// </summary>
		protected static RMethod r_MClearStaticCache;
		public static RMethod RMClearStaticCache
		{
			get
			{
				if(r_MClearStaticCache == null)
				{
					r_MClearStaticCache = new(typeof(UnityEngine.GUIContent), "ClearStaticCache", 0);
					r_MClearStaticCache.SetBelong(null);
				}
				return r_MClearStaticCache;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent[] Temp(System.String[])
		/// </summary>
		protected static RMethod r_MTemp_StringArray;
		public static RMethod RMTemp_StringArray
		{
			get
			{
				if(r_MTemp_StringArray == null)
				{
					r_MTemp_StringArray = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(System.String).MakeArrayType());
					r_MTemp_StringArray.SetBelong(null);
				}
				return r_MTemp_StringArray;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent[] Temp(UnityEngine.Texture[])
		/// </summary>
		protected static RMethod r_MTemp_TextureArray;
		public static RMethod RMTemp_TextureArray
		{
			get
			{
				if(r_MTemp_TextureArray == null)
				{
					r_MTemp_TextureArray = new(typeof(UnityEngine.GUIContent), "Temp", 0, typeof(UnityEngine.Texture).MakeArrayType());
					r_MTemp_TextureArray.SetBelong(null);
				}
				return r_MTemp_TextureArray;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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

        public static UnityEngine.GUIContent Temp(System.String @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMTemp_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(System.String @t, System.String @tooltip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @tooltip};
            var ___result = RMTemp_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(UnityEngine.Texture @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMTemp_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(UnityEngine.Texture @i, System.String @tooltip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @tooltip};
            var ___result = RMTemp_Texture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static UnityEngine.GUIContent Temp(System.String @t, UnityEngine.Texture @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @i};
            var ___result = RMTemp_String_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public static void ClearStaticCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearStaticCache.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GUIContent[] Temp(System.String[] @texts)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texts};
            var ___result = RMTemp_StringArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent[])___result;
        }


        public static UnityEngine.GUIContent[] Temp(UnityEngine.Texture[] @images)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@images};
            var ___result = RMTemp_TextureArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
