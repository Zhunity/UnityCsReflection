using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Gradient
	/// </summary>
    public partial class RGradient : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.GradientColorKey[] colorKeys
		/// </summary>
		protected RPropertyArray<RUnityEngine.RGradientColorKey> r_colorKeys;
		public virtual RPropertyArray<RUnityEngine.RGradientColorKey> RcolorKeys
		{
			get
			{
				if(r_colorKeys == null)
				{
					r_colorKeys = new(this, "colorKeys", -1);
					r_colorKeys.SetBelong(this.instance);
				}
				return r_colorKeys;
			}
		}

		/// <summary>
		/// UnityEngine.GradientAlphaKey[] alphaKeys
		/// </summary>
		protected RPropertyArray<RUnityEngine.RGradientAlphaKey> r_alphaKeys;
		public virtual RPropertyArray<RUnityEngine.RGradientAlphaKey> RalphaKeys
		{
			get
			{
				if(r_alphaKeys == null)
				{
					r_alphaKeys = new(this, "alphaKeys", -1);
					r_alphaKeys.SetBelong(this.instance);
				}
				return r_alphaKeys;
			}
		}

		/// <summary>
		/// UnityEngine.GradientMode mode
		/// </summary>
		protected RProperty r_mode;
		public virtual RProperty Rmode
		{
			get
			{
				if(r_mode == null)
				{
					r_mode = new(this, "mode", -1);
					r_mode.SetBelong(this.instance);
				}
				return r_mode;
			}
		}

		/// <summary>
		/// UnityEngine.ColorSpace colorSpace
		/// </summary>
		protected RProperty r_colorSpace;
		public virtual RProperty RcolorSpace
		{
			get
			{
				if(r_colorSpace == null)
				{
					r_colorSpace = new(this, "colorSpace", -1);
					r_colorSpace.SetBelong(this.instance);
				}
				return r_colorSpace;
			}
		}

		/// <summary>
		/// UnityEngine.Color constantColor
		/// </summary>
		protected RUnityEngine.RColor r_constantColor;
		public virtual RUnityEngine.RColor RconstantColor
		{
			get
			{
				if(r_constantColor == null)
				{
					r_constantColor = new(this, "constantColor", -1);
					r_constantColor.SetBelong(this.instance);
				}
				return r_constantColor;
			}
		}

		/// <summary>
		/// IntPtr Init()
		/// </summary>
		protected static RMethod r_RInit;
		public static RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(typeof(UnityEngine.Gradient), "Init", 0);
					r_RInit.SetBelong(null);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_RCleanup;
		public virtual RMethod RCleanup
		{
			get
			{
				if(r_RCleanup == null)
				{
					r_RCleanup = new(this, "Cleanup", 0);
					r_RCleanup.SetBelong(this.instance);
				}
				return r_RCleanup;
			}
		}

		/// <summary>
		/// Boolean Internal_Equals(IntPtr)
		/// </summary>
		protected RMethod r_RInternal_Equals_IntPtr;
		public virtual RMethod RInternal_Equals_IntPtr
		{
			get
			{
				if(r_RInternal_Equals_IntPtr == null)
				{
					r_RInternal_Equals_IntPtr = new(this, "Internal_Equals", 0, typeof(System.IntPtr));
					r_RInternal_Equals_IntPtr.SetBelong(this.instance);
				}
				return r_RInternal_Equals_IntPtr;
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
		/// UnityEngine.Color Evaluate(Single)
		/// </summary>
		protected RMethod r_REvaluate_Single;
		public virtual RMethod REvaluate_Single
		{
			get
			{
				if(r_REvaluate_Single == null)
				{
					r_REvaluate_Single = new(this, "Evaluate", 0, typeof(System.Single));
					r_REvaluate_Single.SetBelong(this.instance);
				}
				return r_REvaluate_Single;
			}
		}

		/// <summary>
		/// Void SetKeys(UnityEngine.GradientColorKey[], UnityEngine.GradientAlphaKey[])
		/// </summary>
		protected RMethod r_RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray;
		public virtual RMethod RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray
		{
			get
			{
				if(r_RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray == null)
				{
					r_RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray = new(this, "SetKeys", 0, typeof(UnityEngine.GradientColorKey).MakeArrayType(), typeof(UnityEngine.GradientAlphaKey).MakeArrayType());
					r_RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray.SetBelong(this.instance);
				}
				return r_RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray;
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
		/// Boolean Equals(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_REquals_Gradient;
		public virtual RMethod REquals_Gradient
		{
			get
			{
				if(r_REquals_Gradient == null)
				{
					r_REquals_Gradient = new(this, "Equals", 0, typeof(UnityEngine.Gradient));
					r_REquals_Gradient.SetBelong(this.instance);
				}
				return r_REquals_Gradient;
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
		/// Void Evaluate_Injected(Single, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_REvaluate_Injected_Single_Out_Color;
		public virtual RMethod REvaluate_Injected_Single_Out_Color
		{
			get
			{
				if(r_REvaluate_Injected_Single_Out_Color == null)
				{
					r_REvaluate_Injected_Single_Out_Color = new(this, "Evaluate_Injected", 0, typeof(System.Single), typeof(UnityEngine.Color).MakeByRefType());
					r_REvaluate_Injected_Single_Out_Color.SetBelong(this.instance);
				}
				return r_REvaluate_Injected_Single_Out_Color;
			}
		}

		/// <summary>
		/// Void get_constantColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rget_constantColor_Injected_Out_Color;
		public virtual RMethod Rget_constantColor_Injected_Out_Color
		{
			get
			{
				if(r_Rget_constantColor_Injected_Out_Color == null)
				{
					r_Rget_constantColor_Injected_Out_Color = new(this, "get_constantColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rget_constantColor_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_Rget_constantColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_constantColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rset_constantColor_Injected_Ref_Color;
		public virtual RMethod Rset_constantColor_Injected_Ref_Color
		{
			get
			{
				if(r_Rset_constantColor_Injected_Ref_Color == null)
				{
					r_Rset_constantColor_Injected_Ref_Color = new(this, "set_constantColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rset_constantColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_Rset_constantColor_Injected_Ref_Color;
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


        public RGradient() : base("UnityEngine.Gradient")
        {
        }

        public RGradient(System.Object instance) : base("UnityEngine.Gradient")
		{
            SetInstance(instance);
		}

        public RGradient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGradient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.IntPtr Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Internal_Equals(System.IntPtr  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RInternal_Equals_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color Evaluate(System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = REvaluate_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void SetKeys(UnityEngine.GradientColorKey[]  @colorKeys, UnityEngine.GradientAlphaKey[]  @alphaKeys)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorKeys, @alphaKeys};
            var ___result = RSetKeys_GradientColorKeyArray_GradientAlphaKeyArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Gradient  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Gradient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Evaluate_Injected(System.Single  @time, out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @ret};
            var ___result = REvaluate_Injected_Single_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void get_constantColor_Injected(out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_constantColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_constantColor_Injected(ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_constantColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[0];

            
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
