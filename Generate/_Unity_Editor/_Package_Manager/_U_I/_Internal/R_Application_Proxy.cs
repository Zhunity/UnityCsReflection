
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy
	/// </summary>
    public partial class RApplicationProxy : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy");
            }
        }

        public RApplicationProxy() : base("UnityEditor.PackageManager.UI.Internal.ApplicationProxy")
        {
        }

        public RApplicationProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.ApplicationProxy")
		{
            SetInstance(instance);
		}

        public RApplicationProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RApplicationProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[System.Boolean] onInternetReachabilityChange
		/// </summary>
		protected REvent r_EonInternetReachabilityChange;
		public virtual REvent REonInternetReachabilityChange
		{
			get
			{
				if(r_EonInternetReachabilityChange == null)
				{
					r_EonInternetReachabilityChange = new(this, "onInternetReachabilityChange");
				}
				return r_EonInternetReachabilityChange;
			}
		}

		/// <summary>
		/// System.Action onFinishCompiling
		/// </summary>
		protected REvent r_EonFinishCompiling;
		public virtual REvent REonFinishCompiling
		{
			get
			{
				if(r_EonFinishCompiling == null)
				{
					r_EonFinishCompiling = new(this, "onFinishCompiling");
				}
				return r_EonFinishCompiling;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PlayModeStateChange] onPlayModeStateChanged
		/// </summary>
		protected REvent r_EonPlayModeStateChanged;
		public virtual REvent REonPlayModeStateChanged
		{
			get
			{
				if(r_EonPlayModeStateChanged == null)
				{
					r_EonPlayModeStateChanged = new(this, "onPlayModeStateChanged");
				}
				return r_EonPlayModeStateChanged;
			}
		}

		/// <summary>
		/// System.Action update
		/// </summary>
		protected REvent r_Eupdate;
		public virtual REvent REupdate
		{
			get
			{
				if(r_Eupdate == null)
				{
					r_Eupdate = new(this, "update");
				}
				return r_Eupdate;
			}
		}

		/// <summary>
		/// System.Boolean m_CheckingCompilation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_CheckingCompilation;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_CheckingCompilation
		{
			get
			{
				if(r_Fm_CheckingCompilation == null)
				{
					r_Fm_CheckingCompilation = new(this, "m_CheckingCompilation");
				}
				return r_Fm_CheckingCompilation;
			}
		}

		/// <summary>
		/// System.Boolean m_IsInternetReachable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsInternetReachable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsInternetReachable
		{
			get
			{
				if(r_Fm_IsInternetReachable == null)
				{
					r_Fm_IsInternetReachable = new(this, "m_IsInternetReachable");
				}
				return r_Fm_IsInternetReachable;
			}
		}

		/// <summary>
		/// System.Double m_LastInternetCheck
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_Fm_LastInternetCheck;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RFm_LastInternetCheck
		{
			get
			{
				if(r_Fm_LastInternetCheck == null)
				{
					r_Fm_LastInternetCheck = new(this, "m_LastInternetCheck");
				}
				return r_Fm_LastInternetCheck;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] onInternetReachabilityChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FonInternetReachabilityChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> RFonInternetReachabilityChange
		{
			get
			{
				if(r_FonInternetReachabilityChange == null)
				{
					r_FonInternetReachabilityChange = new(this, "onInternetReachabilityChange");
				}
				return r_FonInternetReachabilityChange;
			}
		}

		/// <summary>
		/// System.Action onFinishCompiling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonFinishCompiling;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonFinishCompiling
		{
			get
			{
				if(r_FonFinishCompiling == null)
				{
					r_FonFinishCompiling = new(this, "onFinishCompiling");
				}
				return r_FonFinishCompiling;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PlayModeStateChange] onPlayModeStateChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPlayModeStateChange> r_FonPlayModeStateChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPlayModeStateChange> RFonPlayModeStateChanged
		{
			get
			{
				if(r_FonPlayModeStateChanged == null)
				{
					r_FonPlayModeStateChanged = new(this, "onPlayModeStateChanged");
				}
				return r_FonPlayModeStateChanged;
			}
		}

		/// <summary>
		/// System.Action update
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Fupdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFupdate
		{
			get
			{
				if(r_Fupdate == null)
				{
					r_Fupdate = new(this, "update");
				}
				return r_Fupdate;
			}
		}

		/// <summary>
		/// System.String userAppDataPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PuserAppDataPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPuserAppDataPath
		{
			get
			{
				if(r_PuserAppDataPath == null)
				{
					r_PuserAppDataPath = new(this, "userAppDataPath", -1);
				}
				return r_PuserAppDataPath;
			}
		}

		/// <summary>
		/// Boolean isInternetReachable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInternetReachable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInternetReachable
		{
			get
			{
				if(r_PisInternetReachable == null)
				{
					r_PisInternetReachable = new(this, "isInternetReachable", -1);
				}
				return r_PisInternetReachable;
			}
		}

		/// <summary>
		/// Boolean isBatchMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisBatchMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisBatchMode
		{
			get
			{
				if(r_PisBatchMode == null)
				{
					r_PisBatchMode = new(this, "isBatchMode", -1);
				}
				return r_PisBatchMode;
			}
		}

		/// <summary>
		/// Boolean isUpmRunning
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisUpmRunning;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisUpmRunning
		{
			get
			{
				if(r_PisUpmRunning == null)
				{
					r_PisUpmRunning = new(this, "isUpmRunning", -1);
				}
				return r_PisUpmRunning;
			}
		}

		/// <summary>
		/// Boolean isCompiling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCompiling;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCompiling
		{
			get
			{
				if(r_PisCompiling == null)
				{
					r_PisCompiling = new(this, "isCompiling", -1);
				}
				return r_PisCompiling;
			}
		}

		/// <summary>
		/// System.String unityVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PunityVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPunityVersion
		{
			get
			{
				if(r_PunityVersion == null)
				{
					r_PunityVersion = new(this, "unityVersion", -1);
				}
				return r_PunityVersion;
			}
		}

		/// <summary>
		/// System.String shortUnityVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PshortUnityVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPshortUnityVersion
		{
			get
			{
				if(r_PshortUnityVersion == null)
				{
					r_PshortUnityVersion = new(this, "shortUnityVersion", -1);
				}
				return r_PshortUnityVersion;
			}
		}

		/// <summary>
		/// Boolean isDeveloperBuild
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDeveloperBuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDeveloperBuild
		{
			get
			{
				if(r_PisDeveloperBuild == null)
				{
					r_PisDeveloperBuild = new(this, "isDeveloperBuild", -1);
				}
				return r_PisDeveloperBuild;
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
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void PlayModeStateChanged(UnityEditor.PlayModeStateChange)
		/// </summary>
		protected RMethod r_MPlayModeStateChanged_PlayModeStateChange;
		public virtual RMethod RMPlayModeStateChanged_PlayModeStateChange
		{
			get
			{
				if(r_MPlayModeStateChanged_PlayModeStateChange == null)
				{
					r_MPlayModeStateChanged_PlayModeStateChange = new(this, "PlayModeStateChanged", 0, typeof(UnityEditor.PlayModeStateChange));
				}
				return r_MPlayModeStateChanged_PlayModeStateChange;
			}
		}

		/// <summary>
		/// Void OnUpdate()
		/// </summary>
		protected RMethod r_MOnUpdate;
		public virtual RMethod RMOnUpdate
		{
			get
			{
				if(r_MOnUpdate == null)
				{
					r_MOnUpdate = new(this, "OnUpdate", 0);
				}
				return r_MOnUpdate;
			}
		}

		/// <summary>
		/// Void CheckInternetReachability()
		/// </summary>
		protected RMethod r_MCheckInternetReachability;
		public virtual RMethod RMCheckInternetReachability
		{
			get
			{
				if(r_MCheckInternetReachability == null)
				{
					r_MCheckInternetReachability = new(this, "CheckInternetReachability", 0);
				}
				return r_MCheckInternetReachability;
			}
		}

		/// <summary>
		/// Void CheckCompilationStatus()
		/// </summary>
		protected RMethod r_MCheckCompilationStatus;
		public virtual RMethod RMCheckCompilationStatus
		{
			get
			{
				if(r_MCheckCompilationStatus == null)
				{
					r_MCheckCompilationStatus = new(this, "CheckCompilationStatus", 0);
				}
				return r_MCheckCompilationStatus;
			}
		}

		/// <summary>
		/// Void OpenURL(System.String)
		/// </summary>
		protected RMethod r_MOpenURL_String;
		public virtual RMethod RMOpenURL_String
		{
			get
			{
				if(r_MOpenURL_String == null)
				{
					r_MOpenURL_String = new(this, "OpenURL", 0, typeof(System.String));
				}
				return r_MOpenURL_String;
			}
		}

		/// <summary>
		/// Void RevealInFinder(System.String)
		/// </summary>
		protected RMethod r_MRevealInFinder_String;
		public virtual RMethod RMRevealInFinder_String
		{
			get
			{
				if(r_MRevealInFinder_String == null)
				{
					r_MRevealInFinder_String = new(this, "RevealInFinder", 0, typeof(System.String));
				}
				return r_MRevealInFinder_String;
			}
		}

		/// <summary>
		/// System.String OpenFilePanelWithFilters(System.String, System.String, System.String[])
		/// </summary>
		protected RMethod r_MOpenFilePanelWithFilters_String_String_StringArray;
		public virtual RMethod RMOpenFilePanelWithFilters_String_String_StringArray
		{
			get
			{
				if(r_MOpenFilePanelWithFilters_String_String_StringArray == null)
				{
					r_MOpenFilePanelWithFilters_String_String_StringArray = new(this, "OpenFilePanelWithFilters", 0, typeof(System.String), typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MOpenFilePanelWithFilters_String_String_StringArray;
			}
		}

		/// <summary>
		/// System.String OpenFolderPanel(System.String, System.String)
		/// </summary>
		protected RMethod r_MOpenFolderPanel_String_String;
		public virtual RMethod RMOpenFolderPanel_String_String
		{
			get
			{
				if(r_MOpenFolderPanel_String_String == null)
				{
					r_MOpenFolderPanel_String_String = new(this, "OpenFolderPanel", 0, typeof(System.String), typeof(System.String));
				}
				return r_MOpenFolderPanel_String_String;
			}
		}

		/// <summary>
		/// Boolean DisplayDialog(System.String, System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MDisplayDialog_String_String_String_String_String;
		public virtual RMethod RMDisplayDialog_String_String_String_String_String
		{
			get
			{
				if(r_MDisplayDialog_String_String_String_String_String == null)
				{
					r_MDisplayDialog_String_String_String_String_String = new(this, "DisplayDialog", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MDisplayDialog_String_String_String_String_String;
			}
		}

		/// <summary>
		/// Int32 DisplayDialogComplex(System.String, System.String, System.String, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MDisplayDialogComplex_String_String_String_String_String_String;
		public virtual RMethod RMDisplayDialogComplex_String_String_String_String_String_String
		{
			get
			{
				if(r_MDisplayDialogComplex_String_String_String_String_String_String == null)
				{
					r_MDisplayDialogComplex_String_String_String_String_String_String = new(this, "DisplayDialogComplex", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MDisplayDialogComplex_String_String_String_String_String_String;
			}
		}

		/// <summary>
		/// T Load[T](System.String)
		/// </summary>
		protected RMethod r_MLoad_GT_String;
		public virtual RMethod RMLoad_GT_String
		{
			get
			{
				if(r_MLoad_GT_String == null)
				{
					r_MLoad_GT_String = new(this, "Load", 1, typeof(System.String));
				}
				return r_MLoad_GT_String;
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


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayModeStateChanged(UnityEditor.PlayModeStateChange @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMPlayModeStateChanged_PlayModeStateChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckInternetReachability()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckInternetReachability.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckCompilationStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckCompilationStatus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenURL(System.String @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = RMOpenURL_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RevealInFinder(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMRevealInFinder_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String OpenFilePanelWithFilters(System.String @title, System.String @directory, System.String[] @filters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title, @directory, @filters};
            var ___result = RMOpenFilePanelWithFilters_String_String_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String OpenFolderPanel(System.String @title, System.String @folder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title, @folder};
            var ___result = RMOpenFolderPanel_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean DisplayDialog(System.String @idForAnalytics, System.String @title, System.String @message, System.String @ok, System.String @cancel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idForAnalytics, @title, @message, @ok, @cancel};
            var ___result = RMDisplayDialog_String_String_String_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 DisplayDialogComplex(System.String @idForAnalytics, System.String @title, System.String @message, System.String @ok, System.String @cancel, System.String @alt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idForAnalytics, @title, @message, @ok, @cancel, @alt};
            var ___result = RMDisplayDialogComplex_String_String_String_String_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual T Load<T>(System.String @path) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@path};
            var ___result = RMLoad_GT_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
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
