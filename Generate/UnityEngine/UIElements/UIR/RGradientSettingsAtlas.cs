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
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerWrite;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerWrite
		{
			get
			{
				if(r_s_MarkerWrite == null)
				{
					r_s_MarkerWrite = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas"), "s_MarkerWrite");
					r_s_MarkerWrite.SetBelong(null);
				}
				return r_s_MarkerWrite;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_MarkerCommit
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_MarkerCommit;
		public static RUnity.RProfiling.RProfilerMarker Rs_MarkerCommit
		{
			get
			{
				if(r_s_MarkerCommit == null)
				{
					r_s_MarkerCommit = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas"), "s_MarkerCommit");
					r_s_MarkerCommit.SetBelong(null);
				}
				return r_s_MarkerCommit;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected RField r_m_Length;
		public virtual RField Rm_Length
		{
			get
			{
				if(r_m_Length == null)
				{
					r_m_Length = new(this, "m_Length");
					r_m_Length.SetBelong(this.instance);
				}
				return r_m_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_ElemWidth
		/// </summary>
		protected RField r_m_ElemWidth;
		public virtual RField Rm_ElemWidth
		{
			get
			{
				if(r_m_ElemWidth == null)
				{
					r_m_ElemWidth = new(this, "m_ElemWidth");
					r_m_ElemWidth.SetBelong(this.instance);
				}
				return r_m_ElemWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_m_Allocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator Rm_Allocator
		{
			get
			{
				if(r_m_Allocator == null)
				{
					r_m_Allocator = new(this, "m_Allocator");
					r_m_Allocator.SetBelong(this.instance);
				}
				return r_m_Allocator;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_Atlas
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_Atlas;
		public virtual RUnityEngine.RTexture2D Rm_Atlas
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
		/// UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture m_RawAtlas
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas.RRawTexture r_m_RawAtlas;
		public virtual RUnityEngine.RUIElements.RUIR.RGradientSettingsAtlas.RRawTexture Rm_RawAtlas
		{
			get
			{
				if(r_m_RawAtlas == null)
				{
					r_m_RawAtlas = new(this, "m_RawAtlas");
					r_m_RawAtlas.SetBelong(this.instance);
				}
				return r_m_RawAtlas;
			}
		}

		/// <summary>
		/// System.Int32 s_TextureCounter
		/// </summary>
		protected static RField r_s_TextureCounter;
		public static RField Rs_TextureCounter
		{
			get
			{
				if(r_s_TextureCounter == null)
				{
					r_s_TextureCounter = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas"), "s_TextureCounter");
					r_s_TextureCounter.SetBelong(null);
				}
				return r_s_TextureCounter;
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
		/// System.Boolean <MustCommit>k__BackingField
		/// </summary>
		protected RField r___1__MustCommit__2__k__BackingField;
		public virtual RField R__1__MustCommit__2__k__BackingField
		{
			get
			{
				if(r___1__MustCommit__2__k__BackingField == null)
				{
					r___1__MustCommit__2__k__BackingField = new(this, "<MustCommit>k__BackingField");
					r___1__MustCommit__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__MustCommit__2__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 length
		/// </summary>
		protected RProperty r_length;
		public virtual RProperty Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length", -1);
					r_length.SetBelong(this.instance);
				}
				return r_length;
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
		/// Boolean MustCommit
		/// </summary>
		protected RProperty r_MustCommit;
		public virtual RProperty RMustCommit
		{
			get
			{
				if(r_MustCommit == null)
				{
					r_MustCommit = new(this, "MustCommit", -1);
					r_MustCommit.SetBelong(this.instance);
				}
				return r_MustCommit;
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
		/// UnityEngine.UIElements.UIR.Alloc Add(Int32)
		/// </summary>
		protected RMethod r_RAdd_Int32;
		public virtual RMethod RAdd_Int32
		{
			get
			{
				if(r_RAdd_Int32 == null)
				{
					r_RAdd_Int32 = new(this, "Add", 0, typeof(System.Int32));
					r_RAdd_Int32.SetBelong(this.instance);
				}
				return r_RAdd_Int32;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.UIR.Alloc)
		/// </summary>
		protected RMethod r_RRemove_Alloc;
		public virtual RMethod RRemove_Alloc
		{
			get
			{
				if(r_RRemove_Alloc == null)
				{
					r_RRemove_Alloc = new(this, "Remove", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"));
					r_RRemove_Alloc.SetBelong(this.instance);
				}
				return r_RRemove_Alloc;
			}
		}

		/// <summary>
		/// Void Write(UnityEngine.UIElements.UIR.Alloc, UnityEngine.UIElements.GradientSettings[], UnityEngine.UIElements.UIR.GradientRemap)
		/// </summary>
		protected RMethod r_RWrite_Alloc_GradientSettingsArray_GradientRemap;
		public virtual RMethod RWrite_Alloc_GradientSettingsArray_GradientRemap
		{
			get
			{
				if(r_RWrite_Alloc_GradientSettingsArray_GradientRemap == null)
				{
					r_RWrite_Alloc_GradientSettingsArray_GradientRemap = new(this, "Write", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"),  ReleactionUtils.GetType("UnityEngine.UIElements.GradientSettings").MakeArrayType(),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.GradientRemap"));
					r_RWrite_Alloc_GradientSettingsArray_GradientRemap.SetBelong(this.instance);
				}
				return r_RWrite_Alloc_GradientSettingsArray_GradientRemap;
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
		/// Void PrepareAtlas()
		/// </summary>
		protected RMethod r_RPrepareAtlas;
		public virtual RMethod RPrepareAtlas
		{
			get
			{
				if(r_RPrepareAtlas == null)
				{
					r_RPrepareAtlas = new(this, "PrepareAtlas", 0);
					r_RPrepareAtlas.SetBelong(this.instance);
				}
				return r_RPrepareAtlas;
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


        public virtual System.Object Add(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RAdd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual void Commit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCommit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareAtlas()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareAtlas.Invoke(___genericsType, ___parameters);

            
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
