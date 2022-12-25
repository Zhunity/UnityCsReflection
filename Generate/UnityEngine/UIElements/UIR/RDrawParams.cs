using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.DrawParams
	/// </summary>
    public partial class RDrawParams : RMember //
    {

		/// <summary>
		/// UnityEngine.Rect k_UnlimitedRect
		/// </summary>
		protected static RUnityEngine.RRect r_k_UnlimitedRect;
		public static RUnityEngine.RRect Rk_UnlimitedRect
		{
			get
			{
				if(r_k_UnlimitedRect == null)
				{
					r_k_UnlimitedRect = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.DrawParams"), "k_UnlimitedRect");
					r_k_UnlimitedRect.SetBelong(null);
				}
				return r_k_UnlimitedRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect k_FullNormalizedRect
		/// </summary>
		protected static RUnityEngine.RRect r_k_FullNormalizedRect;
		public static RUnityEngine.RRect Rk_FullNormalizedRect
		{
			get
			{
				if(r_k_FullNormalizedRect == null)
				{
					r_k_FullNormalizedRect = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.DrawParams"), "k_FullNormalizedRect");
					r_k_FullNormalizedRect.SetBelong(null);
				}
				return r_k_FullNormalizedRect;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.Matrix4x4] view
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RMatrix4x4> r_view;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RMatrix4x4> Rview
		{
			get
			{
				if(r_view == null)
				{
					r_view = new(this, "view");
					r_view.SetBelong(this.instance);
				}
				return r_view;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.Rect] scissor
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RRect> r_scissor;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RRect> Rscissor
		{
			get
			{
				if(r_scissor == null)
				{
					r_scissor = new(this, "scissor");
					r_scissor.SetBelong(this.instance);
				}
				return r_scissor;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.RenderTexture] renderTexture
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RRenderTexture> r_renderTexture;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RRenderTexture> RrenderTexture
		{
			get
			{
				if(r_renderTexture == null)
				{
					r_renderTexture = new(this, "renderTexture");
					r_renderTexture.SetBelong(this.instance);
				}
				return r_renderTexture;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Material] defaultMaterial
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RMaterial> r_defaultMaterial;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RMaterial> RdefaultMaterial
		{
			get
			{
				if(r_defaultMaterial == null)
				{
					r_defaultMaterial = new(this, "defaultMaterial");
					r_defaultMaterial.SetBelong(this.instance);
				}
				return r_defaultMaterial;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
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


        public RDrawParams() : base("UnityEngine.UIElements.UIR.DrawParams")
        {
        }

        public RDrawParams(System.Object instance) : base("UnityEngine.UIElements.UIR.DrawParams")
		{
            SetInstance(instance);
		}

        public RDrawParams(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDrawParams(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
