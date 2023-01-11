using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Font
	/// </summary>
    public partial class RFont : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEngine.Font] textureRebuilt
		/// </summary>
		protected static REvent r_textureRebuilt;
		public static REvent RtextureRebuilt
		{
			get
			{
				if(r_textureRebuilt == null)
				{
					r_textureRebuilt = new(typeof(UnityEngine.Font), "textureRebuilt");
					r_textureRebuilt.SetBelong(null);
				}
				return r_textureRebuilt;
			}
		}

		/// <summary>
		/// UnityEngine.Font+FontTextureRebuildCallback m_FontTextureRebuildCallback
		/// </summary>
		protected REvent r_m_FontTextureRebuildCallback;
		public virtual REvent Rm_FontTextureRebuildCallback
		{
			get
			{
				if(r_m_FontTextureRebuildCallback == null)
				{
					r_m_FontTextureRebuildCallback = new(this, "m_FontTextureRebuildCallback");
					r_m_FontTextureRebuildCallback.SetBelong(this.instance);
				}
				return r_m_FontTextureRebuildCallback;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material", -1);
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// System.String[] fontNames
		/// </summary>
		protected RPropertyArray<RSystem.RString> r_fontNames;
		public virtual RPropertyArray<RSystem.RString> RfontNames
		{
			get
			{
				if(r_fontNames == null)
				{
					r_fontNames = new(this, "fontNames", -1);
					r_fontNames.SetBelong(this.instance);
				}
				return r_fontNames;
			}
		}

		/// <summary>
		/// Boolean dynamic
		/// </summary>
		protected RSystem.RBoolean r_dynamic;
		public virtual RSystem.RBoolean Rdynamic
		{
			get
			{
				if(r_dynamic == null)
				{
					r_dynamic = new(this, "dynamic", -1);
					r_dynamic.SetBelong(this.instance);
				}
				return r_dynamic;
			}
		}

		/// <summary>
		/// Int32 ascent
		/// </summary>
		protected RSystem.RInt32 r_ascent;
		public virtual RSystem.RInt32 Rascent
		{
			get
			{
				if(r_ascent == null)
				{
					r_ascent = new(this, "ascent", -1);
					r_ascent.SetBelong(this.instance);
				}
				return r_ascent;
			}
		}

		/// <summary>
		/// Int32 fontSize
		/// </summary>
		protected RSystem.RInt32 r_fontSize;
		public virtual RSystem.RInt32 RfontSize
		{
			get
			{
				if(r_fontSize == null)
				{
					r_fontSize = new(this, "fontSize", -1);
					r_fontSize.SetBelong(this.instance);
				}
				return r_fontSize;
			}
		}

		/// <summary>
		/// UnityEngine.CharacterInfo[] characterInfo
		/// </summary>
		protected RPropertyArray<RUnityEngine.RCharacterInfo> r_characterInfo;
		public virtual RPropertyArray<RUnityEngine.RCharacterInfo> RcharacterInfo
		{
			get
			{
				if(r_characterInfo == null)
				{
					r_characterInfo = new(this, "characterInfo", -1);
					r_characterInfo.SetBelong(this.instance);
				}
				return r_characterInfo;
			}
		}

		/// <summary>
		/// Int32 lineHeight
		/// </summary>
		protected RSystem.RInt32 r_lineHeight;
		public virtual RSystem.RInt32 RlineHeight
		{
			get
			{
				if(r_lineHeight == null)
				{
					r_lineHeight = new(this, "lineHeight", -1);
					r_lineHeight.SetBelong(this.instance);
				}
				return r_lineHeight;
			}
		}

		/// <summary>
		/// FontTextureRebuildCallback textureRebuildCallback
		/// </summary>
		protected RUnityEngine.RFont.RFontTextureRebuildCallback r_textureRebuildCallback;
		public virtual RUnityEngine.RFont.RFontTextureRebuildCallback RtextureRebuildCallback
		{
			get
			{
				if(r_textureRebuildCallback == null)
				{
					r_textureRebuildCallback = new(this, "textureRebuildCallback", -1);
					r_textureRebuildCallback.SetBelong(this.instance);
				}
				return r_textureRebuildCallback;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
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
		/// UnityEngine.Font CreateDynamicFontFromOSFont(System.String, Int32)
		/// </summary>
		protected static RMethod r_CreateDynamicFontFromOSFont_String_Int32;
		public static RMethod RCreateDynamicFontFromOSFont_String_Int32
		{
			get
			{
				if(r_CreateDynamicFontFromOSFont_String_Int32 == null)
				{
					r_CreateDynamicFontFromOSFont_String_Int32 = new(typeof(UnityEngine.Font), "CreateDynamicFontFromOSFont", 0, typeof(System.String), typeof(System.Int32));
					r_CreateDynamicFontFromOSFont_String_Int32.SetBelong(null);
				}
				return r_CreateDynamicFontFromOSFont_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Font CreateDynamicFontFromOSFont(System.String[], Int32)
		/// </summary>
		protected static RMethod r_CreateDynamicFontFromOSFont_StringArray_Int32;
		public static RMethod RCreateDynamicFontFromOSFont_StringArray_Int32
		{
			get
			{
				if(r_CreateDynamicFontFromOSFont_StringArray_Int32 == null)
				{
					r_CreateDynamicFontFromOSFont_StringArray_Int32 = new(typeof(UnityEngine.Font), "CreateDynamicFontFromOSFont", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_CreateDynamicFontFromOSFont_StringArray_Int32.SetBelong(null);
				}
				return r_CreateDynamicFontFromOSFont_StringArray_Int32;
			}
		}

		/// <summary>
		/// Void InvokeTextureRebuilt_Internal(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_InvokeTextureRebuilt_Internal_Font;
		public static RMethod RInvokeTextureRebuilt_Internal_Font
		{
			get
			{
				if(r_InvokeTextureRebuilt_Internal_Font == null)
				{
					r_InvokeTextureRebuilt_Internal_Font = new(typeof(UnityEngine.Font), "InvokeTextureRebuilt_Internal", 0, typeof(UnityEngine.Font));
					r_InvokeTextureRebuilt_Internal_Font.SetBelong(null);
				}
				return r_InvokeTextureRebuilt_Internal_Font;
			}
		}

		/// <summary>
		/// Int32 GetMaxVertsForString(System.String)
		/// </summary>
		protected static RMethod r_GetMaxVertsForString_String;
		public static RMethod RGetMaxVertsForString_String
		{
			get
			{
				if(r_GetMaxVertsForString_String == null)
				{
					r_GetMaxVertsForString_String = new(typeof(UnityEngine.Font), "GetMaxVertsForString", 0, typeof(System.String));
					r_GetMaxVertsForString_String.SetBelong(null);
				}
				return r_GetMaxVertsForString_String;
			}
		}

		/// <summary>
		/// UnityEngine.Font GetDefault()
		/// </summary>
		protected static RMethod r_GetDefault;
		public static RMethod RGetDefault
		{
			get
			{
				if(r_GetDefault == null)
				{
					r_GetDefault = new(typeof(UnityEngine.Font), "GetDefault", 0);
					r_GetDefault.SetBelong(null);
				}
				return r_GetDefault;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Char)
		/// </summary>
		protected RMethod r_HasCharacter_Char;
		public virtual RMethod RHasCharacter_Char
		{
			get
			{
				if(r_HasCharacter_Char == null)
				{
					r_HasCharacter_Char = new(this, "HasCharacter", 0, typeof(System.Char));
					r_HasCharacter_Char.SetBelong(this.instance);
				}
				return r_HasCharacter_Char;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Int32)
		/// </summary>
		protected RMethod r_HasCharacter_Int32;
		public virtual RMethod RHasCharacter_Int32
		{
			get
			{
				if(r_HasCharacter_Int32 == null)
				{
					r_HasCharacter_Int32 = new(this, "HasCharacter", 0, typeof(System.Int32));
					r_HasCharacter_Int32.SetBelong(this.instance);
				}
				return r_HasCharacter_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetOSInstalledFontNames()
		/// </summary>
		protected static RMethod r_GetOSInstalledFontNames;
		public static RMethod RGetOSInstalledFontNames
		{
			get
			{
				if(r_GetOSInstalledFontNames == null)
				{
					r_GetOSInstalledFontNames = new(typeof(UnityEngine.Font), "GetOSInstalledFontNames", 0);
					r_GetOSInstalledFontNames.SetBelong(null);
				}
				return r_GetOSInstalledFontNames;
			}
		}

		/// <summary>
		/// System.String[] GetPathsToOSFonts()
		/// </summary>
		protected static RMethod r_GetPathsToOSFonts;
		public static RMethod RGetPathsToOSFonts
		{
			get
			{
				if(r_GetPathsToOSFonts == null)
				{
					r_GetPathsToOSFonts = new(typeof(UnityEngine.Font), "GetPathsToOSFonts", 0);
					r_GetPathsToOSFonts.SetBelong(null);
				}
				return r_GetPathsToOSFonts;
			}
		}

		/// <summary>
		/// Void Internal_CreateFont(UnityEngine.Font, System.String)
		/// </summary>
		protected static RMethod r_Internal_CreateFont_Font_String;
		public static RMethod RInternal_CreateFont_Font_String
		{
			get
			{
				if(r_Internal_CreateFont_Font_String == null)
				{
					r_Internal_CreateFont_Font_String = new(typeof(UnityEngine.Font), "Internal_CreateFont", 0, typeof(UnityEngine.Font), typeof(System.String));
					r_Internal_CreateFont_Font_String.SetBelong(null);
				}
				return r_Internal_CreateFont_Font_String;
			}
		}

		/// <summary>
		/// Void Internal_CreateFontFromPath(UnityEngine.Font, System.String)
		/// </summary>
		protected static RMethod r_Internal_CreateFontFromPath_Font_String;
		public static RMethod RInternal_CreateFontFromPath_Font_String
		{
			get
			{
				if(r_Internal_CreateFontFromPath_Font_String == null)
				{
					r_Internal_CreateFontFromPath_Font_String = new(typeof(UnityEngine.Font), "Internal_CreateFontFromPath", 0, typeof(UnityEngine.Font), typeof(System.String));
					r_Internal_CreateFontFromPath_Font_String.SetBelong(null);
				}
				return r_Internal_CreateFontFromPath_Font_String;
			}
		}

		/// <summary>
		/// Void Internal_CreateDynamicFont(UnityEngine.Font, System.String[], Int32)
		/// </summary>
		protected static RMethod r_Internal_CreateDynamicFont_Font_StringArray_Int32;
		public static RMethod RInternal_CreateDynamicFont_Font_StringArray_Int32
		{
			get
			{
				if(r_Internal_CreateDynamicFont_Font_StringArray_Int32 == null)
				{
					r_Internal_CreateDynamicFont_Font_StringArray_Int32 = new(typeof(UnityEngine.Font), "Internal_CreateDynamicFont", 0, typeof(UnityEngine.Font), typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_Internal_CreateDynamicFont_Font_StringArray_Int32.SetBelong(null);
				}
				return r_Internal_CreateDynamicFont_Font_StringArray_Int32;
			}
		}

		/// <summary>
		/// Boolean GetCharacterInfo(Char, UnityEngine.CharacterInfo ByRef, Int32, UnityEngine.FontStyle)
		/// </summary>
		protected RMethod r_GetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle;
		public virtual RMethod RGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle
		{
			get
			{
				if(r_GetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle == null)
				{
					r_GetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle = new(this, "GetCharacterInfo", 0, typeof(System.Char), typeof(UnityEngine.CharacterInfo).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.FontStyle));
					r_GetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle.SetBelong(this.instance);
				}
				return r_GetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle;
			}
		}

		/// <summary>
		/// Boolean GetCharacterInfo(Char, UnityEngine.CharacterInfo ByRef, Int32)
		/// </summary>
		protected RMethod r_GetCharacterInfo_Char_Out_CharacterInfo_Int32;
		public virtual RMethod RGetCharacterInfo_Char_Out_CharacterInfo_Int32
		{
			get
			{
				if(r_GetCharacterInfo_Char_Out_CharacterInfo_Int32 == null)
				{
					r_GetCharacterInfo_Char_Out_CharacterInfo_Int32 = new(this, "GetCharacterInfo", 0, typeof(System.Char), typeof(UnityEngine.CharacterInfo).MakeByRefType(), typeof(System.Int32));
					r_GetCharacterInfo_Char_Out_CharacterInfo_Int32.SetBelong(this.instance);
				}
				return r_GetCharacterInfo_Char_Out_CharacterInfo_Int32;
			}
		}

		/// <summary>
		/// Boolean GetCharacterInfo(Char, UnityEngine.CharacterInfo ByRef)
		/// </summary>
		protected RMethod r_GetCharacterInfo_Char_Out_CharacterInfo;
		public virtual RMethod RGetCharacterInfo_Char_Out_CharacterInfo
		{
			get
			{
				if(r_GetCharacterInfo_Char_Out_CharacterInfo == null)
				{
					r_GetCharacterInfo_Char_Out_CharacterInfo = new(this, "GetCharacterInfo", 0, typeof(System.Char), typeof(UnityEngine.CharacterInfo).MakeByRefType());
					r_GetCharacterInfo_Char_Out_CharacterInfo.SetBelong(this.instance);
				}
				return r_GetCharacterInfo_Char_Out_CharacterInfo;
			}
		}

		/// <summary>
		/// Void RequestCharactersInTexture(System.String, Int32, UnityEngine.FontStyle)
		/// </summary>
		protected RMethod r_RequestCharactersInTexture_String_Int32_FontStyle;
		public virtual RMethod RRequestCharactersInTexture_String_Int32_FontStyle
		{
			get
			{
				if(r_RequestCharactersInTexture_String_Int32_FontStyle == null)
				{
					r_RequestCharactersInTexture_String_Int32_FontStyle = new(this, "RequestCharactersInTexture", 0, typeof(System.String), typeof(System.Int32), typeof(UnityEngine.FontStyle));
					r_RequestCharactersInTexture_String_Int32_FontStyle.SetBelong(this.instance);
				}
				return r_RequestCharactersInTexture_String_Int32_FontStyle;
			}
		}

		/// <summary>
		/// Void RequestCharactersInTexture(System.String, Int32)
		/// </summary>
		protected RMethod r_RequestCharactersInTexture_String_Int32;
		public virtual RMethod RRequestCharactersInTexture_String_Int32
		{
			get
			{
				if(r_RequestCharactersInTexture_String_Int32 == null)
				{
					r_RequestCharactersInTexture_String_Int32 = new(this, "RequestCharactersInTexture", 0, typeof(System.String), typeof(System.Int32));
					r_RequestCharactersInTexture_String_Int32.SetBelong(this.instance);
				}
				return r_RequestCharactersInTexture_String_Int32;
			}
		}

		/// <summary>
		/// Void RequestCharactersInTexture(System.String)
		/// </summary>
		protected RMethod r_RequestCharactersInTexture_String;
		public virtual RMethod RRequestCharactersInTexture_String
		{
			get
			{
				if(r_RequestCharactersInTexture_String == null)
				{
					r_RequestCharactersInTexture_String = new(this, "RequestCharactersInTexture", 0, typeof(System.String));
					r_RequestCharactersInTexture_String.SetBelong(this.instance);
				}
				return r_RequestCharactersInTexture_String;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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


        public RFont() : base("UnityEngine.Font")
        {
        }

        public RFont(System.Object instance) : base("UnityEngine.Font")
		{
            SetInstance(instance);
		}

        public RFont(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFont(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Font CreateDynamicFontFromOSFont(System.String @fontname, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontname, @size};
            var ___result = RCreateDynamicFontFromOSFont_String_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public static UnityEngine.Font CreateDynamicFontFromOSFont(System.String[] @fontnames, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontnames, @size};
            var ___result = RCreateDynamicFontFromOSFont_StringArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public static void InvokeTextureRebuilt_Internal(UnityEngine.Font @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RInvokeTextureRebuilt_Internal_Font.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetMaxVertsForString(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetMaxVertsForString_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Font GetDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefault.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public virtual System.Boolean HasCharacter(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RHasCharacter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacter(System.Int32 @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RHasCharacter_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String[] GetOSInstalledFontNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOSInstalledFontNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] GetPathsToOSFonts()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPathsToOSFonts.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static void Internal_CreateFont(UnityEngine.Font @self, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @name};
            var ___result = RInternal_CreateFont_Font_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CreateFontFromPath(UnityEngine.Font @self, System.String @fontPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @fontPath};
            var ___result = RInternal_CreateFontFromPath_Font_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CreateDynamicFont(UnityEngine.Font @self, System.String[] @_names, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @_names, @size};
            var ___result = RInternal_CreateDynamicFont_Font_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetCharacterInfo(System.Char @ch, out UnityEngine.CharacterInfo @info, System.Int32 @size, UnityEngine.FontStyle @style)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @info, @size, @style};
            var ___result = RGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle.Invoke(___genericsType, ___parameters);
			@info = (UnityEngine.CharacterInfo)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetCharacterInfo(System.Char @ch, out UnityEngine.CharacterInfo @info, System.Int32 @size)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @info, @size};
            var ___result = RGetCharacterInfo_Char_Out_CharacterInfo_Int32.Invoke(___genericsType, ___parameters);
			@info = (UnityEngine.CharacterInfo)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetCharacterInfo(System.Char @ch, out UnityEngine.CharacterInfo @info)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @info};
            var ___result = RGetCharacterInfo_Char_Out_CharacterInfo.Invoke(___genericsType, ___parameters);
			@info = (UnityEngine.CharacterInfo)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void RequestCharactersInTexture(System.String @characters, System.Int32 @size, UnityEngine.FontStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @size, @style};
            var ___result = RRequestCharactersInTexture_String_Int32_FontStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestCharactersInTexture(System.String @characters, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @size};
            var ___result = RRequestCharactersInTexture_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestCharactersInTexture(System.String @characters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters};
            var ___result = RRequestCharactersInTexture_String.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean Equals(System.Object @other)
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
