
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
		protected SMFrame.Editor.Refleaction.RUnityEditorInternal.RReorderableList r_Fm_ReorderableList;
		public virtual SMFrame.Editor.Refleaction.RUnityEditorInternal.RReorderableList RFm_ReorderableList
		{
			get
			{
				if(r_Fm_ReorderableList == null)
				{
					r_Fm_ReorderableList = new(this, "m_ReorderableList");
					r_Fm_ReorderableList.SetBelong(this.instance);
				}
				return r_Fm_ReorderableList;
			}
		}

		/// <summary>
		/// System.Single m_HeaderHeight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fm_HeaderHeight;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFm_HeaderHeight
		{
			get
			{
				if(r_Fm_HeaderHeight == null)
				{
					r_Fm_HeaderHeight = new(this, "m_HeaderHeight");
					r_Fm_HeaderHeight.SetBelong(this.instance);
				}
				return r_Fm_HeaderHeight;
			}
		}

		/// <summary>
		/// System.Boolean m_Reorderable
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Reorderable;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Reorderable
		{
			get
			{
				if(r_Fm_Reorderable == null)
				{
					r_Fm_Reorderable = new(this, "m_Reorderable");
					r_Fm_Reorderable.SetBelong(this.instance);
				}
				return r_Fm_Reorderable;
			}
		}

		/// <summary>
		/// System.Boolean m_IsNotInPrefabContextModeWithOverrides
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_IsNotInPrefabContextModeWithOverrides;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_IsNotInPrefabContextModeWithOverrides
		{
			get
			{
				if(r_Fm_IsNotInPrefabContextModeWithOverrides == null)
				{
					r_Fm_IsNotInPrefabContextModeWithOverrides = new(this, "m_IsNotInPrefabContextModeWithOverrides");
					r_Fm_IsNotInPrefabContextModeWithOverrides.SetBelong(this.instance);
				}
				return r_Fm_IsNotInPrefabContextModeWithOverrides;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_OriginalProperty
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty r_Fm_OriginalProperty;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty RFm_OriginalProperty
		{
			get
			{
				if(r_Fm_OriginalProperty == null)
				{
					r_Fm_OriginalProperty = new(this, "m_OriginalProperty");
					r_Fm_OriginalProperty.SetBelong(this.instance);
				}
				return r_Fm_OriginalProperty;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_ArraySize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty r_Fm_ArraySize;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty RFm_ArraySize
		{
			get
			{
				if(r_Fm_ArraySize == null)
				{
					r_Fm_ArraySize = new(this, "m_ArraySize");
					r_Fm_ArraySize.SetBelong(this.instance);
				}
				return r_Fm_ArraySize;
			}
		}

		/// <summary>
		/// UnityEngine.Rect s_ToolTipRect
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RRect r_Fs_ToolTipRect;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RRect RFs_ToolTipRect
		{
			get
			{
				if(r_Fs_ToolTipRect == null)
				{
					r_Fs_ToolTipRect = new( ReflectionUtils.GetType("UnityEditorInternal.ReorderableListWrapper"), "s_ToolTipRect");
					r_Fs_ToolTipRect.SetBelong(null);
				}
				return r_Fs_ToolTipRect;
			}
		}

		/// <summary>
		/// System.Int32 m_LastArraySize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_LastArraySize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_LastArraySize
		{
			get
			{
				if(r_Fm_LastArraySize == null)
				{
					r_Fm_LastArraySize = new(this, "m_LastArraySize");
					r_Fm_LastArraySize.SetBelong(this.instance);
				}
				return r_Fm_LastArraySize;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty Property
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty r_PProperty;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RSerializedProperty RPProperty
		{
			get
			{
				if(r_PProperty == null)
				{
					r_PProperty = new(this, "Property", -1);
					r_PProperty.SetBelong(this.instance);
				}
				return r_PProperty;
			}
		}

		/// <summary>
		/// System.String GetPropertyIdentifier(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MGetPropertyIdentifier_SerializedProperty;
		public static RMethod RMGetPropertyIdentifier_SerializedProperty
		{
			get
			{
				if(r_MGetPropertyIdentifier_SerializedProperty == null)
				{
					r_MGetPropertyIdentifier_SerializedProperty = new( ReflectionUtils.GetType("UnityEditorInternal.ReorderableListWrapper"), "GetPropertyIdentifier", 0, typeof(UnityEditor.SerializedProperty));
					r_MGetPropertyIdentifier_SerializedProperty.SetBelong(null);
				}
				return r_MGetPropertyIdentifier_SerializedProperty;
			}
		}

		/// <summary>
		/// Void Init(Boolean)
		/// </summary>
		protected RMethod r_MInit_Boolean;
		public virtual RMethod RMInit_Boolean
		{
			get
			{
				if(r_MInit_Boolean == null)
				{
					r_MInit_Boolean = new(this, "Init", 0, typeof(System.Boolean));
					r_MInit_Boolean.SetBelong(this.instance);
				}
				return r_MInit_Boolean;
			}
		}

		/// <summary>
		/// Void InvalidateCache()
		/// </summary>
		protected RMethod r_MInvalidateCache;
		public virtual RMethod RMInvalidateCache
		{
			get
			{
				if(r_MInvalidateCache == null)
				{
					r_MInvalidateCache = new(this, "InvalidateCache", 0);
					r_MInvalidateCache.SetBelong(this.instance);
				}
				return r_MInvalidateCache;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_MGetHeight;
		public virtual RMethod RMGetHeight
		{
			get
			{
				if(r_MGetHeight == null)
				{
					r_MGetHeight = new(this, "GetHeight", 0);
					r_MGetHeight.SetBelong(this.instance);
				}
				return r_MGetHeight;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.GUIContent, UnityEngine.Rect, UnityEngine.Rect, System.String, Boolean)
		/// </summary>
		protected RMethod r_MDraw_GUIContent_Rect_Rect_String_Boolean;
		public virtual RMethod RMDraw_GUIContent_Rect_Rect_String_Boolean
		{
			get
			{
				if(r_MDraw_GUIContent_Rect_Rect_String_Boolean == null)
				{
					r_MDraw_GUIContent_Rect_Rect_String_Boolean = new(this, "Draw", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Boolean));
					r_MDraw_GUIContent_Rect_Rect_String_Boolean.SetBelong(this.instance);
				}
				return r_MDraw_GUIContent_Rect_Rect_String_Boolean;
			}
		}

		/// <summary>
		/// Void DrawChildren(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.EventType)
		/// </summary>
		protected RMethod r_MDrawChildren_Rect_Rect_Rect_Rect_EventType;
		public virtual RMethod RMDrawChildren_Rect_Rect_Rect_Rect_EventType
		{
			get
			{
				if(r_MDrawChildren_Rect_Rect_Rect_Rect_EventType == null)
				{
					r_MDrawChildren_Rect_Rect_Rect_Rect_EventType = new(this, "DrawChildren", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.EventType));
					r_MDrawChildren_Rect_Rect_Rect_Rect_EventType.SetBelong(this.instance);
				}
				return r_MDrawChildren_Rect_Rect_Rect_Rect_EventType;
			}
		}

		/// <summary>
		/// Boolean <Init>b__15_0(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_M__0__Init__1__b__15_0_ReorderableList;
		public virtual RMethod RM__0__Init__1__b__15_0_ReorderableList
		{
			get
			{
				if(r_M__0__Init__1__b__15_0_ReorderableList == null)
				{
					r_M__0__Init__1__b__15_0_ReorderableList = new(this, "<Init>b__15_0", 0, typeof(UnityEditorInternal.ReorderableList));
					r_M__0__Init__1__b__15_0_ReorderableList.SetBelong(this.instance);
				}
				return r_M__0__Init__1__b__15_0_ReorderableList;
			}
		}

		/// <summary>
		/// Boolean <Init>b__15_1(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_M__0__Init__1__b__15_1_ReorderableList;
		public virtual RMethod RM__0__Init__1__b__15_1_ReorderableList
		{
			get
			{
				if(r_M__0__Init__1__b__15_1_ReorderableList == null)
				{
					r_M__0__Init__1__b__15_1_ReorderableList = new(this, "<Init>b__15_1", 0, typeof(UnityEditorInternal.ReorderableList));
					r_M__0__Init__1__b__15_1_ReorderableList.SetBelong(this.instance);
				}
				return r_M__0__Init__1__b__15_1_ReorderableList;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMGetPropertyIdentifier_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Init(System.Boolean @reorderable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reorderable};
            var ___result = RMInit_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvalidateCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void Draw(UnityEngine.GUIContent @label, UnityEngine.Rect @r, UnityEngine.Rect @visibleArea, System.String @tooltip, System.Boolean @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@label, @r, @visibleArea, @tooltip, @includeChildren};
            var ___result = RMDraw_GUIContent_Rect_Rect_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawChildren(UnityEngine.Rect @listRect, UnityEngine.Rect @headerRect, UnityEngine.Rect @sizeRect, UnityEngine.Rect @visibleRect, UnityEngine.EventType @previousEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect, @headerRect, @sizeRect, @visibleRect, @previousEvent};
            var ___result = RMDrawChildren_Rect_Rect_Rect_Rect_EventType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__Init__1__b__15_0(UnityEditorInternal.ReorderableList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RM__0__Init__1__b__15_0_ReorderableList.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__Init__1__b__15_1(UnityEditorInternal.ReorderableList @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RM__0__Init__1__b__15_1_ReorderableList.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
