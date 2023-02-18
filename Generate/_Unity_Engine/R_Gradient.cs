
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Gradient
	/// </summary>
    public partial class RGradient : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
					r_Fm_Ptr.SetBelong(this.GetValue());
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.GradientColorKey[] colorKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RGradientColorKey> r_PcolorKeys;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RGradientColorKey> RPcolorKeys
		{
			get
			{
				if(r_PcolorKeys == null)
				{
					r_PcolorKeys = new(this, "colorKeys", -1);
					r_PcolorKeys.SetBelong(this.GetValue());
				}
				return r_PcolorKeys;
			}
		}

		/// <summary>
		/// UnityEngine.GradientAlphaKey[] alphaKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RGradientAlphaKey> r_PalphaKeys;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RGradientAlphaKey> RPalphaKeys
		{
			get
			{
				if(r_PalphaKeys == null)
				{
					r_PalphaKeys = new(this, "alphaKeys", -1);
					r_PalphaKeys.SetBelong(this.GetValue());
				}
				return r_PalphaKeys;
			}
		}

		/// <summary>
		/// UnityEngine.GradientMode mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGradientMode r_Pmode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGradientMode RPmode
		{
			get
			{
				if(r_Pmode == null)
				{
					r_Pmode = new(this, "mode", -1);
					r_Pmode.SetBelong(this.GetValue());
				}
				return r_Pmode;
			}
		}

		/// <summary>
		/// UnityEngine.ColorSpace colorSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColorSpace r_PcolorSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColorSpace RPcolorSpace
		{
			get
			{
				if(r_PcolorSpace == null)
				{
					r_PcolorSpace = new(this, "colorSpace", -1);
					r_PcolorSpace.SetBelong(this.GetValue());
				}
				return r_PcolorSpace;
			}
		}

		/// <summary>
		/// UnityEngine.Color constantColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PconstantColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPconstantColor
		{
			get
			{
				if(r_PconstantColor == null)
				{
					r_PconstantColor = new(this, "constantColor", -1);
					r_PconstantColor.SetBelong(this.GetValue());
				}
				return r_PconstantColor;
			}
		}

		/// <summary>
		/// IntPtr Init()
		/// </summary>
		protected static RMethod r_MInit;
		public static RMethod RMInit
		{
			get
			{
				if(r_MInit == null)
				{
					r_MInit = new(typeof(UnityEngine.Gradient), "Init", 0);
					r_MInit.SetBelong(null);
				}
				return r_MInit;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_MCleanup;
		public virtual RMethod RMCleanup
		{
			get
			{
				if(r_MCleanup == null)
				{
					r_MCleanup = new(this, "Cleanup", 0);
					r_MCleanup.SetBelong(this.GetValue());
				}
				return r_MCleanup;
			}
		}

		/// <summary>
		/// Boolean Internal_Equals(IntPtr)
		/// </summary>
		protected RMethod r_MInternal_Equals_IntPtr;
		public virtual RMethod RMInternal_Equals_IntPtr
		{
			get
			{
				if(r_MInternal_Equals_IntPtr == null)
				{
					r_MInternal_Equals_IntPtr = new(this, "Internal_Equals", 0, typeof(System.IntPtr));
					r_MInternal_Equals_IntPtr.SetBelong(this.GetValue());
				}
				return r_MInternal_Equals_IntPtr;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// UnityEngine.Color Evaluate(Single)
		/// </summary>
		protected RMethod r_MEvaluate_Single;
		public virtual RMethod RMEvaluate_Single
		{
			get
			{
				if(r_MEvaluate_Single == null)
				{
					r_MEvaluate_Single = new(this, "Evaluate", 0, typeof(System.Single));
					r_MEvaluate_Single.SetBelong(this.GetValue());
				}
				return r_MEvaluate_Single;
			}
		}

		/// <summary>
		/// Void SetKeys(UnityEngine.GradientColorKey[], UnityEngine.GradientAlphaKey[])
		/// </summary>
		protected RMethod r_MSetKeys_GradientColorKeyArray_GradientAlphaKeyArray;
		public virtual RMethod RMSetKeys_GradientColorKeyArray_GradientAlphaKeyArray
		{
			get
			{
				if(r_MSetKeys_GradientColorKeyArray_GradientAlphaKeyArray == null)
				{
					r_MSetKeys_GradientColorKeyArray_GradientAlphaKeyArray = new(this, "SetKeys", 0, typeof(UnityEngine.GradientColorKey).MakeArrayType(), typeof(UnityEngine.GradientAlphaKey).MakeArrayType());
					r_MSetKeys_GradientColorKeyArray_GradientAlphaKeyArray.SetBelong(this.GetValue());
				}
				return r_MSetKeys_GradientColorKeyArray_GradientAlphaKeyArray;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Gradient)
		/// </summary>
		protected RMethod r_MEquals_Gradient;
		public virtual RMethod RMEquals_Gradient
		{
			get
			{
				if(r_MEquals_Gradient == null)
				{
					r_MEquals_Gradient = new(this, "Equals", 0, typeof(UnityEngine.Gradient));
					r_MEquals_Gradient.SetBelong(this.GetValue());
				}
				return r_MEquals_Gradient;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Void Evaluate_Injected(Single, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MEvaluate_Injected_Single_Out_Color;
		public virtual RMethod RMEvaluate_Injected_Single_Out_Color
		{
			get
			{
				if(r_MEvaluate_Injected_Single_Out_Color == null)
				{
					r_MEvaluate_Injected_Single_Out_Color = new(this, "Evaluate_Injected", 0, typeof(System.Single), typeof(UnityEngine.Color).MakeByRefType());
					r_MEvaluate_Injected_Single_Out_Color.SetBelong(this.GetValue());
				}
				return r_MEvaluate_Injected_Single_Out_Color;
			}
		}

		/// <summary>
		/// Void get_constantColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mget_constantColor_Injected_Out_Color;
		public virtual RMethod RMget_constantColor_Injected_Out_Color
		{
			get
			{
				if(r_Mget_constantColor_Injected_Out_Color == null)
				{
					r_Mget_constantColor_Injected_Out_Color = new(this, "get_constantColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Mget_constantColor_Injected_Out_Color.SetBelong(this.GetValue());
				}
				return r_Mget_constantColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_constantColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mset_constantColor_Injected_Ref_Color;
		public virtual RMethod RMset_constantColor_Injected_Ref_Color
		{
			get
			{
				if(r_Mset_constantColor_Injected_Ref_Color == null)
				{
					r_Mset_constantColor_Injected_Ref_Color = new(this, "set_constantColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Mset_constantColor_Injected_Ref_Color.SetBelong(this.GetValue());
				}
				return r_Mset_constantColor_Injected_Ref_Color;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMInit.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Internal_Equals(System.IntPtr @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMInternal_Equals_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color Evaluate(System.Single @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RMEvaluate_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void SetKeys(UnityEngine.GradientColorKey[] @colorKeys, UnityEngine.GradientAlphaKey[] @alphaKeys)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorKeys, @alphaKeys};
            var ___result = RMSetKeys_GradientColorKeyArray_GradientAlphaKeyArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Gradient @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Gradient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Evaluate_Injected(System.Single @time, out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @ret};
            var ___result = RMEvaluate_Injected_Single_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[1];

            
        }


        public virtual void get_constantColor_Injected(out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_constantColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_constantColor_Injected(ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_constantColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[0];

            
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
