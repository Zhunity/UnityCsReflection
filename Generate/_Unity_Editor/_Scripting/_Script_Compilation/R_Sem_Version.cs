
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.Scripting.ScriptCompilation.SemVersion
	/// </summary>
    public partial class RSemVersion : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion");
            }
        }

        public RSemVersion() : base("UnityEditor.Scripting.ScriptCompilation.SemVersion")
        {
        }

        public RSemVersion(System.Object instance) : base("UnityEditor.Scripting.ScriptCompilation.SemVersion")
		{
            SetInstance(instance);
		}

        public RSemVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSemVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean <IsInitialized>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__IsInitialized__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__IsInitialized__1__k__BackingField
		{
			get
			{
				if(r_F__0__IsInitialized__1__k__BackingField == null)
				{
					r_F__0__IsInitialized__1__k__BackingField = new(this, "<IsInitialized>k__BackingField");
				}
				return r_F__0__IsInitialized__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <Major>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__Major__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__Major__1__k__BackingField
		{
			get
			{
				if(r_F__0__Major__1__k__BackingField == null)
				{
					r_F__0__Major__1__k__BackingField = new(this, "<Major>k__BackingField");
				}
				return r_F__0__Major__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <Minor>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__Minor__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__Minor__1__k__BackingField
		{
			get
			{
				if(r_F__0__Minor__1__k__BackingField == null)
				{
					r_F__0__Minor__1__k__BackingField = new(this, "<Minor>k__BackingField");
				}
				return r_F__0__Minor__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <Patch>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__Patch__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__Patch__1__k__BackingField
		{
			get
			{
				if(r_F__0__Patch__1__k__BackingField == null)
				{
					r_F__0__Patch__1__k__BackingField = new(this, "<Patch>k__BackingField");
				}
				return r_F__0__Patch__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Prerelease>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__Prerelease__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__Prerelease__1__k__BackingField
		{
			get
			{
				if(r_F__0__Prerelease__1__k__BackingField == null)
				{
					r_F__0__Prerelease__1__k__BackingField = new(this, "<Prerelease>k__BackingField");
				}
				return r_F__0__Prerelease__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Build>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__Build__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__Build__1__k__BackingField
		{
			get
			{
				if(r_F__0__Build__1__k__BackingField == null)
				{
					r_F__0__Build__1__k__BackingField = new(this, "<Build>k__BackingField");
				}
				return r_F__0__Build__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Scripting.ScriptCompilation.SemVersionTypeTraits <VersionTypeTraits>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersionTypeTraits r_F__0__VersionTypeTraits__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersionTypeTraits RF__0__VersionTypeTraits__1__k__BackingField
		{
			get
			{
				if(r_F__0__VersionTypeTraits__1__k__BackingField == null)
				{
					r_F__0__VersionTypeTraits__1__k__BackingField = new(Type, "<VersionTypeTraits>k__BackingField");
				}
				return r_F__0__VersionTypeTraits__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean IsInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsInitialized
		{
			get
			{
				if(r_PIsInitialized == null)
				{
					r_PIsInitialized = new(this, "IsInitialized", -1);
				}
				return r_PIsInitialized;
			}
		}

		/// <summary>
		/// Int32 Major
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMajor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMajor
		{
			get
			{
				if(r_PMajor == null)
				{
					r_PMajor = new(this, "Major", -1);
				}
				return r_PMajor;
			}
		}

		/// <summary>
		/// Int32 Minor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMinor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMinor
		{
			get
			{
				if(r_PMinor == null)
				{
					r_PMinor = new(this, "Minor", -1);
				}
				return r_PMinor;
			}
		}

		/// <summary>
		/// Int32 Patch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PPatch;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPPatch
		{
			get
			{
				if(r_PPatch == null)
				{
					r_PPatch = new(this, "Patch", -1);
				}
				return r_PPatch;
			}
		}

		/// <summary>
		/// System.String Prerelease
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPrerelease;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPrerelease
		{
			get
			{
				if(r_PPrerelease == null)
				{
					r_PPrerelease = new(this, "Prerelease", -1);
				}
				return r_PPrerelease;
			}
		}

		/// <summary>
		/// System.String Build
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PBuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPBuild
		{
			get
			{
				if(r_PBuild == null)
				{
					r_PBuild = new(this, "Build", -1);
				}
				return r_PBuild;
			}
		}

		/// <summary>
		/// UnityEditor.Scripting.ScriptCompilation.SemVersionTypeTraits VersionTypeTraits
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersionTypeTraits r_PVersionTypeTraits;
		public static Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersionTypeTraits RPVersionTypeTraits
		{
			get
			{
				if(r_PVersionTypeTraits == null)
				{
					r_PVersionTypeTraits = new(Type, "VersionTypeTraits", -1);
				}
				return r_PVersionTypeTraits;
			}
		}

		/// <summary>
		/// Int32 Compare(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_MCompare_SemVersion_SemVersion;
		public static RMethod RMCompare_SemVersion_SemVersion
		{
			get
			{
				if(r_MCompare_SemVersion_SemVersion == null)
				{
					r_MCompare_SemVersion_SemVersion = new(Type, "Compare", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_MCompare_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_Mop_Equality_SemVersion_SemVersion;
		public static RMethod RMop_Equality_SemVersion_SemVersion
		{
			get
			{
				if(r_Mop_Equality_SemVersion_SemVersion == null)
				{
					r_Mop_Equality_SemVersion_SemVersion = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_Mop_Equality_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_Mop_Inequality_SemVersion_SemVersion;
		public static RMethod RMop_Inequality_SemVersion_SemVersion
		{
			get
			{
				if(r_Mop_Inequality_SemVersion_SemVersion == null)
				{
					r_Mop_Inequality_SemVersion_SemVersion = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_Mop_Inequality_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_SemVersion_SemVersion;
		public static RMethod RMop_GreaterThan_SemVersion_SemVersion
		{
			get
			{
				if(r_Mop_GreaterThan_SemVersion_SemVersion == null)
				{
					r_Mop_GreaterThan_SemVersion_SemVersion = new(Type, "op_GreaterThan", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_Mop_GreaterThan_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_SemVersion_SemVersion;
		public static RMethod RMop_GreaterThanOrEqual_SemVersion_SemVersion
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_SemVersion_SemVersion == null)
				{
					r_Mop_GreaterThanOrEqual_SemVersion_SemVersion = new(Type, "op_GreaterThanOrEqual", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_Mop_GreaterThanOrEqual_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_Mop_LessThan_SemVersion_SemVersion;
		public static RMethod RMop_LessThan_SemVersion_SemVersion
		{
			get
			{
				if(r_Mop_LessThan_SemVersion_SemVersion == null)
				{
					r_Mop_LessThan_SemVersion_SemVersion = new(Type, "op_LessThan", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_Mop_LessThan_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(UnityEditor.Scripting.ScriptCompilation.SemVersion, UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_SemVersion_SemVersion;
		public static RMethod RMop_LessThanOrEqual_SemVersion_SemVersion
		{
			get
			{
				if(r_Mop_LessThanOrEqual_SemVersion_SemVersion == null)
				{
					r_Mop_LessThanOrEqual_SemVersion_SemVersion = new(Type, "op_LessThanOrEqual", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"),  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_Mop_LessThanOrEqual_SemVersion_SemVersion;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected RMethod r_MCompareTo_SemVersion;
		public virtual RMethod RMCompareTo_SemVersion
		{
			get
			{
				if(r_MCompareTo_SemVersion == null)
				{
					r_MCompareTo_SemVersion = new(this, "CompareTo", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_MCompareTo_SemVersion;
			}
		}

		/// <summary>
		/// Int32 CompareExtension(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCompareExtension_String_String_Boolean;
		public static RMethod RMCompareExtension_String_String_Boolean
		{
			get
			{
				if(r_MCompareExtension_String_String_Boolean == null)
				{
					r_MCompareExtension_String_String_Boolean = new(Type, "CompareExtension", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MCompareExtension_String_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEditor.Scripting.ScriptCompilation.SemVersion)
		/// </summary>
		protected RMethod r_MEquals_SemVersion;
		public virtual RMethod RMEquals_SemVersion
		{
			get
			{
				if(r_MEquals_SemVersion == null)
				{
					r_MEquals_SemVersion = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEditor.Scripting.ScriptCompilation.SemVersion"));
				}
				return r_MEquals_SemVersion;
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
		/// UnityEditor.Scripting.ScriptCompilation.SemVersion Parse(System.String, Boolean)
		/// </summary>
		protected RMethod r_MParse_String_Boolean;
		public virtual RMethod RMParse_String_Boolean
		{
			get
			{
				if(r_MParse_String_Boolean == null)
				{
					r_MParse_String_Boolean = new(this, "Parse", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MParse_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.Scripting.ScriptCompilation.IVersionTypeTraits GetVersionTypeTraits()
		/// </summary>
		protected RMethod r_MGetVersionTypeTraits;
		public virtual RMethod RMGetVersionTypeTraits
		{
			get
			{
				if(r_MGetVersionTypeTraits == null)
				{
					r_MGetVersionTypeTraits = new(this, "GetVersionTypeTraits", 0);
				}
				return r_MGetVersionTypeTraits;
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


        public static System.Int32 Compare(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @versionA, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @versionB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@versionA.Value, @versionB.Value};
            var ___result = RMCompare_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @left, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @left, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_GreaterThan(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @left, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_GreaterThan_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_GreaterThanOrEqual(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @left, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_GreaterThanOrEqual_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_LessThan(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @left, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_LessThan_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_LessThanOrEqual(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @left, Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_LessThanOrEqual_SemVersion_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCompareTo_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 CompareExtension(System.String @current, System.String @other, System.Boolean @lower)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @other, @lower};
            var ___result = RMCompareExtension_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_SemVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion Parse(System.String @version, System.Boolean @strict)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version, @strict};
            var ___result = RMParse_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RIVersionTypeTraits GetVersionTypeTraits()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVersionTypeTraits.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RIVersionTypeTraits>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
