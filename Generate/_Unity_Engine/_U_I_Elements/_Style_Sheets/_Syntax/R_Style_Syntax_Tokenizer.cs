
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer
	/// </summary>
    public partial class RStyleSyntaxTokenizer : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken] m_Tokens
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken> r_Fm_Tokens;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken> RFm_Tokens
		{
			get
			{
				if(r_Fm_Tokens == null)
				{
					r_Fm_Tokens = new(this, "m_Tokens");
				}
				return r_Fm_Tokens;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentTokenIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CurrentTokenIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CurrentTokenIndex
		{
			get
			{
				if(r_Fm_CurrentTokenIndex == null)
				{
					r_Fm_CurrentTokenIndex = new(this, "m_CurrentTokenIndex");
				}
				return r_Fm_CurrentTokenIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken current
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken r_Pcurrent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken RPcurrent
		{
			get
			{
				if(r_Pcurrent == null)
				{
					r_Pcurrent = new(this, "current", -1);
				}
				return r_Pcurrent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext()
		/// </summary>
		protected RMethod r_MMoveNext;
		public virtual RMethod RMMoveNext
		{
			get
			{
				if(r_MMoveNext == null)
				{
					r_MMoveNext = new(this, "MoveNext", 0);
				}
				return r_MMoveNext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext()
		/// </summary>
		protected RMethod r_MPeekNext;
		public virtual RMethod RMPeekNext
		{
			get
			{
				if(r_MPeekNext == null)
				{
					r_MPeekNext = new(this, "PeekNext", 0);
				}
				return r_MPeekNext;
			}
		}

		/// <summary>
		/// Void Tokenize(System.String)
		/// </summary>
		protected RMethod r_MTokenize_String;
		public virtual RMethod RMTokenize_String
		{
			get
			{
				if(r_MTokenize_String == null)
				{
					r_MTokenize_String = new(this, "Tokenize", 0, typeof(System.String));
				}
				return r_MTokenize_String;
			}
		}

		/// <summary>
		/// Boolean IsNextCharacter(System.String, Int32, Char)
		/// </summary>
		protected static RMethod r_MIsNextCharacter_String_Int32_Char;
		public static RMethod RMIsNextCharacter_String_Int32_Char
		{
			get
			{
				if(r_MIsNextCharacter_String_Int32_Char == null)
				{
					r_MIsNextCharacter_String_Int32_Char = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "IsNextCharacter", 0, typeof(System.String), typeof(System.Int32), typeof(System.Char));
				}
				return r_MIsNextCharacter_String_Int32_Char;
			}
		}

		/// <summary>
		/// Boolean IsNextLetterOrDash(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsNextLetterOrDash_String_Int32;
		public static RMethod RMIsNextLetterOrDash_String_Int32
		{
			get
			{
				if(r_MIsNextLetterOrDash_String_Int32 == null)
				{
					r_MIsNextLetterOrDash_String_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "IsNextLetterOrDash", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MIsNextLetterOrDash_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNextNumber(System.String, Int32)
		/// </summary>
		protected static RMethod r_MIsNextNumber_String_Int32;
		public static RMethod RMIsNextNumber_String_Int32
		{
			get
			{
				if(r_MIsNextNumber_String_Int32 == null)
				{
					r_MIsNextNumber_String_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "IsNextNumber", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MIsNextNumber_String_Int32;
			}
		}

		/// <summary>
		/// Int32 GlobCharacter(System.String, Int32, Char)
		/// </summary>
		protected static RMethod r_MGlobCharacter_String_Int32_Char;
		public static RMethod RMGlobCharacter_String_Int32_Char
		{
			get
			{
				if(r_MGlobCharacter_String_Int32_Char == null)
				{
					r_MGlobCharacter_String_Int32_Char = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "GlobCharacter", 0, typeof(System.String), typeof(System.Int32), typeof(System.Char));
				}
				return r_MGlobCharacter_String_Int32_Char;
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


        public RStyleSyntaxTokenizer() : base("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer")
        {
        }

        public RStyleSyntaxTokenizer(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer")
		{
            SetInstance(instance);
		}

        public RStyleSyntaxTokenizer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleSyntaxTokenizer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken PeekNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPeekNext.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken(___result);
        }


        public virtual void Tokenize(System.String @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RMTokenize_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsNextCharacter(System.String @s, System.Int32 @index, System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @c};
            var ___result = RMIsNextCharacter_String_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNextLetterOrDash(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsNextLetterOrDash_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNextNumber(System.String @s, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RMIsNextNumber_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GlobCharacter(System.String @s, System.Int32 @index, System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @c};
            var ___result = RMGlobCharacter_String_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
