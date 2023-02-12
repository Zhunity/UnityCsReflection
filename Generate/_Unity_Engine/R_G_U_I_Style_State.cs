
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUIStyleState
	/// </summary>
    public partial class RGUIStyleState : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
					r_Fm_Ptr.SetBelong(this.instance);
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_SourceStyle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RGUIStyle r_Fm_SourceStyle;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RGUIStyle RFm_SourceStyle
		{
			get
			{
				if(r_Fm_SourceStyle == null)
				{
					r_Fm_SourceStyle = new(this, "m_SourceStyle");
					r_Fm_SourceStyle.SetBelong(this.instance);
				}
				return r_Fm_SourceStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D background
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D r_Pbackground;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D RPbackground
		{
			get
			{
				if(r_Pbackground == null)
				{
					r_Pbackground = new(this, "background", -1);
					r_Pbackground.SetBelong(this.instance);
				}
				return r_Pbackground;
			}
		}

		/// <summary>
		/// UnityEngine.Color textColor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_PtextColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RPtextColor
		{
			get
			{
				if(r_PtextColor == null)
				{
					r_PtextColor = new(this, "textColor", -1);
					r_PtextColor.SetBelong(this.instance);
				}
				return r_PtextColor;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] scaledBackgrounds
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D> r_PscaledBackgrounds;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RUnityEngine.RTexture2D> RPscaledBackgrounds
		{
			get
			{
				if(r_PscaledBackgrounds == null)
				{
					r_PscaledBackgrounds = new(this, "scaledBackgrounds", -1);
					r_PscaledBackgrounds.SetBelong(this.instance);
				}
				return r_PscaledBackgrounds;
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
					r_MInit = new(typeof(UnityEngine.GUIStyleState), "Init", 0);
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
					r_MCleanup.SetBelong(this.instance);
				}
				return r_MCleanup;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState ProduceGUIStyleStateFromDeserialization(UnityEngine.GUIStyle, IntPtr)
		/// </summary>
		protected static RMethod r_MProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr;
		public static RMethod RMProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr
		{
			get
			{
				if(r_MProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr == null)
				{
					r_MProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr = new(typeof(UnityEngine.GUIStyleState), "ProduceGUIStyleStateFromDeserialization", 0, typeof(UnityEngine.GUIStyle), typeof(System.IntPtr));
					r_MProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr.SetBelong(null);
				}
				return r_MProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle, IntPtr)
		/// </summary>
		protected static RMethod r_MGetGUIStyleState_GUIStyle_IntPtr;
		public static RMethod RMGetGUIStyleState_GUIStyle_IntPtr
		{
			get
			{
				if(r_MGetGUIStyleState_GUIStyle_IntPtr == null)
				{
					r_MGetGUIStyleState_GUIStyle_IntPtr = new(typeof(UnityEngine.GUIStyleState), "GetGUIStyleState", 0, typeof(UnityEngine.GUIStyle), typeof(System.IntPtr));
					r_MGetGUIStyleState_GUIStyle_IntPtr.SetBelong(null);
				}
				return r_MGetGUIStyleState_GUIStyle_IntPtr;
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
		/// Void get_textColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mget_textColor_Injected_Out_Color;
		public virtual RMethod RMget_textColor_Injected_Out_Color
		{
			get
			{
				if(r_Mget_textColor_Injected_Out_Color == null)
				{
					r_Mget_textColor_Injected_Out_Color = new(this, "get_textColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Mget_textColor_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_Mget_textColor_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_textColor_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Mset_textColor_Injected_Ref_Color;
		public virtual RMethod RMset_textColor_Injected_Ref_Color
		{
			get
			{
				if(r_Mset_textColor_Injected_Ref_Color == null)
				{
					r_Mset_textColor_Injected_Ref_Color = new(this, "set_textColor_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Mset_textColor_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_Mset_textColor_Injected_Ref_Color;
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


        public RGUIStyleState() : base("UnityEngine.GUIStyleState")
        {
        }

        public RGUIStyleState(System.Object instance) : base("UnityEngine.GUIStyleState")
		{
            SetInstance(instance);
		}

        public RGUIStyleState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIStyleState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public static UnityEngine.GUIStyleState ProduceGUIStyleStateFromDeserialization(UnityEngine.GUIStyle @sourceStyle, System.IntPtr @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceStyle, @source};
            var ___result = RMProduceGUIStyleStateFromDeserialization_GUIStyle_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyleState)___result;
        }


        public static UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle @sourceStyle, System.IntPtr @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceStyle, @source};
            var ___result = RMGetGUIStyleState_GUIStyle_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyleState)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_textColor_Injected(out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_textColor_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_textColor_Injected(ref UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_textColor_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[0];

            
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
