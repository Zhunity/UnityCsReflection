
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules
	/// </summary>
    public partial class RUnicodeLineBreakingRules : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.UnicodeLineBreakingRules);
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


		/// <summary>
		/// UnityEngine.TextCore.Text.UnicodeLineBreakingRules s_Instance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules r_Fs_Instance;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RUnicodeLineBreakingRules RFs_Instance
		{
			get
			{
				if(r_Fs_Instance == null)
				{
					r_Fs_Instance = new(Type, "s_Instance");
				}
				return r_Fs_Instance;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset m_UnicodeLineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAsset r_Fm_UnicodeLineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAsset RFm_UnicodeLineBreakingRules
		{
			get
			{
				if(r_Fm_UnicodeLineBreakingRules == null)
				{
					r_Fm_UnicodeLineBreakingRules = new(this, "m_UnicodeLineBreakingRules");
				}
				return r_Fm_UnicodeLineBreakingRules;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset m_LeadingCharacters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAsset r_Fm_LeadingCharacters;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAsset RFm_LeadingCharacters
		{
			get
			{
				if(r_Fm_LeadingCharacters == null)
				{
					r_Fm_LeadingCharacters = new(this, "m_LeadingCharacters");
				}
				return r_Fm_LeadingCharacters;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset m_FollowingCharacters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAsset r_Fm_FollowingCharacters;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAsset RFm_FollowingCharacters
		{
			get
			{
				if(r_Fm_FollowingCharacters == null)
				{
					r_Fm_FollowingCharacters = new(this, "m_FollowingCharacters");
				}
				return r_Fm_FollowingCharacters;
			}
		}

		/// <summary>
		/// System.Boolean m_UseModernHangulLineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UseModernHangulLineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UseModernHangulLineBreakingRules
		{
			get
			{
				if(r_Fm_UseModernHangulLineBreakingRules == null)
				{
					r_Fm_UseModernHangulLineBreakingRules = new(this, "m_UseModernHangulLineBreakingRules");
				}
				return r_Fm_UseModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] s_LeadingCharactersLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fs_LeadingCharactersLookup;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RFs_LeadingCharactersLookup
		{
			get
			{
				if(r_Fs_LeadingCharactersLookup == null)
				{
					r_Fs_LeadingCharactersLookup = new(Type, "s_LeadingCharactersLookup");
				}
				return r_Fs_LeadingCharactersLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] s_FollowingCharactersLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fs_FollowingCharactersLookup;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RFs_FollowingCharactersLookup
		{
			get
			{
				if(r_Fs_FollowingCharactersLookup == null)
				{
					r_Fs_FollowingCharactersLookup = new(Type, "s_FollowingCharactersLookup");
				}
				return r_Fs_FollowingCharactersLookup;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset lineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAsset r_PlineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAsset RPlineBreakingRules
		{
			get
			{
				if(r_PlineBreakingRules == null)
				{
					r_PlineBreakingRules = new(this, "lineBreakingRules", -1);
				}
				return r_PlineBreakingRules;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset leadingCharacters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAsset r_PleadingCharacters;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAsset RPleadingCharacters
		{
			get
			{
				if(r_PleadingCharacters == null)
				{
					r_PleadingCharacters = new(this, "leadingCharacters", -1);
				}
				return r_PleadingCharacters;
			}
		}

		/// <summary>
		/// UnityEngine.TextAsset followingCharacters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAsset r_PfollowingCharacters;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAsset RPfollowingCharacters
		{
			get
			{
				if(r_PfollowingCharacters == null)
				{
					r_PfollowingCharacters = new(this, "followingCharacters", -1);
				}
				return r_PfollowingCharacters;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] leadingCharactersLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_PleadingCharactersLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RPleadingCharactersLookup
		{
			get
			{
				if(r_PleadingCharactersLookup == null)
				{
					r_PleadingCharactersLookup = new(this, "leadingCharactersLookup", -1);
				}
				return r_PleadingCharactersLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] followingCharactersLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> r_PfollowingCharactersLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RUInt32> RPfollowingCharactersLookup
		{
			get
			{
				if(r_PfollowingCharactersLookup == null)
				{
					r_PfollowingCharactersLookup = new(this, "followingCharactersLookup", -1);
				}
				return r_PfollowingCharactersLookup;
			}
		}

		/// <summary>
		/// Boolean useModernHangulLineBreakingRules
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseModernHangulLineBreakingRules;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseModernHangulLineBreakingRules
		{
			get
			{
				if(r_PuseModernHangulLineBreakingRules == null)
				{
					r_PuseModernHangulLineBreakingRules = new(this, "useModernHangulLineBreakingRules", -1);
				}
				return r_PuseModernHangulLineBreakingRules;
			}
		}

		/// <summary>
		/// Void LoadLineBreakingRules()
		/// </summary>
		protected static RMethod r_MLoadLineBreakingRules;
		public static RMethod RMLoadLineBreakingRules
		{
			get
			{
				if(r_MLoadLineBreakingRules == null)
				{
					r_MLoadLineBreakingRules = new(Type, "LoadLineBreakingRules", 0);
				}
				return r_MLoadLineBreakingRules;
			}
		}

		/// <summary>
		/// Void LoadLineBreakingRules(UnityEngine.TextAsset, UnityEngine.TextAsset)
		/// </summary>
		protected static RMethod r_MLoadLineBreakingRules_TextAsset_TextAsset;
		public static RMethod RMLoadLineBreakingRules_TextAsset_TextAsset
		{
			get
			{
				if(r_MLoadLineBreakingRules_TextAsset_TextAsset == null)
				{
					r_MLoadLineBreakingRules_TextAsset_TextAsset = new(Type, "LoadLineBreakingRules", 0, typeof(UnityEngine.TextAsset), typeof(UnityEngine.TextAsset));
				}
				return r_MLoadLineBreakingRules_TextAsset_TextAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.UInt32] GetCharacters(UnityEngine.TextAsset)
		/// </summary>
		protected static RMethod r_MGetCharacters_TextAsset;
		public static RMethod RMGetCharacters_TextAsset
		{
			get
			{
				if(r_MGetCharacters_TextAsset == null)
				{
					r_MGetCharacters_TextAsset = new(Type, "GetCharacters", 0, typeof(UnityEngine.TextAsset));
				}
				return r_MGetCharacters_TextAsset;
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


        public static void LoadLineBreakingRules()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadLineBreakingRules.Invoke(___genericsType, ___parameters);

            
        }


        public static void LoadLineBreakingRules(UnityEngine.TextAsset @leadingRules, UnityEngine.TextAsset @followingRules)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@leadingRules, @followingRules};
            var ___result = RMLoadLineBreakingRules_TextAsset_TextAsset.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.HashSet<System.UInt32> GetCharacters(UnityEngine.TextAsset @file)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@file};
            var ___result = RMGetCharacters_TextAsset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.HashSet<System.UInt32>>(___result);
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
