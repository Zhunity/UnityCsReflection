
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.GenericMenu
	/// </summary>
    public partial class RGenericMenu : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.GenericMenu);
            }
        }

        public RGenericMenu() : base("UnityEditor.GenericMenu")
        {
        }

        public RGenericMenu(System.Object instance) : base("UnityEditor.GenericMenu")
		{
            SetInstance(instance);
		}

        public RGenericMenu(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGenericMenu(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.GenericMenu+MenuItem] m_MenuItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuItem> r_Fm_MenuItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuItem> RFm_MenuItems
		{
			get
			{
				if(r_Fm_MenuItems == null)
				{
					r_Fm_MenuItems = new(this, "m_MenuItems");
				}
				return r_Fm_MenuItems;
			}
		}

		/// <summary>
		/// System.Boolean <allowDuplicateNames>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__allowDuplicateNames__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__allowDuplicateNames__1__k__BackingField
		{
			get
			{
				if(r_F__0__allowDuplicateNames__1__k__BackingField == null)
				{
					r_F__0__allowDuplicateNames__1__k__BackingField = new(this, "<allowDuplicateNames>k__BackingField");
				}
				return r_F__0__allowDuplicateNames__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean allowDuplicateNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowDuplicateNames;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPallowDuplicateNames
		{
			get
			{
				if(r_PallowDuplicateNames == null)
				{
					r_PallowDuplicateNames = new(this, "allowDuplicateNames", -1);
				}
				return r_PallowDuplicateNames;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.GenericMenu+MenuItem] menuItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuItem> r_PmenuItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuItem> RPmenuItems
		{
			get
			{
				if(r_PmenuItems == null)
				{
					r_PmenuItems = new(this, "menuItems", -1);
				}
				return r_PmenuItems;
			}
		}

		/// <summary>
		/// Void AddItem(UnityEngine.GUIContent, Boolean, MenuFunction)
		/// </summary>
		protected RMethod r_MAddItem_GUIContent_Boolean_MenuFunction;
		public virtual RMethod RMAddItem_GUIContent_Boolean_MenuFunction
		{
			get
			{
				if(r_MAddItem_GUIContent_Boolean_MenuFunction == null)
				{
					r_MAddItem_GUIContent_Boolean_MenuFunction = new(this, "AddItem", 0, typeof(UnityEngine.GUIContent), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEditor.GenericMenu+MenuFunction"));
				}
				return r_MAddItem_GUIContent_Boolean_MenuFunction;
			}
		}

		/// <summary>
		/// Void AddItem(UnityEngine.GUIContent, Boolean, MenuFunction2, System.Object)
		/// </summary>
		protected RMethod r_MAddItem_GUIContent_Boolean_MenuFunction2_Object;
		public virtual RMethod RMAddItem_GUIContent_Boolean_MenuFunction2_Object
		{
			get
			{
				if(r_MAddItem_GUIContent_Boolean_MenuFunction2_Object == null)
				{
					r_MAddItem_GUIContent_Boolean_MenuFunction2_Object = new(this, "AddItem", 0, typeof(UnityEngine.GUIContent), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEditor.GenericMenu+MenuFunction2"), typeof(System.Object));
				}
				return r_MAddItem_GUIContent_Boolean_MenuFunction2_Object;
			}
		}

		/// <summary>
		/// Void AddDisabledItem(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MAddDisabledItem_GUIContent;
		public virtual RMethod RMAddDisabledItem_GUIContent
		{
			get
			{
				if(r_MAddDisabledItem_GUIContent == null)
				{
					r_MAddDisabledItem_GUIContent = new(this, "AddDisabledItem", 0, typeof(UnityEngine.GUIContent));
				}
				return r_MAddDisabledItem_GUIContent;
			}
		}

		/// <summary>
		/// Void AddDisabledItem(UnityEngine.GUIContent, Boolean)
		/// </summary>
		protected RMethod r_MAddDisabledItem_GUIContent_Boolean;
		public virtual RMethod RMAddDisabledItem_GUIContent_Boolean
		{
			get
			{
				if(r_MAddDisabledItem_GUIContent_Boolean == null)
				{
					r_MAddDisabledItem_GUIContent_Boolean = new(this, "AddDisabledItem", 0, typeof(UnityEngine.GUIContent), typeof(System.Boolean));
				}
				return r_MAddDisabledItem_GUIContent_Boolean;
			}
		}

		/// <summary>
		/// Void AddSeparator(System.String)
		/// </summary>
		protected RMethod r_MAddSeparator_String;
		public virtual RMethod RMAddSeparator_String
		{
			get
			{
				if(r_MAddSeparator_String == null)
				{
					r_MAddSeparator_String = new(this, "AddSeparator", 0, typeof(System.String));
				}
				return r_MAddSeparator_String;
			}
		}

		/// <summary>
		/// Int32 GetItemCount()
		/// </summary>
		protected RMethod r_MGetItemCount;
		public virtual RMethod RMGetItemCount
		{
			get
			{
				if(r_MGetItemCount == null)
				{
					r_MGetItemCount = new(this, "GetItemCount", 0);
				}
				return r_MGetItemCount;
			}
		}

		/// <summary>
		/// Void ShowAsContext()
		/// </summary>
		protected RMethod r_MShowAsContext;
		public virtual RMethod RMShowAsContext
		{
			get
			{
				if(r_MShowAsContext == null)
				{
					r_MShowAsContext = new(this, "ShowAsContext", 0);
				}
				return r_MShowAsContext;
			}
		}

		/// <summary>
		/// Void DropDown(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDropDown_Rect;
		public virtual RMethod RMDropDown_Rect
		{
			get
			{
				if(r_MDropDown_Rect == null)
				{
					r_MDropDown_Rect = new(this, "DropDown", 0, typeof(UnityEngine.Rect));
				}
				return r_MDropDown_Rect;
			}
		}

		/// <summary>
		/// Void DropDown(UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_MDropDown_Rect_Boolean;
		public virtual RMethod RMDropDown_Rect_Boolean
		{
			get
			{
				if(r_MDropDown_Rect_Boolean == null)
				{
					r_MDropDown_Rect_Boolean = new(this, "DropDown", 0, typeof(UnityEngine.Rect), typeof(System.Boolean));
				}
				return r_MDropDown_Rect_Boolean;
			}
		}

		/// <summary>
		/// Void Popup(UnityEngine.Rect, Int32)
		/// </summary>
		protected RMethod r_MPopup_Rect_Int32;
		public virtual RMethod RMPopup_Rect_Int32
		{
			get
			{
				if(r_MPopup_Rect_Int32 == null)
				{
					r_MPopup_Rect_Int32 = new(this, "Popup", 0, typeof(UnityEngine.Rect), typeof(System.Int32));
				}
				return r_MPopup_Rect_Int32;
			}
		}

		/// <summary>
		/// Void CatchMenu(System.Object, System.String[], Int32)
		/// </summary>
		protected RMethod r_MCatchMenu_Object_StringArray_Int32;
		public virtual RMethod RMCatchMenu_Object_StringArray_Int32
		{
			get
			{
				if(r_MCatchMenu_Object_StringArray_Int32 == null)
				{
					r_MCatchMenu_Object_StringArray_Int32 = new(this, "CatchMenu", 0, typeof(System.Object), typeof(System.String).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCatchMenu_Object_StringArray_Int32;
			}
		}

		/// <summary>
		/// Void ObjectContextDropDown(UnityEngine.Rect, UnityEngine.Object[], Int32)
		/// </summary>
		protected RMethod r_MObjectContextDropDown_Rect_ObjectArray_Int32;
		public virtual RMethod RMObjectContextDropDown_Rect_ObjectArray_Int32
		{
			get
			{
				if(r_MObjectContextDropDown_Rect_ObjectArray_Int32 == null)
				{
					r_MObjectContextDropDown_Rect_ObjectArray_Int32 = new(this, "ObjectContextDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Int32));
				}
				return r_MObjectContextDropDown_Rect_ObjectArray_Int32;
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


        public virtual void AddItem(UnityEngine.GUIContent @content, System.Boolean @on, Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuFunction @func)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @on, @func.Value};
            var ___result = RMAddItem_GUIContent_Boolean_MenuFunction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddItem(UnityEngine.GUIContent @content, System.Boolean @on, Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuFunction2 @func, System.Object @userData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @on, @func.Value, @userData};
            var ___result = RMAddItem_GUIContent_Boolean_MenuFunction2_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDisabledItem(UnityEngine.GUIContent @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RMAddDisabledItem_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDisabledItem(UnityEngine.GUIContent @content, System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @on};
            var ___result = RMAddDisabledItem_GUIContent_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSeparator(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMAddSeparator_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetItemCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetItemCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void ShowAsContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowAsContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DropDown(UnityEngine.Rect @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMDropDown_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DropDown(UnityEngine.Rect @position, System.Boolean @shouldDiscardMenuOnSecondClick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @shouldDiscardMenuOnSecondClick};
            var ___result = RMDropDown_Rect_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Popup(UnityEngine.Rect @position, System.Int32 @selectedIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @selectedIndex};
            var ___result = RMPopup_Rect_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CatchMenu(System.Object @userData, System.String[] @options, System.Int32 @selected)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userData, @options, @selected};
            var ___result = RMCatchMenu_Object_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ObjectContextDropDown(UnityEngine.Rect @position, UnityEngine.Object[] @context, System.Int32 @contextUserData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @context, @contextUserData};
            var ___result = RMObjectContextDropDown_Rect_ObjectArray_Int32.Invoke(___genericsType, ___parameters);

            
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
