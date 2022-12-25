using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.VectorImageManager
	/// </summary>
    public partial class RVectorImageManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.VectorImageManager] instances
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RVectorImageManager> r_instances;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RVectorImageManager> Rinstances
		{
			get
			{
				if(r_instances == null)
				{
					r_instances = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"), "instances");
					r_instances.SetBelong(null);
				}
				return r_instances;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerRegister
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerRegister;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerRegister
		{
			get
			{
				if(r_s_MarkerRegister == null)
				{
					r_s_MarkerRegister = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"), "s_MarkerRegister");
					r_s_MarkerRegister.SetBelong(null);
				}
				return r_s_MarkerRegister;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerUnregister
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerUnregister;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerUnregister
		{
			get
			{
				if(r_s_MarkerUnregister == null)
				{
					r_s_MarkerUnregister = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageManager"), "s_MarkerUnregister");
					r_s_MarkerUnregister.SetBelong(null);
				}
				return r_s_MarkerUnregister;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase m_Atlas
		/// </summary>
		protected RUnityEngine.RUIElements.RAtlasBase r_m_Atlas;
		public virtual RUnityEngine.RUIElements.RAtlasBase Rm_Atlas
		{
			get
			{
				if(r_m_Atlas == null)
				{
					r_m_Atlas = new(this, "m_Atlas");
					r_m_Atlas.SetBelong(this.instance);
				}
				return r_m_Atlas;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo] m_Registered
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RVectorImage, RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo> r_m_Registered;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RVectorImage, RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo> Rm_Registered
		{
			get
			{
				if(r_m_Registered == null)
				{
					r_m_Registered = new(this, "m_Registered");
					r_m_Registered.SetBelong(this.instance);
				}
				return r_m_Registered;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageRenderInfoPool m_RenderInfoPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfoPool r_m_RenderInfoPool;
		public virtual RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfoPool Rm_RenderInfoPool
		{
			get
			{
				if(r_m_RenderInfoPool == null)
				{
					r_m_RenderInfoPool = new(this, "m_RenderInfoPool");
					r_m_RenderInfoPool.SetBelong(this.instance);
				}
				return r_m_RenderInfoPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemapPool m_GradientRemapPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGradientRemapPool r_m_GradientRemapPool;
		public virtual RUnityEngine.RUIElements.RUIR.RGradientRemapPool Rm_GradientRemapPool
		{
			get
			{
				if(r_m_GradientRemapPool == null)
				{
					r_m_GradientRemapPool = new(this, "m_GradientRemapPool");
					r_m_GradientRemapPool.SetBelong(this.instance);
				}
				return r_m_GradientRemapPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientSettingsAtlas m_GradientSettingsAtlas
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas r_m_GradientSettingsAtlas;
		public virtual RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas Rm_GradientSettingsAtlas
		{
			get
			{
				if(r_m_GradientSettingsAtlas == null)
				{
					r_m_GradientSettingsAtlas = new(this, "m_GradientSettingsAtlas");
					r_m_GradientSettingsAtlas.SetBelong(this.instance);
				}
				return r_m_GradientSettingsAtlas;
			}
		}

		/// <summary>
		/// System.Boolean m_LoggedExhaustedSettingsAtlas
		/// </summary>
		protected RField r_m_LoggedExhaustedSettingsAtlas;
		public virtual RField Rm_LoggedExhaustedSettingsAtlas
		{
			get
			{
				if(r_m_LoggedExhaustedSettingsAtlas == null)
				{
					r_m_LoggedExhaustedSettingsAtlas = new(this, "m_LoggedExhaustedSettingsAtlas");
					r_m_LoggedExhaustedSettingsAtlas.SetBelong(this.instance);
				}
				return r_m_LoggedExhaustedSettingsAtlas;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RField r___1__disposed__2__k__BackingField;
		public virtual RField R__1__disposed__2__k__BackingField
		{
			get
			{
				if(r___1__disposed__2__k__BackingField == null)
				{
					r___1__disposed__2__k__BackingField = new(this, "<disposed>k__BackingField");
					r___1__disposed__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__disposed__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D atlas
		/// </summary>
		protected RUnityEngine.RTexture2D r_atlas;
		public virtual RUnityEngine.RTexture2D Ratlas
		{
			get
			{
				if(r_atlas == null)
				{
					r_atlas = new(this, "atlas", -1);
					r_atlas.SetBelong(this.instance);
				}
				return r_atlas;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RProperty r_disposed;
		public virtual RProperty Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed", -1);
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void Commit()
		/// </summary>
		protected RMethod r_RCommit;
		public virtual RMethod RCommit
		{
			get
			{
				if(r_RCommit == null)
				{
					r_RCommit = new(this, "Commit", 0);
					r_RCommit.SetBelong(this.instance);
				}
				return r_RCommit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RAddUser_VectorImage_VisualElement;
		public virtual RMethod RAddUser_VectorImage_VisualElement
		{
			get
			{
				if(r_RAddUser_VectorImage_VisualElement == null)
				{
					r_RAddUser_VectorImage_VisualElement = new(this, "AddUser", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.UIElements.VisualElement));
					r_RAddUser_VectorImage_VisualElement.SetBelong(this.instance);
				}
				return r_RAddUser_VectorImage_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveUser(UnityEngine.UIElements.VectorImage)
		/// </summary>
		protected RMethod r_RRemoveUser_VectorImage;
		public virtual RMethod RRemoveUser_VectorImage
		{
			get
			{
				if(r_RRemoveUser_VectorImage == null)
				{
					r_RRemoveUser_VectorImage = new(this, "RemoveUser", 0, typeof(UnityEngine.UIElements.VectorImage));
					r_RRemoveUser_VectorImage.SetBelong(this.instance);
				}
				return r_RRemoveUser_VectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RRegister_VectorImage_VisualElement;
		public virtual RMethod RRegister_VectorImage_VisualElement
		{
			get
			{
				if(r_RRegister_VectorImage_VisualElement == null)
				{
					r_RRegister_VectorImage_VisualElement = new(this, "Register", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.UIElements.VisualElement));
					r_RRegister_VectorImage_VisualElement.SetBelong(this.instance);
				}
				return r_RRegister_VectorImage_VisualElement;
			}
		}

		/// <summary>
		/// Void Unregister(UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.UIR.VectorImageRenderInfo)
		/// </summary>
		protected RMethod r_RUnregister_VectorImage_VectorImageRenderInfo;
		public virtual RMethod RUnregister_VectorImage_VectorImageRenderInfo
		{
			get
			{
				if(r_RUnregister_VectorImage_VectorImageRenderInfo == null)
				{
					r_RUnregister_VectorImage_VectorImageRenderInfo = new(this, "Unregister", 0, typeof(UnityEngine.UIElements.VectorImage),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageRenderInfo"));
					r_RUnregister_VectorImage_VectorImageRenderInfo.SetBelong(this.instance);
				}
				return r_RUnregister_VectorImage_VectorImageRenderInfo;
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
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Commit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCommit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object AddUser(UnityEngine.UIElements.VectorImage  @vi, UnityEngine.UIElements.VisualElement  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi, @context};
            var ___result = RAddUser_VectorImage_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void RemoveUser(UnityEngine.UIElements.VectorImage  @vi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi};
            var ___result = RRemoveUser_VectorImage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Register(UnityEngine.UIElements.VectorImage  @vi, UnityEngine.UIElements.VisualElement  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi, @context};
            var ___result = RRegister_VectorImage_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
