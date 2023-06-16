
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
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
		/// System.Int32[] s_ResolvedDarkStyleSheetIds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fs_ResolvedDarkStyleSheetIds;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFs_ResolvedDarkStyleSheetIds
		{
			get
			{
				if(r_Fs_ResolvedDarkStyleSheetIds == null)
				{
					r_Fs_ResolvedDarkStyleSheetIds = new(Type, "s_ResolvedDarkStyleSheetIds");
				}
				return r_Fs_ResolvedDarkStyleSheetIds;
			}
		}

		/// <summary>
		/// System.Int32[] s_ResolvedLightStyleSheetIds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fs_ResolvedLightStyleSheetIds;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFs_ResolvedLightStyleSheetIds
		{
			get
			{
				if(r_Fs_ResolvedLightStyleSheetIds == null)
				{
					r_Fs_ResolvedLightStyleSheetIds = new(Type, "s_ResolvedLightStyleSheetIds");
				}
				return r_Fs_ResolvedLightStyleSheetIds;
			}
		}

		/// <summary>
		/// System.Int32[] m_SerializedResolvedDarkStyleSheetIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_SerializedResolvedDarkStyleSheetIds;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_SerializedResolvedDarkStyleSheetIds
		{
			get
			{
				if(r_Fm_SerializedResolvedDarkStyleSheetIds == null)
				{
					r_Fm_SerializedResolvedDarkStyleSheetIds = new(this, "m_SerializedResolvedDarkStyleSheetIds");
				}
				return r_Fm_SerializedResolvedDarkStyleSheetIds;
			}
		}

		/// <summary>
		/// System.Int32[] m_SerializedResolvedLightStyleSheetIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_SerializedResolvedLightStyleSheetIds;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_SerializedResolvedLightStyleSheetIds
		{
			get
			{
				if(r_Fm_SerializedResolvedLightStyleSheetIds == null)
				{
					r_Fm_SerializedResolvedLightStyleSheetIds = new(this, "m_SerializedResolvedLightStyleSheetIds");
				}
				return r_Fm_SerializedResolvedLightStyleSheetIds;
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
		/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy m_ApplicationProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy r_Fm_ApplicationProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy RFm_ApplicationProxy
		{
			get
			{
				if(r_Fm_ApplicationProxy == null)
				{
					r_Fm_ApplicationProxy = new(this, "m_ApplicationProxy");
				}
				return r_Fm_ApplicationProxy;
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
		/// Int32[] resolvedStyleSheetIds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_PresolvedStyleSheetIds;
		public static Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPresolvedStyleSheetIds
		{
			get
			{
				if(r_PresolvedStyleSheetIds == null)
				{
					r_PresolvedStyleSheetIds = new(Type, "resolvedStyleSheetIds", -1);
				}
				return r_PresolvedStyleSheetIds;
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
		/// UnityEngine.UIElements.StyleSheet inProgressDropdownStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_PinProgressDropdownStyleSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RPinProgressDropdownStyleSheet
		{
			get
			{
				if(r_PinProgressDropdownStyleSheet == null)
				{
					r_PinProgressDropdownStyleSheet = new(this, "inProgressDropdownStyleSheet", -1);
				}
				return r_PinProgressDropdownStyleSheet;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet FindResolvedStyleSheetFromType(StyleSheetType)
		/// </summary>
		protected RMethod r_MFindResolvedStyleSheetFromType_StyleSheetType;
		public virtual RMethod RMFindResolvedStyleSheetFromType_StyleSheetType
		{
			get
			{
				if(r_MFindResolvedStyleSheetFromType_StyleSheetType == null)
				{
					r_MFindResolvedStyleSheetFromType_StyleSheetType = new(this, "FindResolvedStyleSheetFromType", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ResourceLoader+StyleSheetType"));
				}
				return r_MFindResolvedStyleSheetFromType_StyleSheetType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet ResolveStyleSheets(StyleSheetType, System.String[])
		/// </summary>
		protected RMethod r_MResolveStyleSheets_StyleSheetType_StringArray;
		public virtual RMethod RMResolveStyleSheets_StyleSheetType_StringArray
		{
			get
			{
				if(r_MResolveStyleSheets_StyleSheetType_StringArray == null)
				{
					r_MResolveStyleSheets_StyleSheetType_StringArray = new(this, "ResolveStyleSheets", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ResourceLoader+StyleSheetType"), typeof(System.String).MakeArrayType());
				}
				return r_MResolveStyleSheets_StyleSheetType_StringArray;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet ResolveStyleSheets(StyleSheetType, UnityEngine.UIElements.StyleSheet[])
		/// </summary>
		protected RMethod r_MResolveStyleSheets_StyleSheetType_StyleSheetArray;
		public virtual RMethod RMResolveStyleSheets_StyleSheetType_StyleSheetArray
		{
			get
			{
				if(r_MResolveStyleSheets_StyleSheetType_StyleSheetArray == null)
				{
					r_MResolveStyleSheets_StyleSheetType_StyleSheetArray = new(this, "ResolveStyleSheets", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ResourceLoader+StyleSheetType"), typeof(UnityEngine.UIElements.StyleSheet).MakeArrayType());
				}
				return r_MResolveStyleSheets_StyleSheetType_StyleSheetArray;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.ApplicationProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_ApplicationProxy;
		public virtual RMethod RMResolveDependencies_ApplicationProxy
		{
			get
			{
				if(r_MResolveDependencies_ApplicationProxy == null)
				{
					r_MResolveDependencies_ApplicationProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"));
				}
				return r_MResolveDependencies_ApplicationProxy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTemplate(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetTemplate_String_Boolean;
		public virtual RMethod RMGetTemplate_String_Boolean
		{
			get
			{
				if(r_MGetTemplate_String_Boolean == null)
				{
					r_MGetTemplate_String_Boolean = new(this, "GetTemplate", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetTemplate_String_Boolean;
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
		/// UnityEngine.UIElements.StyleSheet <get_packageManagerWindowStyleSheet>b__17_0(System.String)
		/// </summary>
		protected RMethod r_M__0__get_packageManagerWindowStyleSheet__1__b__17_0_String;
		public virtual RMethod RM__0__get_packageManagerWindowStyleSheet__1__b__17_0_String
		{
			get
			{
				if(r_M__0__get_packageManagerWindowStyleSheet__1__b__17_0_String == null)
				{
					r_M__0__get_packageManagerWindowStyleSheet__1__b__17_0_String = new(this, "<get_packageManagerWindowStyleSheet>b__17_0", 0, typeof(System.String));
				}
				return r_M__0__get_packageManagerWindowStyleSheet__1__b__17_0_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet <ResolveStyleSheets>b__24_0(System.String)
		/// </summary>
		protected RMethod r_M__0__ResolveStyleSheets__1__b__24_0_String;
		public virtual RMethod RM__0__ResolveStyleSheets__1__b__24_0_String
		{
			get
			{
				if(r_M__0__ResolveStyleSheets__1__b__24_0_String == null)
				{
					r_M__0__ResolveStyleSheets__1__b__24_0_String = new(this, "<ResolveStyleSheets>b__24_0", 0, typeof(System.String));
				}
				return r_M__0__ResolveStyleSheets__1__b__24_0_String;
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


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.StyleSheet FindResolvedStyleSheetFromType(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RResourceLoader.RStyleSheetType @styleSheetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheetType.Value};
            var ___result = RMFindResolvedStyleSheetFromType_StyleSheetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
        }


        public virtual UnityEngine.UIElements.StyleSheet ResolveStyleSheets(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RResourceLoader.RStyleSheetType @styleSheetType, System.String[] @styleSheetPaths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheetType.Value, @styleSheetPaths};
            var ___result = RMResolveStyleSheets_StyleSheetType_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
        }


        public virtual UnityEngine.UIElements.StyleSheet ResolveStyleSheets(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RResourceLoader.RStyleSheetType @styleSheetType, UnityEngine.UIElements.StyleSheet[] @styleSheets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheetType.Value, @styleSheets};
            var ___result = RMResolveStyleSheets_StyleSheetType_StyleSheetArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
        }


        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @applicationProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@applicationProxy.Value};
            var ___result = RMResolveDependencies_ApplicationProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement GetTemplate(System.String @templateFilename, System.Boolean @shouldThrowException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateFilename, @shouldThrowException};
            var ___result = RMGetTemplate_String_Boolean.Invoke(___genericsType, ___parameters);

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


        public virtual UnityEngine.UIElements.StyleSheet __0__get_packageManagerWindowStyleSheet__1__b__17_0(System.String @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RM__0__get_packageManagerWindowStyleSheet__1__b__17_0_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
        }


        public virtual UnityEngine.UIElements.StyleSheet __0__ResolveStyleSheets__1__b__24_0(System.String @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RM__0__ResolveStyleSheets__1__b__24_0_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleSheet>(___result);
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
