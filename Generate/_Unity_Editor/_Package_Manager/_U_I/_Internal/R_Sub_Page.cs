
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.SubPage
	/// </summary>
    public partial class RSubPage : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.SubPage");
            }
        }

        public RSubPage() : base("UnityEditor.PackageManager.UI.Internal.SubPage")
        {
        }

        public RSubPage(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.SubPage")
		{
            SetInstance(instance);
		}

        public RSubPage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSubPage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab <tab>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_F__0__tab__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RF__0__tab__1__k__BackingField
		{
			get
			{
				if(r_F__0__tab__1__k__BackingField == null)
				{
					r_F__0__tab__1__k__BackingField = new(this, "<tab>k__BackingField");
				}
				return r_F__0__tab__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__name__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__name__1__k__BackingField
		{
			get
			{
				if(r_F__0__name__1__k__BackingField == null)
				{
					r_F__0__name__1__k__BackingField = new(this, "<name>k__BackingField");
				}
				return r_F__0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <displayName>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__displayName__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__displayName__1__k__BackingField
		{
			get
			{
				if(r_F__0__displayName__1__k__BackingField == null)
				{
					r_F__0__displayName__1__k__BackingField = new(this, "<displayName>k__BackingField");
				}
				return r_F__0__displayName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <priority>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__priority__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__priority__1__k__BackingField
		{
			get
			{
				if(r_F__0__priority__1__k__BackingField == null)
				{
					r_F__0__priority__1__k__BackingField = new(this, "<priority>k__BackingField");
				}
				return r_F__0__priority__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <contentType>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__contentType__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__contentType__1__k__BackingField
		{
			get
			{
				if(r_F__0__contentType__1__k__BackingField == null)
				{
					r_F__0__contentType__1__k__BackingField = new(this, "<contentType>k__BackingField");
				}
				return r_F__0__contentType__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEditor.PackageManager.UI.Internal.IPackage,System.Boolean] <filter>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RBoolean> r_F__0__filter__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RBoolean> RF__0__filter__1__k__BackingField
		{
			get
			{
				if(r_F__0__filter__1__k__BackingField == null)
				{
					r_F__0__filter__1__k__BackingField = new(this, "<filter>k__BackingField");
				}
				return r_F__0__filter__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEditor.PackageManager.UI.Internal.IPackage,System.String] <getGroupName>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RString> r_F__0__getGroupName__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RString> RF__0__getGroupName__1__k__BackingField
		{
			get
			{
				if(r_F__0__getGroupName__1__k__BackingField == null)
				{
					r_F__0__getGroupName__1__k__BackingField = new(this, "<getGroupName>k__BackingField");
				}
				return r_F__0__getGroupName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`3[System.String,System.String,System.Int32] <compareGroup>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> r_F__0__compareGroup__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> RF__0__compareGroup__1__k__BackingField
		{
			get
			{
				if(r_F__0__compareGroup__1__k__BackingField == null)
				{
					r_F__0__compareGroup__1__k__BackingField = new(this, "<compareGroup>k__BackingField");
				}
				return r_F__0__compareGroup__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageFilterTab tab
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab r_Ptab;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageFilterTab RPtab
		{
			get
			{
				if(r_Ptab == null)
				{
					r_Ptab = new(this, "tab", -1);
				}
				return r_Ptab;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ppriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpriority
		{
			get
			{
				if(r_Ppriority == null)
				{
					r_Ppriority = new(this, "priority", -1);
				}
				return r_Ppriority;
			}
		}

		/// <summary>
		/// System.String contentType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PcontentType;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPcontentType
		{
			get
			{
				if(r_PcontentType == null)
				{
					r_PcontentType = new(this, "contentType", -1);
				}
				return r_PcontentType;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEditor.PackageManager.UI.Internal.IPackage,System.Boolean] filter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RBoolean> r_Pfilter;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RBoolean> RPfilter
		{
			get
			{
				if(r_Pfilter == null)
				{
					r_Pfilter = new(this, "filter", -1);
				}
				return r_Pfilter;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEditor.PackageManager.UI.Internal.IPackage,System.String] getGroupName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RString> r_PgetGroupName;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage, Hvak.Editor.Refleaction.RSystem.RString> RPgetGroupName
		{
			get
			{
				if(r_PgetGroupName == null)
				{
					r_PgetGroupName = new(this, "getGroupName", -1);
				}
				return r_PgetGroupName;
			}
		}

		/// <summary>
		/// System.Func`3[System.String,System.String,System.Int32] compareGroup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> r_PcompareGroup;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> RPcompareGroup
		{
			get
			{
				if(r_PcompareGroup == null)
				{
					r_PcompareGroup = new(this, "compareGroup", -1);
				}
				return r_PcompareGroup;
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
