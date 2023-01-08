using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexReplacement
	/// </summary>
    public partial class RRegexReplacement : RMember //
    {

		/// <summary>
		/// System.Int32 Specials
		/// </summary>
		protected static RField r_Specials;
		public static RField RSpecials
		{
			get
			{
				if(r_Specials == null)
				{
					r_Specials = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "Specials");
					r_Specials.SetBelong(null);
				}
				return r_Specials;
			}
		}

		/// <summary>
		/// System.Int32 LeftPortion
		/// </summary>
		protected static RField r_LeftPortion;
		public static RField RLeftPortion
		{
			get
			{
				if(r_LeftPortion == null)
				{
					r_LeftPortion = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "LeftPortion");
					r_LeftPortion.SetBelong(null);
				}
				return r_LeftPortion;
			}
		}

		/// <summary>
		/// System.Int32 RightPortion
		/// </summary>
		protected static RField r_RightPortion;
		public static RField RRightPortion
		{
			get
			{
				if(r_RightPortion == null)
				{
					r_RightPortion = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "RightPortion");
					r_RightPortion.SetBelong(null);
				}
				return r_RightPortion;
			}
		}

		/// <summary>
		/// System.Int32 LastGroup
		/// </summary>
		protected static RField r_LastGroup;
		public static RField RLastGroup
		{
			get
			{
				if(r_LastGroup == null)
				{
					r_LastGroup = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "LastGroup");
					r_LastGroup.SetBelong(null);
				}
				return r_LastGroup;
			}
		}

		/// <summary>
		/// System.Int32 WholeString
		/// </summary>
		protected static RField r_WholeString;
		public static RField RWholeString
		{
			get
			{
				if(r_WholeString == null)
				{
					r_WholeString = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "WholeString");
					r_WholeString.SetBelong(null);
				}
				return r_WholeString;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] _strings
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r__strings;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R_strings
		{
			get
			{
				if(r__strings == null)
				{
					r__strings = new(this, "_strings");
					r__strings.SetBelong(this.instance);
				}
				return r__strings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] _rules
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r__rules;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R_rules
		{
			get
			{
				if(r__rules == null)
				{
					r__rules = new(this, "_rules");
					r__rules.SetBelong(this.instance);
				}
				return r__rules;
			}
		}

		/// <summary>
		/// System.String <Pattern>k__BackingField
		/// </summary>
		protected RField r___0__Pattern__1__k__BackingField;
		public virtual RField R__0__Pattern__1__k__BackingField
		{
			get
			{
				if(r___0__Pattern__1__k__BackingField == null)
				{
					r___0__Pattern__1__k__BackingField = new(this, "<Pattern>k__BackingField");
					r___0__Pattern__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__Pattern__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String Pattern
		/// </summary>
		protected RProperty r_Pattern;
		public virtual RProperty RPattern
		{
			get
			{
				if(r_Pattern == null)
				{
					r_Pattern = new(this, "Pattern", -1);
					r_Pattern.SetBelong(this.instance);
				}
				return r_Pattern;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference`1[System.Text.RegularExpressions.RegexReplacement], System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_GetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions;
		public static RMethod RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions
		{
			get
			{
				if(r_GetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions == null)
				{
					r_GetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions = new( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "GetOrCreate", 0, typeof(System.WeakReference<>).MakeGenericType( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement")), typeof(System.String), typeof(System.Collections.Hashtable), typeof(System.Int32), typeof(System.Collections.Hashtable), typeof(System.Text.RegularExpressions.RegexOptions));
					r_GetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions.SetBelong(null);
				}
				return r_GetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions;
			}
		}

		/// <summary>
		/// Void ReplacementImpl(System.Text.StringBuilder, System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_ReplacementImpl_StringBuilder_Match;
		public virtual RMethod RReplacementImpl_StringBuilder_Match
		{
			get
			{
				if(r_ReplacementImpl_StringBuilder_Match == null)
				{
					r_ReplacementImpl_StringBuilder_Match = new(this, "ReplacementImpl", 0, typeof(System.Text.StringBuilder), typeof(System.Text.RegularExpressions.Match));
					r_ReplacementImpl_StringBuilder_Match.SetBelong(this.instance);
				}
				return r_ReplacementImpl_StringBuilder_Match;
			}
		}

		/// <summary>
		/// Void ReplacementImplRTL(System.Collections.Generic.List`1[System.String], System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_ReplacementImplRTL_List_d_String_p__Match;
		public virtual RMethod RReplacementImplRTL_List_d_String_p__Match
		{
			get
			{
				if(r_ReplacementImplRTL_List_d_String_p__Match == null)
				{
					r_ReplacementImplRTL_List_d_String_p__Match = new(this, "ReplacementImplRTL", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)), typeof(System.Text.RegularExpressions.Match));
					r_ReplacementImplRTL_List_d_String_p__Match.SetBelong(this.instance);
				}
				return r_ReplacementImplRTL_List_d_String_p__Match;
			}
		}

		/// <summary>
		/// System.String Replacement(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_Replacement_Match;
		public virtual RMethod RReplacement_Match
		{
			get
			{
				if(r_Replacement_Match == null)
				{
					r_Replacement_Match = new(this, "Replacement", 0, typeof(System.Text.RegularExpressions.Match));
					r_Replacement_Match.SetBelong(this.instance);
				}
				return r_Replacement_Match;
			}
		}

		/// <summary>
		/// System.String Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_Replace_Regex_String_Int32_Int32;
		public virtual RMethod RReplace_Regex_String_Int32_Int32
		{
			get
			{
				if(r_Replace_Regex_String_Int32_Int32 == null)
				{
					r_Replace_Regex_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_Replace_Regex_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_Replace_Regex_String_Int32_Int32;
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


        public RRegexReplacement() : base("System.Text.RegularExpressions.RegexReplacement")
        {
        }

        public RRegexReplacement(System.Object instance) : base("System.Text.RegularExpressions.RegexReplacement")
		{
            SetInstance(instance);
		}

        public RRegexReplacement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexReplacement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RSystem.RText.RRegularExpressions.RRegexReplacement GetOrCreate(RSystem.RWeakReference<RSystem.RText.RRegularExpressions.RRegexReplacement> @replRef, System.String @replacement, System.Collections.Hashtable @caps, System.Int32 @capsize, System.Collections.Hashtable @capnames, System.Text.RegularExpressions.RegexOptions @roptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replRef.Value, @replacement, @caps, @capsize, @capnames, @roptions};
            var ___result = RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions.Invoke(___genericsType, ___parameters);

            return new RSystem.RText.RRegularExpressions.RRegexReplacement(___result);
        }


        public virtual void ReplacementImpl(System.Text.StringBuilder @sb, System.Text.RegularExpressions.Match @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @match};
            var ___result = RReplacementImpl_StringBuilder_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplacementImplRTL(System.Collections.Generic.List<System.String> @al, System.Text.RegularExpressions.Match @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@al, @match};
            var ___result = RReplacementImplRTL_List_d_String_p__Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Replacement(System.Text.RegularExpressions.Match @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RReplacement_Match.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.Text.RegularExpressions.Regex @regex, System.String @input, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @input, @count, @startat};
            var ___result = RReplace_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
