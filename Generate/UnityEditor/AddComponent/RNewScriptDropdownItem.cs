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
		protected RFieldArray<RSystem.RChar> r_FkInvalidPathChars;
		public virtual RFieldArray<RSystem.RChar> RFkInvalidPathChars
		{
			get
			{
				if(r_FkInvalidPathChars == null)
				{
					r_FkInvalidPathChars = new(this, "kInvalidPathChars");
					r_FkInvalidPathChars.SetBelong(this.instance);
				}
				return r_FkInvalidPathChars;
			}
		}

		/// <summary>
		/// System.Char[] kPathSepChars
		/// </summary>
		protected RFieldArray<RSystem.RChar> r_FkPathSepChars;
		public virtual RFieldArray<RSystem.RChar> RFkPathSepChars
		{
			get
			{
				if(r_FkPathSepChars == null)
				{
					r_FkPathSepChars = new(this, "kPathSepChars");
					r_FkPathSepChars.SetBelong(this.instance);
				}
				return r_FkPathSepChars;
			}
		}

		/// <summary>
		/// System.String kResourcesTemplatePath
		/// </summary>
		protected RSystem.RString r_FkResourcesTemplatePath;
		public virtual RSystem.RString RFkResourcesTemplatePath
		{
			get
			{
				if(r_FkResourcesTemplatePath == null)
				{
					r_FkResourcesTemplatePath = new(this, "kResourcesTemplatePath");
					r_FkResourcesTemplatePath.SetBelong(this.instance);
				}
				return r_FkResourcesTemplatePath;
			}
		}

		/// <summary>
		/// System.String m_Directory
		/// </summary>
		protected RSystem.RString r_Fm_Directory;
		public virtual RSystem.RString RFm_Directory
		{
			get
			{
				if(r_Fm_Directory == null)
				{
					r_Fm_Directory = new(this, "m_Directory");
					r_Fm_Directory.SetBelong(this.instance);
				}
				return r_Fm_Directory;
			}
		}

		/// <summary>
		/// System.String m_ClassName
		/// </summary>
		protected RSystem.RString r_Fm_ClassName;
		public virtual RSystem.RString RFm_ClassName
		{
			get
			{
				if(r_Fm_ClassName == null)
				{
					r_Fm_ClassName = new(this, "m_ClassName");
					r_Fm_ClassName.SetBelong(this.instance);
				}
				return r_Fm_ClassName;
			}
		}

		/// <summary>
		/// System.String className
		/// </summary>
		protected RSystem.RString r_PclassName;
		public virtual RSystem.RString RPclassName
		{
			get
			{
				if(r_PclassName == null)
				{
					r_PclassName = new(this, "className", -1);
					r_PclassName.SetBelong(this.instance);
				}
				return r_PclassName;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected RSystem.RString r_PdisplayName;
		public virtual RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String searchableName
		/// </summary>
		protected RSystem.RString r_PsearchableName;
		public virtual RSystem.RString RPsearchableName
		{
			get
			{
				if(r_PsearchableName == null)
				{
					r_PsearchableName = new(this, "searchableName", -1);
					r_PsearchableName.SetBelong(this.instance);
				}
				return r_PsearchableName;
			}
		}

		/// <summary>
		/// System.String searchableNameLocalized
		/// </summary>
		protected RSystem.RString r_PsearchableNameLocalized;
		public virtual RSystem.RString RPsearchableNameLocalized
		{
			get
			{
				if(r_PsearchableNameLocalized == null)
				{
					r_PsearchableNameLocalized = new(this, "searchableNameLocalized", -1);
					r_PsearchableNameLocalized.SetBelong(this.instance);
				}
				return r_PsearchableNameLocalized;
			}
		}

		/// <summary>
		/// System.String localizedName
		/// </summary>
		protected RSystem.RString r_PlocalizedName;
		public virtual RSystem.RString RPlocalizedName
		{
			get
			{
				if(r_PlocalizedName == null)
				{
					r_PlocalizedName = new(this, "localizedName", -1);
					r_PlocalizedName.SetBelong(this.instance);
				}
				return r_PlocalizedName;
			}
		}

		/// <summary>
		/// System.String menuPath
		/// </summary>
		protected RSystem.RString r_PmenuPath;
		public virtual RSystem.RString RPmenuPath
		{
			get
			{
				if(r_PmenuPath == null)
				{
					r_PmenuPath = new(this, "menuPath", -1);
					r_PmenuPath.SetBelong(this.instance);
				}
				return r_PmenuPath;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected RUnityEngine.RGUIContent r_Pcontent;
		public virtual RUnityEngine.RGUIContent RPcontent
		{
			get
			{
				if(r_Pcontent == null)
				{
					r_Pcontent = new(this, "content", -1);
					r_Pcontent.SetBelong(this.instance);
				}
				return r_Pcontent;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RSystem.RString r_Ptooltip;
		public virtual RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D icon
		/// </summary>
		protected RUnityEngine.RTexture2D r_Picon;
		public virtual RUnityEngine.RTexture2D RPicon
		{
			get
			{
				if(r_Picon == null)
				{
					r_Picon = new(this, "icon", -1);
					r_Picon.SetBelong(this.instance);
				}
				return r_Picon;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected RSystem.RInt32 r_Pid;
		public virtual RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.instance);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Int32 elementIndex
		/// </summary>
		protected RSystem.RInt32 r_PelementIndex;
		public virtual RSystem.RInt32 RPelementIndex
		{
			get
			{
				if(r_PelementIndex == null)
				{
					r_PelementIndex = new(this, "elementIndex", -1);
					r_PelementIndex.SetBelong(this.instance);
				}
				return r_PelementIndex;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RSystem.RBoolean r_Penabled;
		public virtual RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
					r_Penabled.SetBelong(this.instance);
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_PuserData;
		public virtual RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
					r_PuserData.SetBelong(this.instance);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem] children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> r_Pchildren;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.RIMGUI.RControls.RAdvancedDropdownItem> RPchildren
		{
			get
			{
				if(r_Pchildren == null)
				{
					r_Pchildren = new(this, "children", -1);
					r_Pchildren.SetBelong(this.instance);
				}
				return r_Pchildren;
			}
		}

		/// <summary>
		/// Boolean hasChildren
		/// </summary>
		protected RSystem.RBoolean r_PhasChildren;
		public virtual RSystem.RBoolean RPhasChildren
		{
			get
			{
				if(r_PhasChildren == null)
				{
					r_PhasChildren = new(this, "hasChildren", -1);
					r_PhasChildren.SetBelong(this.instance);
				}
				return r_PhasChildren;
			}
		}

		/// <summary>
		/// Boolean CanCreate()
		/// </summary>
		protected RMethod r_MCanCreate;
		public virtual RMethod RMCanCreate
		{
			get
			{
				if(r_MCanCreate == null)
				{
					r_MCanCreate = new(this, "CanCreate", 0);
					r_MCanCreate.SetBelong(this.instance);
				}
				return r_MCanCreate;
			}
		}

		/// <summary>
		/// System.String GetError()
		/// </summary>
		protected RMethod r_MGetError;
		public virtual RMethod RMGetError
		{
			get
			{
				if(r_MGetError == null)
				{
					r_MGetError = new(this, "GetError", 0);
					r_MGetError.SetBelong(this.instance);
				}
				return r_MGetError;
			}
		}

		/// <summary>
		/// Void Create(UnityEngine.GameObject[], System.String)
		/// </summary>
		protected RMethod r_MCreate_GameObjectArray_String;
		public virtual RMethod RMCreate_GameObjectArray_String
		{
			get
			{
				if(r_MCreate_GameObjectArray_String == null)
				{
					r_MCreate_GameObjectArray_String = new(this, "Create", 0, typeof(UnityEngine.GameObject).MakeArrayType(), typeof(System.String));
					r_MCreate_GameObjectArray_String.SetBelong(this.instance);
				}
				return r_MCreate_GameObjectArray_String;
			}
		}

		/// <summary>
		/// Boolean InvalidTargetPath()
		/// </summary>
		protected RMethod r_MInvalidTargetPath;
		public virtual RMethod RMInvalidTargetPath
		{
			get
			{
				if(r_MInvalidTargetPath == null)
				{
					r_MInvalidTargetPath = new(this, "InvalidTargetPath", 0);
					r_MInvalidTargetPath.SetBelong(this.instance);
				}
				return r_MInvalidTargetPath;
			}
		}

		/// <summary>
		/// System.String TargetPath()
		/// </summary>
		protected RMethod r_MTargetPath;
		public virtual RMethod RMTargetPath
		{
			get
			{
				if(r_MTargetPath == null)
				{
					r_MTargetPath = new(this, "TargetPath", 0);
					r_MTargetPath.SetBelong(this.instance);
				}
				return r_MTargetPath;
			}
		}

		/// <summary>
		/// System.String TargetDir()
		/// </summary>
		protected RMethod r_MTargetDir;
		public virtual RMethod RMTargetDir
		{
			get
			{
				if(r_MTargetDir == null)
				{
					r_MTargetDir = new(this, "TargetDir", 0);
					r_MTargetDir.SetBelong(this.instance);
				}
				return r_MTargetDir;
			}
		}

		/// <summary>
		/// Boolean ClassNameIsInvalid()
		/// </summary>
		protected RMethod r_MClassNameIsInvalid;
		public virtual RMethod RMClassNameIsInvalid
		{
			get
			{
				if(r_MClassNameIsInvalid == null)
				{
					r_MClassNameIsInvalid = new(this, "ClassNameIsInvalid", 0);
					r_MClassNameIsInvalid.SetBelong(this.instance);
				}
				return r_MClassNameIsInvalid;
			}
		}

		/// <summary>
		/// Boolean ClassExists(System.String)
		/// </summary>
		protected RMethod r_MClassExists_String;
		public virtual RMethod RMClassExists_String
		{
			get
			{
				if(r_MClassExists_String == null)
				{
					r_MClassExists_String = new(this, "ClassExists", 0, typeof(System.String));
					r_MClassExists_String.SetBelong(this.instance);
				}
				return r_MClassExists_String;
			}
		}

		/// <summary>
		/// Boolean ClassAlreadyExists()
		/// </summary>
		protected RMethod r_MClassAlreadyExists;
		public virtual RMethod RMClassAlreadyExists
		{
			get
			{
				if(r_MClassAlreadyExists == null)
				{
					r_MClassAlreadyExists = new(this, "ClassAlreadyExists", 0);
					r_MClassAlreadyExists.SetBelong(this.instance);
				}
				return r_MClassAlreadyExists;
			}
		}

		/// <summary>
		/// System.String GetTemplatePath()
		/// </summary>
		protected RMethod r_MGetTemplatePath;
		public virtual RMethod RMGetTemplatePath
		{
			get
			{
				if(r_MGetTemplatePath == null)
				{
					r_MGetTemplatePath = new(this, "GetTemplatePath", 0);
					r_MGetTemplatePath.SetBelong(this.instance);
				}
				return r_MGetTemplatePath;
			}
		}

		/// <summary>
		/// Void CreateScript()
		/// </summary>
		protected RMethod r_MCreateScript;
		public virtual RMethod RMCreateScript
		{
			get
			{
				if(r_MCreateScript == null)
				{
					r_MCreateScript = new(this, "CreateScript", 0);
					r_MCreateScript.SetBelong(this.instance);
				}
				return r_MCreateScript;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
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

		/// <summary>
		/// Void set_displayName(System.String)
		/// </summary>
		protected RMethod r_Mset_displayName_String;
		public virtual RMethod RMset_displayName_String
		{
			get
			{
				if(r_Mset_displayName_String == null)
				{
					r_Mset_displayName_String = new(this, "set_displayName", 0, typeof(System.String));
					r_Mset_displayName_String.SetBelong(this.instance);
				}
				return r_Mset_displayName_String;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)
		/// </summary>
		protected RMethod r_MAddChild_AdvancedDropdownItem;
		public virtual RMethod RMAddChild_AdvancedDropdownItem
		{
			get
			{
				if(r_MAddChild_AdvancedDropdownItem == null)
				{
					r_MAddChild_AdvancedDropdownItem = new(this, "AddChild", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem));
					r_MAddChild_AdvancedDropdownItem.SetBelong(this.instance);
				}
				return r_MAddChild_AdvancedDropdownItem;
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
		/// Void AddSeparator()
		/// </summary>
		protected RMethod r_MAddSeparator;
		public virtual RMethod RMAddSeparator
		{
			get
			{
				if(r_MAddSeparator == null)
				{
					r_MAddSeparator = new(this, "AddSeparator", 0);
					r_MAddSeparator.SetBelong(this.instance);
				}
				return r_MAddSeparator;
			}
		}

		/// <summary>
		/// Boolean IsSeparator()
		/// </summary>
		protected RMethod r_MIsSeparator;
		public virtual RMethod RMIsSeparator
		{
			get
			{
				if(r_MIsSeparator == null)
				{
					r_MIsSeparator = new(this, "IsSeparator", 0);
					r_MIsSeparator.SetBelong(this.instance);
				}
				return r_MIsSeparator;
			}
		}

		/// <summary>
		/// Void SortChildren(System.Comparison`1[UnityEditor.IMGUI.Controls.AdvancedDropdownItem], Boolean)
		/// </summary>
		protected RMethod r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean;
		public virtual RMethod RMSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean
		{
			get
			{
				if(r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean == null)
				{
					r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean = new(this, "SortChildren", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem)), typeof(System.Boolean));
					r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.SetBelong(this.instance);
				}
				return r_MSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean;
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
            var ___result = RMCanCreate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetError.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Create(UnityEngine.GameObject[] @gameObjects, System.String @searchString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gameObjects, @searchString};
            var ___result = RMCreate_GameObjectArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InvalidTargetPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvalidTargetPath.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String TargetPath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTargetPath.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String TargetDir()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTargetDir.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ClassNameIsInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClassNameIsInvalid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ClassExists(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMClassExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ClassAlreadyExists()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClassAlreadyExists.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetTemplatePath()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTemplatePath.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CreateScript()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateScript.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 CompareTo(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void set_displayName(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_displayName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAddChild_AdvancedDropdownItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddSeparator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsSeparator.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SortChildren(System.Comparison<UnityEditor.IMGUI.Controls.AdvancedDropdownItem> @comparer, System.Boolean @recursive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparer, @recursive};
            var ___result = RMSortChildren_Comparison_d_AdvancedDropdownItem_p__Boolean.Invoke(___genericsType, ___parameters);

            
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


    }
}
