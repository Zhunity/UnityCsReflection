
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.VectorImageManager
	/// </summary>
    public partial class RVectorImageManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.VectorImageManager] instances
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager> r_Finstances;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager> RFinstances
		{
			get
			{
				if(r_Finstances == null)
				{
					r_Finstances = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"), "instances");
					r_Finstances.SetBelong(null);
				}
				return r_Finstances;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerRegister
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerRegister;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerRegister
		{
			get
			{
				if(r_Fs_MarkerRegister == null)
				{
					r_Fs_MarkerRegister = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"), "s_MarkerRegister");
					r_Fs_MarkerRegister.SetBelong(null);
				}
				return r_Fs_MarkerRegister;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerUnregister
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerUnregister;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerUnregister
		{
			get
			{
				if(r_Fs_MarkerUnregister == null)
				{
					r_Fs_MarkerUnregister = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"), "s_MarkerUnregister");
					r_Fs_MarkerUnregister.SetBelong(null);
				}
				return r_Fs_MarkerUnregister;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase m_Atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase r_Fm_Atlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase RFm_Atlas
		{
			get
			{
				if(r_Fm_Atlas == null)
				{
					r_Fm_Atlas = new(this, "m_Atlas");
					r_Fm_Atlas.SetBelong(this.instance);
				}
				return r_Fm_Atlas;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo] m_Registered
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo> r_Fm_Registered;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo> RFm_Registered
		{
			get
			{
				if(r_Fm_Registered == null)
				{
					r_Fm_Registered = new(this, "m_Registered");
					r_Fm_Registered.SetBelong(this.instance);
				}
				return r_Fm_Registered;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageRenderInfoPool m_RenderInfoPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfoPool r_Fm_RenderInfoPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfoPool RFm_RenderInfoPool
		{
			get
			{
				if(r_Fm_RenderInfoPool == null)
				{
					r_Fm_RenderInfoPool = new(this, "m_RenderInfoPool");
					r_Fm_RenderInfoPool.SetBelong(this.instance);
				}
				return r_Fm_RenderInfoPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemapPool m_GradientRemapPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemapPool r_Fm_GradientRemapPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemapPool RFm_GradientRemapPool
		{
			get
			{
				if(r_Fm_GradientRemapPool == null)
				{
					r_Fm_GradientRemapPool = new(this, "m_GradientRemapPool");
					r_Fm_GradientRemapPool.SetBelong(this.instance);
				}
				return r_Fm_GradientRemapPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientSettingsAtlas m_GradientSettingsAtlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas r_Fm_GradientSettingsAtlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas RFm_GradientSettingsAtlas
		{
			get
			{
				if(r_Fm_GradientSettingsAtlas == null)
				{
					r_Fm_GradientSettingsAtlas = new(this, "m_GradientSettingsAtlas");
					r_Fm_GradientSettingsAtlas.SetBelong(this.instance);
				}
				return r_Fm_GradientSettingsAtlas;
			}
		}

		/// <summary>
		/// System.Boolean m_LoggedExhaustedSettingsAtlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_LoggedExhaustedSettingsAtlas;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_LoggedExhaustedSettingsAtlas
		{
			get
			{
				if(r_Fm_LoggedExhaustedSettingsAtlas == null)
				{
					r_Fm_LoggedExhaustedSettingsAtlas = new(this, "m_LoggedExhaustedSettingsAtlas");
					r_Fm_LoggedExhaustedSettingsAtlas.SetBelong(this.instance);
				}
				return r_Fm_LoggedExhaustedSettingsAtlas;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r_F__0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Patlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPatlas
		{
			get
			{
				if(r_Patlas == null)
				{
					r_Patlas = new(this, "atlas", -1);
					r_Patlas.SetBelong(this.instance);
				}
				return r_Patlas;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
					r_Pdisposed.SetBelong(this.instance);
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void Commit()
		/// </summary>
		protected RMethod r_MCommit;
		public virtual RMethod RMCommit
		{
			get
			{
				if(r_MCommit == null)
				{
					r_MCommit = new(this, "Commit", 0);
					r_MCommit.SetBelong(this.instance);
				}
				return r_MCommit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MAddUser_VectorImage_VisualElement;
		public virtual RMethod RMAddUser_VectorImage_VisualElement
		{
			get
			{
				if(r_MAddUser_VectorImage_VisualElement == null)
				{
					r_MAddUser_VectorImage_VisualElement = new(this, "AddUser", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.UIElements.VisualElement));
					r_MAddUser_VectorImage_VisualElement.SetBelong(this.instance);
				}
				return r_MAddUser_VectorImage_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveUser(UnityEngine.UIElements.VectorImage)
		/// </summary>
		protected RMethod r_MRemoveUser_VectorImage;
		public virtual RMethod RMRemoveUser_VectorImage
		{
			get
			{
				if(r_MRemoveUser_VectorImage == null)
				{
					r_MRemoveUser_VectorImage = new(this, "RemoveUser", 0, typeof(UnityEngine.UIElements.VectorImage));
					r_MRemoveUser_VectorImage.SetBelong(this.instance);
				}
				return r_MRemoveUser_VectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRegister_VectorImage_VisualElement;
		public virtual RMethod RMRegister_VectorImage_VisualElement
		{
			get
			{
				if(r_MRegister_VectorImage_VisualElement == null)
				{
					r_MRegister_VectorImage_VisualElement = new(this, "Register", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.UIElements.VisualElement));
					r_MRegister_VectorImage_VisualElement.SetBelong(this.instance);
				}
				return r_MRegister_VectorImage_VisualElement;
			}
		}

		/// <summary>
		/// Void Unregister(UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.UIR.VectorImageRenderInfo)
		/// </summary>
		protected RMethod r_MUnregister_VectorImage_VectorImageRenderInfo;
		public virtual RMethod RMUnregister_VectorImage_VectorImageRenderInfo
		{
			get
			{
				if(r_MUnregister_VectorImage_VectorImageRenderInfo == null)
				{
					r_MUnregister_VectorImage_VectorImageRenderInfo = new(this, "Unregister", 0, typeof(UnityEngine.UIElements.VectorImage),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageRenderInfo"));
					r_MUnregister_VectorImage_VectorImageRenderInfo.SetBelong(this.instance);
				}
				return r_MUnregister_VectorImage_VectorImageRenderInfo;
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


        public RVectorImageManager() : base("UnityEngine.UIElements.UIR.VectorImageManager")
        {
        }

        public RVectorImageManager(System.Object instance) : base("UnityEngine.UIElements.UIR.VectorImageManager")
		{
            SetInstance(instance);
		}

        public RVectorImageManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVectorImageManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Commit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCommit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap AddUser(UnityEngine.UIElements.VectorImage @vi, UnityEngine.UIElements.VisualElement @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi, @context};
            var ___result = RMAddUser_VectorImage_VisualElement.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap(___result);
        }


        public virtual void RemoveUser(UnityEngine.UIElements.VectorImage @vi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi};
            var ___result = RMRemoveUser_VectorImage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage @vi, UnityEngine.UIElements.VisualElement @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi, @context};
            var ___result = RMRegister_VectorImage_VisualElement.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo(___result);
        }


        public virtual void Unregister(UnityEngine.UIElements.VectorImage @vi, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo @renderInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi, @renderInfo.Value};
            var ___result = RMUnregister_VectorImage_VectorImageRenderInfo.Invoke(___genericsType, ___parameters);

            
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
