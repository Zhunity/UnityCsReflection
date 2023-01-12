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
		protected static RUnityEngine.RRect r_Fk_UnlimitedRect;
		public static RUnityEngine.RRect RFk_UnlimitedRect
		{
			get
			{
				if(r_Fk_UnlimitedRect == null)
				{
					r_Fk_UnlimitedRect = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawParams"), "k_UnlimitedRect");
					r_Fk_UnlimitedRect.SetBelong(null);
				}
				return r_Fk_UnlimitedRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect k_FullNormalizedRect
		/// </summary>
		protected static RUnityEngine.RRect r_Fk_FullNormalizedRect;
		public static RUnityEngine.RRect RFk_FullNormalizedRect
		{
			get
			{
				if(r_Fk_FullNormalizedRect == null)
				{
					r_Fk_FullNormalizedRect = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawParams"), "k_FullNormalizedRect");
					r_Fk_FullNormalizedRect.SetBelong(null);
				}
				return r_Fk_FullNormalizedRect;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.Matrix4x4] view
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RMatrix4x4> r_Fview;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RMatrix4x4> RFview
		{
			get
			{
				if(r_Fview == null)
				{
					r_Fview = new(this, "view");
					r_Fview.SetBelong(this.instance);
				}
				return r_Fview;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.Rect] scissor
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RRect> r_Fscissor;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RRect> RFscissor
		{
			get
			{
				if(r_Fscissor == null)
				{
					r_Fscissor = new(this, "scissor");
					r_Fscissor.SetBelong(this.instance);
				}
				return r_Fscissor;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.RenderTexture] renderTexture
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RRenderTexture> r_FrenderTexture;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RRenderTexture> RFrenderTexture
		{
			get
			{
				if(r_FrenderTexture == null)
				{
					r_FrenderTexture = new(this, "renderTexture");
					r_FrenderTexture.SetBelong(this.instance);
				}
				return r_FrenderTexture;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Material] defaultMaterial
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RMaterial> r_FdefaultMaterial;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RMaterial> RFdefaultMaterial
		{
			get
			{
				if(r_FdefaultMaterial == null)
				{
					r_FdefaultMaterial = new(this, "defaultMaterial");
					r_FdefaultMaterial.SetBelong(this.instance);
				}
				return r_FdefaultMaterial;
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
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
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
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
