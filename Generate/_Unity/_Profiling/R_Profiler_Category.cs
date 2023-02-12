
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RProfiling
{
	/// <summary>
	/// Unity.Profiling.ProfilerCategory
	/// </summary>
    public partial class RProfilerCategory : RMember //
    {

		/// <summary>
		/// System.UInt16 m_CategoryId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt16 r_Fm_CategoryId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt16 RFm_CategoryId
		{
			get
			{
				if(r_Fm_CategoryId == null)
				{
					r_Fm_CategoryId = new(this, "m_CategoryId");
					r_Fm_CategoryId.SetBelong(this.instance);
				}
				return r_Fm_CategoryId;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 Color
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor32 r_PColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor32 RPColor
		{
			get
			{
				if(r_PColor == null)
				{
					r_PColor = new(this, "Color", -1);
					r_PColor.SetBelong(this.instance);
				}
				return r_PColor;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Render
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PRender;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPRender
		{
			get
			{
				if(r_PRender == null)
				{
					r_PRender = new(typeof(Unity.Profiling.ProfilerCategory), "Render", -1);
					r_PRender.SetBelong(null);
				}
				return r_PRender;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Scripts
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PScripts;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPScripts
		{
			get
			{
				if(r_PScripts == null)
				{
					r_PScripts = new(typeof(Unity.Profiling.ProfilerCategory), "Scripts", -1);
					r_PScripts.SetBelong(null);
				}
				return r_PScripts;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Gui
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PGui;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPGui
		{
			get
			{
				if(r_PGui == null)
				{
					r_PGui = new(typeof(Unity.Profiling.ProfilerCategory), "Gui", -1);
					r_PGui.SetBelong(null);
				}
				return r_PGui;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Physics
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PPhysics;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPPhysics
		{
			get
			{
				if(r_PPhysics == null)
				{
					r_PPhysics = new(typeof(Unity.Profiling.ProfilerCategory), "Physics", -1);
					r_PPhysics.SetBelong(null);
				}
				return r_PPhysics;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Physics2D
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PPhysics2D;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPPhysics2D
		{
			get
			{
				if(r_PPhysics2D == null)
				{
					r_PPhysics2D = new(typeof(Unity.Profiling.ProfilerCategory), "Physics2D", -1);
					r_PPhysics2D.SetBelong(null);
				}
				return r_PPhysics2D;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Animation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PAnimation;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPAnimation
		{
			get
			{
				if(r_PAnimation == null)
				{
					r_PAnimation = new(typeof(Unity.Profiling.ProfilerCategory), "Animation", -1);
					r_PAnimation.SetBelong(null);
				}
				return r_PAnimation;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Ai
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PAi;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPAi
		{
			get
			{
				if(r_PAi == null)
				{
					r_PAi = new(typeof(Unity.Profiling.ProfilerCategory), "Ai", -1);
					r_PAi.SetBelong(null);
				}
				return r_PAi;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Audio
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PAudio;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPAudio
		{
			get
			{
				if(r_PAudio == null)
				{
					r_PAudio = new(typeof(Unity.Profiling.ProfilerCategory), "Audio", -1);
					r_PAudio.SetBelong(null);
				}
				return r_PAudio;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Video
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PVideo;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPVideo
		{
			get
			{
				if(r_PVideo == null)
				{
					r_PVideo = new(typeof(Unity.Profiling.ProfilerCategory), "Video", -1);
					r_PVideo.SetBelong(null);
				}
				return r_PVideo;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Particles
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PParticles;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPParticles
		{
			get
			{
				if(r_PParticles == null)
				{
					r_PParticles = new(typeof(Unity.Profiling.ProfilerCategory), "Particles", -1);
					r_PParticles.SetBelong(null);
				}
				return r_PParticles;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Lighting
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PLighting;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPLighting
		{
			get
			{
				if(r_PLighting == null)
				{
					r_PLighting = new(typeof(Unity.Profiling.ProfilerCategory), "Lighting", -1);
					r_PLighting.SetBelong(null);
				}
				return r_PLighting;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Network
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PNetwork;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPNetwork
		{
			get
			{
				if(r_PNetwork == null)
				{
					r_PNetwork = new(typeof(Unity.Profiling.ProfilerCategory), "Network", -1);
					r_PNetwork.SetBelong(null);
				}
				return r_PNetwork;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Loading
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PLoading;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPLoading
		{
			get
			{
				if(r_PLoading == null)
				{
					r_PLoading = new(typeof(Unity.Profiling.ProfilerCategory), "Loading", -1);
					r_PLoading.SetBelong(null);
				}
				return r_PLoading;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Vr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PVr;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPVr
		{
			get
			{
				if(r_PVr == null)
				{
					r_PVr = new(typeof(Unity.Profiling.ProfilerCategory), "Vr", -1);
					r_PVr.SetBelong(null);
				}
				return r_PVr;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Input
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PInput;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPInput
		{
			get
			{
				if(r_PInput == null)
				{
					r_PInput = new(typeof(Unity.Profiling.ProfilerCategory), "Input", -1);
					r_PInput.SetBelong(null);
				}
				return r_PInput;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Memory
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PMemory;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPMemory
		{
			get
			{
				if(r_PMemory == null)
				{
					r_PMemory = new(typeof(Unity.Profiling.ProfilerCategory), "Memory", -1);
					r_PMemory.SetBelong(null);
				}
				return r_PMemory;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory VirtualTexturing
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PVirtualTexturing;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPVirtualTexturing
		{
			get
			{
				if(r_PVirtualTexturing == null)
				{
					r_PVirtualTexturing = new(typeof(Unity.Profiling.ProfilerCategory), "VirtualTexturing", -1);
					r_PVirtualTexturing.SetBelong(null);
				}
				return r_PVirtualTexturing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory FileIO
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PFileIO;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPFileIO
		{
			get
			{
				if(r_PFileIO == null)
				{
					r_PFileIO = new(typeof(Unity.Profiling.ProfilerCategory), "FileIO", -1);
					r_PFileIO.SetBelong(null);
				}
				return r_PFileIO;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Internal
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PInternal;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPInternal
		{
			get
			{
				if(r_PInternal == null)
				{
					r_PInternal = new(typeof(Unity.Profiling.ProfilerCategory), "Internal", -1);
					r_PInternal.SetBelong(null);
				}
				return r_PInternal;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Any
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PAny;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPAny
		{
			get
			{
				if(r_PAny == null)
				{
					r_PAny = new(typeof(Unity.Profiling.ProfilerCategory), "Any", -1);
					r_PAny.SetBelong(null);
				}
				return r_PAny;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory GPU
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory r_PGPU;
		public static SMFrame.Editor.Refleaction.RUnity.RProfiling.RProfilerCategory RPGPU
		{
			get
			{
				if(r_PGPU == null)
				{
					r_PGPU = new(typeof(Unity.Profiling.ProfilerCategory), "GPU", -1);
					r_PGPU.SetBelong(null);
				}
				return r_PGPU;
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

		/// <summary>
		/// UInt16 op_Implicit(Unity.Profiling.ProfilerCategory)
		/// </summary>
		protected static RMethod r_Mop_Implicit_ProfilerCategory;
		public static RMethod RMop_Implicit_ProfilerCategory
		{
			get
			{
				if(r_Mop_Implicit_ProfilerCategory == null)
				{
					r_Mop_Implicit_ProfilerCategory = new(typeof(Unity.Profiling.ProfilerCategory), "op_Implicit", 0, typeof(Unity.Profiling.ProfilerCategory));
					r_Mop_Implicit_ProfilerCategory.SetBelong(null);
				}
				return r_Mop_Implicit_ProfilerCategory;
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


        public RProfilerCategory() : base("Unity.Profiling.ProfilerCategory")
        {
        }

        public RProfilerCategory(System.Object instance) : base("Unity.Profiling.ProfilerCategory")
		{
            SetInstance(instance);
		}

        public RProfilerCategory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerCategory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.UInt16 op_Implicit(Unity.Profiling.ProfilerCategory @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category};
            var ___result = RMop_Implicit_ProfilerCategory.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
