
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PackageSizeInfo
	/// </summary>
    public partial class RPackageSizeInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageSizeInfo");
            }
        }

        public RPackageSizeInfo() : base("UnityEditor.PackageManager.UI.Internal.PackageSizeInfo")
        {
        }

        public RPackageSizeInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageSizeInfo")
		{
            SetInstance(instance);
		}

        public RPackageSizeInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageSizeInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_SupportedUnityVersionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_SupportedUnityVersionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_SupportedUnityVersionString
		{
			get
			{
				if(r_Fm_SupportedUnityVersionString == null)
				{
					r_Fm_SupportedUnityVersionString = new(this, "m_SupportedUnityVersionString");
				}
				return r_Fm_SupportedUnityVersionString;
			}
		}

		/// <summary>
		/// UnityEditor.Scripting.ScriptCompilation.SemVersion m_SupportedUnityVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion r_Fm_SupportedUnityVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion RFm_SupportedUnityVersion
		{
			get
			{
				if(r_Fm_SupportedUnityVersion == null)
				{
					r_Fm_SupportedUnityVersion = new(this, "m_SupportedUnityVersion");
				}
				return r_Fm_SupportedUnityVersion;
			}
		}

		/// <summary>
		/// System.UInt64 assetCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_FassetCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFassetCount
		{
			get
			{
				if(r_FassetCount == null)
				{
					r_FassetCount = new(this, "assetCount");
				}
				return r_FassetCount;
			}
		}

		/// <summary>
		/// System.UInt64 downloadSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_FdownloadSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFdownloadSize
		{
			get
			{
				if(r_FdownloadSize == null)
				{
					r_FdownloadSize = new(this, "downloadSize");
				}
				return r_FdownloadSize;
			}
		}

		/// <summary>
		/// UnityEditor.Scripting.ScriptCompilation.SemVersion supportedUnityVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion r_PsupportedUnityVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion RPsupportedUnityVersion
		{
			get
			{
				if(r_PsupportedUnityVersion == null)
				{
					r_PsupportedUnityVersion = new(this, "supportedUnityVersion", -1);
				}
				return r_PsupportedUnityVersion;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
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


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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
