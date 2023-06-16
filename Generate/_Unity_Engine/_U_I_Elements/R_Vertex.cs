
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.Vertex
	/// </summary>
    public partial class RVertex : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Vertex);
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


		/// <summary>
		/// System.Single nearZ
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FnearZ;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFnearZ
		{
			get
			{
				if(r_FnearZ == null)
				{
					r_FnearZ = new(Type, "nearZ");
				}
				return r_FnearZ;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 tint
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Ftint;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFtint
		{
			get
			{
				if(r_Ftint == null)
				{
					r_Ftint = new(this, "tint");
				}
				return r_Ftint;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uv
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fuv;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFuv
		{
			get
			{
				if(r_Fuv == null)
				{
					r_Fuv = new(this, "uv");
				}
				return r_Fuv;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 xformClipPages
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FxformClipPages;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFxformClipPages
		{
			get
			{
				if(r_FxformClipPages == null)
				{
					r_FxformClipPages = new(this, "xformClipPages");
				}
				return r_FxformClipPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ids
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fids;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFids
		{
			get
			{
				if(r_Fids == null)
				{
					r_Fids = new(this, "ids");
				}
				return r_Fids;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fflags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 opacityColorPages
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FopacityColorPages;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFopacityColorPages
		{
			get
			{
				if(r_FopacityColorPages == null)
				{
					r_FopacityColorPages = new(this, "opacityColorPages");
				}
				return r_FopacityColorPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 settingIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FsettingIndex;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFsettingIndex
		{
			get
			{
				if(r_FsettingIndex == null)
				{
					r_FsettingIndex = new(this, "settingIndex");
				}
				return r_FsettingIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 circle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Fcircle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFcircle
		{
			get
			{
				if(r_Fcircle == null)
				{
					r_Fcircle = new(this, "circle");
				}
				return r_Fcircle;
			}
		}

		/// <summary>
		/// System.Single textureId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FtextureId;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFtextureId
		{
			get
			{
				if(r_FtextureId == null)
				{
					r_FtextureId = new(this, "textureId");
				}
				return r_FtextureId;
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
