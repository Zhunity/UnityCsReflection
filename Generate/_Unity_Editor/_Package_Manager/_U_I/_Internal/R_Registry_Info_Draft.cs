
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.RegistryInfoDraft
	/// </summary>
    public partial class RRegistryInfoDraft : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.RegistryInfoDraft");
            }
        }

        public RRegistryInfoDraft() : base("UnityEditor.PackageManager.UI.Internal.RegistryInfoDraft")
        {
        }

        public RRegistryInfoDraft(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.RegistryInfoDraft")
		{
            SetInstance(instance);
		}

        public RRegistryInfoDraft(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegistryInfoDraft(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean m_Modified
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Modified;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Modified
		{
			get
			{
				if(r_Fm_Modified == null)
				{
					r_Fm_Modified = new(this, "m_Modified");
				}
				return r_Fm_Modified;
			}
		}

		/// <summary>
		/// System.String m_ErrorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ErrorMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ErrorMessage
		{
			get
			{
				if(r_Fm_ErrorMessage == null)
				{
					r_Fm_ErrorMessage = new(this, "m_ErrorMessage");
				}
				return r_Fm_ErrorMessage;
			}
		}

		/// <summary>
		/// System.Int32 m_UserModificationsInstanceId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_UserModificationsInstanceId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_UserModificationsInstanceId
		{
			get
			{
				if(r_Fm_UserModificationsInstanceId == null)
				{
					r_Fm_UserModificationsInstanceId = new(this, "m_UserModificationsInstanceId");
				}
				return r_Fm_UserModificationsInstanceId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RegistryInfoDraftData m_UserModifications
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoDraftData r_Fm_UserModifications;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoDraftData RFm_UserModifications
		{
			get
			{
				if(r_Fm_UserModifications == null)
				{
					r_Fm_UserModifications = new(this, "m_UserModifications");
				}
				return r_Fm_UserModifications;
			}
		}

		/// <summary>
		/// System.Int32 m_OriginalInstanceId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_OriginalInstanceId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_OriginalInstanceId
		{
			get
			{
				if(r_Fm_OriginalInstanceId == null)
				{
					r_Fm_OriginalInstanceId = new(this, "m_OriginalInstanceId");
				}
				return r_Fm_OriginalInstanceId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData m_Original
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoOriginalData r_Fm_Original;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoOriginalData RFm_Original
		{
			get
			{
				if(r_Fm_Original == null)
				{
					r_Fm_Original = new(this, "m_Original");
				}
				return r_Fm_Original;
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
		/// System.String errorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PerrorMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPerrorMessage
		{
			get
			{
				if(r_PerrorMessage == null)
				{
					r_PerrorMessage = new(this, "errorMessage", -1);
				}
				return r_PerrorMessage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RegistryInfoOriginalData original
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoOriginalData r_Poriginal;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRegistryInfoOriginalData RPoriginal
		{
			get
			{
				if(r_Poriginal == null)
				{
					r_Poriginal = new(this, "original", -1);
				}
				return r_Poriginal;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasUnsavedChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasUnsavedChanges
		{
			get
			{
				if(r_PhasUnsavedChanges == null)
				{
					r_PhasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
				}
				return r_PhasUnsavedChanges;
			}
		}

		/// <summary>
		/// Boolean isUrlOrScopesUpdated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisUrlOrScopesUpdated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisUrlOrScopesUpdated
		{
			get
			{
				if(r_PisUrlOrScopesUpdated == null)
				{
					r_PisUrlOrScopesUpdated = new(this, "isUrlOrScopesUpdated", -1);
				}
				return r_PisUrlOrScopesUpdated;
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
		/// Boolean IsReady()
		/// </summary>
		protected RMethod r_MIsReady;
		public virtual RMethod RMIsReady
		{
			get
			{
				if(r_MIsReady == null)
				{
					r_MIsReady = new(this, "IsReady", 0);
				}
				return r_MIsReady;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void SetModifiedAfterUndo()
		/// </summary>
		protected RMethod r_MSetModifiedAfterUndo;
		public virtual RMethod RMSetModifiedAfterUndo
		{
			get
			{
				if(r_MSetModifiedAfterUndo == null)
				{
					r_MSetModifiedAfterUndo = new(this, "SetModifiedAfterUndo", 0);
				}
				return r_MSetModifiedAfterUndo;
			}
		}

		/// <summary>
		/// Void RegisterWithOriginalOnUndo(System.String)
		/// </summary>
		protected RMethod r_MRegisterWithOriginalOnUndo_String;
		public virtual RMethod RMRegisterWithOriginalOnUndo_String
		{
			get
			{
				if(r_MRegisterWithOriginalOnUndo_String == null)
				{
					r_MRegisterWithOriginalOnUndo_String = new(this, "RegisterWithOriginalOnUndo", 0, typeof(System.String));
				}
				return r_MRegisterWithOriginalOnUndo_String;
			}
		}

		/// <summary>
		/// Void RegisterOnUndo(System.String)
		/// </summary>
		protected RMethod r_MRegisterOnUndo_String;
		public virtual RMethod RMRegisterOnUndo_String
		{
			get
			{
				if(r_MRegisterOnUndo_String == null)
				{
					r_MRegisterOnUndo_String = new(this, "RegisterOnUndo", 0, typeof(System.String));
				}
				return r_MRegisterOnUndo_String;
			}
		}

		/// <summary>
		/// Void SetOriginalRegistryInfo(UnityEditor.PackageManager.RegistryInfo, Boolean)
		/// </summary>
		protected RMethod r_MSetOriginalRegistryInfo_RegistryInfo_Boolean;
		public virtual RMethod RMSetOriginalRegistryInfo_RegistryInfo_Boolean
		{
			get
			{
				if(r_MSetOriginalRegistryInfo_RegistryInfo_Boolean == null)
				{
					r_MSetOriginalRegistryInfo_RegistryInfo_Boolean = new(this, "SetOriginalRegistryInfo", 0, typeof(UnityEditor.PackageManager.RegistryInfo), typeof(System.Boolean));
				}
				return r_MSetOriginalRegistryInfo_RegistryInfo_Boolean;
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
		/// Void RevertChanges()
		/// </summary>
		protected RMethod r_MRevertChanges;
		public virtual RMethod RMRevertChanges
		{
			get
			{
				if(r_MRevertChanges == null)
				{
					r_MRevertChanges = new(this, "RevertChanges", 0);
				}
				return r_MRevertChanges;
			}
		}

		/// <summary>
		/// Boolean Validate()
		/// </summary>
		protected RMethod r_MValidate;
		public virtual RMethod RMValidate
		{
			get
			{
				if(r_MValidate == null)
				{
					r_MValidate = new(this, "Validate", 0);
				}
				return r_MValidate;
			}
		}

		/// <summary>
		/// Void AddErrorMessage(System.String)
		/// </summary>
		protected RMethod r_MAddErrorMessage_String;
		public virtual RMethod RMAddErrorMessage_String
		{
			get
			{
				if(r_MAddErrorMessage_String == null)
				{
					r_MAddErrorMessage_String = new(this, "AddErrorMessage", 0, typeof(System.String));
				}
				return r_MAddErrorMessage_String;
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


        public virtual System.Boolean IsReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsReady.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetModifiedAfterUndo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetModifiedAfterUndo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterWithOriginalOnUndo(System.String @undoEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@undoEvent};
            var ___result = RMRegisterWithOriginalOnUndo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterOnUndo(System.String @undoEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@undoEvent};
            var ___result = RMRegisterOnUndo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOriginalRegistryInfo(UnityEditor.PackageManager.RegistryInfo @registryInfo, System.Boolean @isUndo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@registryInfo, @isUndo};
            var ___result = RMSetOriginalRegistryInfo_RegistryInfo_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScopes(System.Collections.Generic.IEnumerable<System.String> @scopes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scopes};
            var ___result = RMSetScopes_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevertChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRevertChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Validate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void AddErrorMessage(System.String @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message};
            var ___result = RMAddErrorMessage_String.Invoke(___genericsType, ___parameters);

            
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
