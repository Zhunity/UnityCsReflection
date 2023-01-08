using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.GenericMenu
	/// </summary>
    public partial class RGenericMenu : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.GenericMenu+MenuItem] m_MenuItems
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RGenericMenu.RMenuItem> r_m_MenuItems;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RGenericMenu.RMenuItem> Rm_MenuItems
		{
			get
			{
				if(r_m_MenuItems == null)
				{
					r_m_MenuItems = new(this, "m_MenuItems");
					r_m_MenuItems.SetBelong(this.instance);
				}
				return r_m_MenuItems;
			}
		}

		/// <summary>
		/// System.Boolean <allowDuplicateNames>k__BackingField
		/// </summary>
		protected RField r___0__allowDuplicateNames__1__k__BackingField;
		public virtual RField R__0__allowDuplicateNames__1__k__BackingField
		{
			get
			{
				if(r___0__allowDuplicateNames__1__k__BackingField == null)
				{
					r___0__allowDuplicateNames__1__k__BackingField = new(this, "<allowDuplicateNames>k__BackingField");
					r___0__allowDuplicateNames__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__allowDuplicateNames__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean allowDuplicateNames
		/// </summary>
		protected RProperty r_allowDuplicateNames;
		public virtual RProperty RallowDuplicateNames
		{
			get
			{
				if(r_allowDuplicateNames == null)
				{
					r_allowDuplicateNames = new(this, "allowDuplicateNames", -1);
					r_allowDuplicateNames.SetBelong(this.instance);
				}
				return r_allowDuplicateNames;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.GenericMenu+MenuItem] menuItems
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RGenericMenu.RMenuItem> r_menuItems;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RGenericMenu.RMenuItem> RmenuItems
		{
			get
			{
				if(r_menuItems == null)
				{
					r_menuItems = new(this, "menuItems", -1);
					r_menuItems.SetBelong(this.instance);
				}
				return r_menuItems;
			}
		}

		/// <summary>
		/// Void AddItem(UnityEngine.GUIContent, Boolean, MenuFunction)
		/// </summary>
		protected RMethod r_AddItem_GUIContent_Boolean_MenuFunction;
		public virtual RMethod RAddItem_GUIContent_Boolean_MenuFunction
		{
			get
			{
				if(r_AddItem_GUIContent_Boolean_MenuFunction == null)
				{
					r_AddItem_GUIContent_Boolean_MenuFunction = new(this, "AddItem", 0, typeof(UnityEngine.GUIContent), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEditor.GenericMenu+MenuFunction"));
					r_AddItem_GUIContent_Boolean_MenuFunction.SetBelong(this.instance);
				}
				return r_AddItem_GUIContent_Boolean_MenuFunction;
			}
		}

		/// <summary>
		/// Void AddItem(UnityEngine.GUIContent, Boolean, MenuFunction2, System.Object)
		/// </summary>
		protected RMethod r_AddItem_GUIContent_Boolean_MenuFunction2_Object;
		public virtual RMethod RAddItem_GUIContent_Boolean_MenuFunction2_Object
		{
			get
			{
				if(r_AddItem_GUIContent_Boolean_MenuFunction2_Object == null)
				{
					r_AddItem_GUIContent_Boolean_MenuFunction2_Object = new(this, "AddItem", 0, typeof(UnityEngine.GUIContent), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEditor.GenericMenu+MenuFunction2"), typeof(System.Object));
					r_AddItem_GUIContent_Boolean_MenuFunction2_Object.SetBelong(this.instance);
				}
				return r_AddItem_GUIContent_Boolean_MenuFunction2_Object;
			}
		}

		/// <summary>
		/// Void AddDisabledItem(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_AddDisabledItem_GUIContent;
		public virtual RMethod RAddDisabledItem_GUIContent
		{
			get
			{
				if(r_AddDisabledItem_GUIContent == null)
				{
					r_AddDisabledItem_GUIContent = new(this, "AddDisabledItem", 0, typeof(UnityEngine.GUIContent));
					r_AddDisabledItem_GUIContent.SetBelong(this.instance);
				}
				return r_AddDisabledItem_GUIContent;
			}
		}

		/// <summary>
		/// Void AddDisabledItem(UnityEngine.GUIContent, Boolean)
		/// </summary>
		protected RMethod r_AddDisabledItem_GUIContent_Boolean;
		public virtual RMethod RAddDisabledItem_GUIContent_Boolean
		{
			get
			{
				if(r_AddDisabledItem_GUIContent_Boolean == null)
				{
					r_AddDisabledItem_GUIContent_Boolean = new(this, "AddDisabledItem", 0, typeof(UnityEngine.GUIContent), typeof(System.Boolean));
					r_AddDisabledItem_GUIContent_Boolean.SetBelong(this.instance);
				}
				return r_AddDisabledItem_GUIContent_Boolean;
			}
		}

		/// <summary>
		/// Void AddSeparator(System.String)
		/// </summary>
		protected RMethod r_AddSeparator_String;
		public virtual RMethod RAddSeparator_String
		{
			get
			{
				if(r_AddSeparator_String == null)
				{
					r_AddSeparator_String = new(this, "AddSeparator", 0, typeof(System.String));
					r_AddSeparator_String.SetBelong(this.instance);
				}
				return r_AddSeparator_String;
			}
		}

		/// <summary>
		/// Int32 GetItemCount()
		/// </summary>
		protected RMethod r_GetItemCount;
		public virtual RMethod RGetItemCount
		{
			get
			{
				if(r_GetItemCount == null)
				{
					r_GetItemCount = new(this, "GetItemCount", 0);
					r_GetItemCount.SetBelong(this.instance);
				}
				return r_GetItemCount;
			}
		}

		/// <summary>
		/// Void ShowAsContext()
		/// </summary>
		protected RMethod r_ShowAsContext;
		public virtual RMethod RShowAsContext
		{
			get
			{
				if(r_ShowAsContext == null)
				{
					r_ShowAsContext = new(this, "ShowAsContext", 0);
					r_ShowAsContext.SetBelong(this.instance);
				}
				return r_ShowAsContext;
			}
		}

		/// <summary>
		/// Void DropDown(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DropDown_Rect;
		public virtual RMethod RDropDown_Rect
		{
			get
			{
				if(r_DropDown_Rect == null)
				{
					r_DropDown_Rect = new(this, "DropDown", 0, typeof(UnityEngine.Rect));
					r_DropDown_Rect.SetBelong(this.instance);
				}
				return r_DropDown_Rect;
			}
		}

		/// <summary>
		/// Void DropDown(UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_DropDown_Rect_Boolean;
		public virtual RMethod RDropDown_Rect_Boolean
		{
			get
			{
				if(r_DropDown_Rect_Boolean == null)
				{
					r_DropDown_Rect_Boolean = new(this, "DropDown", 0, typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_DropDown_Rect_Boolean.SetBelong(this.instance);
				}
				return r_DropDown_Rect_Boolean;
			}
		}

		/// <summary>
		/// Void Popup(UnityEngine.Rect, Int32)
		/// </summary>
		protected RMethod r_Popup_Rect_Int32;
		public virtual RMethod RPopup_Rect_Int32
		{
			get
			{
				if(r_Popup_Rect_Int32 == null)
				{
					r_Popup_Rect_Int32 = new(this, "Popup", 0, typeof(UnityEngine.Rect), typeof(System.Int32));
					r_Popup_Rect_Int32.SetBelong(this.instance);
				}
				return r_Popup_Rect_Int32;
			}
		}

		/// <summary>
		/// Void CatchMenu(System.Object, System.String[], Int32)
		/// </summary>
		protected RMethod r_CatchMenu_Object_StringArray_Int32;
		public virtual RMethod RCatchMenu_Object_StringArray_Int32
		{
			get
			{
				if(r_CatchMenu_Object_StringArray_Int32 == null)
				{
					r_CatchMenu_Object_StringArray_Int32 = new(this, "CatchMenu", 0, typeof(System.Object), typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_CatchMenu_Object_StringArray_Int32.SetBelong(this.instance);
				}
				return r_CatchMenu_Object_StringArray_Int32;
			}
		}

		/// <summary>
		/// Void ObjectContextDropDown(UnityEngine.Rect, UnityEngine.Object[], Int32)
		/// </summary>
		protected RMethod r_ObjectContextDropDown_Rect_ObjectArray_Int32;
		public virtual RMethod RObjectContextDropDown_Rect_ObjectArray_Int32
		{
			get
			{
				if(r_ObjectContextDropDown_Rect_ObjectArray_Int32 == null)
				{
					r_ObjectContextDropDown_Rect_ObjectArray_Int32 = new(this, "ObjectContextDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Int32));
					r_ObjectContextDropDown_Rect_ObjectArray_Int32.SetBelong(this.instance);
				}
				return r_ObjectContextDropDown_Rect_ObjectArray_Int32;
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



        public virtual void AddDisabledItem(UnityEngine.GUIContent  @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RAddDisabledItem_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDisabledItem(UnityEngine.GUIContent  @content, System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @on};
            var ___result = RAddDisabledItem_GUIContent_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSeparator(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RAddSeparator_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetItemCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetItemCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ShowAsContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowAsContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DropDown(UnityEngine.Rect  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RDropDown_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DropDown(UnityEngine.Rect  @position, System.Boolean  @shouldDiscardMenuOnSecondClick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @shouldDiscardMenuOnSecondClick};
            var ___result = RDropDown_Rect_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Popup(UnityEngine.Rect  @position, System.Int32  @selectedIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @selectedIndex};
            var ___result = RPopup_Rect_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CatchMenu(System.Object  @userData, System.String[]  @options, System.Int32  @selected)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@userData, @options, @selected};
            var ___result = RCatchMenu_Object_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ObjectContextDropDown(UnityEngine.Rect  @position, UnityEngine.Object[]  @context, System.Int32  @contextUserData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @context, @contextUserData};
            var ___result = RObjectContextDropDown_Rect_ObjectArray_Int32.Invoke(___genericsType, ___parameters);

            
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
