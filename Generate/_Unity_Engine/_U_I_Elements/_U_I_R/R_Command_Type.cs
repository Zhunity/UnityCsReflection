
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.CommandType
	/// </summary>
    public partial class RCommandType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.CommandType");
            }
        }

        public RCommandType() : base("UnityEngine.UIElements.UIR.CommandType")
        {
        }

        public RCommandType(System.Object instance) : base("UnityEngine.UIElements.UIR.CommandType")
		{
            SetInstance(instance);
		}

        public RCommandType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCommandType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType Draw
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FDraw;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFDraw
		{
			get
			{
				if(r_FDraw == null)
				{
					r_FDraw = new(Type, "Draw");
				}
				return r_FDraw;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType ImmediateCull
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FImmediateCull;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFImmediateCull
		{
			get
			{
				if(r_FImmediateCull == null)
				{
					r_FImmediateCull = new(Type, "ImmediateCull");
				}
				return r_FImmediateCull;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType Immediate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FImmediate;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFImmediate
		{
			get
			{
				if(r_FImmediate == null)
				{
					r_FImmediate = new(Type, "Immediate");
				}
				return r_FImmediate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PushView
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPushView;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPushView
		{
			get
			{
				if(r_FPushView == null)
				{
					r_FPushView = new(Type, "PushView");
				}
				return r_FPushView;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PopView
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPopView;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPopView
		{
			get
			{
				if(r_FPopView == null)
				{
					r_FPopView = new(Type, "PopView");
				}
				return r_FPopView;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PushScissor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPushScissor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPushScissor
		{
			get
			{
				if(r_FPushScissor == null)
				{
					r_FPushScissor = new(Type, "PushScissor");
				}
				return r_FPushScissor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PopScissor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPopScissor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPopScissor
		{
			get
			{
				if(r_FPopScissor == null)
				{
					r_FPopScissor = new(Type, "PopScissor");
				}
				return r_FPopScissor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PushRenderTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPushRenderTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPushRenderTexture
		{
			get
			{
				if(r_FPushRenderTexture == null)
				{
					r_FPushRenderTexture = new(Type, "PushRenderTexture");
				}
				return r_FPushRenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PopRenderTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPopRenderTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPopRenderTexture
		{
			get
			{
				if(r_FPopRenderTexture == null)
				{
					r_FPopRenderTexture = new(Type, "PopRenderTexture");
				}
				return r_FPopRenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType BlitToPreviousRT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FBlitToPreviousRT;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFBlitToPreviousRT
		{
			get
			{
				if(r_FBlitToPreviousRT == null)
				{
					r_FBlitToPreviousRT = new(Type, "BlitToPreviousRT");
				}
				return r_FBlitToPreviousRT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PushDefaultMaterial
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPushDefaultMaterial;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPushDefaultMaterial
		{
			get
			{
				if(r_FPushDefaultMaterial == null)
				{
					r_FPushDefaultMaterial = new(Type, "PushDefaultMaterial");
				}
				return r_FPushDefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.CommandType PopDefaultMaterial
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType r_FPopDefaultMaterial;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RCommandType RFPopDefaultMaterial
		{
			get
			{
				if(r_FPopDefaultMaterial == null)
				{
					r_FPopDefaultMaterial = new(Type, "PopDefaultMaterial");
				}
				return r_FPopDefaultMaterial;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
