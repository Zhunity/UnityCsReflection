using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditorInternal
{
	/// <summary>
	/// UnityEditorInternal.ReorderableListWrapper
	/// </summary>
    public partial class RReorderableListWrapper : RMember //
    {

		/// <summary>
		/// UnityEditorInternal.ReorderableList m_ReorderableList
		/// </summary>
		protected RUnityEditorInternal.RReorderableList r_m_ReorderableList;
		public virtual RUnityEditorInternal.RReorderableList Rm_ReorderableList
		{
			get
			{
				if(r_m_ReorderableList == null)
				{
					r_m_ReorderableList = new(this, "m_ReorderableList");
					r_m_ReorderableList.SetBelong(this.instance);
				}
				return r_m_ReorderableList;
			}
		}

		/// <summary>
		/// System.Single m_HeaderHeight
		/// </summary>
		protected RField r_m_HeaderHeight;
		public virtual RField Rm_HeaderHeight
		{
			get
			{
				if(r_m_HeaderHeight == null)
				{
					r_m_HeaderHeight = new(this, "m_HeaderHeight");
					r_m_HeaderHeight.SetBelong(this.instance);
				}
				return r_m_HeaderHeight;
			}
		}

		/// <summary>
		/// System.Boolean m_Reorderable
		/// </summary>
		protected RField r_m_Reorderable;
		public virtual RField Rm_Reorderable
		{
			get
			{
				if(r_m_Reorderable == null)
				{
					r_m_Reorderable = new(this, "m_Reorderable");
					r_m_Reorderable.SetBelong(this.instance);
				}
				return r_m_Reorderable;
			}
		}

		/// <summary>
		/// System.Boolean m_IsNotInPrefabContextModeWithOverrides
		/// </summary>
		protected RField r_m_IsNotInPrefabContextModeWithOverrides;
		public virtual RField Rm_IsNotInPrefabContextModeWithOverrides
		{
			get
			{
				if(r_m_IsNotInPrefabContextModeWithOverrides == null)
				{
					r_m_IsNotInPrefabContextModeWithOverrides = new(this, "m_IsNotInPrefabContextModeWithOverrides");
					r_m_IsNotInPrefabContextModeWithOverrides.SetBelong(this.instance);
				}
				return r_m_IsNotInPrefabContextModeWithOverrides;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_OriginalProperty
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_m_OriginalProperty;
		public virtual RUnityEditor.RSerializedProperty Rm_OriginalProperty
		{
			get
			{
				if(r_m_OriginalProperty == null)
				{
					r_m_OriginalProperty = new(this, "m_OriginalProperty");
					r_m_OriginalProperty.SetBelong(this.instance);
				}
				return r_m_OriginalProperty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_ArraySize
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_m_ArraySize;
		public virtual RUnityEditor.RSerializedProperty Rm_ArraySize
		{
			get
			{
				if(r_m_ArraySize == null)
				{
					r_m_ArraySize = new(this, "m_ArraySize");
					r_m_ArraySize.SetBelong(this.instance);
				}
				return r_m_ArraySize;
			}
		}

		/// <summary>
		/// UnityEngine.Rect s_ToolTipRect
		/// </summary>
		protected static RUnityEngine.RRect r_s_ToolTipRect;
		public static RUnityEngine.RRect Rs_ToolTipRect
		{
			get
			{
				if(r_s_ToolTipRect == null)
				{
					r_s_ToolTipRect = new( ReflectionUtils.GetType("UnityEditorInternal.ReorderableListWrapper"), "s_ToolTipRect");
					r_s_ToolTipRect.SetBelong(null);
				}
				return r_s_ToolTipRect;
			}
		}

		/// <summary>
		/// System.Int32 m_LastArraySize
		/// </summary>
		protected RField r_m_LastArraySize;
		public virtual RField Rm_LastArraySize
		{
			get
			{
				if(r_m_LastArraySize == null)
				{
					r_m_LastArraySize = new(this, "m_LastArraySize");
					r_m_LastArraySize.SetBelong(this.instance);
				}
				return r_m_LastArraySize;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty Property
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_Property;
		public virtual RUnityEditor.RSerializedProperty RProperty
		{
			get
			{
				if(r_Property == null)
				{
					r_Property = new(this, "Property", -1);
					r_Property.SetBelong(this.instance);
				}
				return r_Property;
			}
		}

		/// <summary>
		/// System.String GetPropertyIdentifier(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_GetPropertyIdentifier_SerializedProperty;
		public static RMethod RGetPropertyIdentifier_SerializedProperty
		{
			get
			{
				if(r_GetPropertyIdentifier_SerializedProperty == null)
				{
					r_GetPropertyIdentifier_SerializedProperty = new( ReflectionUtils.GetType("UnityEditorInternal.ReorderableListWrapper"), "GetPropertyIdentifier", 0, typeof(UnityEditor.SerializedProperty));
					r_GetPropertyIdentifier_SerializedProperty.SetBelong(null);
				}
				return r_GetPropertyIdentifier_SerializedProperty;
			}
		}

		/// <summary>
		/// Void Init(Boolean)
		/// </summary>
		protected RMethod r_Init_Boolean;
		public virtual RMethod RInit_Boolean
		{
			get
			{
				if(r_Init_Boolean == null)
				{
					r_Init_Boolean = new(this, "Init", 0, typeof(System.Boolean));
					r_Init_Boolean.SetBelong(this.instance);
				}
				return r_Init_Boolean;
			}
		}

		/// <summary>
		/// Void InvalidateCache()
		/// </summary>
		protected RMethod r_InvalidateCache;
		public virtual RMethod RInvalidateCache
		{
			get
			{
				if(r_InvalidateCache == null)
				{
					r_InvalidateCache = new(this, "InvalidateCache", 0);
					r_InvalidateCache.SetBelong(this.instance);
				}
				return r_InvalidateCache;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_GetHeight;
		public virtual RMethod RGetHeight
		{
			get
			{
				if(r_GetHeight == null)
				{
					r_GetHeight = new(this, "GetHeight", 0);
					r_GetHeight.SetBelong(this.instance);
				}
				return r_GetHeight;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.GUIContent, UnityEngine.Rect, UnityEngine.Rect, System.String, Boolean)
		/// </summary>
		protected RMethod r_Draw_GUIContent_Rect_Rect_String_Boolean;
		public virtual RMethod RDraw_GUIContent_Rect_Rect_String_Boolean
		{
			get
			{
				if(r_Draw_GUIContent_Rect_Rect_String_Boolean == null)
				{
					r_Draw_GUIContent_Rect_Rect_String_Boolean = new(this, "Draw", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Boolean));
					r_Draw_GUIContent_Rect_Rect_String_Boolean.SetBelong(this.instance);
				}
				return r_Draw_GUIContent_Rect_Rect_String_Boolean;
			}
		}

		/// <summary>
		/// Void DrawChildren(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.EventType)
		/// </summary>
		protected RMethod r_DrawChildren_Rect_Rect_Rect_Rect_EventType;
		public virtual RMethod RDrawChildren_Rect_Rect_Rect_Rect_EventType
		{
			get
			{
				if(r_DrawChildren_Rect_Rect_Rect_Rect_EventType == null)
				{
					r_DrawChildren_Rect_Rect_Rect_Rect_EventType = new(this, "DrawChildren", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.EventType));
					r_DrawChildren_Rect_Rect_Rect_Rect_EventType.SetBelong(this.instance);
				}
				return r_DrawChildren_Rect_Rect_Rect_Rect_EventType;
			}
		}

		/// <summary>
		/// Boolean <Init>b__15_0(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r___0__Init__1__b__15_0_ReorderableList;
		public virtual RMethod R__0__Init__1__b__15_0_ReorderableList
		{
			get
			{
				if(r___0__Init__1__b__15_0_ReorderableList == null)
				{
					r___0__Init__1__b__15_0_ReorderableList = new(this, "<Init>b__15_0", 0, typeof(UnityEditorInternal.ReorderableList));
					r___0__Init__1__b__15_0_ReorderableList.SetBelong(this.instance);
				}
				return r___0__Init__1__b__15_0_ReorderableList;
			}
		}

		/// <summary>
		/// Boolean <Init>b__15_1(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r___0__Init__1__b__15_1_ReorderableList;
		public virtual RMethod R__0__Init__1__b__15_1_ReorderableList
		{
			get
			{
				if(r___0__Init__1__b__15_1_ReorderableList == null)
				{
					r___0__Init__1__b__15_1_ReorderableList = new(this, "<Init>b__15_1", 0, typeof(UnityEditorInternal.ReorderableList));
					r___0__Init__1__b__15_1_ReorderableList.SetBelong(this.instance);
				}
				return r___0__Init__1__b__15_1_ReorderableList;
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


        public RReorderableListWrapper() : base("UnityEditorInternal.ReorderableListWrapper")
        {
        }

        public RReorderableListWrapper(System.Object instance) : base("UnityEditorInternal.ReorderableListWrapper")
		{
            SetInstance(instance);
		}

        public RReorderableListWrapper(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReorderableListWrapper(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String GetPropertyIdentifier(UnityEditor.SerializedProperty @serializedProperty)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedProperty};
            var ___result = RGetPropertyIdentifier_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Init(System.Boolean @reorderable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reorderable};
            var ___result = RInit_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvalidateCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void Draw(UnityEngine.GUIContent @label, UnityEngine.Rect @r, UnityEngine.Rect @visibleArea, System.String @tooltip, System.Boolean @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label, @r, @visibleArea, @tooltip, @includeChildren};
            var ___result = RDraw_GUIContent_Rect_Rect_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawChildren(UnityEngine.Rect @listRect, UnityEngine.Rect @headerRect, UnityEngine.Rect @sizeRect, UnityEngine.Rect @visibleRect, UnityEngine.EventType @previousEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect, @headerRect, @sizeRect, @visibleRect, @previousEvent};
            var ___result = RDrawChildren_Rect_Rect_Rect_Rect_EventType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__Init__1__b__15_0(UnityEditorInternal.ReorderableList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = R__0__Init__1__b__15_0_ReorderableList.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__Init__1__b__15_1(UnityEditorInternal.ReorderableList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = R__0__Init__1__b__15_1_ReorderableList.Invoke(___genericsType, ___parameters);

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
