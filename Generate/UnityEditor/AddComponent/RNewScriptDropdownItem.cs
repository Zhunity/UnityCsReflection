using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RAddComponent
{
	/// <summary>
	/// UnityEditor.AddComponent.NewScriptDropdownItem
	/// </summary>
    public partial class RNewScriptDropdownItem : RMember //
    {

		/// <summary>
		/// System.Char[] kInvalidPathChars
		/// </summary>
		protected RFieldArray<RField> r_kInvalidPathChars;
		public virtual RFieldArray<RField> RkInvalidPathChars
		{
			get
			{
				if(r_kInvalidPathChars == null)
				{
					r_kInvalidPathChars = new(this, "kInvalidPathChars");
					r_kInvalidPathChars.SetBelong(this.instance);
				}
				return r_kInvalidPathChars;
			}
		}

		/// <summary>
		/// System.Char[] kPathSepChars
		/// </summary>
		protected RFieldArray<RField> r_kPathSepChars;
		public virtual RFieldArray<RField> RkPathSepChars
		{
			get
			{
				if(r_kPathSepChars == null)
				{
					r_kPathSepChars = new(this, "kPathSepChars");
					r_kPathSepChars.SetBelong(this.instance);
				}
				return r_kPathSepChars;
			}
		}

		/// <summary>
		/// System.String kResourcesTemplatePath
		/// </summary>
		protected RField r_kResourcesTemplatePath;
		public virtual RField RkResourcesTemplatePath
		{
			get
			{
				if(r_kResourcesTemplatePath == null)
				{
					r_kResourcesTemplatePath = new(this, "kResourcesTemplatePath");
					r_kResourcesTemplatePath.SetBelong(this.instance);
				}
				return r_kResourcesTemplatePath;
			}
		}

		/// <summary>
		/// System.String m_Directory
		/// </summary>
		protected RField r_m_Directory;
		public virtual RField Rm_Directory
		{
			get
			{
				if(r_m_Directory == null)
				{
					r_m_Directory = new(this, "m_Directory");
					r_m_Directory.SetBelong(this.instance);
				}
				return r_m_Directory;
			}
		}

		/// <summary>
		/// System.String m_ClassName
		/// </summary>
		protected RField r_m_ClassName;
		public virtual RField Rm_ClassName
		{
			get
			{
				if(r_m_ClassName == null)
				{
					r_m_ClassName = new(this, "m_ClassName");
					r_m_ClassName.SetBelong(this.instance);
				}
				return r_m_ClassName;
			}
		}

		/// <summary>
		/// System.String className
		/// </summary>
		protected RProperty r_className;
		public virtual RProperty RclassName
		{
			get
			{
				if(r_className == null)
				{
					r_className = new(this, "className", -1);
					r_className.SetBelong(this.instance);
				}
				return r_className;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected RProperty r_displayName;
		public virtual RProperty RdisplayName
		{
			get
			{
				if(r_displayName == null)
				{
					r_displayName = new(this, "displayName", -1);
					r_displayName.SetBelong(this.instance);
				}
				return r_displayName;
			}
		}

		/// <summary>
		/// System.String searchableName
		/// </summary>
		protected RProperty r_searchableName;
		public virtual RProperty RsearchableName
		{
			get
			{
				if(r_searchableName == null)
				{
					r_searchableName = new(this, "searchableName", -1);
					r_searchableName.SetBelong(this.instance);
				}
				return r_searchableName;
			}
		}

		/// <summary>
		/// System.String searchableNameLocalized
		/// </summary>
		protected RProperty r_searchableNameLocalized;
		public virtual RProperty RsearchableNameLocalized
		{
			get
			{
				if(r_searchableNameLocalized == null)
				{
					r_searchableNameLocalized = new(this, "searchableNameLocalized", -1);
					r_searchableNameLocalized.SetBelong(this.instance);
				}
				return r_searchableNameLocalized;
			}
		}

		/// <summary>
		/// System.String localizedName
		/// </summary>
		protected RProperty r_localizedName;
		public virtual RProperty RlocalizedName
		{
			get
			{
				if(r_localizedName == null)
				{
					r_localizedName = new(this, "localizedName", -1);
					r_localizedName.SetBelong(this.instance);
				}
				return r_localizedName;
			}
		}

		/// <summary>
		/// System.String menuPath
		/// </summary>
		protected RProperty r_menuPath;
		public virtual RProperty RmenuPath
		{
			get
			{
				if(r_menuPath == null)
				{
					r_menuPath = new(this, "menuPath", -1);
					r_menuPath.SetBelong(this.instance);
				}
				return r_menuPath;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected RUnityEngine.RGUIContent r_content;
		public virtual RUnityEngine.RGUIContent Rcontent
		{
			get
			{
				if(r_content == null)
				{
					r_content = new(this, "content", -1);
					r_content.SetBelong(this.instance);
				}
				return r_content;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RProperty r_tooltip;
		public virtual RProperty Rtooltip
		{
			get
			{
				if(r_tooltip == null)
				{
					r_tooltip = new(this, "tooltip", -1);
					r_tooltip.SetBelong(this.instance);
				}
				return r_tooltip;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected RUnityEngine.RTexture2D r_icon;
		public virtual RUnityEngine.RTexture2D Ricon
		{
			get
			{
				if(r_icon == null)
				{
					r_icon = new(this, "icon", -1);
					r_icon.SetBelong(this.instance);
				}
				return r_icon;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// Int32 elementIndex
		/// </summary>
		protected RProperty r_elementIndex;
		public virtual RProperty RelementIndex
		{
			get
			{
				if(r_elementIndex == null)
				{
					r_elementIndex = new(this, "elementIndex", -1);
					r_elementIndex.SetBelong(this.instance);
				}
				return r_elementIndex;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData", -1);
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_children;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> Rchildren
		{
			get
			{
				if(r_children == null)
				{
					r_children = new(this, "children", -1);
					r_children.SetBelong(this.instance);
				}
				return r_children;
			}
		}

		/// <summary>
		/// Boolean hasChildren
		/// </summary>
		protected RProperty r_hasChildren;
		public virtual RProperty RhasChildren
		{
			get
			{
				if(r_hasChildren == null)
				{
					r_hasChildren = new(this, "hasChildren", -1);
					r_hasChildren.SetBelong(this.instance);
				}
				return r_hasChildren;
			}
		}

		/// <summary>
		/// Boolean CanCreate()
		/// </summary>
		protected RMethod r_RCanCreate;
		public virtual RMethod RCanCreate
		{
			get
			{
				if(r_RCanCreate == null)
				{
					r_RCanCreate = new(this, "CanCreate", 0);
					r_RCanCreate.SetBelong(this.instance);
				}
				return r_RCanCreate;
			}
		}

		/// <summary>
		/// System.String GetError()
		/// </summary>
		protected RMethod r_RGetError;
		public virtual RMethod RGetError
		{
			get
			{
				if(r_RGetError == null)
				{
					r_RGetError = new(this, "GetError", 0);
					r_RGetError.SetBelong(this.instance);
				}
				return r_RGetError;
			}
		}

		/// <summary>
		/// Void Create(UnityEngine.GameObject[], System.String)
		/// </summary>
		protected RMethod r_RCreate_GameObjectArray_String;
		public virtual RMethod RCreate_GameObjectArray_String
		{
			get
			{
				if(r_RCreate_GameObjectArray_String == null)
				{
					r_RCreate_GameObjectArray_String = new(this, "Create", 0, typeof(UnityEngine.GameObject).MakeArrayType(), typeof(System.String));
					r_RCreate_GameObjectArray_String.SetBelong(this.instance);
				}
				return r_RCreate_GameObjectArray_String;
			}
		}

		/// <summary>
		/// Boolean InvalidTargetPath()
		/// </summary>
		protected RMethod r_RInvalidTargetPath;
		public virtual RMethod RInvalidTargetPath
		{
			get
			{
				if(r_RInvalidTargetPath == null)
				{
					r_RInvalidTargetPath = new(this, "InvalidTargetPath", 0);
					r_RInvalidTargetPath.SetBelong(this.instance);
				}
				return r_RInvalidTargetPath;
			}
		}

		/// <summary>
		/// System.String TargetPath()
		/// </summary>
		protected RMethod r_RTargetPath;
		public virtual RMethod RTargetPath
		{
			get
			{
				if(r_RTargetPath == null)
				{
					r_RTargetPath = new(this, "TargetPath", 0);
					r_RTargetPath.SetBelong(this.instance);
				}
				return r_RTargetPath;
			}
		}

		/// <summary>
		/// System.String TargetDir()
		/// </summary>
		protected RMethod r_RTargetDir;
		public virtual RMethod RTargetDir
		{
			get
			{
				if(r_RTargetDir == null)
				{
					r_RTargetDir = new(this, "TargetDir", 0);
					r_RTargetDir.SetBelong(this.instance);
				}
				return r_RTargetDir;
			}
		}

		/// <summary>
		/// Boolean ClassNameIsInvalid()
		/// </summary>
		protected RMethod r_RClassNameIsInvalid;
		public virtual RMethod RClassNameIsInvalid
		{
			get
			{
				if(r_RClassNameIsInvalid == null)
				{
					r_RClassNameIsInvalid = new(this, "ClassNameIsInvalid", 0);
					r_RClassNameIsInvalid.SetBelong(this.instance);
				}
				return r_RClassNameIsInvalid;
			}
		}

		/// <summary>
		/// Boolean ClassExists(System.String)
		/// </summary>
		protected RMethod r_RClassExists_String;
		public virtual RMethod RClassExists_String
		{
			get
			{
				if(r_RClassExists_String == null)
				{
					r_RClassExists_String = new(this, "ClassExists", 0, typeof(System.String));
					r_RClassExists_String.SetBelong(this.instance);
				}
				return r_RClassExists_String;
			}
		}

		/// <summary>
		/// Boolean ClassAlreadyExists()
		/// </summary>
		protected RMethod r_RClassAlreadyExists;
		public virtual RMethod RClassAlreadyExists
		{
			get
			{
				if(r_RClassAlreadyExists == null)
				{
					r_RClassAlreadyExists = new(this, "ClassAlreadyExists", 0);
					r_RClassAlreadyExists.SetBelong(this.instance);
				}
				return r_RClassAlreadyExists;
			}
		}

		/// <summary>
		/// System.String GetTemplatePath()
		/// </summary>
		protected RMethod r_RGetTemplatePath;
		public virtual RMethod RGetTemplatePath
		{
			get
			{
				if(r_RGetTemplatePath == null)
				{
					r_RGetTemplatePath = new(this, "GetTemplatePath", 0);
					r_RGetTemplatePath.SetBelong(this.instance);
				}
				return r_RGetTemplatePath;
			}
		}

		/// <summary>
		/// Void CreateScript()
		/// </summary>
		protected RMethod r_RCreateScript;
		public virtual RMethod RCreateScript
		{
			get
			{
				if(r_RCreateScript == null)
				{
					r_RCreateScript = new(this, "CreateScript", 0);
					r_RCreateScript.SetBelong(this.instance);
				}
				return r_RCreateScript;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RCompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_RCompareTo_Object == null)
				{
					r_RCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_RCompareTo_Object.SetBelong(this.instance);
				}
				return r_RCompareTo_Object;
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

		/// <summary>
		/// Void set_displayName(System.String)
		/// </summary>
		protected RMethod r_Rset_displayName_String;
		public virtual RMethod Rset_displayName_String
		{
			get
			{
				if(r_Rset_displayName_String == null)
				{
					r_Rset_displayName_String = new(this, "set_displayName", 0, typeof(System.String));
					r_Rset_displayName_String.SetBelong(this.instance);
				}
				return r_Rset_displayName_String;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_RAddChild_AdvancedDropdownItem;
		public virtual RMethod RAddChild_AdvancedDropdownItem
		{
			get
			{
				if(r_RAddChild_AdvancedDropdownItem == null)
				{
					r_RAddChild_AdvancedDropdownItem = new(this, "AddChild", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_RAddChild_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_RAddChild_AdvancedDropdownItem;
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
		/// Void AddSeparator()
		/// </summary>
		protected RMethod r_RAddSeparator;
		public virtual RMethod RAddSeparator
		{
			get
			{
				if(r_RAddSeparator == null)
				{
					r_RAddSeparator = new(this, "AddSeparator", 0);
					r_RAddSeparator.SetBelong(this.instance);
				}
				return r_RAddSeparator;
			}
		}

		/// <summary>
		/// Boolean IsSeparator()
		/// </summary>
		protected RMethod r_RIsSeparator;
		public virtual RMethod RIsSeparator
		{
			get
			{
				if(r_RIsSeparator == null)
				{
					r_RIsSeparator = new(this, "IsSeparator", 0);
					r_RIsSeparator.SetBelong(this.instance);
				}
				return r_RIsSeparator;
			}
		}

		/// <summary>
		/// Void SortChildren(System.Comparison`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem], Boolean)
		/// </summary>
		protected RMethod r_RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean;
		public virtual RMethod RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean
		{
			get
			{
				if(r_RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean == null)
				{
					r_RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean = new(this, "SortChildren", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)), typeof(System.Boolean));
					r_RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.SetBelong(this.instance);
				}
				return r_RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean;
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


        public RNewScriptDropdownItem() : base("UnityEditor.AddComponent.NewScriptDropdownItem")
        {
        }

        public RNewScriptDropdownItem(System.Object instance) : base("UnityEditor.AddComponent.NewScriptDropdownItem")
		{
            SetInstance(instance);
		}

        public RNewScriptDropdownItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNewScriptDropdownItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean CanCreate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanCreate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetError.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Create(UnityEngine.GameObject[]  @gameObjects, System.String  @searchString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gameObjects, @searchString};
            var ___result = RCreate_GameObjectArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InvalidTargetPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidTargetPath.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String TargetPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTargetPath.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TargetDir()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTargetDir.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ClassNameIsInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClassNameIsInvalid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ClassExists(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RClassExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ClassAlreadyExists()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClassAlreadyExists.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetTemplatePath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTemplatePath.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CreateScript()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateScript.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 CompareTo(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void set_displayName(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_displayName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RAddChild_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddSeparator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsSeparator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SortChildren(System.Comparison<UnityEditor.IMGUI.Controls.AdvancedDropdownItem>  @comparer, System.Boolean  @recursive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer, @recursive};
            var ___result = RSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.Invoke(___genericsType, ___parameters);

            
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


    }
}
