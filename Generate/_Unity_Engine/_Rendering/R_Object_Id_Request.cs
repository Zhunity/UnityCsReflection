
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.ObjectIdRequest
	/// </summary>
    public partial class RObjectIdRequest : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.ObjectIdRequest);
            }
        }

        public RObjectIdRequest() : base("UnityEngine.Rendering.ObjectIdRequest")
        {
        }

        public RObjectIdRequest(System.Object instance) : base("UnityEngine.Rendering.ObjectIdRequest")
		{
            SetInstance(instance);
		}

        public RObjectIdRequest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObjectIdRequest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.RenderTexture <destination>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_F__0__destination__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RF__0__destination__1__k__BackingField
		{
			get
			{
				if(r_F__0__destination__1__k__BackingField == null)
				{
					r_F__0__destination__1__k__BackingField = new(this, "<destination>k__BackingField");
				}
				return r_F__0__destination__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <mipLevel>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__mipLevel__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__mipLevel__1__k__BackingField
		{
			get
			{
				if(r_F__0__mipLevel__1__k__BackingField == null)
				{
					r_F__0__mipLevel__1__k__BackingField = new(this, "<mipLevel>k__BackingField");
				}
				return r_F__0__mipLevel__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace <face>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_F__0__face__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RF__0__face__1__k__BackingField
		{
			get
			{
				if(r_F__0__face__1__k__BackingField == null)
				{
					r_F__0__face__1__k__BackingField = new(this, "<face>k__BackingField");
				}
				return r_F__0__face__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <slice>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__slice__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__slice__1__k__BackingField
		{
			get
			{
				if(r_F__0__slice__1__k__BackingField == null)
				{
					r_F__0__slice__1__k__BackingField = new(this, "<slice>k__BackingField");
				}
				return r_F__0__slice__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ObjectIdResult <result>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RObjectIdResult r_F__0__result__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RObjectIdResult RF__0__result__1__k__BackingField
		{
			get
			{
				if(r_F__0__result__1__k__BackingField == null)
				{
					r_F__0__result__1__k__BackingField = new(this, "<result>k__BackingField");
				}
				return r_F__0__result__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture destination
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_Pdestination;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPdestination
		{
			get
			{
				if(r_Pdestination == null)
				{
					r_Pdestination = new(this, "destination", -1);
				}
				return r_Pdestination;
			}
		}

		/// <summary>
		/// Int32 mipLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmipLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmipLevel
		{
			get
			{
				if(r_PmipLevel == null)
				{
					r_PmipLevel = new(this, "mipLevel", -1);
				}
				return r_PmipLevel;
			}
		}

		/// <summary>
		/// UnityEngine.CubemapFace face
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace r_Pface;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCubemapFace RPface
		{
			get
			{
				if(r_Pface == null)
				{
					r_Pface = new(this, "face", -1);
				}
				return r_Pface;
			}
		}

		/// <summary>
		/// Int32 slice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pslice;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPslice
		{
			get
			{
				if(r_Pslice == null)
				{
					r_Pslice = new(this, "slice", -1);
				}
				return r_Pslice;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ObjectIdResult result
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RObjectIdResult r_Presult;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RObjectIdResult RPresult
		{
			get
			{
				if(r_Presult == null)
				{
					r_Presult = new(this, "result", -1);
				}
				return r_Presult;
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
