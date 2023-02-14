
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.VertexAttribute
	/// </summary>
    public partial class RVertexAttribute : RMember //
    {

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
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute Position
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFPosition
		{
			get
			{
				if(r_FPosition == null)
				{
					r_FPosition = new(typeof(UnityEngine.Rendering.VertexAttribute), "Position");
					r_FPosition.SetBelong(null);
				}
				return r_FPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute Normal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FNormal;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFNormal
		{
			get
			{
				if(r_FNormal == null)
				{
					r_FNormal = new(typeof(UnityEngine.Rendering.VertexAttribute), "Normal");
					r_FNormal.SetBelong(null);
				}
				return r_FNormal;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute Tangent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTangent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTangent
		{
			get
			{
				if(r_FTangent == null)
				{
					r_FTangent = new(typeof(UnityEngine.Rendering.VertexAttribute), "Tangent");
					r_FTangent.SetBelong(null);
				}
				return r_FTangent;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute Color
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFColor
		{
			get
			{
				if(r_FColor == null)
				{
					r_FColor = new(typeof(UnityEngine.Rendering.VertexAttribute), "Color");
					r_FColor.SetBelong(null);
				}
				return r_FColor;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord0
		{
			get
			{
				if(r_FTexCoord0 == null)
				{
					r_FTexCoord0 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord0");
					r_FTexCoord0.SetBelong(null);
				}
				return r_FTexCoord0;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord1
		{
			get
			{
				if(r_FTexCoord1 == null)
				{
					r_FTexCoord1 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord1");
					r_FTexCoord1.SetBelong(null);
				}
				return r_FTexCoord1;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord2
		{
			get
			{
				if(r_FTexCoord2 == null)
				{
					r_FTexCoord2 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord2");
					r_FTexCoord2.SetBelong(null);
				}
				return r_FTexCoord2;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord3
		{
			get
			{
				if(r_FTexCoord3 == null)
				{
					r_FTexCoord3 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord3");
					r_FTexCoord3.SetBelong(null);
				}
				return r_FTexCoord3;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord4
		{
			get
			{
				if(r_FTexCoord4 == null)
				{
					r_FTexCoord4 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord4");
					r_FTexCoord4.SetBelong(null);
				}
				return r_FTexCoord4;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord5
		{
			get
			{
				if(r_FTexCoord5 == null)
				{
					r_FTexCoord5 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord5");
					r_FTexCoord5.SetBelong(null);
				}
				return r_FTexCoord5;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord6
		{
			get
			{
				if(r_FTexCoord6 == null)
				{
					r_FTexCoord6 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord6");
					r_FTexCoord6.SetBelong(null);
				}
				return r_FTexCoord6;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute TexCoord7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FTexCoord7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFTexCoord7
		{
			get
			{
				if(r_FTexCoord7 == null)
				{
					r_FTexCoord7 = new(typeof(UnityEngine.Rendering.VertexAttribute), "TexCoord7");
					r_FTexCoord7.SetBelong(null);
				}
				return r_FTexCoord7;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute BlendWeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FBlendWeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFBlendWeight
		{
			get
			{
				if(r_FBlendWeight == null)
				{
					r_FBlendWeight = new(typeof(UnityEngine.Rendering.VertexAttribute), "BlendWeight");
					r_FBlendWeight.SetBelong(null);
				}
				return r_FBlendWeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute BlendIndices
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_FBlendIndices;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RFBlendIndices
		{
			get
			{
				if(r_FBlendIndices == null)
				{
					r_FBlendIndices = new(typeof(UnityEngine.Rendering.VertexAttribute), "BlendIndices");
					r_FBlendIndices.SetBelong(null);
				}
				return r_FBlendIndices;
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
					r_MGetValue.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
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
					r_MCompareTo_Object.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_IFormatProvider.SetBelong(this.instance);
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
					r_MHasFlag_Enum.SetBelong(this.instance);
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
					r_MGetTypeCode.SetBelong(this.instance);
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


        public RVertexAttribute() : base("UnityEngine.Rendering.VertexAttribute")
        {
        }

        public RVertexAttribute(System.Object instance) : base("UnityEngine.Rendering.VertexAttribute")
		{
            SetInstance(instance);
		}

        public RVertexAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVertexAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
