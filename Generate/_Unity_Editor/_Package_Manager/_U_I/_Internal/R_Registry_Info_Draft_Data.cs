
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.PackageManager.UI.Internal.RegistryInfoDraftData
	/// </summary>
    public partial class RRegistryInfoDraftData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RegistryInfoDraftData");
            }
        }

        public RRegistryInfoDraftData() : base("UnityEditor.PackageManager.UI.Internal.RegistryInfoDraftData")
        {
        }

        public RRegistryInfoDraftData(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.RegistryInfoDraftData")
		{
            SetInstance(instance);
		}

        public RRegistryInfoDraftData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegistryInfoDraftData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_RegistryName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_RegistryName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_RegistryName
		{
			get
			{
				if(r_Fm_RegistryName == null)
				{
					r_Fm_RegistryName = new(this, "m_RegistryName");
				}
				return r_Fm_RegistryName;
			}
		}

		/// <summary>
		/// System.String m_Url
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Url;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Url
		{
			get
			{
				if(r_Fm_Url == null)
				{
					r_Fm_Url = new(this, "m_Url");
				}
				return r_Fm_Url;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Scopes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Scopes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_Scopes
		{
			get
			{
				if(r_Fm_Scopes == null)
				{
					r_Fm_Scopes = new(this, "m_Scopes");
				}
				return r_Fm_Scopes;
			}
		}

		/// <summary>
		/// System.Int32 m_SelectedScopeIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_SelectedScopeIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_SelectedScopeIndex
		{
			get
			{
				if(r_Fm_SelectedScopeIndex == null)
				{
					r_Fm_SelectedScopeIndex = new(this, "m_SelectedScopeIndex");
				}
				return r_Fm_SelectedScopeIndex;
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
		/// System.String url
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Purl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPurl
		{
			get
			{
				if(r_Purl == null)
				{
					r_Purl = new(this, "url", -1);
				}
				return r_Purl;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.String] scopes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RSystem.RString> r_Pscopes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RSystem.RString> RPscopes
		{
			get
			{
				if(r_Pscopes == null)
				{
					r_Pscopes = new(this, "scopes", -1);
				}
				return r_Pscopes;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.String] sanitizedScopes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RSystem.RString> r_PsanitizedScopes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RSystem.RString> RPsanitizedScopes
		{
			get
			{
				if(r_PsanitizedScopes == null)
				{
					r_PsanitizedScopes = new(this, "sanitizedScopes", -1);
				}
				return r_PsanitizedScopes;
			}
		}

		/// <summary>
		/// Int32 selectedScopeIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PselectedScopeIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPselectedScopeIndex
		{
			get
			{
				if(r_PselectedScopeIndex == null)
				{
					r_PselectedScopeIndex = new(this, "selectedScopeIndex", -1);
				}
				return r_PselectedScopeIndex;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void RevertChanges(UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData)
		/// </summary>
		protected RMethod r_MRevertChanges_RegistryInfoOriginalData;
		public virtual RMethod RMRevertChanges_RegistryInfoOriginalData
		{
			get
			{
				if(r_MRevertChanges_RegistryInfoOriginalData == null)
				{
					r_MRevertChanges_RegistryInfoOriginalData = new(this, "RevertChanges", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData"));
				}
				return r_MRevertChanges_RegistryInfoOriginalData;
			}
		}

		/// <summary>
		/// Void SetScopes(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MSetScopes_IEnumerable_d_String_p_;
		public virtual RMethod RMSetScopes_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MSetScopes_IEnumerable_d_String_p_ == null)
				{
					r_MSetScopes_IEnumerable_d_String_p_ = new(this, "SetScopes", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MSetScopes_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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
		/// System.String get_name()
		/// </summary>
		protected RMethod r_Mget_name;
		public virtual RMethod RMget_name
		{
			get
			{
				if(r_Mget_name == null)
				{
					r_Mget_name = new(this, "get_name", 0);
				}
				return r_Mget_name;
			}
		}

		/// <summary>
		/// Void set_name(System.String)
		/// </summary>
		protected RMethod r_Mset_name_String;
		public virtual RMethod RMset_name_String
		{
			get
			{
				if(r_Mset_name_String == null)
				{
					r_Mset_name_String = new(this, "set_name", 0, typeof(System.String));
				}
				return r_Mset_name_String;
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


        public virtual void RevertChanges(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoOriginalData @original)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@original.Value};
            var ___result = RMRevertChanges_RegistryInfoOriginalData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScopes(System.Collections.Generic.IEnumerable<System.String> @scopes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scopes};
            var ___result = RMSetScopes_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String get_name()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_name.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void set_name(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_name_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
