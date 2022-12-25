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
					r_s_ToolTipRect = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableListWrapper"), "s_ToolTipRect");
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
		protected static RMethod r_RGetPropertyIdentifier_SerializedProperty;
		public static RMethod RGetPropertyIdentifier_SerializedProperty
		{
			get
			{
				if(r_RGetPropertyIdentifier_SerializedProperty == null)
				{
					r_RGetPropertyIdentifier_SerializedProperty = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableListWrapper"), "GetPropertyIdentifier", 0, typeof(UnityEditor.SerializedProperty));
					r_RGetPropertyIdentifier_SerializedProperty.SetBelong(null);
				}
				return r_RGetPropertyIdentifier_SerializedProperty;
			}
		}

		/// <summary>
		/// Void Init(Boolean)
		/// </summary>
		protected RMethod r_RInit_Boolean;
		public virtual RMethod RInit_Boolean
		{
			get
			{
				if(r_RInit_Boolean == null)
				{
					r_RInit_Boolean = new(this, "Init", 0, typeof(System.Boolean));
					r_RInit_Boolean.SetBelong(this.instance);
				}
				return r_RInit_Boolean;
			}
		}

		/// <summary>
		/// Void InvalidateCache()
		/// </summary>
		protected RMethod r_RInvalidateCache;
		public virtual RMethod RInvalidateCache
		{
			get
			{
				if(r_RInvalidateCache == null)
				{
					r_RInvalidateCache = new(this, "InvalidateCache", 0);
					r_RInvalidateCache.SetBelong(this.instance);
				}
				return r_RInvalidateCache;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_RGetHeight;
		public virtual RMethod RGetHeight
		{
			get
			{
				if(r_RGetHeight == null)
				{
					r_RGetHeight = new(this, "GetHeight", 0);
					r_RGetHeight.SetBelong(this.instance);
				}
				return r_RGetHeight;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.GUIContent, UnityEngine.Rect, UnityEngine.Rect, System.String, Boolean)
		/// </summary>
		protected RMethod r_RDraw_GUIContent_Rect_Rect_String_Boolean;
		public virtual RMethod RDraw_GUIContent_Rect_Rect_String_Boolean
		{
			get
			{
				if(r_RDraw_GUIContent_Rect_Rect_String_Boolean == null)
				{
					r_RDraw_GUIContent_Rect_Rect_String_Boolean = new(this, "Draw", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Boolean));
					r_RDraw_GUIContent_Rect_Rect_String_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_GUIContent_Rect_Rect_String_Boolean;
			}
		}

		/// <summary>
		/// Void DrawChildren(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.EventType)
		/// </summary>
		protected RMethod r_RDrawChildren_Rect_Rect_Rect_Rect_EventType;
		public virtual RMethod RDrawChildren_Rect_Rect_Rect_Rect_EventType
		{
			get
			{
				if(r_RDrawChildren_Rect_Rect_Rect_Rect_EventType == null)
				{
					r_RDrawChildren_Rect_Rect_Rect_Rect_EventType = new(this, "DrawChildren", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.EventType));
					r_RDrawChildren_Rect_Rect_Rect_Rect_EventType.SetBelong(this.instance);
				}
				return r_RDrawChildren_Rect_Rect_Rect_Rect_EventType;
			}
		}

		/// <summary>
		/// Boolean <Init>b__15_0(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_R__1__Init__2__b__15_0_ReorderableList;
		public virtual RMethod R__1__Init__2__b__15_0_ReorderableList
		{
			get
			{
				if(r_R__1__Init__2__b__15_0_ReorderableList == null)
				{
					r_R__1__Init__2__b__15_0_ReorderableList = new(this, "<Init>b__15_0", 0, typeof(UnityEditorInternal.ReorderableList));
					r_R__1__Init__2__b__15_0_ReorderableList.SetBelong(this.instance);
				}
				return r_R__1__Init__2__b__15_0_ReorderableList;
			}
		}

		/// <summary>
		/// Boolean <Init>b__15_1(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_R__1__Init__2__b__15_1_ReorderableList;
		public virtual RMethod R__1__Init__2__b__15_1_ReorderableList
		{
			get
			{
				if(r_R__1__Init__2__b__15_1_ReorderableList == null)
				{
					r_R__1__Init__2__b__15_1_ReorderableList = new(this, "<Init>b__15_1", 0, typeof(UnityEditorInternal.ReorderableList));
					r_R__1__Init__2__b__15_1_ReorderableList.SetBelong(this.instance);
				}
				return r_R__1__Init__2__b__15_1_ReorderableList;
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

        public static System.String GetPropertyIdentifier(UnityEditor.SerializedProperty  @serializedProperty)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedProperty};
            var ___result = RGetPropertyIdentifier_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Init(System.Boolean  @reorderable)
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


        public virtual void Draw(UnityEngine.GUIContent  @label, UnityEngine.Rect  @r, UnityEngine.Rect  @visibleArea, System.String  @tooltip, System.Boolean  @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label, @r, @visibleArea, @tooltip, @includeChildren};
            var ___result = RDraw_GUIContent_Rect_Rect_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawChildren(UnityEngine.Rect  @listRect, UnityEngine.Rect  @headerRect, UnityEngine.Rect  @sizeRect, UnityEngine.Rect  @visibleRect, UnityEngine.EventType  @previousEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect, @headerRect, @sizeRect, @visibleRect, @previousEvent};
            var ___result = RDrawChildren_Rect_Rect_Rect_Rect_EventType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __1__Init__2__b__15_0(UnityEditorInternal.ReorderableList  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = R__1__Init__2__b__15_0_ReorderableList.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __1__Init__2__b__15_1(UnityEditorInternal.ReorderableList  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = R__1__Init__2__b__15_1_ReorderableList.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
