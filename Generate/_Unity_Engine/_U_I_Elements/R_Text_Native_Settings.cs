
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.TextNativeSettings
	/// </summary>
    public partial class RTextNativeSettings : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.TextNativeSettings");
            }
        }

        public RTextNativeSettings() : base("UnityEngine.UIElements.TextNativeSettings")
        {
        }

        public RTextNativeSettings(System.Object instance) : base("UnityEngine.UIElements.TextNativeSettings")
		{
            SetInstance(instance);
		}

        public RTextNativeSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextNativeSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ftext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtext
		{
			get
			{
				if(r_Ftext == null)
				{
					r_Ftext = new(this, "text");
				}
				return r_Ftext;
			}
		}

		/// <summary>
		/// UnityEngine.Font font
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_Ffont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RFfont
		{
			get
			{
				if(r_Ffont == null)
				{
					r_Ffont = new(this, "font");
				}
				return r_Ffont;
			}
		}

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFsize
		{
			get
			{
				if(r_Fsize == null)
				{
					r_Fsize = new(this, "size");
				}
				return r_Fsize;
			}
		}

		/// <summary>
		/// System.Single scaling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fscaling;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFscaling
		{
			get
			{
				if(r_Fscaling == null)
				{
					r_Fscaling = new(this, "scaling");
				}
				return r_Fscaling;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFontStyle r_Fstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFontStyle RFstyle
		{
			get
			{
				if(r_Fstyle == null)
				{
					r_Fstyle = new(this, "style");
				}
				return r_Fstyle;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Fcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor anchor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor r_Fanchor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor RFanchor
		{
			get
			{
				if(r_Fanchor == null)
				{
					r_Fanchor = new(this, "anchor");
				}
				return r_Fanchor;
			}
		}

		/// <summary>
		/// System.Boolean wordWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FwordWrap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFwordWrap
		{
			get
			{
				if(r_FwordWrap == null)
				{
					r_FwordWrap = new(this, "wordWrap");
				}
				return r_FwordWrap;
			}
		}

		/// <summary>
		/// System.Single wordWrapWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FwordWrapWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFwordWrapWidth
		{
			get
			{
				if(r_FwordWrapWidth == null)
				{
					r_FwordWrapWidth = new(this, "wordWrapWidth");
				}
				return r_FwordWrapWidth;
			}
		}

		/// <summary>
		/// System.Boolean richText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FrichText;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFrichText
		{
			get
			{
				if(r_FrichText == null)
				{
					r_FrichText = new(this, "richText");
				}
				return r_FrichText;
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
