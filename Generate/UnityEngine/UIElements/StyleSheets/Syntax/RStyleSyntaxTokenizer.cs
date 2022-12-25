using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer
	/// </summary>
    public partial class RStyleSyntaxTokenizer : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken] m_Tokens
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken> r_m_Tokens;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken> Rm_Tokens
		{
			get
			{
				if(r_m_Tokens == null)
				{
					r_m_Tokens = new(this, "m_Tokens");
					r_m_Tokens.SetBelong(this.instance);
				}
				return r_m_Tokens;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentTokenIndex
		/// </summary>
		protected RField r_m_CurrentTokenIndex;
		public virtual RField Rm_CurrentTokenIndex
		{
			get
			{
				if(r_m_CurrentTokenIndex == null)
				{
					r_m_CurrentTokenIndex = new(this, "m_CurrentTokenIndex");
					r_m_CurrentTokenIndex.SetBelong(this.instance);
				}
				return r_m_CurrentTokenIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken current
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken r_current;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new(this, "current", -1);
					r_current.SetBelong(this.instance);
				}
				return r_current;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext()
		/// </summary>
		protected RMethod r_RPeekNext;
		public virtual RMethod RPeekNext
		{
			get
			{
				if(r_RPeekNext == null)
				{
					r_RPeekNext = new(this, "PeekNext", 0);
					r_RPeekNext.SetBelong(this.instance);
				}
				return r_RPeekNext;
			}
		}

		/// <summary>
		/// Void Tokenize(System.String)
		/// </summary>
		protected RMethod r_RTokenize_String;
		public virtual RMethod RTokenize_String
		{
			get
			{
				if(r_RTokenize_String == null)
				{
					r_RTokenize_String = new(this, "Tokenize", 0, typeof(System.String));
					r_RTokenize_String.SetBelong(this.instance);
				}
				return r_RTokenize_String;
			}
		}

		/// <summary>
		/// Boolean IsNextCharacter(System.String, Int32, Char)
		/// </summary>
		protected static RMethod r_RIsNextCharacter_String_Int32_Char;
		public static RMethod RIsNextCharacter_String_Int32_Char
		{
			get
			{
				if(r_RIsNextCharacter_String_Int32_Char == null)
				{
					r_RIsNextCharacter_String_Int32_Char = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "IsNextCharacter", 0, typeof(System.String), typeof(System.Int32), typeof(System.Char));
					r_RIsNextCharacter_String_Int32_Char.SetBelong(null);
				}
				return r_RIsNextCharacter_String_Int32_Char;
			}
		}

		/// <summary>
		/// Boolean IsNextLetterOrDash(System.String, Int32)
		/// </summary>
		protected static RMethod r_RIsNextLetterOrDash_String_Int32;
		public static RMethod RIsNextLetterOrDash_String_Int32
		{
			get
			{
				if(r_RIsNextLetterOrDash_String_Int32 == null)
				{
					r_RIsNextLetterOrDash_String_Int32 = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "IsNextLetterOrDash", 0, typeof(System.String), typeof(System.Int32));
					r_RIsNextLetterOrDash_String_Int32.SetBelong(null);
				}
				return r_RIsNextLetterOrDash_String_Int32;
			}
		}

		/// <summary>
		/// Boolean IsNextNumber(System.String, Int32)
		/// </summary>
		protected static RMethod r_RIsNextNumber_String_Int32;
		public static RMethod RIsNextNumber_String_Int32
		{
			get
			{
				if(r_RIsNextNumber_String_Int32 == null)
				{
					r_RIsNextNumber_String_Int32 = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "IsNextNumber", 0, typeof(System.String), typeof(System.Int32));
					r_RIsNextNumber_String_Int32.SetBelong(null);
				}
				return r_RIsNextNumber_String_Int32;
			}
		}

		/// <summary>
		/// Int32 GlobCharacter(System.String, Int32, Char)
		/// </summary>
		protected static RMethod r_RGlobCharacter_String_Int32_Char;
		public static RMethod RGlobCharacter_String_Int32_Char
		{
			get
			{
				if(r_RGlobCharacter_String_Int32_Char == null)
				{
					r_RGlobCharacter_String_Int32_Char = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), "GlobCharacter", 0, typeof(System.String), typeof(System.Int32), typeof(System.Char));
					r_RGlobCharacter_String_Int32_Char.SetBelong(null);
				}
				return r_RGlobCharacter_String_Int32_Char;
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

        public virtual System.Object MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object PeekNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeekNext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Tokenize(System.String  @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RTokenize_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsNextCharacter(System.String  @s, System.Int32  @index, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @c};
            var ___result = RIsNextCharacter_String_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNextLetterOrDash(System.String  @s, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsNextLetterOrDash_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsNextNumber(System.String  @s, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index};
            var ___result = RIsNextNumber_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GlobCharacter(System.String  @s, System.Int32  @index, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @c};
            var ___result = RGlobCharacter_String_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
