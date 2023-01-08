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
		protected RProperty r_multiline;
		public virtual RProperty Rmultiline
		{
			get
			{
				if(r_multiline == null)
				{
					r_multiline = new(this, "multiline", -1);
					r_multiline.SetBelong(this.instance);
				}
				return r_multiline;
			}
		}

		/// <summary>
		/// Boolean isReadOnly
		/// </summary>
		protected RProperty r_isReadOnly;
		public virtual RProperty RisReadOnly
		{
			get
			{
				if(r_isReadOnly == null)
				{
					r_isReadOnly = new(this, "isReadOnly", -1);
					r_isReadOnly.SetBelong(this.instance);
				}
				return r_isReadOnly;
			}
		}

		/// <summary>
		/// Int32 maxLength
		/// </summary>
		protected RProperty r_maxLength;
		public virtual RProperty RmaxLength
		{
			get
			{
				if(r_maxLength == null)
				{
					r_maxLength = new(this, "maxLength", -1);
					r_maxLength.SetBelong(this.instance);
				}
				return r_maxLength;
			}
		}

		/// <summary>
		/// Boolean isDelayed
		/// </summary>
		protected RProperty r_isDelayed;
		public virtual RProperty RisDelayed
		{
			get
			{
				if(r_isDelayed == null)
				{
					r_isDelayed = new(this, "isDelayed", -1);
					r_isDelayed.SetBelong(this.instance);
				}
				return r_isDelayed;
			}
		}

		/// <summary>
		/// System.Func`2[System.Char,System.Boolean] AcceptCharacter
		/// </summary>
		protected RSystem.RFunc<RProperty, RProperty> r_AcceptCharacter;
		public virtual RSystem.RFunc<RProperty, RProperty> RAcceptCharacter
		{
			get
			{
				if(r_AcceptCharacter == null)
				{
					r_AcceptCharacter = new(this, "AcceptCharacter", -1);
					r_AcceptCharacter.SetBelong(this.instance);
				}
				return r_AcceptCharacter;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] UpdateScrollOffset
		/// </summary>
		protected RSystem.RAction<RProperty> r_UpdateScrollOffset;
		public virtual RSystem.RAction<RProperty> RUpdateScrollOffset
		{
			get
			{
				if(r_UpdateScrollOffset == null)
				{
					r_UpdateScrollOffset = new(this, "UpdateScrollOffset", -1);
					r_UpdateScrollOffset.SetBelong(this.instance);
				}
				return r_UpdateScrollOffset;
			}
		}

		/// <summary>
		/// System.Action UpdateValueFromText
		/// </summary>
		protected RSystem.RAction r_UpdateValueFromText;
		public virtual RSystem.RAction RUpdateValueFromText
		{
			get
			{
				if(r_UpdateValueFromText == null)
				{
					r_UpdateValueFromText = new(this, "UpdateValueFromText", -1);
					r_UpdateValueFromText.SetBelong(this.instance);
				}
				return r_UpdateValueFromText;
			}
		}

		/// <summary>
		/// System.Action UpdateTextFromValue
		/// </summary>
		protected RSystem.RAction r_UpdateTextFromValue;
		public virtual RSystem.RAction RUpdateTextFromValue
		{
			get
			{
				if(r_UpdateTextFromValue == null)
				{
					r_UpdateTextFromValue = new(this, "UpdateTextFromValue", -1);
					r_UpdateTextFromValue.SetBelong(this.instance);
				}
				return r_UpdateTextFromValue;
			}
		}

		/// <summary>
		/// System.Action MoveFocusToCompositeRoot
		/// </summary>
		protected RSystem.RAction r_MoveFocusToCompositeRoot;
		public virtual RSystem.RAction RMoveFocusToCompositeRoot
		{
			get
			{
				if(r_MoveFocusToCompositeRoot == null)
				{
					r_MoveFocusToCompositeRoot = new(this, "MoveFocusToCompositeRoot", -1);
					r_MoveFocusToCompositeRoot.SetBelong(this.instance);
				}
				return r_MoveFocusToCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean hasFocus
		/// </summary>
		protected RProperty r_hasFocus;
		public virtual RProperty RhasFocus
		{
			get
			{
				if(r_hasFocus == null)
				{
					r_hasFocus = new(this, "hasFocus", -1);
					r_hasFocus.SetBelong(this.instance);
				}
				return r_hasFocus;
			}
		}

		/// <summary>
		/// Char maskChar
		/// </summary>
		protected RProperty r_maskChar;
		public virtual RProperty RmaskChar
		{
			get
			{
				if(r_maskChar == null)
				{
					r_maskChar = new(this, "maskChar", -1);
					r_maskChar.SetBelong(this.instance);
				}
				return r_maskChar;
			}
		}

		/// <summary>
		/// Boolean isPassword
		/// </summary>
		protected RProperty r_isPassword;
		public virtual RProperty RisPassword
		{
			get
			{
				if(r_isPassword == null)
				{
					r_isPassword = new(this, "isPassword", -1);
					r_isPassword.SetBelong(this.instance);
				}
				return r_isPassword;
			}
		}

		/// <summary>
		/// Void ResetValueAndText()
		/// </summary>
		protected RMethod r_ResetValueAndText;
		public virtual RMethod RResetValueAndText
		{
			get
			{
				if(r_ResetValueAndText == null)
				{
					r_ResetValueAndText = new(this, "ResetValueAndText", 0);
					r_ResetValueAndText.SetBelong(this.instance);
				}
				return r_ResetValueAndText;
			}
		}

		/// <summary>
		/// Void SaveValueAndText()
		/// </summary>
		protected RMethod r_SaveValueAndText;
		public virtual RMethod RSaveValueAndText
		{
			get
			{
				if(r_SaveValueAndText == null)
				{
					r_SaveValueAndText = new(this, "SaveValueAndText", 0);
					r_SaveValueAndText.SetBelong(this.instance);
				}
				return r_SaveValueAndText;
			}
		}

		/// <summary>
		/// Void RestoreValueAndText()
		/// </summary>
		protected RMethod r_RestoreValueAndText;
		public virtual RMethod RRestoreValueAndText
		{
			get
			{
				if(r_RestoreValueAndText == null)
				{
					r_RestoreValueAndText = new(this, "RestoreValueAndText", 0);
					r_RestoreValueAndText.SetBelong(this.instance);
				}
				return r_RestoreValueAndText;
			}
		}

		/// <summary>
		/// Void UpdateText(System.String)
		/// </summary>
		protected RMethod r_UpdateText_String;
		public virtual RMethod RUpdateText_String
		{
			get
			{
				if(r_UpdateText_String == null)
				{
					r_UpdateText_String = new(this, "UpdateText", 0, typeof(System.String));
					r_UpdateText_String.SetBelong(this.instance);
				}
				return r_UpdateText_String;
			}
		}

		/// <summary>
		/// System.String CullString(System.String)
		/// </summary>
		protected RMethod r_CullString_String;
		public virtual RMethod RCullString_String
		{
			get
			{
				if(r_CullString_String == null)
				{
					r_CullString_String = new(this, "CullString", 0, typeof(System.String));
					r_CullString_String.SetBelong(this.instance);
				}
				return r_CullString_String;
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
            var ___result = RResetValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreValueAndText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreValueAndText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateText(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RUpdateText_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String CullString(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RCullString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
