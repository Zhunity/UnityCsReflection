
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.UIR.GradientSettingsAtlas
	/// </summary>
    public partial class RGradientSettingsAtlas : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas");
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


		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerWrite
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerWrite;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerWrite
		{
			get
			{
				if(r_Fs_MarkerWrite == null)
				{
					r_Fs_MarkerWrite = new(Type, "s_MarkerWrite");
				}
				return r_Fs_MarkerWrite;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerCommit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_MarkerCommit;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_MarkerCommit
		{
			get
			{
				if(r_Fs_MarkerCommit == null)
				{
					r_Fs_MarkerCommit = new(Type, "s_MarkerCommit");
				}
				return r_Fs_MarkerCommit;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Length
		{
			get
			{
				if(r_Fm_Length == null)
				{
					r_Fm_Length = new(this, "m_Length");
				}
				return r_Fm_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_ElemWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ElemWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ElemWidth
		{
			get
			{
				if(r_Fm_ElemWidth == null)
				{
					r_Fm_ElemWidth = new(this, "m_ElemWidth");
				}
				return r_Fm_ElemWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_Fm_Allocator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator RFm_Allocator
		{
			get
			{
				if(r_Fm_Allocator == null)
				{
					r_Fm_Allocator = new(this, "m_Allocator");
				}
				return r_Fm_Allocator;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_Atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Fm_Atlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RFm_Atlas
		{
			get
			{
				if(r_Fm_Atlas == null)
				{
					r_Fm_Atlas = new(this, "m_Atlas");
				}
				return r_Fm_Atlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture m_RawAtlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas.RRawTexture r_Fm_RawAtlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas.RRawTexture RFm_RawAtlas
		{
			get
			{
				if(r_Fm_RawAtlas == null)
				{
					r_Fm_RawAtlas = new(this, "m_RawAtlas");
				}
				return r_Fm_RawAtlas;
			}
		}

		/// <summary>
		/// System.Int32 s_TextureCounter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_TextureCounter;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_TextureCounter
		{
			get
			{
				if(r_Fs_TextureCounter == null)
				{
					r_Fs_TextureCounter = new(Type, "s_TextureCounter");
				}
				return r_Fs_TextureCounter;
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
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <MustCommit>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__MustCommit__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__MustCommit__1__k__BackingField
		{
			get
			{
				if(r_F__0__MustCommit__1__k__BackingField == null)
				{
					r_F__0__MustCommit__1__k__BackingField = new(this, "<MustCommit>k__BackingField");
				}
				return r_F__0__MustCommit__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Plength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPlength
		{
			get
			{
				if(r_Plength == null)
				{
					r_Plength = new(this, "length", -1);
				}
				return r_Plength;
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
				}
				return r_Pdisposed;
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
				}
				return r_Patlas;
			}
		}

		/// <summary>
		/// Boolean MustCommit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PMustCommit;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPMustCommit
		{
			get
			{
				if(r_PMustCommit == null)
				{
					r_PMustCommit = new(this, "MustCommit", -1);
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc Add(System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RMAdd_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc>(___result);
        }


        public virtual void Remove(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMRemove_Alloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc @alloc, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RGradientSettings> @settings, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap @remap)
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
