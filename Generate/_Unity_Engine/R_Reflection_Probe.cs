
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.ReflectionProbe
	/// </summary>
    public partial class RReflectionProbe : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.ReflectionProbe);
            }
        }

        public RReflectionProbe() : base("UnityEngine.ReflectionProbe")
        {
        }

        public RReflectionProbe(System.Object instance) : base("UnityEngine.ReflectionProbe")
		{
            SetInstance(instance);
		}

        public RReflectionProbe(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReflectionProbe(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`2[UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe+ReflectionProbeEvent] reflectionProbeChanged
		/// </summary>
		protected static REvent r_EreflectionProbeChanged;
		public static REvent REreflectionProbeChanged
		{
			get
			{
				if(r_EreflectionProbeChanged == null)
				{
					r_EreflectionProbeChanged = new(Type, "reflectionProbeChanged");
				}
				return r_EreflectionProbeChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Cubemap] defaultReflectionSet
		/// </summary>
		protected static REvent r_EdefaultReflectionSet;
		public static REvent REdefaultReflectionSet
		{
			get
			{
				if(r_EdefaultReflectionSet == null)
				{
					r_EdefaultReflectionSet = new(Type, "defaultReflectionSet");
				}
				return r_EdefaultReflectionSet;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Texture] defaultReflectionTexture
		/// </summary>
		protected static REvent r_EdefaultReflectionTexture;
		public static REvent REdefaultReflectionTexture
		{
			get
			{
				if(r_EdefaultReflectionTexture == null)
				{
					r_EdefaultReflectionTexture = new(Type, "defaultReflectionTexture");
				}
				return r_EdefaultReflectionTexture;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe+ReflectionProbeEvent] reflectionProbeChanged
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RReflectionProbe, Hvak.Editor.Refleaction.RUnityEngine.RReflectionProbe.RReflectionProbeEvent> r_FreflectionProbeChanged;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RReflectionProbe, Hvak.Editor.Refleaction.RUnityEngine.RReflectionProbe.RReflectionProbeEvent> RFreflectionProbeChanged
		{
			get
			{
				if(r_FreflectionProbeChanged == null)
				{
					r_FreflectionProbeChanged = new(Type, "reflectionProbeChanged");
				}
				return r_FreflectionProbeChanged;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Action`1[UnityEngine.Texture]] registeredDefaultReflectionSetActions
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture>> r_FregisteredDefaultReflectionSetActions;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture>> RFregisteredDefaultReflectionSetActions
		{
			get
			{
				if(r_FregisteredDefaultReflectionSetActions == null)
				{
					r_FregisteredDefaultReflectionSetActions = new(Type, "registeredDefaultReflectionSetActions");
				}
				return r_FregisteredDefaultReflectionSetActions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Action`1[UnityEngine.Texture]] registeredDefaultReflectionTextureActions
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture>> r_FregisteredDefaultReflectionTextureActions;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RTexture>> RFregisteredDefaultReflectionTextureActions
		{
			get
			{
				if(r_FregisteredDefaultReflectionTextureActions == null)
				{
					r_FregisteredDefaultReflectionTextureActions = new(Type, "registeredDefaultReflectionTextureActions");
				}
				return r_FregisteredDefaultReflectionTextureActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Psize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 center
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Pcenter;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPcenter
		{
			get
			{
				if(r_Pcenter == null)
				{
					r_Pcenter = new(this, "center", -1);
				}
				return r_Pcenter;
			}
		}

		/// <summary>
		/// Single nearClipPlane
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PnearClipPlane;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPnearClipPlane
		{
			get
			{
				if(r_PnearClipPlane == null)
				{
					r_PnearClipPlane = new(this, "nearClipPlane", -1);
				}
				return r_PnearClipPlane;
			}
		}

		/// <summary>
		/// Single farClipPlane
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfarClipPlane;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfarClipPlane
		{
			get
			{
				if(r_PfarClipPlane == null)
				{
					r_PfarClipPlane = new(this, "farClipPlane", -1);
				}
				return r_PfarClipPlane;
			}
		}

		/// <summary>
		/// Single intensity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pintensity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPintensity
		{
			get
			{
				if(r_Pintensity == null)
				{
					r_Pintensity = new(this, "intensity", -1);
				}
				return r_Pintensity;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBounds r_Pbounds;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBounds RPbounds
		{
			get
			{
				if(r_Pbounds == null)
				{
					r_Pbounds = new(this, "bounds", -1);
				}
				return r_Pbounds;
			}
		}

		/// <summary>
		/// Boolean hdr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Phdr;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhdr
		{
			get
			{
				if(r_Phdr == null)
				{
					r_Phdr = new(this, "hdr", -1);
				}
				return r_Phdr;
			}
		}

		/// <summary>
		/// Boolean renderDynamicObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PrenderDynamicObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPrenderDynamicObjects
		{
			get
			{
				if(r_PrenderDynamicObjects == null)
				{
					r_PrenderDynamicObjects = new(this, "renderDynamicObjects", -1);
				}
				return r_PrenderDynamicObjects;
			}
		}

		/// <summary>
		/// Single shadowDistance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PshadowDistance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPshadowDistance
		{
			get
			{
				if(r_PshadowDistance == null)
				{
					r_PshadowDistance = new(this, "shadowDistance", -1);
				}
				return r_PshadowDistance;
			}
		}

		/// <summary>
		/// Int32 resolution
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Presolution;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPresolution
		{
			get
			{
				if(r_Presolution == null)
				{
					r_Presolution = new(this, "resolution", -1);
				}
				return r_Presolution;
			}
		}

		/// <summary>
		/// Int32 cullingMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcullingMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcullingMask
		{
			get
			{
				if(r_PcullingMask == null)
				{
					r_PcullingMask = new(this, "cullingMask", -1);
				}
				return r_PcullingMask;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeClearFlags r_PclearFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeClearFlags RPclearFlags
		{
			get
			{
				if(r_PclearFlags == null)
				{
					r_PclearFlags = new(this, "clearFlags", -1);
				}
				return r_PclearFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PbackgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPbackgroundColor
		{
			get
			{
				if(r_PbackgroundColor == null)
				{
					r_PbackgroundColor = new(this, "backgroundColor", -1);
				}
				return r_PbackgroundColor;
			}
		}

		/// <summary>
		/// Single blendDistance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PblendDistance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPblendDistance
		{
			get
			{
				if(r_PblendDistance == null)
				{
					r_PblendDistance = new(this, "blendDistance", -1);
				}
				return r_PblendDistance;
			}
		}

		/// <summary>
		/// Boolean boxProjection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PboxProjection;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPboxProjection
		{
			get
			{
				if(r_PboxProjection == null)
				{
					r_PboxProjection = new(this, "boxProjection", -1);
				}
				return r_PboxProjection;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeMode mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeMode r_Pmode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeMode RPmode
		{
			get
			{
				if(r_Pmode == null)
				{
					r_Pmode = new(this, "mode", -1);
				}
				return r_Pmode;
			}
		}

		/// <summary>
		/// Int32 importance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pimportance;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPimportance
		{
			get
			{
				if(r_Pimportance == null)
				{
					r_Pimportance = new(this, "importance", -1);
				}
				return r_Pimportance;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeRefreshMode r_PrefreshMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeRefreshMode RPrefreshMode
		{
			get
			{
				if(r_PrefreshMode == null)
				{
					r_PrefreshMode = new(this, "refreshMode", -1);
				}
				return r_PrefreshMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeTimeSlicingMode r_PtimeSlicingMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RReflectionProbeTimeSlicingMode RPtimeSlicingMode
		{
			get
			{
				if(r_PtimeSlicingMode == null)
				{
					r_PtimeSlicingMode = new(this, "timeSlicingMode", -1);
				}
				return r_PtimeSlicingMode;
			}
		}

		/// <summary>
		/// UnityEngine.Texture bakedTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_PbakedTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RPbakedTexture
		{
			get
			{
				if(r_PbakedTexture == null)
				{
					r_PbakedTexture = new(this, "bakedTexture", -1);
				}
				return r_PbakedTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture customBakedTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_PcustomBakedTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RPcustomBakedTexture
		{
			get
			{
				if(r_PcustomBakedTexture == null)
				{
					r_PcustomBakedTexture = new(this, "customBakedTexture", -1);
				}
				return r_PcustomBakedTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture realtimeTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_PrealtimeTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPrealtimeTexture
		{
			get
			{
				if(r_PrealtimeTexture == null)
				{
					r_PrealtimeTexture = new(this, "realtimeTexture", -1);
				}
				return r_PrealtimeTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_Ptexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RPtexture
		{
			get
			{
				if(r_Ptexture == null)
				{
					r_Ptexture = new(this, "texture", -1);
				}
				return r_Ptexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 textureHDRDecodeValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PtextureHDRDecodeValues;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPtextureHDRDecodeValues
		{
			get
			{
				if(r_PtextureHDRDecodeValues == null)
				{
					r_PtextureHDRDecodeValues = new(this, "textureHDRDecodeValues", -1);
				}
				return r_PtextureHDRDecodeValues;
			}
		}

		/// <summary>
		/// Int32 minBakedCubemapResolution
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PminBakedCubemapResolution;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPminBakedCubemapResolution
		{
			get
			{
				if(r_PminBakedCubemapResolution == null)
				{
					r_PminBakedCubemapResolution = new(Type, "minBakedCubemapResolution", -1);
				}
				return r_PminBakedCubemapResolution;
			}
		}

		/// <summary>
		/// Int32 maxBakedCubemapResolution
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaxBakedCubemapResolution;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPmaxBakedCubemapResolution
		{
			get
			{
				if(r_PmaxBakedCubemapResolution == null)
				{
					r_PmaxBakedCubemapResolution = new(Type, "maxBakedCubemapResolution", -1);
				}
				return r_PmaxBakedCubemapResolution;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 defaultTextureHDRDecodeValues
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PdefaultTextureHDRDecodeValues;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPdefaultTextureHDRDecodeValues
		{
			get
			{
				if(r_PdefaultTextureHDRDecodeValues == null)
				{
					r_PdefaultTextureHDRDecodeValues = new(Type, "defaultTextureHDRDecodeValues", -1);
				}
				return r_PdefaultTextureHDRDecodeValues;
			}
		}

		/// <summary>
		/// UnityEngine.Texture defaultTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture r_PdefaultTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture RPdefaultTexture
		{
			get
			{
				if(r_PdefaultTexture == null)
				{
					r_PdefaultTexture = new(Type, "defaultTexture", -1);
				}
				return r_PdefaultTexture;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(this, "enabled", -1);
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Boolean isActiveAndEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisActiveAndEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisActiveAndEnabled
		{
			get
			{
				if(r_PisActiveAndEnabled == null)
				{
					r_PisActiveAndEnabled = new(this, "isActiveAndEnabled", -1);
				}
				return r_PisActiveAndEnabled;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTransform r_Ptransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGameObject r_PgameObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGameObject RPgameObject
		{
			get
			{
				if(r_PgameObject == null)
				{
					r_PgameObject = new(this, "gameObject", -1);
				}
				return r_PgameObject;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtag
		{
			get
			{
				if(r_Ptag == null)
				{
					r_Ptag = new(this, "tag", -1);
				}
				return r_Ptag;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Prigidbody;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPrigidbody
		{
			get
			{
				if(r_Prigidbody == null)
				{
					r_Prigidbody = new(this, "rigidbody", -1);
				}
				return r_Prigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Prigidbody2D;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPrigidbody2D
		{
			get
			{
				if(r_Prigidbody2D == null)
				{
					r_Prigidbody2D = new(this, "rigidbody2D", -1);
				}
				return r_Prigidbody2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component camera
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Pcamera;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPcamera
		{
			get
			{
				if(r_Pcamera == null)
				{
					r_Pcamera = new(this, "camera", -1);
				}
				return r_Pcamera;
			}
		}

		/// <summary>
		/// UnityEngine.Component light
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Plight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPlight
		{
			get
			{
				if(r_Plight == null)
				{
					r_Plight = new(this, "light", -1);
				}
				return r_Plight;
			}
		}

		/// <summary>
		/// UnityEngine.Component animation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Panimation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPanimation
		{
			get
			{
				if(r_Panimation == null)
				{
					r_Panimation = new(this, "animation", -1);
				}
				return r_Panimation;
			}
		}

		/// <summary>
		/// UnityEngine.Component constantForce
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PconstantForce;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPconstantForce
		{
			get
			{
				if(r_PconstantForce == null)
				{
					r_PconstantForce = new(this, "constantForce", -1);
				}
				return r_PconstantForce;
			}
		}

		/// <summary>
		/// UnityEngine.Component renderer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Prenderer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPrenderer
		{
			get
			{
				if(r_Prenderer == null)
				{
					r_Prenderer = new(this, "renderer", -1);
				}
				return r_Prenderer;
			}
		}

		/// <summary>
		/// UnityEngine.Component audio
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Paudio;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPaudio
		{
			get
			{
				if(r_Paudio == null)
				{
					r_Paudio = new(this, "audio", -1);
				}
				return r_Paudio;
			}
		}

		/// <summary>
		/// UnityEngine.Component networkView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PnetworkView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPnetworkView
		{
			get
			{
				if(r_PnetworkView == null)
				{
					r_PnetworkView = new(this, "networkView", -1);
				}
				return r_PnetworkView;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Pcollider;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPcollider
		{
			get
			{
				if(r_Pcollider == null)
				{
					r_Pcollider = new(this, "collider", -1);
				}
				return r_Pcollider;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_Pcollider2D;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPcollider2D
		{
			get
			{
				if(r_Pcollider2D == null)
				{
					r_Pcollider2D = new(this, "collider2D", -1);
				}
				return r_Pcollider2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component hingeJoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PhingeJoint;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPhingeJoint
		{
			get
			{
				if(r_PhingeJoint == null)
				{
					r_PhingeJoint = new(this, "hingeJoint", -1);
				}
				return r_PhingeJoint;
			}
		}

		/// <summary>
		/// UnityEngine.Component particleSystem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RComponent r_PparticleSystem;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RComponent RPparticleSystem
		{
			get
			{
				if(r_PparticleSystem == null)
				{
					r_PparticleSystem = new(this, "particleSystem", -1);
				}
				return r_PparticleSystem;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
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
		/// Int32 RenderProbe()
		/// </summary>
		protected RMethod r_MRenderProbe;
		public virtual RMethod RMRenderProbe
		{
			get
			{
				if(r_MRenderProbe == null)
				{
					r_MRenderProbe = new(this, "RenderProbe", 0);
				}
				return r_MRenderProbe;
			}
		}

		/// <summary>
		/// Int32 RenderProbe(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MRenderProbe_RenderTexture;
		public virtual RMethod RMRenderProbe_RenderTexture
		{
			get
			{
				if(r_MRenderProbe_RenderTexture == null)
				{
					r_MRenderProbe_RenderTexture = new(this, "RenderProbe", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MRenderProbe_RenderTexture;
			}
		}

		/// <summary>
		/// Boolean IsFinishedRendering(Int32)
		/// </summary>
		protected RMethod r_MIsFinishedRendering_Int32;
		public virtual RMethod RMIsFinishedRendering_Int32
		{
			get
			{
				if(r_MIsFinishedRendering_Int32 == null)
				{
					r_MIsFinishedRendering_Int32 = new(this, "IsFinishedRendering", 0, typeof(System.Int32));
				}
				return r_MIsFinishedRendering_Int32;
			}
		}

		/// <summary>
		/// Int32 ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode, UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture;
		public virtual RMethod RMScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture
		{
			get
			{
				if(r_MScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture == null)
				{
					r_MScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture = new(this, "ScheduleRender", 0, typeof(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode), typeof(UnityEngine.RenderTexture));
				}
				return r_MScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture;
			}
		}

		/// <summary>
		/// Boolean BlendCubemap(UnityEngine.Texture, UnityEngine.Texture, Single, UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_MBlendCubemap_Texture_Texture_Single_RenderTexture;
		public static RMethod RMBlendCubemap_Texture_Texture_Single_RenderTexture
		{
			get
			{
				if(r_MBlendCubemap_Texture_Texture_Single_RenderTexture == null)
				{
					r_MBlendCubemap_Texture_Texture_Single_RenderTexture = new(Type, "BlendCubemap", 0, typeof(UnityEngine.Texture), typeof(UnityEngine.Texture), typeof(System.Single), typeof(UnityEngine.RenderTexture));
				}
				return r_MBlendCubemap_Texture_Texture_Single_RenderTexture;
			}
		}

		/// <summary>
		/// Void UpdateCachedState()
		/// </summary>
		protected static RMethod r_MUpdateCachedState;
		public static RMethod RMUpdateCachedState
		{
			get
			{
				if(r_MUpdateCachedState == null)
				{
					r_MUpdateCachedState = new(Type, "UpdateCachedState", 0);
				}
				return r_MUpdateCachedState;
			}
		}

		/// <summary>
		/// Void CallReflectionProbeEvent(UnityEngine.ReflectionProbe, ReflectionProbeEvent)
		/// </summary>
		protected static RMethod r_MCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent;
		public static RMethod RMCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent
		{
			get
			{
				if(r_MCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent == null)
				{
					r_MCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent = new(Type, "CallReflectionProbeEvent", 0, typeof(UnityEngine.ReflectionProbe),  ReflectionUtils.GetType("UnityEngine.ReflectionProbe+ReflectionProbeEvent"));
				}
				return r_MCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent;
			}
		}

		/// <summary>
		/// Void CallSetDefaultReflection(UnityEngine.Texture)
		/// </summary>
		protected static RMethod r_MCallSetDefaultReflection_Texture;
		public static RMethod RMCallSetDefaultReflection_Texture
		{
			get
			{
				if(r_MCallSetDefaultReflection_Texture == null)
				{
					r_MCallSetDefaultReflection_Texture = new(Type, "CallSetDefaultReflection", 0, typeof(UnityEngine.Texture));
				}
				return r_MCallSetDefaultReflection_Texture;
			}
		}

		/// <summary>
		/// Void get_size_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_size_Injected_Out_Vector3;
		public virtual RMethod RMget_size_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_size_Injected_Out_Vector3 == null)
				{
					r_Mget_size_Injected_Out_Vector3 = new(this, "get_size_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_size_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_size_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mset_size_Injected_Ref_Vector3;
		public virtual RMethod RMset_size_Injected_Ref_Vector3
		{
			get
			{
				if(r_Mset_size_Injected_Ref_Vector3 == null)
				{
					r_Mset_size_Injected_Ref_Vector3 = new(this, "set_size_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mset_size_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_center_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mget_center_Injected_Out_Vector3;
		public virtual RMethod RMget_center_Injected_Out_Vector3
		{
			get
			{
				if(r_Mget_center_Injected_Out_Vector3 == null)
				{
					r_Mget_center_Injected_Out_Vector3 = new(this, "get_center_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mget_center_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_center_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Mset_center_Injected_Ref_Vector3;
		public virtual RMethod RMset_center_Injected_Ref_Vector3
		{
			get
			{
				if(r_Mset_center_Injected_Ref_Vector3 == null)
				{
					r_Mset_center_Injected_Ref_Vector3 = new(this, "set_center_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
				}
				return r_Mset_center_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mget_bounds_Injected_Out_Bounds;
		public virtual RMethod RMget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Mget_bounds_Injected_Out_Bounds == null)
				{
					r_Mget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
				}
				return r_Mget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void get_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mget_backgroundColor_Injected_Out_Color;
		public virtual RMethod RMget_backgroundColor_Injected_Out_Color
		{
			get
			{
				if(r_Mget_backgroundColor_Injected_Out_Color == null)
				{
					r_Mget_backgroundColor_Injected_Out_Color = new(this, "get_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_Mget_backgroundColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_backgroundColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mset_backgroundColor_Injected_Ref_Color;
		public virtual RMethod RMset_backgroundColor_Injected_Ref_Color
		{
			get
			{
				if(r_Mset_backgroundColor_Injected_Ref_Color == null)
				{
					r_Mset_backgroundColor_Injected_Ref_Color = new(this, "set_backgroundColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_Mset_backgroundColor_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void get_textureHDRDecodeValues_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Mget_textureHDRDecodeValues_Injected_Out_Vector4;
		public virtual RMethod RMget_textureHDRDecodeValues_Injected_Out_Vector4
		{
			get
			{
				if(r_Mget_textureHDRDecodeValues_Injected_Out_Vector4 == null)
				{
					r_Mget_textureHDRDecodeValues_Injected_Out_Vector4 = new(this, "get_textureHDRDecodeValues_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
				}
				return r_Mget_textureHDRDecodeValues_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void get_defaultTextureHDRDecodeValues_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected static RMethod r_Mget_defaultTextureHDRDecodeValues_Injected_Out_Vector4;
		public static RMethod RMget_defaultTextureHDRDecodeValues_Injected_Out_Vector4
		{
			get
			{
				if(r_Mget_defaultTextureHDRDecodeValues_Injected_Out_Vector4 == null)
				{
					r_Mget_defaultTextureHDRDecodeValues_Injected_Out_Vector4 = new(Type, "get_defaultTextureHDRDecodeValues_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
				}
				return r_Mget_defaultTextureHDRDecodeValues_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_MGetComponent_Type;
		public virtual RMethod RMGetComponent_Type
		{
			get
			{
				if(r_MGetComponent_Type == null)
				{
					r_MGetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
				}
				return r_MGetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_MGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RMGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_MGetComponentFastPath_Type_IntPtr == null)
				{
					r_MGetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
				}
				return r_MGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_MGetComponent_GT;
		public virtual RMethod RMGetComponent_GT
		{
			get
			{
				if(r_MGetComponent_GT == null)
				{
					r_MGetComponent_GT = new(this, "GetComponent", 1);
				}
				return r_MGetComponent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_MTryGetComponent_Type_Out_Component;
		public virtual RMethod RMTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_MTryGetComponent_Type_Out_Component == null)
				{
					r_MTryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
				}
				return r_MTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_MTryGetComponent_GT_Out_T;
		public virtual RMethod RMTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_MTryGetComponent_GT_Out_T == null)
				{
					r_MTryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MTryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_MGetComponent_String;
		public virtual RMethod RMGetComponent_String
		{
			get
			{
				if(r_MGetComponent_String == null)
				{
					r_MGetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
				}
				return r_MGetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInChildren_Type_Boolean;
		public virtual RMethod RMGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_MGetComponentInChildren_Type_Boolean == null)
				{
					r_MGetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentInChildren_Type;
		public virtual RMethod RMGetComponentInChildren_Type
		{
			get
			{
				if(r_MGetComponentInChildren_Type == null)
				{
					r_MGetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
				}
				return r_MGetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInChildren_GT_Boolean;
		public virtual RMethod RMGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_MGetComponentInChildren_GT_Boolean == null)
				{
					r_MGetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
				}
				return r_MGetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_MGetComponentInChildren_GT;
		public virtual RMethod RMGetComponentInChildren_GT
		{
			get
			{
				if(r_MGetComponentInChildren_GT == null)
				{
					r_MGetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
				}
				return r_MGetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_Type_Boolean;
		public virtual RMethod RMGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_MGetComponentsInChildren_Type_Boolean == null)
				{
					r_MGetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_Type;
		public virtual RMethod RMGetComponentsInChildren_Type
		{
			get
			{
				if(r_MGetComponentsInChildren_Type == null)
				{
					r_MGetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
				}
				return r_MGetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT_Boolean;
		public virtual RMethod RMGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_MGetComponentsInChildren_GT_Boolean == null)
				{
					r_MGetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
				}
				return r_MGetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RMGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT;
		public virtual RMethod RMGetComponentsInChildren_GT
		{
			get
			{
				if(r_MGetComponentsInChildren_GT == null)
				{
					r_MGetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
				}
				return r_MGetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RMGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_MGetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_MGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInParent_Type_Boolean;
		public virtual RMethod RMGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_MGetComponentInParent_Type_Boolean == null)
				{
					r_MGetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentInParent_Type;
		public virtual RMethod RMGetComponentInParent_Type
		{
			get
			{
				if(r_MGetComponentInParent_Type == null)
				{
					r_MGetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
				}
				return r_MGetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentInParent_GT_Boolean;
		public virtual RMethod RMGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_MGetComponentInParent_GT_Boolean == null)
				{
					r_MGetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
				}
				return r_MGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_MGetComponentInParent_GT;
		public virtual RMethod RMGetComponentInParent_GT
		{
			get
			{
				if(r_MGetComponentInParent_GT == null)
				{
					r_MGetComponentInParent_GT = new(this, "GetComponentInParent", 1);
				}
				return r_MGetComponentInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInParent_Type_Boolean;
		public virtual RMethod RMGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_MGetComponentsInParent_Type_Boolean == null)
				{
					r_MGetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MGetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_MGetComponentsInParent_Type;
		public virtual RMethod RMGetComponentsInParent_Type
		{
			get
			{
				if(r_MGetComponentsInParent_Type == null)
				{
					r_MGetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
				}
				return r_MGetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_MGetComponentsInParent_GT_Boolean;
		public virtual RMethod RMGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_MGetComponentsInParent_GT_Boolean == null)
				{
					r_MGetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
				}
				return r_MGetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RMGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_MGetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_MGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_MGetComponentsInParent_GT;
		public virtual RMethod RMGetComponentsInParent_GT
		{
			get
			{
				if(r_MGetComponentsInParent_GT == null)
				{
					r_MGetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
				}
				return r_MGetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_MGetComponents_Type;
		public virtual RMethod RMGetComponents_Type
		{
			get
			{
				if(r_MGetComponents_Type == null)
				{
					r_MGetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
				}
				return r_MGetComponents_Type;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_MGetComponents_Type_List_d_Component_p_;
		public virtual RMethod RMGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_MGetComponents_Type_List_d_Component_p_ == null)
				{
					r_MGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Component)));
				}
				return r_MGetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_MGetComponents_GT_List_d_T_p_;
		public virtual RMethod RMGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_MGetComponents_GT_List_d_T_p_ == null)
				{
					r_MGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MGetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_MGetComponents_GT;
		public virtual RMethod RMGetComponents_GT
		{
			get
			{
				if(r_MGetComponents_GT == null)
				{
					r_MGetComponents_GT = new(this, "GetComponents", 1);
				}
				return r_MGetComponents_GT;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_MCompareTag_String;
		public virtual RMethod RMCompareTag_String
		{
			get
			{
				if(r_MCompareTag_String == null)
				{
					r_MCompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
				}
				return r_MCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_MGetCoupledComponent;
		public virtual RMethod RMGetCoupledComponent
		{
			get
			{
				if(r_MGetCoupledComponent == null)
				{
					r_MGetCoupledComponent = new(this, "GetCoupledComponent", 0);
				}
				return r_MGetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_MIsCoupledComponent;
		public virtual RMethod RMIsCoupledComponent
		{
			get
			{
				if(r_MIsCoupledComponent == null)
				{
					r_MIsCoupledComponent = new(this, "IsCoupledComponent", 0);
				}
				return r_MIsCoupledComponent;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RMSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_MSendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_MSendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String_Object;
		public virtual RMethod RMSendMessageUpwards_String_Object
		{
			get
			{
				if(r_MSendMessageUpwards_String_Object == null)
				{
					r_MSendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String;
		public virtual RMethod RMSendMessageUpwards_String
		{
			get
			{
				if(r_MSendMessageUpwards_String == null)
				{
					r_MSendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
				}
				return r_MSendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RMSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_MSendMessageUpwards_String_SendMessageOptions == null)
				{
					r_MSendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSendMessage_String_Object;
		public virtual RMethod RMSendMessage_String_Object
		{
			get
			{
				if(r_MSendMessage_String_Object == null)
				{
					r_MSendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_MSendMessage_String;
		public virtual RMethod RMSendMessage_String
		{
			get
			{
				if(r_MSendMessage_String == null)
				{
					r_MSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
				}
				return r_MSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RMSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_MSendMessage_String_Object_SendMessageOptions == null)
				{
					r_MSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MSendMessage_String_SendMessageOptions;
		public virtual RMethod RMSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_MSendMessage_String_SendMessageOptions == null)
				{
					r_MSendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MSendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RMBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_MBroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_MBroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MBroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String_Object;
		public virtual RMethod RMBroadcastMessage_String_Object
		{
			get
			{
				if(r_MBroadcastMessage_String_Object == null)
				{
					r_MBroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MBroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String;
		public virtual RMethod RMBroadcastMessage_String
		{
			get
			{
				if(r_MBroadcastMessage_String == null)
				{
					r_MBroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
				}
				return r_MBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_MBroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RMBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_MBroadcastMessage_String_SendMessageOptions == null)
				{
					r_MBroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
				}
				return r_MBroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 RenderProbe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRenderProbe.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 RenderProbe(UnityEngine.RenderTexture @targetTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetTexture};
            var ___result = RMRenderProbe_RenderTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean IsFinishedRendering(System.Int32 @renderId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderId};
            var ___result = RMIsFinishedRendering_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode @timeSlicingMode, UnityEngine.RenderTexture @targetTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeSlicingMode, @targetTexture};
            var ___result = RMScheduleRender_ReflectionProbeTimeSlicingMode_RenderTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean BlendCubemap(UnityEngine.Texture @src, UnityEngine.Texture @dst, System.Single @blend, UnityEngine.RenderTexture @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst, @blend, @target};
            var ___result = RMBlendCubemap_Texture_Texture_Single_RenderTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void UpdateCachedState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateCachedState.Invoke(___genericsType, ___parameters);

            
        }


        public static void CallReflectionProbeEvent(UnityEngine.ReflectionProbe @probe, Hvak.Editor.Refleaction.RUnityEngine.RReflectionProbe.RReflectionProbeEvent @probeEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@probe, @probeEvent.Value};
            var ___result = RMCallReflectionProbeEvent_ReflectionProbe_ReflectionProbeEvent.Invoke(___genericsType, ___parameters);

            
        }


        public static void CallSetDefaultReflection(UnityEngine.Texture @defaultReflectionCubemap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultReflectionCubemap};
            var ___result = RMCallSetDefaultReflection_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_size_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_size_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_size_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_size_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_center_Injected(out UnityEngine.Vector3 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_center_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_center_Injected(ref UnityEngine.Vector3 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_center_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void get_backgroundColor_Injected(out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_backgroundColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_backgroundColor_Injected(ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_backgroundColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void get_textureHDRDecodeValues_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_textureHDRDecodeValues_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public static void get_defaultTextureHDRDecodeValues_Injected(out UnityEngine.Vector4 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_defaultTextureHDRDecodeValues_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual UnityEngine.Component GetComponent(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual void GetComponentFastPath(System.Type @type, System.IntPtr @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RMGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponent_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual System.Boolean TryGetComponent(System.Type @type, out UnityEngine.Component @component)
        {
			@component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RMTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			@component = (UnityEngine.Component)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryGetComponent<T>(out T @component)
        {
			@component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RMTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			@component = (T)___parameters[0];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Component GetComponent(System.String @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponent_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual T GetComponentInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @result)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @result};
            var ___result = RMGetComponentsInChildren_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentsInChildren_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RMGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual T GetComponentInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @t, System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RMGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RMGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual void GetComponentsInParent<T>(System.Boolean @includeInactive, System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RMGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetComponents_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component[]>(___result);
        }


        public virtual void GetComponents(System.Type @type, System.Collections.Generic.List<UnityEngine.Component> @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RMGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetComponents<T>(System.Collections.Generic.List<T> @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RMGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetComponents_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual System.Boolean CompareTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMCompareTag_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Component>(___result);
        }


        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SendMessageUpwards(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RMSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RMSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RMSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, System.Object @value, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RMSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, System.Object @parameter, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RMBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, System.Object @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RMBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RMBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String @methodName, UnityEngine.SendMessageOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RMBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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
