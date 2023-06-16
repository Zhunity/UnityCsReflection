
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Text.RegularExpressions.RegexReplacement
	/// </summary>
    public partial class RRegexReplacement : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement");
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


		/// <summary>
		/// System.Int32 Specials
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSpecials;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSpecials
		{
			get
			{
				if(r_FSpecials == null)
				{
					r_FSpecials = new(Type, "Specials");
				}
				return r_FSpecials;
			}
		}

		/// <summary>
		/// System.Int32 LeftPortion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLeftPortion;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLeftPortion
		{
			get
			{
				if(r_FLeftPortion == null)
				{
					r_FLeftPortion = new(Type, "LeftPortion");
				}
				return r_FLeftPortion;
			}
		}

		/// <summary>
		/// System.Int32 RightPortion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FRightPortion;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFRightPortion
		{
			get
			{
				if(r_FRightPortion == null)
				{
					r_FRightPortion = new(Type, "RightPortion");
				}
				return r_FRightPortion;
			}
		}

		/// <summary>
		/// System.Int32 LastGroup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLastGroup;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLastGroup
		{
			get
			{
				if(r_FLastGroup == null)
				{
					r_FLastGroup = new(Type, "LastGroup");
				}
				return r_FLastGroup;
			}
		}

		/// <summary>
		/// System.Int32 WholeString
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWholeString;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWholeString
		{
			get
			{
				if(r_FWholeString == null)
				{
					r_FWholeString = new(Type, "WholeString");
				}
				return r_FWholeString;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] _strings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_F_strings;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RF_strings
		{
			get
			{
				if(r_F_strings == null)
				{
					r_F_strings = new(this, "_strings");
				}
				return r_F_strings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] _rules
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> r_F_rules;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> RF_rules
		{
			get
			{
				if(r_F_rules == null)
				{
					r_F_rules = new(this, "_rules");
				}
				return r_F_rules;
			}
		}

		/// <summary>
		/// System.String <Pattern>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__Pattern__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__Pattern__1__k__BackingField
		{
			get
			{
				if(r_F__0__Pattern__1__k__BackingField == null)
				{
					r_F__0__Pattern__1__k__BackingField = new(this, "<Pattern>k__BackingField");
				}
				return r_F__0__Pattern__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String Pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPattern
		{
			get
			{
				if(r_PPattern == null)
				{
					r_PPattern = new(this, "Pattern", -1);
				}
				return r_PPattern;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference`1[System.Text.RegularExpressions.RegexReplacement], System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions;
		public static RMethod RMGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions
		{
			get
			{
				if(r_MGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions == null)
				{
					r_MGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions = new(Type, "GetOrCreate", 0,  ReflectionUtils.GetType("System.WeakReference`1").MakeGenericType( ReflectionUtils.GetType("System.Text.RegularExpressions.RegexReplacement")), typeof(System.String), typeof(System.Collections.Hashtable), typeof(System.Int32), typeof(System.Collections.Hashtable), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions;
			}
		}

		/// <summary>
		/// Void ReplacementImpl(System.Text.StringBuilder, System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MReplacementImpl_StringBuilder_Match;
		public virtual RMethod RMReplacementImpl_StringBuilder_Match
		{
			get
			{
				if(r_MReplacementImpl_StringBuilder_Match == null)
				{
					r_MReplacementImpl_StringBuilder_Match = new(this, "ReplacementImpl", 0, typeof(System.Text.StringBuilder), typeof(System.Text.RegularExpressions.Match));
				}
				return r_MReplacementImpl_StringBuilder_Match;
			}
		}

		/// <summary>
		/// Void ReplacementImplRTL(System.Collections.Generic.List`1[System.String], System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MReplacementImplRTL_List_d_String_p__Match;
		public virtual RMethod RMReplacementImplRTL_List_d_String_p__Match
		{
			get
			{
				if(r_MReplacementImplRTL_List_d_String_p__Match == null)
				{
					r_MReplacementImplRTL_List_d_String_p__Match = new(this, "ReplacementImplRTL", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.String)), typeof(System.Text.RegularExpressions.Match));
				}
				return r_MReplacementImplRTL_List_d_String_p__Match;
			}
		}

		/// <summary>
		/// System.String Replacement(System.Text.RegularExpressions.Match)
		/// </summary>
		protected RMethod r_MReplacement_Match;
		public virtual RMethod RMReplacement_Match
		{
			get
			{
				if(r_MReplacement_Match == null)
				{
					r_MReplacement_Match = new(this, "Replacement", 0, typeof(System.Text.RegularExpressions.Match));
				}
				return r_MReplacement_Match;
			}
		}

		/// <summary>
		/// System.String Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MReplace_Regex_String_Int32_Int32;
		public virtual RMethod RMReplace_Regex_String_Int32_Int32
		{
			get
			{
				if(r_MReplace_Regex_String_Int32_Int32 == null)
				{
					r_MReplace_Regex_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReplace_Regex_String_Int32_Int32;
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


        public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement GetOrCreate(Hvak.Editor.Refleaction.RSystem.RWeakReference<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement> @replRef, System.String @replacement, System.Collections.Hashtable @caps, System.Int32 @capsize, System.Collections.Hashtable @capnames, System.Text.RegularExpressions.RegexOptions @roptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replRef.Value, @replacement, @caps, @capsize, @capnames, @roptions};
            var ___result = RMGetOrCreate_WeakReference_d_RegexReplacement_p__String_Hashtable_Int32_Hashtable_RegexOptions.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement>(___result);
        }


        public virtual void ReplacementImpl(System.Text.StringBuilder @sb, System.Text.RegularExpressions.Match @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @match};
            var ___result = RMReplacementImpl_StringBuilder_Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplacementImplRTL(System.Collections.Generic.List<System.String> @al, System.Text.RegularExpressions.Match @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@al, @match};
            var ___result = RMReplacementImplRTL_List_d_String_p__Match.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Replacement(System.Text.RegularExpressions.Match @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match};
            var ___result = RMReplacement_Match.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String Replace(System.Text.RegularExpressions.Regex @regex, System.String @input, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @input, @count, @startat};
            var ___result = RMReplace_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
