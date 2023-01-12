using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.GradientSettingsAtlas
	/// </summary>
    public partial class RGradientSettingsAtlas : RMember //
    {

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerWrite
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerWrite;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerWrite
		{
			get
			{
				if(r_Fs_MarkerWrite == null)
				{
					r_Fs_MarkerWrite = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas"), "s_MarkerWrite");
					r_Fs_MarkerWrite.SetBelong(null);
				}
				return r_Fs_MarkerWrite;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerCommit
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_Fs_MarkerCommit;
		public static RUnity.RProfiling.RProfilerMarker RFs_MarkerCommit
		{
			get
			{
				if(r_Fs_MarkerCommit == null)
				{
					r_Fs_MarkerCommit = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas"), "s_MarkerCommit");
					r_Fs_MarkerCommit.SetBelong(null);
				}
				return r_Fs_MarkerCommit;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected RSystem.RInt32 r_Fm_Length;
		public virtual RSystem.RInt32 RFm_Length
		{
			get
			{
				if(r_Fm_Length == null)
				{
					r_Fm_Length = new(this, "m_Length");
					r_Fm_Length.SetBelong(this.instance);
				}
				return r_Fm_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_ElemWidth
		/// </summary>
		protected RSystem.RInt32 r_Fm_ElemWidth;
		public virtual RSystem.RInt32 RFm_ElemWidth
		{
			get
			{
				if(r_Fm_ElemWidth == null)
				{
					r_Fm_ElemWidth = new(this, "m_ElemWidth");
					r_Fm_ElemWidth.SetBelong(this.instance);
				}
				return r_Fm_ElemWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_Fm_Allocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator RFm_Allocator
		{
			get
			{
				if(r_Fm_Allocator == null)
				{
					r_Fm_Allocator = new(this, "m_Allocator");
					r_Fm_Allocator.SetBelong(this.instance);
				}
				return r_Fm_Allocator;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_Atlas
		/// </summary>
		protected RUnityEngine.RTexture2D r_Fm_Atlas;
		public virtual RUnityEngine.RTexture2D RFm_Atlas
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
		/// UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture m_RawAtlas
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas.RRawTexture r_Fm_RawAtlas;
		public virtual RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas.RRawTexture RFm_RawAtlas
		{
			get
			{
				if(r_Fm_RawAtlas == null)
				{
					r_Fm_RawAtlas = new(this, "m_RawAtlas");
					r_Fm_RawAtlas.SetBelong(this.instance);
				}
				return r_Fm_RawAtlas;
			}
		}

		/// <summary>
		/// System.Int32 s_TextureCounter
		/// </summary>
		protected static RSystem.RInt32 r_Fs_TextureCounter;
		public static RSystem.RInt32 RFs_TextureCounter
		{
			get
			{
				if(r_Fs_TextureCounter == null)
				{
					r_Fs_TextureCounter = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas"), "s_TextureCounter");
					r_Fs_TextureCounter.SetBelong(null);
				}
				return r_Fs_TextureCounter;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__disposed__1__k__BackingField
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
		/// System.Boolean <MustCommit>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__MustCommit__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__MustCommit__1__k__BackingField
		{
			get
			{
				if(r_F__0__MustCommit__1__k__BackingField == null)
				{
					r_F__0__MustCommit__1__k__BackingField = new(this, "<MustCommit>k__BackingField");
					r_F__0__MustCommit__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__MustCommit__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 length
		/// </summary>
		protected RSystem.RInt32 r_Plength;
		public virtual RSystem.RInt32 RPlength
		{
			get
			{
				if(r_Plength == null)
				{
					r_Plength = new(this, "length", -1);
					r_Plength.SetBelong(this.instance);
				}
				return r_Plength;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RSystem.RBoolean r_Pdisposed;
		public virtual RSystem.RBoolean RPdisposed
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
		/// UnityEngine.Texture2D atlas
		/// </summary>
		protected RUnityEngine.RTexture2D r_Patlas;
		public virtual RUnityEngine.RTexture2D RPatlas
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
		/// Boolean MustCommit
		/// </summary>
		protected RSystem.RBoolean r_PMustCommit;
		public virtual RSystem.RBoolean RPMustCommit
		{
			get
			{
				if(r_PMustCommit == null)
				{
					r_PMustCommit = new(this, "MustCommit", -1);
					r_PMustCommit.SetBelong(this.instance);
				}
				return r_PMustCommit;
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
		/// UnityEngine.UIElements.UIR.Alloc Add(Int32)
		/// </summary>
		protected RMethod r_MAdd_Int32;
		public virtual RMethod RMAdd_Int32
		{
			get
			{
				if(r_MAdd_Int32 == null)
				{
					r_MAdd_Int32 = new(this, "Add", 0, typeof(System.Int32));
					r_MAdd_Int32.SetBelong(this.instance);
				}
				return r_MAdd_Int32;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.UIR.Alloc)
		/// </summary>
		protected RMethod r_MRemove_Alloc;
		public virtual RMethod RMRemove_Alloc
		{
			get
			{
				if(r_MRemove_Alloc == null)
				{
					r_MRemove_Alloc = new(this, "Remove", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"));
					r_MRemove_Alloc.SetBelong(this.instance);
				}
				return r_MRemove_Alloc;
			}
		}

		/// <summary>
		/// Void Write(UnityEngine.UIElements.UIR.Alloc, UnityEngine.UIElements.GradientSettings[], UnityEngine.UIElements.UIR.GradientRemap)
		/// </summary>
		protected RMethod r_MWrite_Alloc_GradientSettingsArray_GradientRemap;
		public virtual RMethod RMWrite_Alloc_GradientSettingsArray_GradientRemap
		{
			get
			{
				if(r_MWrite_Alloc_GradientSettingsArray_GradientRemap == null)
				{
					r_MWrite_Alloc_GradientSettingsArray_GradientRemap = new(this, "Write", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"),  ReflectionUtils.GetType("UnityEngine.UIElements.GradientSettings").MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientRemap"));
					r_MWrite_Alloc_GradientSettingsArray_GradientRemap.SetBelong(this.instance);
				}
				return r_MWrite_Alloc_GradientSettingsArray_GradientRemap;
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
		/// Void PrepareAtlas()
		/// </summary>
		protected RMethod r_MPrepareAtlas;
		public virtual RMethod RMPrepareAtlas
		{
			get
			{
				if(r_MPrepareAtlas == null)
				{
					r_MPrepareAtlas = new(this, "PrepareAtlas", 0);
					r_MPrepareAtlas.SetBelong(this.instance);
				}
				return r_MPrepareAtlas;
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


        public RGradientSettingsAtlas() : base("UnityEngine.UIElements.UIR.GradientSettingsAtlas")
        {
        }

        public RGradientSettingsAtlas(System.Object instance) : base("UnityEngine.UIElements.UIR.GradientSettingsAtlas")
		{
            SetInstance(instance);
		}

        public RGradientSettingsAtlas(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGradientSettingsAtlas(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual RUnityEngine.RUIElements.RUIR.RAlloc Add(System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RMAdd_Int32.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RAlloc(___result);
        }


        public virtual void Remove(RUnityEngine.RUIElements.RUIR.RAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMRemove_Alloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(RUnityEngine.RUIElements.RUIR.RAlloc @alloc, RTypeArray<RUnityEngine.RUIElements.RGradientSettings> @settings, RUnityEngine.RUIElements.RUIR.RGradientRemap @remap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @settings.Value, @remap.Value};
            var ___result = RMWrite_Alloc_GradientSettingsArray_GradientRemap.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Commit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCommit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareAtlas()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepareAtlas.Invoke(___genericsType, ___parameters);

            
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
