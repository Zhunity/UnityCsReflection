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
					r_Specials = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "Specials");
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
					r_LeftPortion = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "LeftPortion");
					r_LeftPortion.SetBelong(null);
				}
				return r_LeftPortion;
			}
		}

		/// <summary>
		/// System.Int32 RightPortion
		/// </summary>
		protected static RField r_RightPortion;
		public static RField RightPortion
		{
			get
			{
				if(r_RightPortion == null)
				{
					r_RightPortion = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "RightPortion");
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
					r_LastGroup = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "LastGroup");
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
					r_WholeString = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "WholeString");
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
		protected RField r___1__Pattern__2__k__BackingField;
		public virtual RField R__1__Pattern__2__k__BackingField
		{
			get
			{
				if(r___1__Pattern__2__k__BackingField == null)
				{
					r___1__Pattern__2__k__BackingField = new(this, "<Pattern>k__BackingField");
					r___1__Pattern__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Pattern__2__k__BackingField;
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
		protected static RMethod r_RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions;
		public static RMethod RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions
		{
			get
			{
				if(r_RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions == null)
				{
					r_RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions = new( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement"), "GetOrCreate", 0, typeof(System.WeakReference<>).MakeGenericType( ReleactionUtils.GetType("System.Text.RegularExpressions.RegexReplacement")), typeof(System.String), typeof(System.Collections.Hashtable), typeof(System.Int32), typeof(System.Collections.Hashtable), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions.SetBelong(null);
				}
				return r_RGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions;
			}
		}

		/// <summary>
		/// Void ReplacementImpl(System.Text.StringBuilder, System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_RReplacementImpl_StringBuilder_Match;
		public virtual RMethod RReplacementImpl_StringBuilder_Match
		{
			get
			{
				if(r_RReplacementImpl_StringBuilder_Match == null)
				{
					r_RReplacementImpl_StringBuilder_Match = new(this, "ReplacementImpl", 0, typeof(System.Text.StringBuilder), typeof(System.Text.RegularExpressions.Match));
					r_RReplacementImpl_StringBuilder_Match.SetBelong(this.instance);
				}
				return r_RReplacementImpl_StringBuilder_Match;
			}
		}

		/// <summary>
		/// Void ReplacementImplRTL(System.Collections.Generic.List`1[System.String], System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_RReplacementImplRTL_List_d_String_p__Match;
		public virtual RMethod RReplacementImplRTL_List_d_String_p__Match
		{
			get
			{
				if(r_RReplacementImplRTL_List_d_String_p__Match == null)
				{
					r_RReplacementImplRTL_List_d_String_p__Match = new(this, "ReplacementImplRTL", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)), typeof(System.Text.RegularExpressions.Match));
					r_RReplacementImplRTL_List_d_String_p__Match.SetBelong(this.instance);
				}
				return r_RReplacementImplRTL_List_d_String_p__Match;
			}
		}

		/// <summary>
		/// System.String Replacement(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_RReplacement_Match;
		public virtual RMethod RReplacement_Match
		{
			get
			{
				if(r_RReplacement_Match == null)
				{
					r_RReplacement_Match = new(this, "Replacement", 0, typeof(System.Text.RegularExpressions.Match));
					r_RReplacement_Match.SetBelong(this.instance);
				}
				return r_RReplacement_Match;
			}
		}

		/// <summary>
		/// System.String Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RReplace_Regex_String_Int32_Int32;
		public virtual RMethod RReplace_Regex_String_Int32_Int32
		{
			get
			{
				if(r_RReplace_Regex_String_Int32_Int32 == null)
				{
					r_RReplace_Regex_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RReplace_Regex_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReplace_Regex_String_Int32_Int32;
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


        public virtual void ReplacementImpl(System.Text.StringBuilder  @sb, System.Text.RegularExpressions.Match  @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @match};
            var ___result = RReplacementImpl_StringBuilder_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplacementImplRTL(System.Collections.Generic.List<System.String>  @al, System.Text.RegularExpressions.Match  @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@al, @match};
            var ___result = RReplacementImplRTL_List_d_String_p__Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Replacement(System.Text.RegularExpressions.Match  @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RReplacement_Match.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.Text.RegularExpressions.Regex  @regex, System.String  @input, System.Int32  @count, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @input, @count, @startat};
            var ___result = RReplace_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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