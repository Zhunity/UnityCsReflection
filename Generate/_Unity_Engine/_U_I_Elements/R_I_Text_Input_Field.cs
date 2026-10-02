
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.ITextInputField
	/// </summary>
    public partial class RITextInputField : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ITextInputField");
            }
        }

        public RITextInputField() : base("UnityEngine.UIElements.ITextInputField")
        {
        }

        public RITextInputField(System.Object instance) : base("UnityEngine.UIElements.ITextInputField")
		{
            SetInstance(instance);
		}

        public RITextInputField(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITextInputField(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean hasFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasFocus
		{
			get
			{
				if(r_PhasFocus == null)
				{
					r_PhasFocus = new(this, "hasFocus", -1);
				}
				return r_PhasFocus;
			}
		}

		/// <summary>
		/// Boolean doubleClickSelectsWord
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdoubleClickSelectsWord;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdoubleClickSelectsWord
		{
			get
			{
				if(r_PdoubleClickSelectsWord == null)
				{
					r_PdoubleClickSelectsWord = new(this, "doubleClickSelectsWord", -1);
				}
				return r_PdoubleClickSelectsWord;
			}
		}

		/// <summary>
		/// Boolean tripleClickSelectsLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PtripleClickSelectsLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPtripleClickSelectsLine
		{
			get
			{
				if(r_PtripleClickSelectsLine == null)
				{
					r_PtripleClickSelectsLine = new(this, "tripleClickSelectsLine", -1);
				}
				return r_PtripleClickSelectsLine;
			}
		}

		/// <summary>
		/// Boolean isReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisReadOnly
		{
			get
			{
				if(r_PisReadOnly == null)
				{
					r_PisReadOnly = new(this, "isReadOnly", -1);
				}
				return r_PisReadOnly;
			}
		}

		/// <summary>
		/// Boolean isDelayed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDelayed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDelayed
		{
			get
			{
				if(r_PisDelayed == null)
				{
					r_PisDelayed = new(this, "isDelayed", -1);
				}
				return r_PisDelayed;
			}
		}

		/// <summary>
		/// Boolean isPasswordField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPasswordField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPasswordField
		{
			get
			{
				if(r_PisPasswordField == null)
				{
					r_PisPasswordField = new(this, "isPasswordField", -1);
				}
				return r_PisPasswordField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextEditorEngine editorEngine
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEngine r_PeditorEngine;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEngine RPeditorEngine
		{
			get
			{
				if(r_PeditorEngine == null)
				{
					r_PeditorEngine = new(this, "editorEngine", -1);
				}
				return r_PeditorEngine;
			}
		}

		/// <summary>
		/// Void SyncTextEngine()
		/// </summary>
		protected RMethod r_MSyncTextEngine;
		public virtual RMethod RMSyncTextEngine
		{
			get
			{
				if(r_MSyncTextEngine == null)
				{
					r_MSyncTextEngine = new(this, "SyncTextEngine", 0);
				}
				return r_MSyncTextEngine;
			}
		}

		/// <summary>
		/// Boolean AcceptCharacter(Char)
		/// </summary>
		protected RMethod r_MAcceptCharacter_Char;
		public virtual RMethod RMAcceptCharacter_Char
		{
			get
			{
				if(r_MAcceptCharacter_Char == null)
				{
					r_MAcceptCharacter_Char = new(this, "AcceptCharacter", 0, typeof(System.Char));
				}
				return r_MAcceptCharacter_Char;
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
				}
				return r_MCullString_String;
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
				}
				return r_MUpdateText_String;
			}
		}

		/// <summary>
		/// Void UpdateValueFromText()
		/// </summary>
		protected RMethod r_MUpdateValueFromText;
		public virtual RMethod RMUpdateValueFromText
		{
			get
			{
				if(r_MUpdateValueFromText == null)
				{
					r_MUpdateValueFromText = new(this, "UpdateValueFromText", 0);
				}
				return r_MUpdateValueFromText;
			}
		}


		public virtual void SyncTextEngine()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMSyncTextEngine.Invoke(___genericsType, ___parameters);
		}


		public virtual System.Boolean AcceptCharacter(System.Char @c)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@c};
			var ___result = RMAcceptCharacter_Char.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.String CullString(System.String @s)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@s};
			var ___result = RMCullString_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


		public virtual void UpdateText(System.String @value)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@value};
			var ___result = RMUpdateText_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void UpdateValueFromText()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMUpdateValueFromText.Invoke(___genericsType, ___parameters);
		}


    }
}
