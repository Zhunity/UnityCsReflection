
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.ResourceLoader
	/// </summary>
    public partial class RResourceLoader : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ResourceLoader");
            }
        }

        public RResourceLoader() : base("UnityEditor.PackageManager.UI.Internal.ResourceLoader")
        {
        }

        public RResourceLoader(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ResourceLoader")
		{
            SetInstance(instance);
		}

        public RResourceLoader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RResourceLoader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String k_TemplateRoot
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_TemplateRoot;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_TemplateRoot
		{
			get
			{
				if(r_Fk_TemplateRoot == null)
				{
					r_Fk_TemplateRoot = new(Type, "k_TemplateRoot");
				}
				return r_Fk_TemplateRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet[] m_ResolvedDarkStyleSheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_Fm_ResolvedDarkStyleSheets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RFm_ResolvedDarkStyleSheets
		{
			get
			{
				if(r_Fm_ResolvedDarkStyleSheets == null)
				{
					r_Fm_ResolvedDarkStyleSheets = new(this, "m_ResolvedDarkStyleSheets");
				}
				return r_Fm_ResolvedDarkStyleSheets;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet[] m_ResolvedLightStyleSheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_Fm_ResolvedLightStyleSheets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RFm_ResolvedLightStyleSheets
		{
			get
			{
				if(r_Fm_ResolvedLightStyleSheets == null)
				{
					r_Fm_ResolvedLightStyleSheets = new(this, "m_ResolvedLightStyleSheets");
				}
				return r_Fm_ResolvedLightStyleSheets;
			}
		}

		/// <summary>
		/// System.Int32 m_NestedGetTemplateDepth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NestedGetTemplateDepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NestedGetTemplateDepth
		{
			get
			{
				if(r_Fm_NestedGetTemplateDepth == null)
				{
					r_Fm_NestedGetTemplateDepth = new(this, "m_NestedGetTemplateDepth");
				}
				return r_Fm_NestedGetTemplateDepth;
			}
		}

		/// <summary>
		/// System.String lightOrDarkTheme
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_PlightOrDarkTheme;
		public static Hvak.Editor.Refleaction.RSystem.RString RPlightOrDarkTheme
		{
			get
			{
				if(r_PlightOrDarkTheme == null)
				{
					r_PlightOrDarkTheme = new(Type, "lightOrDarkTheme", -1);
				}
				return r_PlightOrDarkTheme;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet[] resolvedStyleSheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_PresolvedStyleSheets;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RPresolvedStyleSheets
		{
			get
			{
				if(r_PresolvedStyleSheets == null)
				{
					r_PresolvedStyleSheets = new(this, "resolvedStyleSheets", -1);
				}
				return r_PresolvedStyleSheets;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet packageManagerCommonStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PpackageManagerCommonStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPpackageManagerCommonStyleSheet
		{
			get
			{
				if(r_PpackageManagerCommonStyleSheet == null)
				{
					r_PpackageManagerCommonStyleSheet = new(this, "packageManagerCommonStyleSheet", -1);
				}
				return r_PpackageManagerCommonStyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet packageManagerWindowStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PpackageManagerWindowStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPpackageManagerWindowStyleSheet
		{
			get
			{
				if(r_PpackageManagerWindowStyleSheet == null)
				{
					r_PpackageManagerWindowStyleSheet = new(this, "packageManagerWindowStyleSheet", -1);
				}
				return r_PpackageManagerWindowStyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet filtersDropdownStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PfiltersDropdownStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPfiltersDropdownStyleSheet
		{
			get
			{
				if(r_PfiltersDropdownStyleSheet == null)
				{
					r_PfiltersDropdownStyleSheet = new(this, "filtersDropdownStyleSheet", -1);
				}
				return r_PfiltersDropdownStyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet inputDropdownStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PinputDropdownStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPinputDropdownStyleSheet
		{
			get
			{
				if(r_PinputDropdownStyleSheet == null)
				{
					r_PinputDropdownStyleSheet = new(this, "inputDropdownStyleSheet", -1);
				}
				return r_PinputDropdownStyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet ResolveStyleSheets(System.String[])
		/// </summary>
		protected static RMethod r_MResolveStyleSheets_StringArray;
		public static RMethod RMResolveStyleSheets_StringArray
		{
			get
			{
				if(r_MResolveStyleSheets_StringArray == null)
				{
					r_MResolveStyleSheets_StringArray = new(Type, "ResolveStyleSheets", 0, typeof(System.String).MakeArrayType());
				}
				return r_MResolveStyleSheets_StringArray;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet ResolveStyleSheets(UnityEngine.UIElements.StyleSheet[])
		/// </summary>
		protected static RMethod r_MResolveStyleSheets_StyleSheetArray;
		public static RMethod RMResolveStyleSheets_StyleSheetArray
		{
			get
			{
				if(r_MResolveStyleSheets_StyleSheetArray == null)
				{
					r_MResolveStyleSheets_StyleSheetArray = new(Type, "ResolveStyleSheets", 0, typeof(UnityEngine.UIElements.StyleSheet).MakeArrayType());
				}
				return r_MResolveStyleSheets_StyleSheetArray;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTemplate(System.String)
		/// </summary>
		protected RMethod r_MGetTemplate_String;
		public virtual RMethod RMGetTemplate_String
		{
			get
			{
				if(r_MGetTemplate_String == null)
				{
					r_MGetTemplate_String = new(this, "GetTemplate", 0, typeof(System.String));
				}
				return r_MGetTemplate_String;
			}
		}

		/// <summary>
		/// Void LocalizeVisualElement(UnityEngine.UIElements.VisualElement, System.Func`2[System.String,System.String])
		/// </summary>
		protected RMethod r_MLocalizeVisualElement_VisualElement_Func_d_String_String_p_;
		public virtual RMethod RMLocalizeVisualElement_VisualElement_Func_d_String_String_p_
		{
			get
			{
				if(r_MLocalizeVisualElement_VisualElement_Func_d_String_String_p_ == null)
				{
					r_MLocalizeVisualElement_VisualElement_Func_d_String_String_p_ = new(this, "LocalizeVisualElement", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.String), typeof(System.String)));
				}
				return r_MLocalizeVisualElement_VisualElement_Func_d_String_String_p_;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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


		public static UnityEngine.UIElements.StyleSheet ResolveStyleSheets(System.String[] @styleSheetPaths)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@styleSheetPaths};
			var ___result = RMResolveStyleSheets_StringArray.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
		}


		public static UnityEngine.UIElements.StyleSheet ResolveStyleSheets(UnityEngine.UIElements.StyleSheet[] @styleSheets)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@styleSheets};
			var ___result = RMResolveStyleSheets_StyleSheetArray.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
		}


		public virtual UnityEngine.UIElements.VisualElement GetTemplate(System.String @templateFilename)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@templateFilename};
			var ___result = RMGetTemplate_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
		}


		public virtual void LocalizeVisualElement(UnityEngine.UIElements.VisualElement @visualElement, System.Func<System.String, System.String> @l10nFunc)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@visualElement, @l10nFunc};
			var ___result = RMLocalizeVisualElement_VisualElement_Func_d_String_String_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual void Reset()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMReset.Invoke(___genericsType, ___parameters);
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
