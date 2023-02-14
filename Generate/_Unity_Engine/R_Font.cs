
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Font
	/// </summary>
    public partial class RFont : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEngine.Font] textureRebuilt
		/// </summary>
		protected static REvent r_EtextureRebuilt;
		public static REvent REtextureRebuilt
		{
			get
			{
				if(r_EtextureRebuilt == null)
				{
					r_EtextureRebuilt = new(typeof(UnityEngine.Font), "textureRebuilt");
					r_EtextureRebuilt.SetBelong(null);
				}
				return r_EtextureRebuilt;
			}
		}

		/// <summary>
		/// UnityEngine.Font+FontTextureRebuildCallback m_FontTextureRebuildCallback
		/// </summary>
		protected REvent r_Em_FontTextureRebuildCallback;
		public virtual REvent REm_FontTextureRebuildCallback
		{
			get
			{
				if(r_Em_FontTextureRebuildCallback == null)
				{
					r_Em_FontTextureRebuildCallback = new(this, "m_FontTextureRebuildCallback");
					r_Em_FontTextureRebuildCallback.SetBelong(this.instance);
				}
				return r_Em_FontTextureRebuildCallback;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Font] textureRebuilt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RFont> r_FtextureRebuilt;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RFont> RFtextureRebuilt
		{
			get
			{
				if(r_FtextureRebuilt == null)
				{
					r_FtextureRebuilt = new(typeof(UnityEngine.Font), "textureRebuilt");
					r_FtextureRebuilt.SetBelong(null);
				}
				return r_FtextureRebuilt;
			}
		}

		/// <summary>
		/// UnityEngine.Font+FontTextureRebuildCallback m_FontTextureRebuildCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont.RFontTextureRebuildCallback r_Fm_FontTextureRebuildCallback;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont.RFontTextureRebuildCallback RFm_FontTextureRebuildCallback
		{
			get
			{
				if(r_Fm_FontTextureRebuildCallback == null)
				{
					r_Fm_FontTextureRebuildCallback = new(this, "m_FontTextureRebuildCallback");
					r_Fm_FontTextureRebuildCallback.SetBelong(this.instance);
				}
				return r_Fm_FontTextureRebuildCallback;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Pmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPmaterial
		{
			get
			{
				if(r_Pmaterial == null)
				{
					r_Pmaterial = new(this, "material", -1);
					r_Pmaterial.SetBelong(this.instance);
				}
				return r_Pmaterial;
			}
		}

		/// <summary>
		/// System.String[] fontNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PfontNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPfontNames
		{
			get
			{
				if(r_PfontNames == null)
				{
					r_PfontNames = new(this, "fontNames", -1);
					r_PfontNames.SetBelong(this.instance);
				}
				return r_PfontNames;
			}
		}

		/// <summary>
		/// Boolean dynamic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdynamic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdynamic
		{
			get
			{
				if(r_Pdynamic == null)
				{
					r_Pdynamic = new(this, "dynamic", -1);
					r_Pdynamic.SetBelong(this.instance);
				}
				return r_Pdynamic;
			}
		}

		/// <summary>
		/// Int32 ascent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pascent;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPascent
		{
			get
			{
				if(r_Pascent == null)
				{
					r_Pascent = new(this, "ascent", -1);
					r_Pascent.SetBelong(this.instance);
				}
				return r_Pascent;
			}
		}

		/// <summary>
		/// Int32 fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PfontSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPfontSize
		{
			get
			{
				if(r_PfontSize == null)
				{
					r_PfontSize = new(this, "fontSize", -1);
					r_PfontSize.SetBelong(this.instance);
				}
				return r_PfontSize;
			}
		}

		/// <summary>
		/// UnityEngine.CharacterInfo[] characterInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RCharacterInfo> r_PcharacterInfo;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RCharacterInfo> RPcharacterInfo
		{
			get
			{
				if(r_PcharacterInfo == null)
				{
					r_PcharacterInfo = new(this, "characterInfo", -1);
					r_PcharacterInfo.SetBelong(this.instance);
				}
				return r_PcharacterInfo;
			}
		}

		/// <summary>
		/// Int32 lineHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PlineHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlineHeight
		{
			get
			{
				if(r_PlineHeight == null)
				{
					r_PlineHeight = new(this, "lineHeight", -1);
					r_PlineHeight.SetBelong(this.instance);
				}
				return r_PlineHeight;
			}
		}

		/// <summary>
		/// FontTextureRebuildCallback textureRebuildCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont.RFontTextureRebuildCallback r_PtextureRebuildCallback;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont.RFontTextureRebuildCallback RPtextureRebuildCallback
		{
			get
			{
				if(r_PtextureRebuildCallback == null)
				{
					r_PtextureRebuildCallback = new(this, "textureRebuildCallback", -1);
					r_PtextureRebuildCallback.SetBelong(this.instance);
				}
				return r_PtextureRebuildCallback;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Font CreateDynamicFontFromOSFont(System.String, Int32)
		/// </summary>
		protected static RMethod r_MCreateDynamicFontFromOSFont_String_Int32;
		public static RMethod RMCreateDynamicFontFromOSFont_String_Int32
		{
			get
			{
				if(r_MCreateDynamicFontFromOSFont_String_Int32 == null)
				{
					r_MCreateDynamicFontFromOSFont_String_Int32 = new(typeof(UnityEngine.Font), "CreateDynamicFontFromOSFont", 0, typeof(System.String), typeof(System.Int32));
					r_MCreateDynamicFontFromOSFont_String_Int32.SetBelong(null);
				}
				return r_MCreateDynamicFontFromOSFont_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Font CreateDynamicFontFromOSFont(System.String[], Int32)
		/// </summary>
		protected static RMethod r_MCreateDynamicFontFromOSFont_StringArray_Int32;
		public static RMethod RMCreateDynamicFontFromOSFont_StringArray_Int32
		{
			get
			{
				if(r_MCreateDynamicFontFromOSFont_StringArray_Int32 == null)
				{
					r_MCreateDynamicFontFromOSFont_StringArray_Int32 = new(typeof(UnityEngine.Font), "CreateDynamicFontFromOSFont", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_MCreateDynamicFontFromOSFont_StringArray_Int32.SetBelong(null);
				}
				return r_MCreateDynamicFontFromOSFont_StringArray_Int32;
			}
		}

		/// <summary>
		/// Void InvokeTextureRebuilt_Internal(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_MInvokeTextureRebuilt_Internal_Font;
		public static RMethod RMInvokeTextureRebuilt_Internal_Font
		{
			get
			{
				if(r_MInvokeTextureRebuilt_Internal_Font == null)
				{
					r_MInvokeTextureRebuilt_Internal_Font = new(typeof(UnityEngine.Font), "InvokeTextureRebuilt_Internal", 0, typeof(UnityEngine.Font));
					r_MInvokeTextureRebuilt_Internal_Font.SetBelong(null);
				}
				return r_MInvokeTextureRebuilt_Internal_Font;
			}
		}

		/// <summary>
		/// Int32 GetMaxVertsForString(System.String)
		/// </summary>
		protected static RMethod r_MGetMaxVertsForString_String;
		public static RMethod RMGetMaxVertsForString_String
		{
			get
			{
				if(r_MGetMaxVertsForString_String == null)
				{
					r_MGetMaxVertsForString_String = new(typeof(UnityEngine.Font), "GetMaxVertsForString", 0, typeof(System.String));
					r_MGetMaxVertsForString_String.SetBelong(null);
				}
				return r_MGetMaxVertsForString_String;
			}
		}

		/// <summary>
		/// UnityEngine.Font GetDefault()
		/// </summary>
		protected static RMethod r_MGetDefault;
		public static RMethod RMGetDefault
		{
			get
			{
				if(r_MGetDefault == null)
				{
					r_MGetDefault = new(typeof(UnityEngine.Font), "GetDefault", 0);
					r_MGetDefault.SetBelong(null);
				}
				return r_MGetDefault;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Char)
		/// </summary>
		protected RMethod r_MHasCharacter_Char;
		public virtual RMethod RMHasCharacter_Char
		{
			get
			{
				if(r_MHasCharacter_Char == null)
				{
					r_MHasCharacter_Char = new(this, "HasCharacter", 0, typeof(System.Char));
					r_MHasCharacter_Char.SetBelong(this.instance);
				}
				return r_MHasCharacter_Char;
			}
		}

		/// <summary>
		/// Boolean HasCharacter(Int32)
		/// </summary>
		protected RMethod r_MHasCharacter_Int32;
		public virtual RMethod RMHasCharacter_Int32
		{
			get
			{
				if(r_MHasCharacter_Int32 == null)
				{
					r_MHasCharacter_Int32 = new(this, "HasCharacter", 0, typeof(System.Int32));
					r_MHasCharacter_Int32.SetBelong(this.instance);
				}
				return r_MHasCharacter_Int32;
			}
		}

		/// <summary>
		/// System.String[] GetOSInstalledFontNames()
		/// </summary>
		protected static RMethod r_MGetOSInstalledFontNames;
		public static RMethod RMGetOSInstalledFontNames
		{
			get
			{
				if(r_MGetOSInstalledFontNames == null)
				{
					r_MGetOSInstalledFontNames = new(typeof(UnityEngine.Font), "GetOSInstalledFontNames", 0);
					r_MGetOSInstalledFontNames.SetBelong(null);
				}
				return r_MGetOSInstalledFontNames;
			}
		}

		/// <summary>
		/// System.String[] GetPathsToOSFonts()
		/// </summary>
		protected static RMethod r_MGetPathsToOSFonts;
		public static RMethod RMGetPathsToOSFonts
		{
			get
			{
				if(r_MGetPathsToOSFonts == null)
				{
					r_MGetPathsToOSFonts = new(typeof(UnityEngine.Font), "GetPathsToOSFonts", 0);
					r_MGetPathsToOSFonts.SetBelong(null);
				}
				return r_MGetPathsToOSFonts;
			}
		}

		/// <summary>
		/// Void Internal_CreateFont(UnityEngine.Font, System.String)
		/// </summary>
		protected static RMethod r_MInternal_CreateFont_Font_String;
		public static RMethod RMInternal_CreateFont_Font_String
		{
			get
			{
				if(r_MInternal_CreateFont_Font_String == null)
				{
					r_MInternal_CreateFont_Font_String = new(typeof(UnityEngine.Font), "Internal_CreateFont", 0, typeof(UnityEngine.Font), typeof(System.String));
					r_MInternal_CreateFont_Font_String.SetBelong(null);
				}
				return r_MInternal_CreateFont_Font_String;
			}
		}

		/// <summary>
		/// Void Internal_CreateFontFromPath(UnityEngine.Font, System.String)
		/// </summary>
		protected static RMethod r_MInternal_CreateFontFromPath_Font_String;
		public static RMethod RMInternal_CreateFontFromPath_Font_String
		{
			get
			{
				if(r_MInternal_CreateFontFromPath_Font_String == null)
				{
					r_MInternal_CreateFontFromPath_Font_String = new(typeof(UnityEngine.Font), "Internal_CreateFontFromPath", 0, typeof(UnityEngine.Font), typeof(System.String));
					r_MInternal_CreateFontFromPath_Font_String.SetBelong(null);
				}
				return r_MInternal_CreateFontFromPath_Font_String;
			}
		}

		/// <summary>
		/// Void Internal_CreateDynamicFont(UnityEngine.Font, System.String[], Int32)
		/// </summary>
		protected static RMethod r_MInternal_CreateDynamicFont_Font_StringArray_Int32;
		public static RMethod RMInternal_CreateDynamicFont_Font_StringArray_Int32
		{
			get
			{
				if(r_MInternal_CreateDynamicFont_Font_StringArray_Int32 == null)
				{
					r_MInternal_CreateDynamicFont_Font_StringArray_Int32 = new(typeof(UnityEngine.Font), "Internal_CreateDynamicFont", 0, typeof(UnityEngine.Font), typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_MInternal_CreateDynamicFont_Font_StringArray_Int32.SetBelong(null);
				}
				return r_MInternal_CreateDynamicFont_Font_StringArray_Int32;
			}
		}

		/// <summary>
		/// Boolean GetCharacterInfo(Char, UnityEngine.CharacterInfo ByRef, Int32, UnityEngine.FontStyle)
		/// </summary>
		protected RMethod r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle;
		public virtual RMethod RMGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle
		{
			get
			{
				if(r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle == null)
				{
					r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle = new(this, "GetCharacterInfo", 0, typeof(System.Char), typeof(UnityEngine.CharacterInfo).MakeByRefType(), typeof(System.Int32), typeof(UnityEngine.FontStyle));
					r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle.SetBelong(this.instance);
				}
				return r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle;
			}
		}

		/// <summary>
		/// Boolean GetCharacterInfo(Char, UnityEngine.CharacterInfo ByRef, Int32)
		/// </summary>
		protected RMethod r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32;
		public virtual RMethod RMGetCharacterInfo_Char_Out_CharacterInfo_Int32
		{
			get
			{
				if(r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32 == null)
				{
					r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32 = new(this, "GetCharacterInfo", 0, typeof(System.Char), typeof(UnityEngine.CharacterInfo).MakeByRefType(), typeof(System.Int32));
					r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32.SetBelong(this.instance);
				}
				return r_MGetCharacterInfo_Char_Out_CharacterInfo_Int32;
			}
		}

		/// <summary>
		/// Boolean GetCharacterInfo(Char, UnityEngine.CharacterInfo ByRef)
		/// </summary>
		protected RMethod r_MGetCharacterInfo_Char_Out_CharacterInfo;
		public virtual RMethod RMGetCharacterInfo_Char_Out_CharacterInfo
		{
			get
			{
				if(r_MGetCharacterInfo_Char_Out_CharacterInfo == null)
				{
					r_MGetCharacterInfo_Char_Out_CharacterInfo = new(this, "GetCharacterInfo", 0, typeof(System.Char), typeof(UnityEngine.CharacterInfo).MakeByRefType());
					r_MGetCharacterInfo_Char_Out_CharacterInfo.SetBelong(this.instance);
				}
				return r_MGetCharacterInfo_Char_Out_CharacterInfo;
			}
		}

		/// <summary>
		/// Void RequestCharactersInTexture(System.String, Int32, UnityEngine.FontStyle)
		/// </summary>
		protected RMethod r_MRequestCharactersInTexture_String_Int32_FontStyle;
		public virtual RMethod RMRequestCharactersInTexture_String_Int32_FontStyle
		{
			get
			{
				if(r_MRequestCharactersInTexture_String_Int32_FontStyle == null)
				{
					r_MRequestCharactersInTexture_String_Int32_FontStyle = new(this, "RequestCharactersInTexture", 0, typeof(System.String), typeof(System.Int32), typeof(UnityEngine.FontStyle));
					r_MRequestCharactersInTexture_String_Int32_FontStyle.SetBelong(this.instance);
				}
				return r_MRequestCharactersInTexture_String_Int32_FontStyle;
			}
		}

		/// <summary>
		/// Void RequestCharactersInTexture(System.String, Int32)
		/// </summary>
		protected RMethod r_MRequestCharactersInTexture_String_Int32;
		public virtual RMethod RMRequestCharactersInTexture_String_Int32
		{
			get
			{
				if(r_MRequestCharactersInTexture_String_Int32 == null)
				{
					r_MRequestCharactersInTexture_String_Int32 = new(this, "RequestCharactersInTexture", 0, typeof(System.String), typeof(System.Int32));
					r_MRequestCharactersInTexture_String_Int32.SetBelong(this.instance);
				}
				return r_MRequestCharactersInTexture_String_Int32;
			}
		}

		/// <summary>
		/// Void RequestCharactersInTexture(System.String)
		/// </summary>
		protected RMethod r_MRequestCharactersInTexture_String;
		public virtual RMethod RMRequestCharactersInTexture_String
		{
			get
			{
				if(r_MRequestCharactersInTexture_String == null)
				{
					r_MRequestCharactersInTexture_String = new(this, "RequestCharactersInTexture", 0, typeof(System.String));
					r_MRequestCharactersInTexture_String.SetBelong(this.instance);
				}
				return r_MRequestCharactersInTexture_String;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
            var ___result = RMCreateDynamicFontFromOSFont_String_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public static UnityEngine.Font CreateDynamicFontFromOSFont(System.String[] @fontnames, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fontnames, @size};
            var ___result = RMCreateDynamicFontFromOSFont_StringArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public static void InvokeTextureRebuilt_Internal(UnityEngine.Font @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RMInvokeTextureRebuilt_Internal_Font.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetMaxVertsForString(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetMaxVertsForString_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Font GetDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefault.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public virtual System.Boolean HasCharacter(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMHasCharacter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasCharacter(System.Int32 @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMHasCharacter_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String[] GetOSInstalledFontNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOSInstalledFontNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] GetPathsToOSFonts()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPathsToOSFonts.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static void Internal_CreateFont(UnityEngine.Font @self, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @name};
            var ___result = RMInternal_CreateFont_Font_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CreateFontFromPath(UnityEngine.Font @self, System.String @fontPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @fontPath};
            var ___result = RMInternal_CreateFontFromPath_Font_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_CreateDynamicFont(UnityEngine.Font @self, System.String[] @_names, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @_names, @size};
            var ___result = RMInternal_CreateDynamicFont_Font_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetCharacterInfo(System.Char @ch, out UnityEngine.CharacterInfo @info, System.Int32 @size, UnityEngine.FontStyle @style)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @info, @size, @style};
            var ___result = RMGetCharacterInfo_Char_Out_CharacterInfo_Int32_FontStyle.Invoke(___genericsType, ___parameters);
			@info = (UnityEngine.CharacterInfo)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetCharacterInfo(System.Char @ch, out UnityEngine.CharacterInfo @info, System.Int32 @size)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @info, @size};
            var ___result = RMGetCharacterInfo_Char_Out_CharacterInfo_Int32.Invoke(___genericsType, ___parameters);
			@info = (UnityEngine.CharacterInfo)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetCharacterInfo(System.Char @ch, out UnityEngine.CharacterInfo @info)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @info};
            var ___result = RMGetCharacterInfo_Char_Out_CharacterInfo.Invoke(___genericsType, ___parameters);
			@info = (UnityEngine.CharacterInfo)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void RequestCharactersInTexture(System.String @characters, System.Int32 @size, UnityEngine.FontStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @size, @style};
            var ___result = RMRequestCharactersInTexture_String_Int32_FontStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestCharactersInTexture(System.String @characters, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @size};
            var ___result = RMRequestCharactersInTexture_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestCharactersInTexture(System.String @characters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters};
            var ___result = RMRequestCharactersInTexture_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
