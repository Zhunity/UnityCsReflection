using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.Vertex
	/// </summary>
    public partial class RVertex : RMember //
    {

		/// <summary>
		/// System.Single nearZ
		/// </summary>
		protected static RField r_nearZ;
		public static RField RnearZ
		{
			get
			{
				if(r_nearZ == null)
				{
					r_nearZ = new(typeof(UnityEngine.UIElements.Vertex), "nearZ");
					r_nearZ.SetBelong(null);
				}
				return r_nearZ;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position");
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 tint
		/// </summary>
		protected RUnityEngine.RColor32 r_tint;
		public virtual RUnityEngine.RColor32 Rtint
		{
			get
			{
				if(r_tint == null)
				{
					r_tint = new(this, "tint");
					r_tint.SetBelong(this.instance);
				}
				return r_tint;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uv
		/// </summary>
		protected RUnityEngine.RVector2 r_uv;
		public virtual RUnityEngine.RVector2 Ruv
		{
			get
			{
				if(r_uv == null)
				{
					r_uv = new(this, "uv");
					r_uv.SetBelong(this.instance);
				}
				return r_uv;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 xformClipPages
		/// </summary>
		protected RUnityEngine.RColor32 r_xformClipPages;
		public virtual RUnityEngine.RColor32 RxformClipPages
		{
			get
			{
				if(r_xformClipPages == null)
				{
					r_xformClipPages = new(this, "xformClipPages");
					r_xformClipPages.SetBelong(this.instance);
				}
				return r_xformClipPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ids
		/// </summary>
		protected RUnityEngine.RColor32 r_ids;
		public virtual RUnityEngine.RColor32 Rids
		{
			get
			{
				if(r_ids == null)
				{
					r_ids = new(this, "ids");
					r_ids.SetBelong(this.instance);
				}
				return r_ids;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 flags
		/// </summary>
		protected RUnityEngine.RColor32 r_flags;
		public virtual RUnityEngine.RColor32 Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 opacityColorPages
		/// </summary>
		protected RUnityEngine.RColor32 r_opacityColorPages;
		public virtual RUnityEngine.RColor32 RopacityColorPages
		{
			get
			{
				if(r_opacityColorPages == null)
				{
					r_opacityColorPages = new(this, "opacityColorPages");
					r_opacityColorPages.SetBelong(this.instance);
				}
				return r_opacityColorPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 settingIndex
		/// </summary>
		protected RUnityEngine.RColor32 r_settingIndex;
		public virtual RUnityEngine.RColor32 RsettingIndex
		{
			get
			{
				if(r_settingIndex == null)
				{
					r_settingIndex = new(this, "settingIndex");
					r_settingIndex.SetBelong(this.instance);
				}
				return r_settingIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 circle
		/// </summary>
		protected RUnityEngine.RVector4 r_circle;
		public virtual RUnityEngine.RVector4 Rcircle
		{
			get
			{
				if(r_circle == null)
				{
					r_circle = new(this, "circle");
					r_circle.SetBelong(this.instance);
				}
				return r_circle;
			}
		}

		/// <summary>
		/// System.Single textureId
		/// </summary>
		protected RField r_textureId;
		public virtual RField RtextureId
		{
			get
			{
				if(r_textureId == null)
				{
					r_textureId = new(this, "textureId");
					r_textureId.SetBelong(this.instance);
				}
				return r_textureId;
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


        public RVertex() : base("UnityEngine.UIElements.Vertex")
        {
        }

        public RVertex(System.Object instance) : base("UnityEngine.UIElements.Vertex")
		{
            SetInstance(instance);
		}

        public RVertex(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVertex(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
