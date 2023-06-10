
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.CameraEvent
	/// </summary>
    public partial class RCameraEvent : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.CameraEvent);
            }
        }

        public RCameraEvent() : base("UnityEngine.Rendering.CameraEvent")
        {
        }

        public RCameraEvent(System.Object instance) : base("UnityEngine.Rendering.CameraEvent")
		{
            SetInstance(instance);
		}

        public RCameraEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCameraEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.Rendering.CameraEvent BeforeDepthTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeDepthTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeDepthTexture
		{
			get
			{
				if(r_FBeforeDepthTexture == null)
				{
					r_FBeforeDepthTexture = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeDepthTexture");
				}
				return r_FBeforeDepthTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterDepthTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterDepthTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterDepthTexture
		{
			get
			{
				if(r_FAfterDepthTexture == null)
				{
					r_FAfterDepthTexture = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterDepthTexture");
				}
				return r_FAfterDepthTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeDepthNormalsTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeDepthNormalsTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeDepthNormalsTexture
		{
			get
			{
				if(r_FBeforeDepthNormalsTexture == null)
				{
					r_FBeforeDepthNormalsTexture = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeDepthNormalsTexture");
				}
				return r_FBeforeDepthNormalsTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterDepthNormalsTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterDepthNormalsTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterDepthNormalsTexture
		{
			get
			{
				if(r_FAfterDepthNormalsTexture == null)
				{
					r_FAfterDepthNormalsTexture = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterDepthNormalsTexture");
				}
				return r_FAfterDepthNormalsTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeGBuffer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeGBuffer;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeGBuffer
		{
			get
			{
				if(r_FBeforeGBuffer == null)
				{
					r_FBeforeGBuffer = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeGBuffer");
				}
				return r_FBeforeGBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterGBuffer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterGBuffer;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterGBuffer
		{
			get
			{
				if(r_FAfterGBuffer == null)
				{
					r_FAfterGBuffer = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterGBuffer");
				}
				return r_FAfterGBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeLighting
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeLighting;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeLighting
		{
			get
			{
				if(r_FBeforeLighting == null)
				{
					r_FBeforeLighting = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeLighting");
				}
				return r_FBeforeLighting;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterLighting
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterLighting;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterLighting
		{
			get
			{
				if(r_FAfterLighting == null)
				{
					r_FAfterLighting = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterLighting");
				}
				return r_FAfterLighting;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeFinalPass
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeFinalPass;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeFinalPass
		{
			get
			{
				if(r_FBeforeFinalPass == null)
				{
					r_FBeforeFinalPass = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeFinalPass");
				}
				return r_FBeforeFinalPass;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterFinalPass
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterFinalPass;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterFinalPass
		{
			get
			{
				if(r_FAfterFinalPass == null)
				{
					r_FAfterFinalPass = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterFinalPass");
				}
				return r_FAfterFinalPass;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeForwardOpaque
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeForwardOpaque;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeForwardOpaque
		{
			get
			{
				if(r_FBeforeForwardOpaque == null)
				{
					r_FBeforeForwardOpaque = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeForwardOpaque");
				}
				return r_FBeforeForwardOpaque;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterForwardOpaque
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterForwardOpaque;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterForwardOpaque
		{
			get
			{
				if(r_FAfterForwardOpaque == null)
				{
					r_FAfterForwardOpaque = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterForwardOpaque");
				}
				return r_FAfterForwardOpaque;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeImageEffectsOpaque
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeImageEffectsOpaque;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeImageEffectsOpaque
		{
			get
			{
				if(r_FBeforeImageEffectsOpaque == null)
				{
					r_FBeforeImageEffectsOpaque = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeImageEffectsOpaque");
				}
				return r_FBeforeImageEffectsOpaque;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterImageEffectsOpaque
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterImageEffectsOpaque;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterImageEffectsOpaque
		{
			get
			{
				if(r_FAfterImageEffectsOpaque == null)
				{
					r_FAfterImageEffectsOpaque = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterImageEffectsOpaque");
				}
				return r_FAfterImageEffectsOpaque;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeSkybox
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeSkybox;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeSkybox
		{
			get
			{
				if(r_FBeforeSkybox == null)
				{
					r_FBeforeSkybox = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeSkybox");
				}
				return r_FBeforeSkybox;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterSkybox
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterSkybox;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterSkybox
		{
			get
			{
				if(r_FAfterSkybox == null)
				{
					r_FAfterSkybox = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterSkybox");
				}
				return r_FAfterSkybox;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeForwardAlpha
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeForwardAlpha;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeForwardAlpha
		{
			get
			{
				if(r_FBeforeForwardAlpha == null)
				{
					r_FBeforeForwardAlpha = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeForwardAlpha");
				}
				return r_FBeforeForwardAlpha;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterForwardAlpha
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterForwardAlpha;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterForwardAlpha
		{
			get
			{
				if(r_FAfterForwardAlpha == null)
				{
					r_FAfterForwardAlpha = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterForwardAlpha");
				}
				return r_FAfterForwardAlpha;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeImageEffects
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeImageEffects;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeImageEffects
		{
			get
			{
				if(r_FBeforeImageEffects == null)
				{
					r_FBeforeImageEffects = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeImageEffects");
				}
				return r_FBeforeImageEffects;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterImageEffects
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterImageEffects;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterImageEffects
		{
			get
			{
				if(r_FAfterImageEffects == null)
				{
					r_FAfterImageEffects = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterImageEffects");
				}
				return r_FAfterImageEffects;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterEverything
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterEverything;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterEverything
		{
			get
			{
				if(r_FAfterEverything == null)
				{
					r_FAfterEverything = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterEverything");
				}
				return r_FAfterEverything;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeReflections
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeReflections;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeReflections
		{
			get
			{
				if(r_FBeforeReflections == null)
				{
					r_FBeforeReflections = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeReflections");
				}
				return r_FBeforeReflections;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterReflections
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterReflections;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterReflections
		{
			get
			{
				if(r_FAfterReflections == null)
				{
					r_FAfterReflections = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterReflections");
				}
				return r_FAfterReflections;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent BeforeHaloAndLensFlares
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FBeforeHaloAndLensFlares;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFBeforeHaloAndLensFlares
		{
			get
			{
				if(r_FBeforeHaloAndLensFlares == null)
				{
					r_FBeforeHaloAndLensFlares = new(typeof(UnityEngine.Rendering.CameraEvent), "BeforeHaloAndLensFlares");
				}
				return r_FBeforeHaloAndLensFlares;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CameraEvent AfterHaloAndLensFlares
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent r_FAfterHaloAndLensFlares;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCameraEvent RFAfterHaloAndLensFlares
		{
			get
			{
				if(r_FAfterHaloAndLensFlares == null)
				{
					r_FAfterHaloAndLensFlares = new(typeof(UnityEngine.Rendering.CameraEvent), "AfterHaloAndLensFlares");
				}
				return r_FAfterHaloAndLensFlares;
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
