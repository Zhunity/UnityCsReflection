using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.FontAssetCreationEditorSettings
	/// </summary>
    public partial class RFontAssetCreationEditorSettings : RMember //
    {

		/// <summary>
		/// System.String sourceFontFileGUID
		/// </summary>
		protected RSystem.RString r_sourceFontFileGUID;
		public virtual RSystem.RString RsourceFontFileGUID
		{
			get
			{
				if(r_sourceFontFileGUID == null)
				{
					r_sourceFontFileGUID = new(this, "sourceFontFileGUID");
					r_sourceFontFileGUID.SetBelong(this.instance);
				}
				return r_sourceFontFileGUID;
			}
		}

		/// <summary>
		/// System.Int32 faceIndex
		/// </summary>
		protected RSystem.RInt32 r_faceIndex;
		public virtual RSystem.RInt32 RfaceIndex
		{
			get
			{
				if(r_faceIndex == null)
				{
					r_faceIndex = new(this, "faceIndex");
					r_faceIndex.SetBelong(this.instance);
				}
				return r_faceIndex;
			}
		}

		/// <summary>
		/// System.Int32 pointSizeSamplingMode
		/// </summary>
		protected RSystem.RInt32 r_pointSizeSamplingMode;
		public virtual RSystem.RInt32 RpointSizeSamplingMode
		{
			get
			{
				if(r_pointSizeSamplingMode == null)
				{
					r_pointSizeSamplingMode = new(this, "pointSizeSamplingMode");
					r_pointSizeSamplingMode.SetBelong(this.instance);
				}
				return r_pointSizeSamplingMode;
			}
		}

		/// <summary>
		/// System.Int32 pointSize
		/// </summary>
		protected RSystem.RInt32 r_pointSize;
		public virtual RSystem.RInt32 RpointSize
		{
			get
			{
				if(r_pointSize == null)
				{
					r_pointSize = new(this, "pointSize");
					r_pointSize.SetBelong(this.instance);
				}
				return r_pointSize;
			}
		}

		/// <summary>
		/// System.Int32 padding
		/// </summary>
		protected RSystem.RInt32 r_padding;
		public virtual RSystem.RInt32 Rpadding
		{
			get
			{
				if(r_padding == null)
				{
					r_padding = new(this, "padding");
					r_padding.SetBelong(this.instance);
				}
				return r_padding;
			}
		}

		/// <summary>
		/// System.Int32 paddingMode
		/// </summary>
		protected RSystem.RInt32 r_paddingMode;
		public virtual RSystem.RInt32 RpaddingMode
		{
			get
			{
				if(r_paddingMode == null)
				{
					r_paddingMode = new(this, "paddingMode");
					r_paddingMode.SetBelong(this.instance);
				}
				return r_paddingMode;
			}
		}

		/// <summary>
		/// System.Int32 packingMode
		/// </summary>
		protected RSystem.RInt32 r_packingMode;
		public virtual RSystem.RInt32 RpackingMode
		{
			get
			{
				if(r_packingMode == null)
				{
					r_packingMode = new(this, "packingMode");
					r_packingMode.SetBelong(this.instance);
				}
				return r_packingMode;
			}
		}

		/// <summary>
		/// System.Int32 atlasWidth
		/// </summary>
		protected RSystem.RInt32 r_atlasWidth;
		public virtual RSystem.RInt32 RatlasWidth
		{
			get
			{
				if(r_atlasWidth == null)
				{
					r_atlasWidth = new(this, "atlasWidth");
					r_atlasWidth.SetBelong(this.instance);
				}
				return r_atlasWidth;
			}
		}

		/// <summary>
		/// System.Int32 atlasHeight
		/// </summary>
		protected RSystem.RInt32 r_atlasHeight;
		public virtual RSystem.RInt32 RatlasHeight
		{
			get
			{
				if(r_atlasHeight == null)
				{
					r_atlasHeight = new(this, "atlasHeight");
					r_atlasHeight.SetBelong(this.instance);
				}
				return r_atlasHeight;
			}
		}

		/// <summary>
		/// System.Int32 characterSetSelectionMode
		/// </summary>
		protected RSystem.RInt32 r_characterSetSelectionMode;
		public virtual RSystem.RInt32 RcharacterSetSelectionMode
		{
			get
			{
				if(r_characterSetSelectionMode == null)
				{
					r_characterSetSelectionMode = new(this, "characterSetSelectionMode");
					r_characterSetSelectionMode.SetBelong(this.instance);
				}
				return r_characterSetSelectionMode;
			}
		}

		/// <summary>
		/// System.String characterSequence
		/// </summary>
		protected RSystem.RString r_characterSequence;
		public virtual RSystem.RString RcharacterSequence
		{
			get
			{
				if(r_characterSequence == null)
				{
					r_characterSequence = new(this, "characterSequence");
					r_characterSequence.SetBelong(this.instance);
				}
				return r_characterSequence;
			}
		}

		/// <summary>
		/// System.String referencedFontAssetGUID
		/// </summary>
		protected RSystem.RString r_referencedFontAssetGUID;
		public virtual RSystem.RString RreferencedFontAssetGUID
		{
			get
			{
				if(r_referencedFontAssetGUID == null)
				{
					r_referencedFontAssetGUID = new(this, "referencedFontAssetGUID");
					r_referencedFontAssetGUID.SetBelong(this.instance);
				}
				return r_referencedFontAssetGUID;
			}
		}

		/// <summary>
		/// System.String referencedTextAssetGUID
		/// </summary>
		protected RSystem.RString r_referencedTextAssetGUID;
		public virtual RSystem.RString RreferencedTextAssetGUID
		{
			get
			{
				if(r_referencedTextAssetGUID == null)
				{
					r_referencedTextAssetGUID = new(this, "referencedTextAssetGUID");
					r_referencedTextAssetGUID.SetBelong(this.instance);
				}
				return r_referencedTextAssetGUID;
			}
		}

		/// <summary>
		/// System.Int32 fontStyle
		/// </summary>
		protected RSystem.RInt32 r_fontStyle;
		public virtual RSystem.RInt32 RfontStyle
		{
			get
			{
				if(r_fontStyle == null)
				{
					r_fontStyle = new(this, "fontStyle");
					r_fontStyle.SetBelong(this.instance);
				}
				return r_fontStyle;
			}
		}

		/// <summary>
		/// System.Single fontStyleModifier
		/// </summary>
		protected RSystem.RSingle r_fontStyleModifier;
		public virtual RSystem.RSingle RfontStyleModifier
		{
			get
			{
				if(r_fontStyleModifier == null)
				{
					r_fontStyleModifier = new(this, "fontStyleModifier");
					r_fontStyleModifier.SetBelong(this.instance);
				}
				return r_fontStyleModifier;
			}
		}

		/// <summary>
		/// System.Int32 renderMode
		/// </summary>
		protected RSystem.RInt32 r_renderMode;
		public virtual RSystem.RInt32 RrenderMode
		{
			get
			{
				if(r_renderMode == null)
				{
					r_renderMode = new(this, "renderMode");
					r_renderMode.SetBelong(this.instance);
				}
				return r_renderMode;
			}
		}

		/// <summary>
		/// System.Boolean includeFontFeatures
		/// </summary>
		protected RSystem.RBoolean r_includeFontFeatures;
		public virtual RSystem.RBoolean RincludeFontFeatures
		{
			get
			{
				if(r_includeFontFeatures == null)
				{
					r_includeFontFeatures = new(this, "includeFontFeatures");
					r_includeFontFeatures.SetBelong(this.instance);
				}
				return r_includeFontFeatures;
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


        public RFontAssetCreationEditorSettings() : base("UnityEngine.TextCore.Text.FontAssetCreationEditorSettings")
        {
        }

        public RFontAssetCreationEditorSettings(System.Object instance) : base("UnityEngine.TextCore.Text.FontAssetCreationEditorSettings")
		{
            SetInstance(instance);
		}

        public RFontAssetCreationEditorSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFontAssetCreationEditorSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
