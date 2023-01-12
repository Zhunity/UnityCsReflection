using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.FormatUsage
	/// </summary>
    public partial class RFormatUsage : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected RSystem.RInt32 r_Fvalue__;
		public virtual RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage Sample
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FSample;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFSample
		{
			get
			{
				if(r_FSample == null)
				{
					r_FSample = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "Sample");
					r_FSample.SetBelong(null);
				}
				return r_FSample;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage Linear
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FLinear;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFLinear
		{
			get
			{
				if(r_FLinear == null)
				{
					r_FLinear = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "Linear");
					r_FLinear.SetBelong(null);
				}
				return r_FLinear;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage Sparse
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FSparse;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFSparse
		{
			get
			{
				if(r_FSparse == null)
				{
					r_FSparse = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "Sparse");
					r_FSparse.SetBelong(null);
				}
				return r_FSparse;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage Render
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FRender;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFRender
		{
			get
			{
				if(r_FRender == null)
				{
					r_FRender = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "Render");
					r_FRender.SetBelong(null);
				}
				return r_FRender;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage Blend
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FBlend;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFBlend
		{
			get
			{
				if(r_FBlend == null)
				{
					r_FBlend = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "Blend");
					r_FBlend.SetBelong(null);
				}
				return r_FBlend;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage GetPixels
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FGetPixels;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFGetPixels
		{
			get
			{
				if(r_FGetPixels == null)
				{
					r_FGetPixels = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "GetPixels");
					r_FGetPixels.SetBelong(null);
				}
				return r_FGetPixels;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage SetPixels
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FSetPixels;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFSetPixels
		{
			get
			{
				if(r_FSetPixels == null)
				{
					r_FSetPixels = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "SetPixels");
					r_FSetPixels.SetBelong(null);
				}
				return r_FSetPixels;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage SetPixels32
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FSetPixels32;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFSetPixels32
		{
			get
			{
				if(r_FSetPixels32 == null)
				{
					r_FSetPixels32 = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "SetPixels32");
					r_FSetPixels32.SetBelong(null);
				}
				return r_FSetPixels32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage ReadPixels
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FReadPixels;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFReadPixels
		{
			get
			{
				if(r_FReadPixels == null)
				{
					r_FReadPixels = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "ReadPixels");
					r_FReadPixels.SetBelong(null);
				}
				return r_FReadPixels;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage LoadStore
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FLoadStore;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFLoadStore
		{
			get
			{
				if(r_FLoadStore == null)
				{
					r_FLoadStore = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "LoadStore");
					r_FLoadStore.SetBelong(null);
				}
				return r_FLoadStore;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage MSAA2x
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FMSAA2x;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFMSAA2x
		{
			get
			{
				if(r_FMSAA2x == null)
				{
					r_FMSAA2x = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "MSAA2x");
					r_FMSAA2x.SetBelong(null);
				}
				return r_FMSAA2x;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage MSAA4x
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FMSAA4x;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFMSAA4x
		{
			get
			{
				if(r_FMSAA4x == null)
				{
					r_FMSAA4x = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "MSAA4x");
					r_FMSAA4x.SetBelong(null);
				}
				return r_FMSAA4x;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage MSAA8x
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FMSAA8x;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFMSAA8x
		{
			get
			{
				if(r_FMSAA8x == null)
				{
					r_FMSAA8x = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "MSAA8x");
					r_FMSAA8x.SetBelong(null);
				}
				return r_FMSAA8x;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.FormatUsage StencilSampling
		/// </summary>
		protected static RUnityEngine.RExperimental.RRendering.RFormatUsage r_FStencilSampling;
		public static RUnityEngine.RExperimental.RRendering.RFormatUsage RFStencilSampling
		{
			get
			{
				if(r_FStencilSampling == null)
				{
					r_FStencilSampling = new(typeof(UnityEngine.Experimental.Rendering.FormatUsage), "StencilSampling");
					r_FStencilSampling.SetBelong(null);
				}
				return r_FStencilSampling;
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
					r_MGetValue.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
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
					r_MCompareTo_Object.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_IFormatProvider.SetBelong(this.instance);
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
					r_MHasFlag_Enum.SetBelong(this.instance);
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
					r_MGetTypeCode.SetBelong(this.instance);
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


        public RFormatUsage() : base("UnityEngine.Experimental.Rendering.FormatUsage")
        {
        }

        public RFormatUsage(System.Object instance) : base("UnityEngine.Experimental.Rendering.FormatUsage")
		{
            SetInstance(instance);
		}

        public RFormatUsage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFormatUsage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
