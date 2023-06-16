
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PackageSignInButton
	/// </summary>
    public partial class RPackageSignInButton : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageSignInButton");
            }
        }

        public RPackageSignInButton() : base("UnityEditor.PackageManager.UI.Internal.PackageSignInButton")
        {
        }

        public RPackageSignInButton(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageSignInButton")
		{
            SetInstance(instance);
		}

        public RPackageSignInButton(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageSignInButton(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UnityConnectProxy m_UnityConnectProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy r_Fm_UnityConnectProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUnityConnectProxy RFm_UnityConnectProxy
		{
			get
			{
				if(r_Fm_UnityConnectProxy == null)
				{
					r_Fm_UnityConnectProxy = new(this, "m_UnityConnectProxy");
				}
				return r_Fm_UnityConnectProxy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] m_Versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_Fm_Versions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RFm_Versions
		{
			get
			{
				if(r_Fm_Versions == null)
				{
					r_Fm_Versions = new(this, "m_Versions");
				}
				return r_Fm_Versions;
			}
		}

		/// <summary>
		/// System.Action onAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonAction;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonAction
		{
			get
			{
				if(r_FonAction == null)
				{
					r_FonAction = new(this, "onAction");
				}
				return r_FonAction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button m_Element
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_Fm_Element;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RFm_Element
		{
			get
			{
				if(r_Fm_Element == null)
				{
					r_Fm_Element = new(this, "m_Element");
				}
				return r_Fm_Element;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Button element
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton r_Pelement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RButton RPelement
		{
			get
			{
				if(r_Pelement == null)
				{
					r_Pelement = new(this, "element", -1);
				}
				return r_Pelement;
			}
		}

		/// <summary>
		/// Boolean TriggerAction(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MTriggerAction_IPackageVersion;
		public virtual RMethod RMTriggerAction_IPackageVersion
		{
			get
			{
				if(r_MTriggerAction_IPackageVersion == null)
				{
					r_MTriggerAction_IPackageVersion = new(this, "TriggerAction", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MTriggerAction_IPackageVersion;
			}
		}

		/// <summary>
		/// Boolean IsVisible(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MIsVisible_IPackageVersion;
		public virtual RMethod RMIsVisible_IPackageVersion
		{
			get
			{
				if(r_MIsVisible_IPackageVersion == null)
				{
					r_MIsVisible_IPackageVersion = new(this, "IsVisible", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MIsVisible_IPackageVersion;
			}
		}

		/// <summary>
		/// System.String GetTooltip(UnityEditor.PackageManager.UI.Internal.IPackageVersion, Boolean)
		/// </summary>
		protected RMethod r_MGetTooltip_IPackageVersion_Boolean;
		public virtual RMethod RMGetTooltip_IPackageVersion_Boolean
		{
			get
			{
				if(r_MGetTooltip_IPackageVersion_Boolean == null)
				{
					r_MGetTooltip_IPackageVersion_Boolean = new(this, "GetTooltip", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.Boolean));
				}
				return r_MGetTooltip_IPackageVersion_Boolean;
			}
		}

		/// <summary>
		/// System.String GetText(UnityEditor.PackageManager.UI.Internal.IPackageVersion, Boolean)
		/// </summary>
		protected RMethod r_MGetText_IPackageVersion_Boolean;
		public virtual RMethod RMGetText_IPackageVersion_Boolean
		{
			get
			{
				if(r_MGetText_IPackageVersion_Boolean == null)
				{
					r_MGetText_IPackageVersion_Boolean = new(this, "GetText", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.Boolean));
				}
				return r_MGetText_IPackageVersion_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsInProgress(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MIsInProgress_IPackageVersion;
		public virtual RMethod RMIsInProgress_IPackageVersion
		{
			get
			{
				if(r_MIsInProgress_IPackageVersion == null)
				{
					r_MIsInProgress_IPackageVersion = new(this, "IsInProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MIsInProgress_IPackageVersion;
			}
		}

		/// <summary>
		/// Void RegisterClickAction()
		/// </summary>
		protected RMethod r_MRegisterClickAction;
		public virtual RMethod RMRegisterClickAction
		{
			get
			{
				if(r_MRegisterClickAction == null)
				{
					r_MRegisterClickAction = new(this, "RegisterClickAction", 0);
				}
				return r_MRegisterClickAction;
			}
		}

		/// <summary>
		/// Void SetPackageVersion(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MSetPackageVersion_IPackageVersion;
		public virtual RMethod RMSetPackageVersion_IPackageVersion
		{
			get
			{
				if(r_MSetPackageVersion_IPackageVersion == null)
				{
					r_MSetPackageVersion_IPackageVersion = new(this, "SetPackageVersion", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MSetPackageVersion_IPackageVersion;
			}
		}

		/// <summary>
		/// Void SetPackageVersions(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion])
		/// </summary>
		protected RMethod r_MSetPackageVersions_IEnumerable_d_IPackageVersion_p_;
		public virtual RMethod RMSetPackageVersions_IEnumerable_d_IPackageVersion_p_
		{
			get
			{
				if(r_MSetPackageVersions_IEnumerable_d_IPackageVersion_p_ == null)
				{
					r_MSetPackageVersions_IEnumerable_d_IPackageVersion_p_ = new(this, "SetPackageVersions", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion")));
				}
				return r_MSetPackageVersions_IEnumerable_d_IPackageVersion_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.ButtonDisableCondition] GetDisableConditions(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetDisableConditions_IPackageVersion;
		public virtual RMethod RMGetDisableConditions_IPackageVersion
		{
			get
			{
				if(r_MGetDisableConditions_IPackageVersion == null)
				{
					r_MGetDisableConditions_IPackageVersion = new(this, "GetDisableConditions", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MGetDisableConditions_IPackageVersion;
			}
		}

		/// <summary>
		/// Void SetGlobalDisableConditions(UnityEditor.PackageManager.UI.Internal.ButtonDisableCondition[])
		/// </summary>
		protected RMethod r_MSetGlobalDisableConditions_ButtonDisableConditionArray;
		public virtual RMethod RMSetGlobalDisableConditions_ButtonDisableConditionArray
		{
			get
			{
				if(r_MSetGlobalDisableConditions_ButtonDisableConditionArray == null)
				{
					r_MSetGlobalDisableConditions_ButtonDisableConditionArray = new(this, "SetGlobalDisableConditions", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ButtonDisableCondition").MakeArrayType());
				}
				return r_MSetGlobalDisableConditions_ButtonDisableConditionArray;
			}
		}

		/// <summary>
		/// Void OnClicked()
		/// </summary>
		protected RMethod r_MOnClicked;
		public virtual RMethod RMOnClicked
		{
			get
			{
				if(r_MOnClicked == null)
				{
					r_MOnClicked = new(this, "OnClicked", 0);
				}
				return r_MOnClicked;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageActionState GetActionState(UnityEditor.PackageManager.UI.Internal.IPackageVersion, System.String ByRef, System.String ByRef)
		/// </summary>
		protected RMethod r_MGetActionState_IPackageVersion_Out_String_Out_String;
		public virtual RMethod RMGetActionState_IPackageVersion_Out_String_Out_String
		{
			get
			{
				if(r_MGetActionState_IPackageVersion_Out_String_Out_String == null)
				{
					r_MGetActionState_IPackageVersion_Out_String_Out_String = new(this, "GetActionState", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType());
				}
				return r_MGetActionState_IPackageVersion_Out_String_Out_String;
			}
		}

		/// <summary>
		/// Void Refresh(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion])
		/// </summary>
		protected RMethod r_MRefresh_IEnumerable_d_IPackageVersion_p_;
		public virtual RMethod RMRefresh_IEnumerable_d_IPackageVersion_p_
		{
			get
			{
				if(r_MRefresh_IEnumerable_d_IPackageVersion_p_ == null)
				{
					r_MRefresh_IEnumerable_d_IPackageVersion_p_ = new(this, "Refresh", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion")));
				}
				return r_MRefresh_IEnumerable_d_IPackageVersion_p_;
			}
		}

		/// <summary>
		/// Void Refresh(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MRefresh_IPackageVersion;
		public virtual RMethod RMRefresh_IPackageVersion
		{
			get
			{
				if(r_MRefresh_IPackageVersion == null)
				{
					r_MRefresh_IPackageVersion = new(this, "Refresh", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MRefresh_IPackageVersion;
			}
		}

		/// <summary>
		/// Boolean TriggerAction()
		/// </summary>
		protected RMethod r_MTriggerAction;
		public virtual RMethod RMTriggerAction
		{
			get
			{
				if(r_MTriggerAction == null)
				{
					r_MTriggerAction = new(this, "TriggerAction", 0);
				}
				return r_MTriggerAction;
			}
		}

		/// <summary>
		/// Boolean TriggerAction(System.Collections.Generic.IList`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion])
		/// </summary>
		protected RMethod r_MTriggerAction_IList_d_IPackageVersion_p_;
		public virtual RMethod RMTriggerAction_IList_d_IPackageVersion_p_
		{
			get
			{
				if(r_MTriggerAction_IList_d_IPackageVersion_p_ == null)
				{
					r_MTriggerAction_IList_d_IPackageVersion_p_ = new(this, "TriggerAction", 0,  ReflectionUtils.GetType("System.Collections.Generic.IList`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion")));
				}
				return r_MTriggerAction_IList_d_IPackageVersion_p_;
			}
		}

		/// <summary>
		/// Boolean IsHiddenWhenInProgress(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MIsHiddenWhenInProgress_IPackageVersion;
		public virtual RMethod RMIsHiddenWhenInProgress_IPackageVersion
		{
			get
			{
				if(r_MIsHiddenWhenInProgress_IPackageVersion == null)
				{
					r_MIsHiddenWhenInProgress_IPackageVersion = new(this, "IsHiddenWhenInProgress", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MIsHiddenWhenInProgress_IPackageVersion;
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


        public virtual System.Boolean TriggerAction(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMTriggerAction_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsVisible(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMIsVisible_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String GetTooltip(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, System.Boolean @isInProgress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @isInProgress};
            var ___result = RMGetTooltip_IPackageVersion_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String GetText(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, System.Boolean @isInProgress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @isInProgress};
            var ___result = RMGetText_IPackageVersion_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean IsInProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMIsInProgress_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RegisterClickAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegisterClickAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPackageVersion(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMSetPackageVersion_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPackageVersions(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> @versions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@versions.Value};
            var ___result = RMSetPackageVersions_IEnumerable_d_IPackageVersion_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RButtonDisableCondition> GetDisableConditions(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetDisableConditions_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RButtonDisableCondition>>(___result);
        }


        public virtual void SetGlobalDisableConditions(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RButtonDisableCondition> @disableConditions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disableConditions.Value};
            var ___result = RMSetGlobalDisableConditions_ButtonDisableConditionArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnClicked()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnClicked.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageActionState GetActionState(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version, out System.String @text, out System.String @tooltip)
        {
			@text = default;
			@tooltip = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value, @text, @tooltip};
            var ___result = RMGetActionState_IPackageVersion_Out_String_Out_String.Invoke(___genericsType, ___parameters);
			@text = ReflectionUtils.Convert<System.String>(___parameters[1]);
			@tooltip = ReflectionUtils.Convert<System.String>(___parameters[2]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageActionState>(___result);
        }


        public virtual void Refresh(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> @versions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@versions.Value};
            var ___result = RMRefresh_IEnumerable_d_IPackageVersion_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMRefresh_IPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TriggerAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTriggerAction.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TriggerAction(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> @versions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@versions.Value};
            var ___result = RMTriggerAction_IList_d_IPackageVersion_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsHiddenWhenInProgress(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMIsHiddenWhenInProgress_IPackageVersion.Invoke(___genericsType, ___parameters);

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
