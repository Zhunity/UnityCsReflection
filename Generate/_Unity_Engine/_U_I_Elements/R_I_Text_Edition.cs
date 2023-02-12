
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ITextEdition
	/// </summary>
    public partial class RITextEdition : RMember //
    {

		/// <summary>
		/// Boolean multiline
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pmultiline;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPmultiline
		{
			get
			{
				if(r_Pmultiline == null)
				{
					r_Pmultiline = new(this, "multiline", -1);
					r_Pmultiline.SetBelong(this.instance);
				}
				return r_Pmultiline;
			}
		}

		/// <summary>
		/// Boolean isReadOnly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisReadOnly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisReadOnly
		{
			get
			{
				if(r_PisReadOnly == null)
				{
					r_PisReadOnly = new(this, "isReadOnly", -1);
					r_PisReadOnly.SetBelong(this.instance);
				}
				return r_PisReadOnly;
			}
		}

		/// <summary>
		/// Int32 maxLength
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PmaxLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPmaxLength
		{
			get
			{
				if(r_PmaxLength == null)
				{
					r_PmaxLength = new(this, "maxLength", -1);
					r_PmaxLength.SetBelong(this.instance);
				}
				return r_PmaxLength;
			}
		}

		/// <summary>
		/// Boolean isDelayed
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisDelayed;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisDelayed
		{
			get
			{
				if(r_PisDelayed == null)
				{
					r_PisDelayed = new(this, "isDelayed", -1);
					r_PisDelayed.SetBelong(this.instance);
				}
				return r_PisDelayed;
			}
		}

		/// <summary>
		/// System.Func`2[System.Char,System.Boolean] AcceptCharacter
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RFunc<SMFrame.Editor.Refleaction.RSystem.RChar, SMFrame.Editor.Refleaction.RSystem.RBoolean> r_PAcceptCharacter;
		public virtual SMFrame.Editor.Refleaction.RSystem.RFunc<SMFrame.Editor.Refleaction.RSystem.RChar, SMFrame.Editor.Refleaction.RSystem.RBoolean> RPAcceptCharacter
		{
			get
			{
				if(r_PAcceptCharacter == null)
				{
					r_PAcceptCharacter = new(this, "AcceptCharacter", -1);
					r_PAcceptCharacter.SetBelong(this.instance);
				}
				return r_PAcceptCharacter;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] UpdateScrollOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> r_PUpdateScrollOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction<SMFrame.Editor.Refleaction.RSystem.RBoolean> RPUpdateScrollOffset
		{
			get
			{
				if(r_PUpdateScrollOffset == null)
				{
					r_PUpdateScrollOffset = new(this, "UpdateScrollOffset", -1);
					r_PUpdateScrollOffset.SetBelong(this.instance);
				}
				return r_PUpdateScrollOffset;
			}
		}

		/// <summary>
		/// System.Action UpdateValueFromText
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction r_PUpdateValueFromText;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction RPUpdateValueFromText
		{
			get
			{
				if(r_PUpdateValueFromText == null)
				{
					r_PUpdateValueFromText = new(this, "UpdateValueFromText", -1);
					r_PUpdateValueFromText.SetBelong(this.instance);
				}
				return r_PUpdateValueFromText;
			}
		}

		/// <summary>
		/// System.Action UpdateTextFromValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction r_PUpdateTextFromValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction RPUpdateTextFromValue
		{
			get
			{
				if(r_PUpdateTextFromValue == null)
				{
					r_PUpdateTextFromValue = new(this, "UpdateTextFromValue", -1);
					r_PUpdateTextFromValue.SetBelong(this.instance);
				}
				return r_PUpdateTextFromValue;
			}
		}

		/// <summary>
		/// System.Action MoveFocusToCompositeRoot
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RAction r_PMoveFocusToCompositeRoot;
		public virtual SMFrame.Editor.Refleaction.RSystem.RAction RPMoveFocusToCompositeRoot
		{
			get
			{
				if(r_PMoveFocusToCompositeRoot == null)
				{
					r_PMoveFocusToCompositeRoot = new(this, "MoveFocusToCompositeRoot", -1);
					r_PMoveFocusToCompositeRoot.SetBelong(this.instance);
				}
				return r_PMoveFocusToCompositeRoot;
			}
		}

		/// <summary>
		/// Char maskChar
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RChar r_PmaskChar;
		public virtual SMFrame.Editor.Refleaction.RSystem.RChar RPmaskChar
		{
			get
			{
				if(r_PmaskChar == null)
				{
					r_PmaskChar = new(this, "maskChar", -1);
					r_PmaskChar.SetBelong(this.instance);
				}
				return r_PmaskChar;
			}
		}

		/// <summary>
		/// Boolean isPassword
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisPassword;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisPassword
		{
			get
			{
				if(r_PisPassword == null)
				{
					r_PisPassword = new(this, "isPassword", -1);
					r_PisPassword.SetBelong(this.instance);
				}
				return r_PisPassword;
			}
		}

		/// <summary>
		/// Boolean autoCorrection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PautoCorrection;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPautoCorrection
		{
			get
			{
				if(r_PautoCorrection == null)
				{
					r_PautoCorrection = new(this, "autoCorrection", -1);
					r_PautoCorrection.SetBelong(this.instance);
				}
				return r_PautoCorrection;
			}
		}

		/// <summary>
		/// Boolean hideMobileInput
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PhideMobileInput;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPhideMobileInput
		{
			get
			{
				if(r_PhideMobileInput == null)
				{
					r_PhideMobileInput = new(this, "hideMobileInput", -1);
					r_PhideMobileInput.SetBelong(this.instance);
				}
				return r_PhideMobileInput;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard touchScreenKeyboard
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard r_PtouchScreenKeyboard;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard RPtouchScreenKeyboard
		{
			get
			{
				if(r_PtouchScreenKeyboard == null)
				{
					r_PtouchScreenKeyboard = new(this, "touchScreenKeyboard", -1);
					r_PtouchScreenKeyboard.SetBelong(this.instance);
				}
				return r_PtouchScreenKeyboard;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType keyboardType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_PkeyboardType;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RPkeyboardType
		{
			get
			{
				if(r_PkeyboardType == null)
				{
					r_PkeyboardType = new(this, "keyboardType", -1);
					r_PkeyboardType.SetBelong(this.instance);
				}
				return r_PkeyboardType;
			}
		}

		/// <summary>
		/// Void ResetValueAndText()
		/// </summary>
		protected RMethod r_MResetValueAndText;
		public virtual RMethod RMResetValueAndText
		{
			get
			{
				if(r_MResetValueAndText == null)
				{
					r_MResetValueAndText = new(this, "ResetValueAndText", 0);
					r_MResetValueAndText.SetBelong(this.instance);
				}
				return r_MResetValueAndText;
			}
		}

		/// <summary>
		/// Void SaveValueAndText()
		/// </summary>
		protected RMethod r_MSaveValueAndText;
		public virtual RMethod RMSaveValueAndText
		{
			get
			{
				if(r_MSaveValueAndText == null)
				{
					r_MSaveValueAndText = new(this, "SaveValueAndText", 0);
					r_MSaveValueAndText.SetBelong(this.instance);
				}
				return r_MSaveValueAndText;
			}
		}

		/// <summary>
		/// Void RestoreValueAndText()
		/// </summary>
		protected RMethod r_MRestoreValueAndText;
		public virtual RMethod RMRestoreValueAndText
		{
			get
			{
				if(r_MRestoreValueAndText == null)
				{
					r_MRestoreValueAndText = new(this, "RestoreValueAndText", 0);
					r_MRestoreValueAndText.SetBelong(this.instance);
				}
				return r_MRestoreValueAndText;
			}
		}

		/// <summary>
		/// Void UpdateText(System.String)
		/// </summary>
		protected RMethod r_MUpdateText_String;
		public virtual RMethod RMUpdateText_String
		{
			get
			{
				if(r_MUpdateText_String == null)
				{
					r_MUpdateText_String = new(this, "UpdateText", 0, typeof(System.String));
					r_MUpdateText_String.SetBelong(this.instance);
				}
				return r_MUpdateText_String;
			}
		}

		/// <summary>
		/// System.String CullString(System.String)
		/// </summary>
		protected RMethod r_MCullString_String;
		public virtual RMethod RMCullString_String
		{
			get
			{
				if(r_MCullString_String == null)
				{
					r_MCullString_String = new(this, "CullString", 0, typeof(System.String));
					r_MCullString_String.SetBelong(this.instance);
				}
				return r_MCullString_String;
			}
		}


        public RITextEdition() : base("UnityEngine.UIElements.ITextEdition")
        {
        }

        public RITextEdition(System.Object instance) : base("UnityEngine.UIElements.ITextEdition")
		{
            SetInstance(instance);
		}

        public RITextEdition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITextEdition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResetValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateText(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMUpdateText_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String CullString(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMCullString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
