
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PropertyDrawer
	/// </summary>
    public partial class RPropertyDrawer : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PropertyDrawer);
            }
        }

        public RPropertyDrawer() : base("UnityEditor.PropertyDrawer")
        {
        }

        public RPropertyDrawer(System.Object instance) : base("UnityEditor.PropertyDrawer")
		{
            SetInstance(instance);
		}

        public RPropertyDrawer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyDrawer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.PropertyAttribute m_Attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute r_Fm_Attribute;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute RFm_Attribute
		{
			get
			{
				if(r_Fm_Attribute == null)
				{
					r_Fm_Attribute = new(this, "m_Attribute");
				}
				return r_Fm_Attribute;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo m_FieldInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo r_Fm_FieldInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo RFm_FieldInfo
		{
			get
			{
				if(r_Fm_FieldInfo == null)
				{
					r_Fm_FieldInfo = new(this, "m_FieldInfo");
				}
				return r_Fm_FieldInfo;
			}
		}

		/// <summary>
		/// System.String m_PreferredLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PreferredLabel;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PreferredLabel
		{
			get
			{
				if(r_Fm_PreferredLabel == null)
				{
					r_Fm_PreferredLabel = new(this, "m_PreferredLabel");
				}
				return r_Fm_PreferredLabel;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyAttribute attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute r_Pattribute;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute RPattribute
		{
			get
			{
				if(r_Pattribute == null)
				{
					r_Pattribute = new(this, "attribute", -1);
				}
				return r_Pattribute;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo fieldInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo r_PfieldInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo RPfieldInfo
		{
			get
			{
				if(r_PfieldInfo == null)
				{
					r_PfieldInfo = new(this, "fieldInfo", -1);
				}
				return r_PfieldInfo;
			}
		}

		/// <summary>
		/// System.String preferredLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpreferredLabel;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpreferredLabel
		{
			get
			{
				if(r_PpreferredLabel == null)
				{
					r_PpreferredLabel = new(this, "preferredLabel", -1);
				}
				return r_PpreferredLabel;
			}
		}

		/// <summary>
		/// Void OnGUISafe(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MOnGUISafe_Rect_SerializedProperty_GUIContent;
		public virtual RMethod RMOnGUISafe_Rect_SerializedProperty_GUIContent
		{
			get
			{
				if(r_MOnGUISafe_Rect_SerializedProperty_GUIContent == null)
				{
					r_MOnGUISafe_Rect_SerializedProperty_GUIContent = new(this, "OnGUISafe", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
				}
				return r_MOnGUISafe_Rect_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// Void OnGUI(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MOnGUI_Rect_SerializedProperty_GUIContent;
		public virtual RMethod RMOnGUI_Rect_SerializedProperty_GUIContent
		{
			get
			{
				if(r_MOnGUI_Rect_SerializedProperty_GUIContent == null)
				{
					r_MOnGUI_Rect_SerializedProperty_GUIContent = new(this, "OnGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
				}
				return r_MOnGUI_Rect_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePropertyGUI(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCreatePropertyGUI_SerializedProperty;
		public virtual RMethod RMCreatePropertyGUI_SerializedProperty
		{
			get
			{
				if(r_MCreatePropertyGUI_SerializedProperty == null)
				{
					r_MCreatePropertyGUI_SerializedProperty = new(this, "CreatePropertyGUI", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCreatePropertyGUI_SerializedProperty;
			}
		}

		/// <summary>
		/// Single GetPropertyHeightSafe(UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MGetPropertyHeightSafe_SerializedProperty_GUIContent;
		public virtual RMethod RMGetPropertyHeightSafe_SerializedProperty_GUIContent
		{
			get
			{
				if(r_MGetPropertyHeightSafe_SerializedProperty_GUIContent == null)
				{
					r_MGetPropertyHeightSafe_SerializedProperty_GUIContent = new(this, "GetPropertyHeightSafe", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
				}
				return r_MGetPropertyHeightSafe_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// Single GetPropertyHeight(UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MGetPropertyHeight_SerializedProperty_GUIContent;
		public virtual RMethod RMGetPropertyHeight_SerializedProperty_GUIContent
		{
			get
			{
				if(r_MGetPropertyHeight_SerializedProperty_GUIContent == null)
				{
					r_MGetPropertyHeight_SerializedProperty_GUIContent = new(this, "GetPropertyHeight", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
				}
				return r_MGetPropertyHeight_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUISafe(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCanCacheInspectorGUISafe_SerializedProperty;
		public virtual RMethod RMCanCacheInspectorGUISafe_SerializedProperty
		{
			get
			{
				if(r_MCanCacheInspectorGUISafe_SerializedProperty == null)
				{
					r_MCanCacheInspectorGUISafe_SerializedProperty = new(this, "CanCacheInspectorGUISafe", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCanCacheInspectorGUISafe_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCanCacheInspectorGUI_SerializedProperty;
		public virtual RMethod RMCanCacheInspectorGUI_SerializedProperty
		{
			get
			{
				if(r_MCanCacheInspectorGUI_SerializedProperty == null)
				{
					r_MCanCacheInspectorGUI_SerializedProperty = new(this, "CanCacheInspectorGUI", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCanCacheInspectorGUI_SerializedProperty;
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


        public virtual void OnGUISafe(UnityEngine.Rect @position, UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label};
            var ___result = RMOnGUISafe_Rect_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI(UnityEngine.Rect @position, UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label};
            var ___result = RMOnGUI_Rect_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreatePropertyGUI(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMCreatePropertyGUI_SerializedProperty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Single GetPropertyHeightSafe(UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label};
            var ___result = RMGetPropertyHeightSafe_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single GetPropertyHeight(UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label};
            var ___result = RMGetPropertyHeight_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Boolean CanCacheInspectorGUISafe(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMCanCacheInspectorGUISafe_SerializedProperty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMCanCacheInspectorGUI_SerializedProperty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
