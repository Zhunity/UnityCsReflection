
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.InputDropdownArgs
	/// </summary>
    public partial class RInputDropdownArgs : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.InputDropdownArgs");
            }
        }

        public RInputDropdownArgs() : base("UnityEditor.PackageManager.UI.InputDropdownArgs")
        {
        }

        public RInputDropdownArgs(System.Object instance) : base("UnityEditor.PackageManager.UI.InputDropdownArgs")
		{
            SetInstance(instance);
		}

        public RInputDropdownArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInputDropdownArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String title
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ftitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtitle
		{
			get
			{
				if(r_Ftitle == null)
				{
					r_Ftitle = new(this, "title");
				}
				return r_Ftitle;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEngine.UIElements.Background] icon
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground> r_Ficon;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground> RFicon
		{
			get
			{
				if(r_Ficon == null)
				{
					r_Ficon = new(this, "icon");
				}
				return r_Ficon;
			}
		}

		/// <summary>
		/// System.String iconUssClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FiconUssClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFiconUssClass
		{
			get
			{
				if(r_FiconUssClass == null)
				{
					r_FiconUssClass = new(this, "iconUssClass");
				}
				return r_FiconUssClass;
			}
		}

		/// <summary>
		/// System.String placeholderText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FplaceholderText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFplaceholderText
		{
			get
			{
				if(r_FplaceholderText == null)
				{
					r_FplaceholderText = new(this, "placeholderText");
				}
				return r_FplaceholderText;
			}
		}

		/// <summary>
		/// System.String submitButtonText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsubmitButtonText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsubmitButtonText
		{
			get
			{
				if(r_FsubmitButtonText == null)
				{
					r_FsubmitButtonText = new(this, "submitButtonText");
				}
				return r_FsubmitButtonText;
			}
		}

		/// <summary>
		/// System.String defaultValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FdefaultValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdefaultValue
		{
			get
			{
				if(r_FdefaultValue == null)
				{
					r_FdefaultValue = new(this, "defaultValue");
				}
				return r_FdefaultValue;
			}
		}

		/// <summary>
		/// System.Action`1[System.String] onInputSubmitted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString> r_FonInputSubmitted;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString> RFonInputSubmitted
		{
			get
			{
				if(r_FonInputSubmitted == null)
				{
					r_FonInputSubmitted = new(this, "onInputSubmitted");
				}
				return r_FonInputSubmitted;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEngine.Vector2] windowSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_FwindowSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RFwindowSize
		{
			get
			{
				if(r_FwindowSize == null)
				{
					r_FwindowSize = new(this, "windowSize");
				}
				return r_FwindowSize;
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
