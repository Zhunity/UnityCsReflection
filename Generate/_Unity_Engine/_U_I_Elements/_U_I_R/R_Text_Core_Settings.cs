
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.TextCoreSettings
	/// </summary>
    public partial class RTextCoreSettings : RMember //
    {

		/// <summary>
		/// UnityEngine.Color faceColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FfaceColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFfaceColor
		{
			get
			{
				if(r_FfaceColor == null)
				{
					r_FfaceColor = new(this, "faceColor");
				}
				return r_FfaceColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color outlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FoutlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFoutlineColor
		{
			get
			{
				if(r_FoutlineColor == null)
				{
					r_FoutlineColor = new(this, "outlineColor");
				}
				return r_FoutlineColor;
			}
		}

		/// <summary>
		/// System.Single outlineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FoutlineWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFoutlineWidth
		{
			get
			{
				if(r_FoutlineWidth == null)
				{
					r_FoutlineWidth = new(this, "outlineWidth");
				}
				return r_FoutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color underlayColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FunderlayColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFunderlayColor
		{
			get
			{
				if(r_FunderlayColor == null)
				{
					r_FunderlayColor = new(this, "underlayColor");
				}
				return r_FunderlayColor;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 underlayOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FunderlayOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFunderlayOffset
		{
			get
			{
				if(r_FunderlayOffset == null)
				{
					r_FunderlayOffset = new(this, "underlayOffset");
				}
				return r_FunderlayOffset;
			}
		}

		/// <summary>
		/// System.Single underlaySoftness
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FunderlaySoftness;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFunderlaySoftness
		{
			get
			{
				if(r_FunderlaySoftness == null)
				{
					r_FunderlaySoftness = new(this, "underlaySoftness");
				}
				return r_FunderlaySoftness;
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
		/// Boolean Equals(UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_MEquals_TextCoreSettings;
		public virtual RMethod RMEquals_TextCoreSettings
		{
			get
			{
				if(r_MEquals_TextCoreSettings == null)
				{
					r_MEquals_TextCoreSettings = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
				}
				return r_MEquals_TextCoreSettings;
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


        public RTextCoreSettings() : base("UnityEngine.UIElements.UIR.TextCoreSettings")
        {
        }

        public RTextCoreSettings(System.Object instance) : base("UnityEngine.UIElements.UIR.TextCoreSettings")
		{
            SetInstance(instance);
		}

        public RTextCoreSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextCoreSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextCoreSettings @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_TextCoreSettings.Invoke(___genericsType, ___parameters);

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
