using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules
	/// </summary>
    public partial class RUnicodeLineBreakingRules : RMember //
    {

		/// <summary>
		/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules s_Instance
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules r_s_Instance;
		public static RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules Rs_Instance
		{
			get
			{
				if(r_s_Instance == null)
				{
					r_s_Instance = new(typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules), "s_Instance");
					r_s_Instance.SetBelong(null);
				}
				return r_s_Instance;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset m_UnicodeLineBreakingRules
		/// </summary>
		protected RUnityEngine.RTextAsset r_m_UnicodeLineBreakingRules;
		public virtual RUnityEngine.RTextAsset Rm_UnicodeLineBreakingRules
		{
			get
			{
				if(r_m_UnicodeLineBreakingRules == null)
				{
					r_m_UnicodeLineBreakingRules = new(this, "m_UnicodeLineBreakingRules");
					r_m_UnicodeLineBreakingRules.SetBelong(this.instance);
				}
				return r_m_UnicodeLineBreakingRules;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset m_LeadingCharacters
		/// </summary>
		protected RUnityEngine.RTextAsset r_m_LeadingCharacters;
		public virtual RUnityEngine.RTextAsset Rm_LeadingCharacters
		{
			get
			{
				if(r_m_LeadingCharacters == null)
				{
					r_m_LeadingCharacters = new(this, "m_LeadingCharacters");
					r_m_LeadingCharacters.SetBelong(this.instance);
				}
				return r_m_LeadingCharacters;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset m_FollowingCharacters
		/// </summary>
		protected RUnityEngine.RTextAsset r_m_FollowingCharacters;
		public virtual RUnityEngine.RTextAsset Rm_FollowingCharacters
		{
			get
			{
				if(r_m_FollowingCharacters == null)
				{
					r_m_FollowingCharacters = new(this, "m_FollowingCharacters");
					r_m_FollowingCharacters.SetBelong(this.instance);
				}
				return r_m_FollowingCharacters;
			}
		}

		/// <summary>
		/// System.Boolean m_UseModernHangulLineBreakingRules
		/// </summary>
		protected RSystem.RBoolean r_m_UseModernHangulLineBreakingRules;
		public virtual RSystem.RBoolean Rm_UseModernHangulLineBreakingRules
		{
			get
			{
				if(r_m_UseModernHangulLineBreakingRules == null)
				{
					r_m_UseModernHangulLineBreakingRules = new(this, "m_UseModernHangulLineBreakingRules");
					r_m_UseModernHangulLineBreakingRules.SetBelong(this.instance);
				}
				return r_m_UseModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] s_LeadingCharactersLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_s_LeadingCharactersLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> Rs_LeadingCharactersLookup
		{
			get
			{
				if(r_s_LeadingCharactersLookup == null)
				{
					r_s_LeadingCharactersLookup = new(typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules), "s_LeadingCharactersLookup");
					r_s_LeadingCharactersLookup.SetBelong(null);
				}
				return r_s_LeadingCharactersLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] s_FollowingCharactersLookup
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_s_FollowingCharactersLookup;
		public static RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> Rs_FollowingCharactersLookup
		{
			get
			{
				if(r_s_FollowingCharactersLookup == null)
				{
					r_s_FollowingCharactersLookup = new(typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules), "s_FollowingCharactersLookup");
					r_s_FollowingCharactersLookup.SetBelong(null);
				}
				return r_s_FollowingCharactersLookup;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset lineBreakingRules
		/// </summary>
		protected RUnityEngine.RTextAsset r_lineBreakingRules;
		public virtual RUnityEngine.RTextAsset RlineBreakingRules
		{
			get
			{
				if(r_lineBreakingRules == null)
				{
					r_lineBreakingRules = new(this, "lineBreakingRules", -1);
					r_lineBreakingRules.SetBelong(this.instance);
				}
				return r_lineBreakingRules;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset leadingCharacters
		/// </summary>
		protected RUnityEngine.RTextAsset r_leadingCharacters;
		public virtual RUnityEngine.RTextAsset RleadingCharacters
		{
			get
			{
				if(r_leadingCharacters == null)
				{
					r_leadingCharacters = new(this, "leadingCharacters", -1);
					r_leadingCharacters.SetBelong(this.instance);
				}
				return r_leadingCharacters;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset followingCharacters
		/// </summary>
		protected RUnityEngine.RTextAsset r_followingCharacters;
		public virtual RUnityEngine.RTextAsset RfollowingCharacters
		{
			get
			{
				if(r_followingCharacters == null)
				{
					r_followingCharacters = new(this, "followingCharacters", -1);
					r_followingCharacters.SetBelong(this.instance);
				}
				return r_followingCharacters;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] leadingCharactersLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_leadingCharactersLookup;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> RleadingCharactersLookup
		{
			get
			{
				if(r_leadingCharactersLookup == null)
				{
					r_leadingCharactersLookup = new(this, "leadingCharactersLookup", -1);
					r_leadingCharactersLookup.SetBelong(this.instance);
				}
				return r_leadingCharactersLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] followingCharactersLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> r_followingCharactersLookup;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RSystem.RUInt32> RfollowingCharactersLookup
		{
			get
			{
				if(r_followingCharactersLookup == null)
				{
					r_followingCharactersLookup = new(this, "followingCharactersLookup", -1);
					r_followingCharactersLookup.SetBelong(this.instance);
				}
				return r_followingCharactersLookup;
			}
		}

		/// <summary>
		/// Boolean useModernHangulLineBreakingRules
		/// </summary>
		protected RSystem.RBoolean r_useModernHangulLineBreakingRules;
		public virtual RSystem.RBoolean RuseModernHangulLineBreakingRules
		{
			get
			{
				if(r_useModernHangulLineBreakingRules == null)
				{
					r_useModernHangulLineBreakingRules = new(this, "useModernHangulLineBreakingRules", -1);
					r_useModernHangulLineBreakingRules.SetBelong(this.instance);
				}
				return r_useModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// Void LoadLineBreakingRules()
		/// </summary>
		protected static RMethod r_LoadLineBreakingRules;
		public static RMethod RLoadLineBreakingRules
		{
			get
			{
				if(r_LoadLineBreakingRules == null)
				{
					r_LoadLineBreakingRules = new(typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules), "LoadLineBreakingRules", 0);
					r_LoadLineBreakingRules.SetBelong(null);
				}
				return r_LoadLineBreakingRules;
			}
		}

		/// <summary>
		/// Void LoadLineBreakingRules(UnityEngine.TextAsset, UnityEngine.TextAsset)
		/// </summary>
		protected static RMethod r_LoadLineBreakingRules_TextAsset_TextAsset;
		public static RMethod RLoadLineBreakingRules_TextAsset_TextAsset
		{
			get
			{
				if(r_LoadLineBreakingRules_TextAsset_TextAsset == null)
				{
					r_LoadLineBreakingRules_TextAsset_TextAsset = new(typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules), "LoadLineBreakingRules", 0, typeof(UnityEngine.TextAsset), typeof(UnityEngine.TextAsset));
					r_LoadLineBreakingRules_TextAsset_TextAsset.SetBelong(null);
				}
				return r_LoadLineBreakingRules_TextAsset_TextAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] GetCharacters(UnityEngine.TextAsset)
		/// </summary>
		protected static RMethod r_GetCharacters_TextAsset;
		public static RMethod RGetCharacters_TextAsset
		{
			get
			{
				if(r_GetCharacters_TextAsset == null)
				{
					r_GetCharacters_TextAsset = new(typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules), "GetCharacters", 0, typeof(UnityEngine.TextAsset));
					r_GetCharacters_TextAsset.SetBelong(null);
				}
				return r_GetCharacters_TextAsset;
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


        public RUnicodeLineBreakingRules() : base("UnityEngine.TextCore.Text.UnicodeLineBreakingRules")
        {
        }

        public RUnicodeLineBreakingRules(System.Object instance) : base("UnityEngine.TextCore.Text.UnicodeLineBreakingRules")
		{
            SetInstance(instance);
		}

        public RUnicodeLineBreakingRules(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnicodeLineBreakingRules(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void LoadLineBreakingRules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadLineBreakingRules.Invoke(___genericsType, ___parameters);

            
        }


        public static void LoadLineBreakingRules(UnityEngine.TextAsset @leadingRules, UnityEngine.TextAsset @followingRules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leadingRules, @followingRules};
            var ___result = RLoadLineBreakingRules_TextAsset_TextAsset.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.HashSet<System.UInt32> GetCharacters(UnityEngine.TextAsset @file)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@file};
            var ___result = RGetCharacters_TextAsset.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.HashSet<System.UInt32>)___result;
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
