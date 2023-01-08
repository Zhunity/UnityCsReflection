using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PropertyDrawer
	/// </summary>
    public partial class RPropertyDrawer : RMember //
    {

		/// <summary>
		/// UnityEngine.PropertyAttribute m_Attribute
		/// </summary>
		protected RUnityEngine.RPropertyAttribute r_m_Attribute;
		public virtual RUnityEngine.RPropertyAttribute Rm_Attribute
		{
			get
			{
				if(r_m_Attribute == null)
				{
					r_m_Attribute = new(this, "m_Attribute");
					r_m_Attribute.SetBelong(this.instance);
				}
				return r_m_Attribute;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo m_FieldInfo
		/// </summary>
		protected RSystem.RReflection.RFieldInfo r_m_FieldInfo;
		public virtual RSystem.RReflection.RFieldInfo Rm_FieldInfo
		{
			get
			{
				if(r_m_FieldInfo == null)
				{
					r_m_FieldInfo = new(this, "m_FieldInfo");
					r_m_FieldInfo.SetBelong(this.instance);
				}
				return r_m_FieldInfo;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyAttribute attribute
		/// </summary>
		protected RUnityEngine.RPropertyAttribute r_attribute;
		public virtual RUnityEngine.RPropertyAttribute Rattribute
		{
			get
			{
				if(r_attribute == null)
				{
					r_attribute = new(this, "attribute", -1);
					r_attribute.SetBelong(this.instance);
				}
				return r_attribute;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo fieldInfo
		/// </summary>
		protected RSystem.RReflection.RFieldInfo r_fieldInfo;
		public virtual RSystem.RReflection.RFieldInfo RfieldInfo
		{
			get
			{
				if(r_fieldInfo == null)
				{
					r_fieldInfo = new(this, "fieldInfo", -1);
					r_fieldInfo.SetBelong(this.instance);
				}
				return r_fieldInfo;
			}
		}

		/// <summary>
		/// Void OnGUISafe(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_OnGUISafe_Rect_SerializedProperty_GUIContent;
		public virtual RMethod ROnGUISafe_Rect_SerializedProperty_GUIContent
		{
			get
			{
				if(r_OnGUISafe_Rect_SerializedProperty_GUIContent == null)
				{
					r_OnGUISafe_Rect_SerializedProperty_GUIContent = new(this, "OnGUISafe", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
					r_OnGUISafe_Rect_SerializedProperty_GUIContent.SetBelong(this.instance);
				}
				return r_OnGUISafe_Rect_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// Void OnGUI(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_OnGUI_Rect_SerializedProperty_GUIContent;
		public virtual RMethod ROnGUI_Rect_SerializedProperty_GUIContent
		{
			get
			{
				if(r_OnGUI_Rect_SerializedProperty_GUIContent == null)
				{
					r_OnGUI_Rect_SerializedProperty_GUIContent = new(this, "OnGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
					r_OnGUI_Rect_SerializedProperty_GUIContent.SetBelong(this.instance);
				}
				return r_OnGUI_Rect_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePropertyGUI(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_CreatePropertyGUI_SerializedProperty;
		public virtual RMethod RCreatePropertyGUI_SerializedProperty
		{
			get
			{
				if(r_CreatePropertyGUI_SerializedProperty == null)
				{
					r_CreatePropertyGUI_SerializedProperty = new(this, "CreatePropertyGUI", 0, typeof(UnityEditor.SerializedProperty));
					r_CreatePropertyGUI_SerializedProperty.SetBelong(this.instance);
				}
				return r_CreatePropertyGUI_SerializedProperty;
			}
		}

		/// <summary>
		/// Single GetPropertyHeightSafe(UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_GetPropertyHeightSafe_SerializedProperty_GUIContent;
		public virtual RMethod RGetPropertyHeightSafe_SerializedProperty_GUIContent
		{
			get
			{
				if(r_GetPropertyHeightSafe_SerializedProperty_GUIContent == null)
				{
					r_GetPropertyHeightSafe_SerializedProperty_GUIContent = new(this, "GetPropertyHeightSafe", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
					r_GetPropertyHeightSafe_SerializedProperty_GUIContent.SetBelong(this.instance);
				}
				return r_GetPropertyHeightSafe_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// Single GetPropertyHeight(UnityEditor.SerializedProperty, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_GetPropertyHeight_SerializedProperty_GUIContent;
		public virtual RMethod RGetPropertyHeight_SerializedProperty_GUIContent
		{
			get
			{
				if(r_GetPropertyHeight_SerializedProperty_GUIContent == null)
				{
					r_GetPropertyHeight_SerializedProperty_GUIContent = new(this, "GetPropertyHeight", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent));
					r_GetPropertyHeight_SerializedProperty_GUIContent.SetBelong(this.instance);
				}
				return r_GetPropertyHeight_SerializedProperty_GUIContent;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUISafe(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_CanCacheInspectorGUISafe_SerializedProperty;
		public virtual RMethod RCanCacheInspectorGUISafe_SerializedProperty
		{
			get
			{
				if(r_CanCacheInspectorGUISafe_SerializedProperty == null)
				{
					r_CanCacheInspectorGUISafe_SerializedProperty = new(this, "CanCacheInspectorGUISafe", 0, typeof(UnityEditor.SerializedProperty));
					r_CanCacheInspectorGUISafe_SerializedProperty.SetBelong(this.instance);
				}
				return r_CanCacheInspectorGUISafe_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_CanCacheInspectorGUI_SerializedProperty;
		public virtual RMethod RCanCacheInspectorGUI_SerializedProperty
		{
			get
			{
				if(r_CanCacheInspectorGUI_SerializedProperty == null)
				{
					r_CanCacheInspectorGUI_SerializedProperty = new(this, "CanCacheInspectorGUI", 0, typeof(UnityEditor.SerializedProperty));
					r_CanCacheInspectorGUI_SerializedProperty.SetBelong(this.instance);
				}
				return r_CanCacheInspectorGUI_SerializedProperty;
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

        public virtual void OnGUISafe(UnityEngine.Rect @position, UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label};
            var ___result = ROnGUISafe_Rect_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI(UnityEngine.Rect @position, UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label};
            var ___result = ROnGUI_Rect_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreatePropertyGUI(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RCreatePropertyGUI_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Single GetPropertyHeightSafe(UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label};
            var ___result = RGetPropertyHeightSafe_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetPropertyHeight(UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label};
            var ___result = RGetPropertyHeight_SerializedProperty_GUIContent.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean CanCacheInspectorGUISafe(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RCanCacheInspectorGUISafe_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RCanCacheInspectorGUI_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
