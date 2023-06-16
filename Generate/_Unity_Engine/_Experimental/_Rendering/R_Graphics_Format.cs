
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Experimental.Rendering.GraphicsFormat
	/// </summary>
    public partial class RGraphicsFormat : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Experimental.Rendering.GraphicsFormat);
            }
        }

        public RGraphicsFormat() : base("UnityEngine.Experimental.Rendering.GraphicsFormat")
        {
        }

        public RGraphicsFormat(System.Object instance) : base("UnityEngine.Experimental.Rendering.GraphicsFormat")
		{
            SetInstance(instance);
		}

        public RGraphicsFormat(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGraphicsFormat(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(Type, "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8_SRGB
		{
			get
			{
				if(r_FR8_SRGB == null)
				{
					r_FR8_SRGB = new(Type, "R8_SRGB");
				}
				return r_FR8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8_SRGB
		{
			get
			{
				if(r_FR8G8_SRGB == null)
				{
					r_FR8G8_SRGB = new(Type, "R8G8_SRGB");
				}
				return r_FR8G8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8_SRGB
		{
			get
			{
				if(r_FR8G8B8_SRGB == null)
				{
					r_FR8G8B8_SRGB = new(Type, "R8G8B8_SRGB");
				}
				return r_FR8G8B8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8A8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8A8_SRGB
		{
			get
			{
				if(r_FR8G8B8A8_SRGB == null)
				{
					r_FR8G8B8A8_SRGB = new(Type, "R8G8B8A8_SRGB");
				}
				return r_FR8G8B8A8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8_UNorm
		{
			get
			{
				if(r_FR8_UNorm == null)
				{
					r_FR8_UNorm = new(Type, "R8_UNorm");
				}
				return r_FR8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8_UNorm
		{
			get
			{
				if(r_FR8G8_UNorm == null)
				{
					r_FR8G8_UNorm = new(Type, "R8G8_UNorm");
				}
				return r_FR8G8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8_UNorm
		{
			get
			{
				if(r_FR8G8B8_UNorm == null)
				{
					r_FR8G8B8_UNorm = new(Type, "R8G8B8_UNorm");
				}
				return r_FR8G8B8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8A8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8A8_UNorm
		{
			get
			{
				if(r_FR8G8B8A8_UNorm == null)
				{
					r_FR8G8B8A8_UNorm = new(Type, "R8G8B8A8_UNorm");
				}
				return r_FR8G8B8A8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8_SNorm
		{
			get
			{
				if(r_FR8_SNorm == null)
				{
					r_FR8_SNorm = new(Type, "R8_SNorm");
				}
				return r_FR8_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8_SNorm
		{
			get
			{
				if(r_FR8G8_SNorm == null)
				{
					r_FR8G8_SNorm = new(Type, "R8G8_SNorm");
				}
				return r_FR8G8_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8_SNorm
		{
			get
			{
				if(r_FR8G8B8_SNorm == null)
				{
					r_FR8G8B8_SNorm = new(Type, "R8G8B8_SNorm");
				}
				return r_FR8G8B8_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8A8_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8A8_SNorm
		{
			get
			{
				if(r_FR8G8B8A8_SNorm == null)
				{
					r_FR8G8B8A8_SNorm = new(Type, "R8G8B8A8_SNorm");
				}
				return r_FR8G8B8A8_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8_UInt
		{
			get
			{
				if(r_FR8_UInt == null)
				{
					r_FR8_UInt = new(Type, "R8_UInt");
				}
				return r_FR8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8_UInt
		{
			get
			{
				if(r_FR8G8_UInt == null)
				{
					r_FR8G8_UInt = new(Type, "R8G8_UInt");
				}
				return r_FR8G8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8_UInt
		{
			get
			{
				if(r_FR8G8B8_UInt == null)
				{
					r_FR8G8B8_UInt = new(Type, "R8G8B8_UInt");
				}
				return r_FR8G8B8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8A8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8A8_UInt
		{
			get
			{
				if(r_FR8G8B8A8_UInt == null)
				{
					r_FR8G8B8A8_UInt = new(Type, "R8G8B8A8_UInt");
				}
				return r_FR8G8B8A8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8_SInt
		{
			get
			{
				if(r_FR8_SInt == null)
				{
					r_FR8_SInt = new(Type, "R8_SInt");
				}
				return r_FR8_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8_SInt
		{
			get
			{
				if(r_FR8G8_SInt == null)
				{
					r_FR8G8_SInt = new(Type, "R8G8_SInt");
				}
				return r_FR8G8_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8_SInt
		{
			get
			{
				if(r_FR8G8B8_SInt == null)
				{
					r_FR8G8B8_SInt = new(Type, "R8G8B8_SInt");
				}
				return r_FR8G8B8_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR8G8B8A8_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR8G8B8A8_SInt
		{
			get
			{
				if(r_FR8G8B8A8_SInt == null)
				{
					r_FR8G8B8A8_SInt = new(Type, "R8G8B8A8_SInt");
				}
				return r_FR8G8B8A8_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16_UNorm
		{
			get
			{
				if(r_FR16_UNorm == null)
				{
					r_FR16_UNorm = new(Type, "R16_UNorm");
				}
				return r_FR16_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16_UNorm
		{
			get
			{
				if(r_FR16G16_UNorm == null)
				{
					r_FR16G16_UNorm = new(Type, "R16G16_UNorm");
				}
				return r_FR16G16_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16_UNorm
		{
			get
			{
				if(r_FR16G16B16_UNorm == null)
				{
					r_FR16G16B16_UNorm = new(Type, "R16G16B16_UNorm");
				}
				return r_FR16G16B16_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16A16_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16A16_UNorm
		{
			get
			{
				if(r_FR16G16B16A16_UNorm == null)
				{
					r_FR16G16B16A16_UNorm = new(Type, "R16G16B16A16_UNorm");
				}
				return r_FR16G16B16A16_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16_SNorm
		{
			get
			{
				if(r_FR16_SNorm == null)
				{
					r_FR16_SNorm = new(Type, "R16_SNorm");
				}
				return r_FR16_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16_SNorm
		{
			get
			{
				if(r_FR16G16_SNorm == null)
				{
					r_FR16G16_SNorm = new(Type, "R16G16_SNorm");
				}
				return r_FR16G16_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16_SNorm
		{
			get
			{
				if(r_FR16G16B16_SNorm == null)
				{
					r_FR16G16B16_SNorm = new(Type, "R16G16B16_SNorm");
				}
				return r_FR16G16B16_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16A16_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16A16_SNorm
		{
			get
			{
				if(r_FR16G16B16A16_SNorm == null)
				{
					r_FR16G16B16A16_SNorm = new(Type, "R16G16B16A16_SNorm");
				}
				return r_FR16G16B16A16_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16_UInt
		{
			get
			{
				if(r_FR16_UInt == null)
				{
					r_FR16_UInt = new(Type, "R16_UInt");
				}
				return r_FR16_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16_UInt
		{
			get
			{
				if(r_FR16G16_UInt == null)
				{
					r_FR16G16_UInt = new(Type, "R16G16_UInt");
				}
				return r_FR16G16_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16_UInt
		{
			get
			{
				if(r_FR16G16B16_UInt == null)
				{
					r_FR16G16B16_UInt = new(Type, "R16G16B16_UInt");
				}
				return r_FR16G16B16_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16A16_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16A16_UInt
		{
			get
			{
				if(r_FR16G16B16A16_UInt == null)
				{
					r_FR16G16B16A16_UInt = new(Type, "R16G16B16A16_UInt");
				}
				return r_FR16G16B16A16_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16_SInt
		{
			get
			{
				if(r_FR16_SInt == null)
				{
					r_FR16_SInt = new(Type, "R16_SInt");
				}
				return r_FR16_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16_SInt
		{
			get
			{
				if(r_FR16G16_SInt == null)
				{
					r_FR16G16_SInt = new(Type, "R16G16_SInt");
				}
				return r_FR16G16_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16_SInt
		{
			get
			{
				if(r_FR16G16B16_SInt == null)
				{
					r_FR16G16B16_SInt = new(Type, "R16G16B16_SInt");
				}
				return r_FR16G16B16_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16A16_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16A16_SInt
		{
			get
			{
				if(r_FR16G16B16A16_SInt == null)
				{
					r_FR16G16B16A16_SInt = new(Type, "R16G16B16A16_SInt");
				}
				return r_FR16G16B16A16_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32_UInt
		{
			get
			{
				if(r_FR32_UInt == null)
				{
					r_FR32_UInt = new(Type, "R32_UInt");
				}
				return r_FR32_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32_UInt
		{
			get
			{
				if(r_FR32G32_UInt == null)
				{
					r_FR32G32_UInt = new(Type, "R32G32_UInt");
				}
				return r_FR32G32_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32B32_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32B32_UInt
		{
			get
			{
				if(r_FR32G32B32_UInt == null)
				{
					r_FR32G32B32_UInt = new(Type, "R32G32B32_UInt");
				}
				return r_FR32G32B32_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32A32_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32B32A32_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32B32A32_UInt
		{
			get
			{
				if(r_FR32G32B32A32_UInt == null)
				{
					r_FR32G32B32A32_UInt = new(Type, "R32G32B32A32_UInt");
				}
				return r_FR32G32B32A32_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32_SInt
		{
			get
			{
				if(r_FR32_SInt == null)
				{
					r_FR32_SInt = new(Type, "R32_SInt");
				}
				return r_FR32_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32_SInt
		{
			get
			{
				if(r_FR32G32_SInt == null)
				{
					r_FR32G32_SInt = new(Type, "R32G32_SInt");
				}
				return r_FR32G32_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32B32_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32B32_SInt
		{
			get
			{
				if(r_FR32G32B32_SInt == null)
				{
					r_FR32G32B32_SInt = new(Type, "R32G32B32_SInt");
				}
				return r_FR32G32B32_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32A32_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32B32A32_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32B32A32_SInt
		{
			get
			{
				if(r_FR32G32B32A32_SInt == null)
				{
					r_FR32G32B32A32_SInt = new(Type, "R32G32B32A32_SInt");
				}
				return r_FR32G32B32A32_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16_SFloat
		{
			get
			{
				if(r_FR16_SFloat == null)
				{
					r_FR16_SFloat = new(Type, "R16_SFloat");
				}
				return r_FR16_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16_SFloat
		{
			get
			{
				if(r_FR16G16_SFloat == null)
				{
					r_FR16G16_SFloat = new(Type, "R16G16_SFloat");
				}
				return r_FR16G16_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16_SFloat
		{
			get
			{
				if(r_FR16G16B16_SFloat == null)
				{
					r_FR16G16B16_SFloat = new(Type, "R16G16B16_SFloat");
				}
				return r_FR16G16B16_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR16G16B16A16_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR16G16B16A16_SFloat
		{
			get
			{
				if(r_FR16G16B16A16_SFloat == null)
				{
					r_FR16G16B16A16_SFloat = new(Type, "R16G16B16A16_SFloat");
				}
				return r_FR16G16B16A16_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32_SFloat
		{
			get
			{
				if(r_FR32_SFloat == null)
				{
					r_FR32_SFloat = new(Type, "R32_SFloat");
				}
				return r_FR32_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32_SFloat
		{
			get
			{
				if(r_FR32G32_SFloat == null)
				{
					r_FR32G32_SFloat = new(Type, "R32G32_SFloat");
				}
				return r_FR32G32_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32B32_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32B32_SFloat
		{
			get
			{
				if(r_FR32G32B32_SFloat == null)
				{
					r_FR32G32B32_SFloat = new(Type, "R32G32B32_SFloat");
				}
				return r_FR32G32B32_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32A32_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR32G32B32A32_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR32G32B32A32_SFloat
		{
			get
			{
				if(r_FR32G32B32A32_SFloat == null)
				{
					r_FR32G32B32A32_SFloat = new(Type, "R32G32B32A32_SFloat");
				}
				return r_FR32G32B32A32_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8_SRGB
		{
			get
			{
				if(r_FB8G8R8_SRGB == null)
				{
					r_FB8G8R8_SRGB = new(Type, "B8G8R8_SRGB");
				}
				return r_FB8G8R8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8A8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8A8_SRGB
		{
			get
			{
				if(r_FB8G8R8A8_SRGB == null)
				{
					r_FB8G8R8A8_SRGB = new(Type, "B8G8R8A8_SRGB");
				}
				return r_FB8G8R8A8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8_UNorm
		{
			get
			{
				if(r_FB8G8R8_UNorm == null)
				{
					r_FB8G8R8_UNorm = new(Type, "B8G8R8_UNorm");
				}
				return r_FB8G8R8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8A8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8A8_UNorm
		{
			get
			{
				if(r_FB8G8R8A8_UNorm == null)
				{
					r_FB8G8R8A8_UNorm = new(Type, "B8G8R8A8_UNorm");
				}
				return r_FB8G8R8A8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8_SNorm
		{
			get
			{
				if(r_FB8G8R8_SNorm == null)
				{
					r_FB8G8R8_SNorm = new(Type, "B8G8R8_SNorm");
				}
				return r_FB8G8R8_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8A8_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8A8_SNorm
		{
			get
			{
				if(r_FB8G8R8A8_SNorm == null)
				{
					r_FB8G8R8A8_SNorm = new(Type, "B8G8R8A8_SNorm");
				}
				return r_FB8G8R8A8_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8_UInt
		{
			get
			{
				if(r_FB8G8R8_UInt == null)
				{
					r_FB8G8R8_UInt = new(Type, "B8G8R8_UInt");
				}
				return r_FB8G8R8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8A8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8A8_UInt
		{
			get
			{
				if(r_FB8G8R8A8_UInt == null)
				{
					r_FB8G8R8A8_UInt = new(Type, "B8G8R8A8_UInt");
				}
				return r_FB8G8R8A8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8_SInt
		{
			get
			{
				if(r_FB8G8R8_SInt == null)
				{
					r_FB8G8R8_SInt = new(Type, "B8G8R8_SInt");
				}
				return r_FB8G8R8_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_SInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB8G8R8A8_SInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB8G8R8A8_SInt
		{
			get
			{
				if(r_FB8G8R8A8_SInt == null)
				{
					r_FB8G8R8A8_SInt = new(Type, "B8G8R8A8_SInt");
				}
				return r_FB8G8R8A8_SInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R4G4B4A4_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR4G4B4A4_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR4G4B4A4_UNormPack16
		{
			get
			{
				if(r_FR4G4B4A4_UNormPack16 == null)
				{
					r_FR4G4B4A4_UNormPack16 = new(Type, "R4G4B4A4_UNormPack16");
				}
				return r_FR4G4B4A4_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B4G4R4A4_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB4G4R4A4_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB4G4R4A4_UNormPack16
		{
			get
			{
				if(r_FB4G4R4A4_UNormPack16 == null)
				{
					r_FB4G4R4A4_UNormPack16 = new(Type, "B4G4R4A4_UNormPack16");
				}
				return r_FB4G4R4A4_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R5G6B5_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR5G6B5_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR5G6B5_UNormPack16
		{
			get
			{
				if(r_FR5G6B5_UNormPack16 == null)
				{
					r_FR5G6B5_UNormPack16 = new(Type, "R5G6B5_UNormPack16");
				}
				return r_FR5G6B5_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B5G6R5_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB5G6R5_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB5G6R5_UNormPack16
		{
			get
			{
				if(r_FB5G6R5_UNormPack16 == null)
				{
					r_FB5G6R5_UNormPack16 = new(Type, "B5G6R5_UNormPack16");
				}
				return r_FB5G6R5_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R5G5B5A1_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR5G5B5A1_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR5G5B5A1_UNormPack16
		{
			get
			{
				if(r_FR5G5B5A1_UNormPack16 == null)
				{
					r_FR5G5B5A1_UNormPack16 = new(Type, "R5G5B5A1_UNormPack16");
				}
				return r_FR5G5B5A1_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B5G5R5A1_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB5G5R5A1_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB5G5R5A1_UNormPack16
		{
			get
			{
				if(r_FB5G5R5A1_UNormPack16 == null)
				{
					r_FB5G5R5A1_UNormPack16 = new(Type, "B5G5R5A1_UNormPack16");
				}
				return r_FB5G5R5A1_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A1R5G5B5_UNormPack16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA1R5G5B5_UNormPack16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA1R5G5B5_UNormPack16
		{
			get
			{
				if(r_FA1R5G5B5_UNormPack16 == null)
				{
					r_FA1R5G5B5_UNormPack16 = new(Type, "A1R5G5B5_UNormPack16");
				}
				return r_FA1R5G5B5_UNormPack16;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat E5B9G9R9_UFloatPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FE5B9G9R9_UFloatPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFE5B9G9R9_UFloatPack32
		{
			get
			{
				if(r_FE5B9G9R9_UFloatPack32 == null)
				{
					r_FE5B9G9R9_UFloatPack32 = new(Type, "E5B9G9R9_UFloatPack32");
				}
				return r_FE5B9G9R9_UFloatPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat B10G11R11_UFloatPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FB10G11R11_UFloatPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFB10G11R11_UFloatPack32
		{
			get
			{
				if(r_FB10G11R11_UFloatPack32 == null)
				{
					r_FB10G11R11_UFloatPack32 = new(Type, "B10G11R11_UFloatPack32");
				}
				return r_FB10G11R11_UFloatPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2B10G10R10_UNormPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2B10G10R10_UNormPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2B10G10R10_UNormPack32
		{
			get
			{
				if(r_FA2B10G10R10_UNormPack32 == null)
				{
					r_FA2B10G10R10_UNormPack32 = new(Type, "A2B10G10R10_UNormPack32");
				}
				return r_FA2B10G10R10_UNormPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2B10G10R10_UIntPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2B10G10R10_UIntPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2B10G10R10_UIntPack32
		{
			get
			{
				if(r_FA2B10G10R10_UIntPack32 == null)
				{
					r_FA2B10G10R10_UIntPack32 = new(Type, "A2B10G10R10_UIntPack32");
				}
				return r_FA2B10G10R10_UIntPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2B10G10R10_SIntPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2B10G10R10_SIntPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2B10G10R10_SIntPack32
		{
			get
			{
				if(r_FA2B10G10R10_SIntPack32 == null)
				{
					r_FA2B10G10R10_SIntPack32 = new(Type, "A2B10G10R10_SIntPack32");
				}
				return r_FA2B10G10R10_SIntPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_UNormPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2R10G10B10_UNormPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2R10G10B10_UNormPack32
		{
			get
			{
				if(r_FA2R10G10B10_UNormPack32 == null)
				{
					r_FA2R10G10B10_UNormPack32 = new(Type, "A2R10G10B10_UNormPack32");
				}
				return r_FA2R10G10B10_UNormPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_UIntPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2R10G10B10_UIntPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2R10G10B10_UIntPack32
		{
			get
			{
				if(r_FA2R10G10B10_UIntPack32 == null)
				{
					r_FA2R10G10B10_UIntPack32 = new(Type, "A2R10G10B10_UIntPack32");
				}
				return r_FA2R10G10B10_UIntPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_SIntPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2R10G10B10_SIntPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2R10G10B10_SIntPack32
		{
			get
			{
				if(r_FA2R10G10B10_SIntPack32 == null)
				{
					r_FA2R10G10B10_SIntPack32 = new(Type, "A2R10G10B10_SIntPack32");
				}
				return r_FA2R10G10B10_SIntPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_XRSRGBPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2R10G10B10_XRSRGBPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2R10G10B10_XRSRGBPack32
		{
			get
			{
				if(r_FA2R10G10B10_XRSRGBPack32 == null)
				{
					r_FA2R10G10B10_XRSRGBPack32 = new(Type, "A2R10G10B10_XRSRGBPack32");
				}
				return r_FA2R10G10B10_XRSRGBPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_XRUNormPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA2R10G10B10_XRUNormPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA2R10G10B10_XRUNormPack32
		{
			get
			{
				if(r_FA2R10G10B10_XRUNormPack32 == null)
				{
					r_FA2R10G10B10_XRUNormPack32 = new(Type, "A2R10G10B10_XRUNormPack32");
				}
				return r_FA2R10G10B10_XRUNormPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R10G10B10_XRSRGBPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR10G10B10_XRSRGBPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR10G10B10_XRSRGBPack32
		{
			get
			{
				if(r_FR10G10B10_XRSRGBPack32 == null)
				{
					r_FR10G10B10_XRSRGBPack32 = new(Type, "R10G10B10_XRSRGBPack32");
				}
				return r_FR10G10B10_XRSRGBPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R10G10B10_XRUNormPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR10G10B10_XRUNormPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR10G10B10_XRUNormPack32
		{
			get
			{
				if(r_FR10G10B10_XRUNormPack32 == null)
				{
					r_FR10G10B10_XRUNormPack32 = new(Type, "R10G10B10_XRUNormPack32");
				}
				return r_FR10G10B10_XRUNormPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A10R10G10B10_XRSRGBPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA10R10G10B10_XRSRGBPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA10R10G10B10_XRSRGBPack32
		{
			get
			{
				if(r_FA10R10G10B10_XRSRGBPack32 == null)
				{
					r_FA10R10G10B10_XRSRGBPack32 = new(Type, "A10R10G10B10_XRSRGBPack32");
				}
				return r_FA10R10G10B10_XRSRGBPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat A10R10G10B10_XRUNormPack32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FA10R10G10B10_XRUNormPack32;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFA10R10G10B10_XRUNormPack32
		{
			get
			{
				if(r_FA10R10G10B10_XRUNormPack32 == null)
				{
					r_FA10R10G10B10_XRUNormPack32 = new(Type, "A10R10G10B10_XRUNormPack32");
				}
				return r_FA10R10G10B10_XRUNormPack32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat D16_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FD16_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFD16_UNorm
		{
			get
			{
				if(r_FD16_UNorm == null)
				{
					r_FD16_UNorm = new(Type, "D16_UNorm");
				}
				return r_FD16_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat D24_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FD24_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFD24_UNorm
		{
			get
			{
				if(r_FD24_UNorm == null)
				{
					r_FD24_UNorm = new(Type, "D24_UNorm");
				}
				return r_FD24_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat D24_UNorm_S8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FD24_UNorm_S8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFD24_UNorm_S8_UInt
		{
			get
			{
				if(r_FD24_UNorm_S8_UInt == null)
				{
					r_FD24_UNorm_S8_UInt = new(Type, "D24_UNorm_S8_UInt");
				}
				return r_FD24_UNorm_S8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat D32_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FD32_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFD32_SFloat
		{
			get
			{
				if(r_FD32_SFloat == null)
				{
					r_FD32_SFloat = new(Type, "D32_SFloat");
				}
				return r_FD32_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat D32_SFloat_S8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FD32_SFloat_S8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFD32_SFloat_S8_UInt
		{
			get
			{
				if(r_FD32_SFloat_S8_UInt == null)
				{
					r_FD32_SFloat_S8_UInt = new(Type, "D32_SFloat_S8_UInt");
				}
				return r_FD32_SFloat_S8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat S8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FS8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFS8_UInt
		{
			get
			{
				if(r_FS8_UInt == null)
				{
					r_FS8_UInt = new(Type, "S8_UInt");
				}
				return r_FS8_UInt;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_DXT1_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_DXT1_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_DXT1_SRGB
		{
			get
			{
				if(r_FRGB_DXT1_SRGB == null)
				{
					r_FRGB_DXT1_SRGB = new(Type, "RGB_DXT1_SRGB");
				}
				return r_FRGB_DXT1_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT1_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_DXT1_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_DXT1_SRGB
		{
			get
			{
				if(r_FRGBA_DXT1_SRGB == null)
				{
					r_FRGBA_DXT1_SRGB = new(Type, "RGBA_DXT1_SRGB");
				}
				return r_FRGBA_DXT1_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_DXT1_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_DXT1_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_DXT1_UNorm
		{
			get
			{
				if(r_FRGB_DXT1_UNorm == null)
				{
					r_FRGB_DXT1_UNorm = new(Type, "RGB_DXT1_UNorm");
				}
				return r_FRGB_DXT1_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT1_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_DXT1_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_DXT1_UNorm
		{
			get
			{
				if(r_FRGBA_DXT1_UNorm == null)
				{
					r_FRGBA_DXT1_UNorm = new(Type, "RGBA_DXT1_UNorm");
				}
				return r_FRGBA_DXT1_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT3_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_DXT3_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_DXT3_SRGB
		{
			get
			{
				if(r_FRGBA_DXT3_SRGB == null)
				{
					r_FRGBA_DXT3_SRGB = new(Type, "RGBA_DXT3_SRGB");
				}
				return r_FRGBA_DXT3_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT3_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_DXT3_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_DXT3_UNorm
		{
			get
			{
				if(r_FRGBA_DXT3_UNorm == null)
				{
					r_FRGBA_DXT3_UNorm = new(Type, "RGBA_DXT3_UNorm");
				}
				return r_FRGBA_DXT3_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT5_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_DXT5_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_DXT5_SRGB
		{
			get
			{
				if(r_FRGBA_DXT5_SRGB == null)
				{
					r_FRGBA_DXT5_SRGB = new(Type, "RGBA_DXT5_SRGB");
				}
				return r_FRGBA_DXT5_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT5_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_DXT5_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_DXT5_UNorm
		{
			get
			{
				if(r_FRGBA_DXT5_UNorm == null)
				{
					r_FRGBA_DXT5_UNorm = new(Type, "RGBA_DXT5_UNorm");
				}
				return r_FRGBA_DXT5_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R_BC4_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR_BC4_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR_BC4_UNorm
		{
			get
			{
				if(r_FR_BC4_UNorm == null)
				{
					r_FR_BC4_UNorm = new(Type, "R_BC4_UNorm");
				}
				return r_FR_BC4_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R_BC4_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR_BC4_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR_BC4_SNorm
		{
			get
			{
				if(r_FR_BC4_SNorm == null)
				{
					r_FR_BC4_SNorm = new(Type, "R_BC4_SNorm");
				}
				return r_FR_BC4_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RG_BC5_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRG_BC5_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRG_BC5_UNorm
		{
			get
			{
				if(r_FRG_BC5_UNorm == null)
				{
					r_FRG_BC5_UNorm = new(Type, "RG_BC5_UNorm");
				}
				return r_FRG_BC5_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RG_BC5_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRG_BC5_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRG_BC5_SNorm
		{
			get
			{
				if(r_FRG_BC5_SNorm == null)
				{
					r_FRG_BC5_SNorm = new(Type, "RG_BC5_SNorm");
				}
				return r_FRG_BC5_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_BC6H_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_BC6H_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_BC6H_UFloat
		{
			get
			{
				if(r_FRGB_BC6H_UFloat == null)
				{
					r_FRGB_BC6H_UFloat = new(Type, "RGB_BC6H_UFloat");
				}
				return r_FRGB_BC6H_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_BC6H_SFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_BC6H_SFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_BC6H_SFloat
		{
			get
			{
				if(r_FRGB_BC6H_SFloat == null)
				{
					r_FRGB_BC6H_SFloat = new(Type, "RGB_BC6H_SFloat");
				}
				return r_FRGB_BC6H_SFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_BC7_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_BC7_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_BC7_SRGB
		{
			get
			{
				if(r_FRGBA_BC7_SRGB == null)
				{
					r_FRGBA_BC7_SRGB = new(Type, "RGBA_BC7_SRGB");
				}
				return r_FRGBA_BC7_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_BC7_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_BC7_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_BC7_UNorm
		{
			get
			{
				if(r_FRGBA_BC7_UNorm == null)
				{
					r_FRGBA_BC7_UNorm = new(Type, "RGBA_BC7_UNorm");
				}
				return r_FRGBA_BC7_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_2Bpp_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_PVRTC_2Bpp_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_PVRTC_2Bpp_SRGB
		{
			get
			{
				if(r_FRGB_PVRTC_2Bpp_SRGB == null)
				{
					r_FRGB_PVRTC_2Bpp_SRGB = new(Type, "RGB_PVRTC_2Bpp_SRGB");
				}
				return r_FRGB_PVRTC_2Bpp_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_2Bpp_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_PVRTC_2Bpp_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_PVRTC_2Bpp_UNorm
		{
			get
			{
				if(r_FRGB_PVRTC_2Bpp_UNorm == null)
				{
					r_FRGB_PVRTC_2Bpp_UNorm = new(Type, "RGB_PVRTC_2Bpp_UNorm");
				}
				return r_FRGB_PVRTC_2Bpp_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_4Bpp_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_PVRTC_4Bpp_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_PVRTC_4Bpp_SRGB
		{
			get
			{
				if(r_FRGB_PVRTC_4Bpp_SRGB == null)
				{
					r_FRGB_PVRTC_4Bpp_SRGB = new(Type, "RGB_PVRTC_4Bpp_SRGB");
				}
				return r_FRGB_PVRTC_4Bpp_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_4Bpp_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_PVRTC_4Bpp_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_PVRTC_4Bpp_UNorm
		{
			get
			{
				if(r_FRGB_PVRTC_4Bpp_UNorm == null)
				{
					r_FRGB_PVRTC_4Bpp_UNorm = new(Type, "RGB_PVRTC_4Bpp_UNorm");
				}
				return r_FRGB_PVRTC_4Bpp_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_2Bpp_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_PVRTC_2Bpp_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_PVRTC_2Bpp_SRGB
		{
			get
			{
				if(r_FRGBA_PVRTC_2Bpp_SRGB == null)
				{
					r_FRGBA_PVRTC_2Bpp_SRGB = new(Type, "RGBA_PVRTC_2Bpp_SRGB");
				}
				return r_FRGBA_PVRTC_2Bpp_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_2Bpp_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_PVRTC_2Bpp_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_PVRTC_2Bpp_UNorm
		{
			get
			{
				if(r_FRGBA_PVRTC_2Bpp_UNorm == null)
				{
					r_FRGBA_PVRTC_2Bpp_UNorm = new(Type, "RGBA_PVRTC_2Bpp_UNorm");
				}
				return r_FRGBA_PVRTC_2Bpp_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_4Bpp_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_PVRTC_4Bpp_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_PVRTC_4Bpp_SRGB
		{
			get
			{
				if(r_FRGBA_PVRTC_4Bpp_SRGB == null)
				{
					r_FRGBA_PVRTC_4Bpp_SRGB = new(Type, "RGBA_PVRTC_4Bpp_SRGB");
				}
				return r_FRGBA_PVRTC_4Bpp_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_4Bpp_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_PVRTC_4Bpp_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_PVRTC_4Bpp_UNorm
		{
			get
			{
				if(r_FRGBA_PVRTC_4Bpp_UNorm == null)
				{
					r_FRGBA_PVRTC_4Bpp_UNorm = new(Type, "RGBA_PVRTC_4Bpp_UNorm");
				}
				return r_FRGBA_PVRTC_4Bpp_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_ETC_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_ETC_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_ETC_UNorm
		{
			get
			{
				if(r_FRGB_ETC_UNorm == null)
				{
					r_FRGB_ETC_UNorm = new(Type, "RGB_ETC_UNorm");
				}
				return r_FRGB_ETC_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_ETC2_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_ETC2_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_ETC2_SRGB
		{
			get
			{
				if(r_FRGB_ETC2_SRGB == null)
				{
					r_FRGB_ETC2_SRGB = new(Type, "RGB_ETC2_SRGB");
				}
				return r_FRGB_ETC2_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_ETC2_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_ETC2_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_ETC2_UNorm
		{
			get
			{
				if(r_FRGB_ETC2_UNorm == null)
				{
					r_FRGB_ETC2_UNorm = new(Type, "RGB_ETC2_UNorm");
				}
				return r_FRGB_ETC2_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_A1_ETC2_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_A1_ETC2_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_A1_ETC2_SRGB
		{
			get
			{
				if(r_FRGB_A1_ETC2_SRGB == null)
				{
					r_FRGB_A1_ETC2_SRGB = new(Type, "RGB_A1_ETC2_SRGB");
				}
				return r_FRGB_A1_ETC2_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGB_A1_ETC2_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGB_A1_ETC2_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGB_A1_ETC2_UNorm
		{
			get
			{
				if(r_FRGB_A1_ETC2_UNorm == null)
				{
					r_FRGB_A1_ETC2_UNorm = new(Type, "RGB_A1_ETC2_UNorm");
				}
				return r_FRGB_A1_ETC2_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ETC2_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ETC2_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ETC2_SRGB
		{
			get
			{
				if(r_FRGBA_ETC2_SRGB == null)
				{
					r_FRGBA_ETC2_SRGB = new(Type, "RGBA_ETC2_SRGB");
				}
				return r_FRGBA_ETC2_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ETC2_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ETC2_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ETC2_UNorm
		{
			get
			{
				if(r_FRGBA_ETC2_UNorm == null)
				{
					r_FRGBA_ETC2_UNorm = new(Type, "RGBA_ETC2_UNorm");
				}
				return r_FRGBA_ETC2_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R_EAC_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR_EAC_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR_EAC_UNorm
		{
			get
			{
				if(r_FR_EAC_UNorm == null)
				{
					r_FR_EAC_UNorm = new(Type, "R_EAC_UNorm");
				}
				return r_FR_EAC_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat R_EAC_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FR_EAC_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFR_EAC_SNorm
		{
			get
			{
				if(r_FR_EAC_SNorm == null)
				{
					r_FR_EAC_SNorm = new(Type, "R_EAC_SNorm");
				}
				return r_FR_EAC_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RG_EAC_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRG_EAC_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRG_EAC_UNorm
		{
			get
			{
				if(r_FRG_EAC_UNorm == null)
				{
					r_FRG_EAC_UNorm = new(Type, "RG_EAC_UNorm");
				}
				return r_FRG_EAC_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RG_EAC_SNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRG_EAC_SNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRG_EAC_SNorm
		{
			get
			{
				if(r_FRG_EAC_SNorm == null)
				{
					r_FRG_EAC_SNorm = new(Type, "RG_EAC_SNorm");
				}
				return r_FRG_EAC_SNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC4X4_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC4X4_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC4X4_SRGB
		{
			get
			{
				if(r_FRGBA_ASTC4X4_SRGB == null)
				{
					r_FRGBA_ASTC4X4_SRGB = new(Type, "RGBA_ASTC4X4_SRGB");
				}
				return r_FRGBA_ASTC4X4_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC4X4_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC4X4_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC4X4_UNorm
		{
			get
			{
				if(r_FRGBA_ASTC4X4_UNorm == null)
				{
					r_FRGBA_ASTC4X4_UNorm = new(Type, "RGBA_ASTC4X4_UNorm");
				}
				return r_FRGBA_ASTC4X4_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC5X5_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC5X5_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC5X5_SRGB
		{
			get
			{
				if(r_FRGBA_ASTC5X5_SRGB == null)
				{
					r_FRGBA_ASTC5X5_SRGB = new(Type, "RGBA_ASTC5X5_SRGB");
				}
				return r_FRGBA_ASTC5X5_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC5X5_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC5X5_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC5X5_UNorm
		{
			get
			{
				if(r_FRGBA_ASTC5X5_UNorm == null)
				{
					r_FRGBA_ASTC5X5_UNorm = new(Type, "RGBA_ASTC5X5_UNorm");
				}
				return r_FRGBA_ASTC5X5_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC6X6_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC6X6_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC6X6_SRGB
		{
			get
			{
				if(r_FRGBA_ASTC6X6_SRGB == null)
				{
					r_FRGBA_ASTC6X6_SRGB = new(Type, "RGBA_ASTC6X6_SRGB");
				}
				return r_FRGBA_ASTC6X6_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC6X6_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC6X6_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC6X6_UNorm
		{
			get
			{
				if(r_FRGBA_ASTC6X6_UNorm == null)
				{
					r_FRGBA_ASTC6X6_UNorm = new(Type, "RGBA_ASTC6X6_UNorm");
				}
				return r_FRGBA_ASTC6X6_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC8X8_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC8X8_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC8X8_SRGB
		{
			get
			{
				if(r_FRGBA_ASTC8X8_SRGB == null)
				{
					r_FRGBA_ASTC8X8_SRGB = new(Type, "RGBA_ASTC8X8_SRGB");
				}
				return r_FRGBA_ASTC8X8_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC8X8_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC8X8_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC8X8_UNorm
		{
			get
			{
				if(r_FRGBA_ASTC8X8_UNorm == null)
				{
					r_FRGBA_ASTC8X8_UNorm = new(Type, "RGBA_ASTC8X8_UNorm");
				}
				return r_FRGBA_ASTC8X8_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC10X10_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC10X10_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC10X10_SRGB
		{
			get
			{
				if(r_FRGBA_ASTC10X10_SRGB == null)
				{
					r_FRGBA_ASTC10X10_SRGB = new(Type, "RGBA_ASTC10X10_SRGB");
				}
				return r_FRGBA_ASTC10X10_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC10X10_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC10X10_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC10X10_UNorm
		{
			get
			{
				if(r_FRGBA_ASTC10X10_UNorm == null)
				{
					r_FRGBA_ASTC10X10_UNorm = new(Type, "RGBA_ASTC10X10_UNorm");
				}
				return r_FRGBA_ASTC10X10_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC12X12_SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC12X12_SRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC12X12_SRGB
		{
			get
			{
				if(r_FRGBA_ASTC12X12_SRGB == null)
				{
					r_FRGBA_ASTC12X12_SRGB = new(Type, "RGBA_ASTC12X12_SRGB");
				}
				return r_FRGBA_ASTC12X12_SRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC12X12_UNorm
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC12X12_UNorm;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC12X12_UNorm
		{
			get
			{
				if(r_FRGBA_ASTC12X12_UNorm == null)
				{
					r_FRGBA_ASTC12X12_UNorm = new(Type, "RGBA_ASTC12X12_UNorm");
				}
				return r_FRGBA_ASTC12X12_UNorm;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat YUV2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FYUV2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFYUV2
		{
			get
			{
				if(r_FYUV2 == null)
				{
					r_FYUV2 = new(Type, "YUV2");
				}
				return r_FYUV2;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat DepthAuto
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FDepthAuto;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFDepthAuto
		{
			get
			{
				if(r_FDepthAuto == null)
				{
					r_FDepthAuto = new(Type, "DepthAuto");
				}
				return r_FDepthAuto;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat ShadowAuto
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FShadowAuto;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFShadowAuto
		{
			get
			{
				if(r_FShadowAuto == null)
				{
					r_FShadowAuto = new(Type, "ShadowAuto");
				}
				return r_FShadowAuto;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat VideoAuto
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FVideoAuto;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFVideoAuto
		{
			get
			{
				if(r_FVideoAuto == null)
				{
					r_FVideoAuto = new(Type, "VideoAuto");
				}
				return r_FVideoAuto;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC4X4_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC4X4_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC4X4_UFloat
		{
			get
			{
				if(r_FRGBA_ASTC4X4_UFloat == null)
				{
					r_FRGBA_ASTC4X4_UFloat = new(Type, "RGBA_ASTC4X4_UFloat");
				}
				return r_FRGBA_ASTC4X4_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC5X5_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC5X5_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC5X5_UFloat
		{
			get
			{
				if(r_FRGBA_ASTC5X5_UFloat == null)
				{
					r_FRGBA_ASTC5X5_UFloat = new(Type, "RGBA_ASTC5X5_UFloat");
				}
				return r_FRGBA_ASTC5X5_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC6X6_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC6X6_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC6X6_UFloat
		{
			get
			{
				if(r_FRGBA_ASTC6X6_UFloat == null)
				{
					r_FRGBA_ASTC6X6_UFloat = new(Type, "RGBA_ASTC6X6_UFloat");
				}
				return r_FRGBA_ASTC6X6_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC8X8_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC8X8_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC8X8_UFloat
		{
			get
			{
				if(r_FRGBA_ASTC8X8_UFloat == null)
				{
					r_FRGBA_ASTC8X8_UFloat = new(Type, "RGBA_ASTC8X8_UFloat");
				}
				return r_FRGBA_ASTC8X8_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC10X10_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC10X10_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC10X10_UFloat
		{
			get
			{
				if(r_FRGBA_ASTC10X10_UFloat == null)
				{
					r_FRGBA_ASTC10X10_UFloat = new(Type, "RGBA_ASTC10X10_UFloat");
				}
				return r_FRGBA_ASTC10X10_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC12X12_UFloat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FRGBA_ASTC12X12_UFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFRGBA_ASTC12X12_UFloat
		{
			get
			{
				if(r_FRGBA_ASTC12X12_UFloat == null)
				{
					r_FRGBA_ASTC12X12_UFloat = new(Type, "RGBA_ASTC12X12_UFloat");
				}
				return r_FRGBA_ASTC12X12_UFloat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat D16_UNorm_S8_UInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_FD16_UNorm_S8_UInt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RFD16_UNorm_S8_UInt
		{
			get
			{
				if(r_FD16_UNorm_S8_UInt == null)
				{
					r_FD16_UNorm_S8_UInt = new(Type, "D16_UNorm_S8_UInt");
				}
				return r_FD16_UNorm_S8_UInt;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
