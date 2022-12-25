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
		protected RField r_m_CategoryId;
		public virtual RField Rm_CategoryId
		{
			get
			{
				if(r_m_CategoryId == null)
				{
					r_m_CategoryId = new(this, "m_CategoryId");
					r_m_CategoryId.SetBelong(this.instance);
				}
				return r_m_CategoryId;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 Color
		/// </summary>
		protected RUnityEngine.RColor32 r_Color;
		public virtual RUnityEngine.RColor32 RColor
		{
			get
			{
				if(r_Color == null)
				{
					r_Color = new(this, "Color", -1);
					r_Color.SetBelong(this.instance);
				}
				return r_Color;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Render
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Render;
		public static RUnity.RProfiling.RProfilerCategory Render
		{
			get
			{
				if(r_Render == null)
				{
					r_Render = new(typeof(Unity.Profiling.ProfilerCategory), "Render", -1);
					r_Render.SetBelong(null);
				}
				return r_Render;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Scripts
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Scripts;
		public static RUnity.RProfiling.RProfilerCategory RScripts
		{
			get
			{
				if(r_Scripts == null)
				{
					r_Scripts = new(typeof(Unity.Profiling.ProfilerCategory), "Scripts", -1);
					r_Scripts.SetBelong(null);
				}
				return r_Scripts;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Gui
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Gui;
		public static RUnity.RProfiling.RProfilerCategory RGui
		{
			get
			{
				if(r_Gui == null)
				{
					r_Gui = new(typeof(Unity.Profiling.ProfilerCategory), "Gui", -1);
					r_Gui.SetBelong(null);
				}
				return r_Gui;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Physics
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Physics;
		public static RUnity.RProfiling.RProfilerCategory RPhysics
		{
			get
			{
				if(r_Physics == null)
				{
					r_Physics = new(typeof(Unity.Profiling.ProfilerCategory), "Physics", -1);
					r_Physics.SetBelong(null);
				}
				return r_Physics;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Physics2D
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Physics2D;
		public static RUnity.RProfiling.RProfilerCategory RPhysics2D
		{
			get
			{
				if(r_Physics2D == null)
				{
					r_Physics2D = new(typeof(Unity.Profiling.ProfilerCategory), "Physics2D", -1);
					r_Physics2D.SetBelong(null);
				}
				return r_Physics2D;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Animation
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Animation;
		public static RUnity.RProfiling.RProfilerCategory RAnimation
		{
			get
			{
				if(r_Animation == null)
				{
					r_Animation = new(typeof(Unity.Profiling.ProfilerCategory), "Animation", -1);
					r_Animation.SetBelong(null);
				}
				return r_Animation;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Ai
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Ai;
		public static RUnity.RProfiling.RProfilerCategory RAi
		{
			get
			{
				if(r_Ai == null)
				{
					r_Ai = new(typeof(Unity.Profiling.ProfilerCategory), "Ai", -1);
					r_Ai.SetBelong(null);
				}
				return r_Ai;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Audio
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Audio;
		public static RUnity.RProfiling.RProfilerCategory RAudio
		{
			get
			{
				if(r_Audio == null)
				{
					r_Audio = new(typeof(Unity.Profiling.ProfilerCategory), "Audio", -1);
					r_Audio.SetBelong(null);
				}
				return r_Audio;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Video
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Video;
		public static RUnity.RProfiling.RProfilerCategory RVideo
		{
			get
			{
				if(r_Video == null)
				{
					r_Video = new(typeof(Unity.Profiling.ProfilerCategory), "Video", -1);
					r_Video.SetBelong(null);
				}
				return r_Video;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Particles
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Particles;
		public static RUnity.RProfiling.RProfilerCategory RParticles
		{
			get
			{
				if(r_Particles == null)
				{
					r_Particles = new(typeof(Unity.Profiling.ProfilerCategory), "Particles", -1);
					r_Particles.SetBelong(null);
				}
				return r_Particles;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Lighting
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Lighting;
		public static RUnity.RProfiling.RProfilerCategory RLighting
		{
			get
			{
				if(r_Lighting == null)
				{
					r_Lighting = new(typeof(Unity.Profiling.ProfilerCategory), "Lighting", -1);
					r_Lighting.SetBelong(null);
				}
				return r_Lighting;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Network
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Network;
		public static RUnity.RProfiling.RProfilerCategory RNetwork
		{
			get
			{
				if(r_Network == null)
				{
					r_Network = new(typeof(Unity.Profiling.ProfilerCategory), "Network", -1);
					r_Network.SetBelong(null);
				}
				return r_Network;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Loading
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Loading;
		public static RUnity.RProfiling.RProfilerCategory RLoading
		{
			get
			{
				if(r_Loading == null)
				{
					r_Loading = new(typeof(Unity.Profiling.ProfilerCategory), "Loading", -1);
					r_Loading.SetBelong(null);
				}
				return r_Loading;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Vr
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Vr;
		public static RUnity.RProfiling.RProfilerCategory RVr
		{
			get
			{
				if(r_Vr == null)
				{
					r_Vr = new(typeof(Unity.Profiling.ProfilerCategory), "Vr", -1);
					r_Vr.SetBelong(null);
				}
				return r_Vr;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Input
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Input;
		public static RUnity.RProfiling.RProfilerCategory RInput
		{
			get
			{
				if(r_Input == null)
				{
					r_Input = new(typeof(Unity.Profiling.ProfilerCategory), "Input", -1);
					r_Input.SetBelong(null);
				}
				return r_Input;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Memory
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Memory;
		public static RUnity.RProfiling.RProfilerCategory RMemory
		{
			get
			{
				if(r_Memory == null)
				{
					r_Memory = new(typeof(Unity.Profiling.ProfilerCategory), "Memory", -1);
					r_Memory.SetBelong(null);
				}
				return r_Memory;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory VirtualTexturing
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_VirtualTexturing;
		public static RUnity.RProfiling.RProfilerCategory RVirtualTexturing
		{
			get
			{
				if(r_VirtualTexturing == null)
				{
					r_VirtualTexturing = new(typeof(Unity.Profiling.ProfilerCategory), "VirtualTexturing", -1);
					r_VirtualTexturing.SetBelong(null);
				}
				return r_VirtualTexturing;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory FileIO
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_FileIO;
		public static RUnity.RProfiling.RProfilerCategory RFileIO
		{
			get
			{
				if(r_FileIO == null)
				{
					r_FileIO = new(typeof(Unity.Profiling.ProfilerCategory), "FileIO", -1);
					r_FileIO.SetBelong(null);
				}
				return r_FileIO;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Internal
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Internal;
		public static RUnity.RProfiling.RProfilerCategory RInternal
		{
			get
			{
				if(r_Internal == null)
				{
					r_Internal = new(typeof(Unity.Profiling.ProfilerCategory), "Internal", -1);
					r_Internal.SetBelong(null);
				}
				return r_Internal;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory Any
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_Any;
		public static RUnity.RProfiling.RProfilerCategory RAny
		{
			get
			{
				if(r_Any == null)
				{
					r_Any = new(typeof(Unity.Profiling.ProfilerCategory), "Any", -1);
					r_Any.SetBelong(null);
				}
				return r_Any;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerCategory GPU
		/// </summary>
		protected static RUnity.RProfiling.RProfilerCategory r_GPU;
		public static RUnity.RProfiling.RProfilerCategory RGPU
		{
			get
			{
				if(r_GPU == null)
				{
					r_GPU = new(typeof(Unity.Profiling.ProfilerCategory), "GPU", -1);
					r_GPU.SetBelong(null);
				}
				return r_GPU;
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

		/// <summary>
		/// UInt16 op_Implicit(Unity.Profiling.ProfilerCategory)
		/// </summary>
		protected static RMethod r_Rop_Implicit_ProfilerCategory;
		public static RMethod Rop_Implicit_ProfilerCategory
		{
			get
			{
				if(r_Rop_Implicit_ProfilerCategory == null)
				{
					r_Rop_Implicit_ProfilerCategory = new(typeof(Unity.Profiling.ProfilerCategory), "op_Implicit", 0, typeof(Unity.Profiling.ProfilerCategory));
					r_Rop_Implicit_ProfilerCategory.SetBelong(null);
				}
				return r_Rop_Implicit_ProfilerCategory;
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
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.UInt16 op_Implicit(Unity.Profiling.ProfilerCategory  @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category};
            var ___result = Rop_Implicit_ProfilerCategory.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
