
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.State
	/// </summary>
    public partial class RState : RMember //
    {

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
					r_Fmaterial.SetBelong(this.instance);
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId texture
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId r_Ftexture;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId RFtexture
		{
			get
			{
				if(r_Ftexture == null)
				{
					r_Ftexture = new(this, "texture");
					r_Ftexture.SetBelong(this.instance);
				}
				return r_Ftexture;
			}
		}

		/// <summary>
		/// System.Int32 stencilRef
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FstencilRef;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFstencilRef
		{
			get
			{
				if(r_FstencilRef == null)
				{
					r_FstencilRef = new(this, "stencilRef");
					r_FstencilRef.SetBelong(this.instance);
				}
				return r_FstencilRef;
			}
		}

		/// <summary>
		/// System.Single sdfScale
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FsdfScale;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFsdfScale
		{
			get
			{
				if(r_FsdfScale == null)
				{
					r_FsdfScale = new(this, "sdfScale");
					r_FsdfScale.SetBelong(this.instance);
				}
				return r_FsdfScale;
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


        public RState() : base("UnityEngine.UIElements.UIR.State")
        {
        }

        public RState(System.Object instance) : base("UnityEngine.UIElements.UIR.State")
		{
            SetInstance(instance);
		}

        public RState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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