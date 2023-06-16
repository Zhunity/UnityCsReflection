
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy
	/// </summary>
    public partial class RAssetDatabaseProxy : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy");
            }
        }

        public RAssetDatabaseProxy() : base("UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy")
        {
        }

        public RAssetDatabaseProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy")
		{
            SetInstance(instance);
		}

        public RAssetDatabaseProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetDatabaseProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void ImportPackage(System.String, Boolean)
		/// </summary>
		protected RMethod r_MImportPackage_String_Boolean;
		public virtual RMethod RMImportPackage_String_Boolean
		{
			get
			{
				if(r_MImportPackage_String_Boolean == null)
				{
					r_MImportPackage_String_Boolean = new(this, "ImportPackage", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MImportPackage_String_Boolean;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_MRefresh;
		public virtual RMethod RMRefresh
		{
			get
			{
				if(r_MRefresh == null)
				{
					r_MRefresh = new(this, "Refresh", 0);
				}
				return r_MRefresh;
			}
		}

		/// <summary>
		/// T LoadAssetAtPath[T](System.String)
		/// </summary>
		protected RMethod r_MLoadAssetAtPath_GT_String;
		public virtual RMethod RMLoadAssetAtPath_GT_String
		{
			get
			{
				if(r_MLoadAssetAtPath_GT_String == null)
				{
					r_MLoadAssetAtPath_GT_String = new(this, "LoadAssetAtPath", 1, typeof(System.String));
				}
				return r_MLoadAssetAtPath_GT_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object LoadMainAssetAtPath(System.String)
		/// </summary>
		protected RMethod r_MLoadMainAssetAtPath_String;
		public virtual RMethod RMLoadMainAssetAtPath_String
		{
			get
			{
				if(r_MLoadMainAssetAtPath_String == null)
				{
					r_MLoadMainAssetAtPath_String = new(this, "LoadMainAssetAtPath", 0, typeof(System.String));
				}
				return r_MLoadMainAssetAtPath_String;
			}
		}

		/// <summary>
		/// Boolean GetAssetFolderInfo(System.String, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetAssetFolderInfo_String_Out_Boolean_Out_Boolean;
		public virtual RMethod RMGetAssetFolderInfo_String_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MGetAssetFolderInfo_String_Out_Boolean_Out_Boolean == null)
				{
					r_MGetAssetFolderInfo_String_Out_Boolean_Out_Boolean = new(this, "GetAssetFolderInfo", 0, typeof(System.String), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
				}
				return r_MGetAssetFolderInfo_String_Out_Boolean_Out_Boolean;
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


        public virtual void ImportPackage(System.String @packagePath, System.Boolean @interactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packagePath, @interactive};
            var ___result = RMImportPackage_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T LoadAssetAtPath<T>(System.String @assetPath) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@assetPath};
            var ___result = RMLoadAssetAtPath_GT_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual UnityEngine.Object LoadMainAssetAtPath(System.String @assetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetPath};
            var ___result = RMLoadMainAssetAtPath_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Object>(___result);
        }


        public virtual System.Boolean GetAssetFolderInfo(System.String @path, out System.Boolean @rootFolder, out System.Boolean @immutable)
        {
			@rootFolder = default;
			@immutable = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @rootFolder, @immutable};
            var ___result = RMGetAssetFolderInfo_String_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@rootFolder = ReflectionUtils.Convert<System.Boolean>(___parameters[1]);
			@immutable = ReflectionUtils.Convert<System.Boolean>(___parameters[2]);

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
