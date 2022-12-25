using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.TextCoreSettings
	/// </summary>
    public partial class RTextCoreSettings : RMember //
    {

		/// <summary>
		/// UnityEngine.Color faceColor
		/// </summary>
		protected RUnityEngine.RColor r_faceColor;
		public virtual RUnityEngine.RColor RfaceColor
		{
			get
			{
				if(r_faceColor == null)
				{
					r_faceColor = new(this, "faceColor");
					r_faceColor.SetBelong(this.instance);
				}
				return r_faceColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color outlineColor
		/// </summary>
		protected RUnityEngine.RColor r_outlineColor;
		public virtual RUnityEngine.RColor RoutlineColor
		{
			get
			{
				if(r_outlineColor == null)
				{
					r_outlineColor = new(this, "outlineColor");
					r_outlineColor.SetBelong(this.instance);
				}
				return r_outlineColor;
			}
		}

		/// <summary>
		/// System.Single outlineWidth
		/// </summary>
		protected RField r_outlineWidth;
		public virtual RField RoutlineWidth
		{
			get
			{
				if(r_outlineWidth == null)
				{
					r_outlineWidth = new(this, "outlineWidth");
					r_outlineWidth.SetBelong(this.instance);
				}
				return r_outlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color underlayColor
		/// </summary>
		protected RUnityEngine.RColor r_underlayColor;
		public virtual RUnityEngine.RColor RunderlayColor
		{
			get
			{
				if(r_underlayColor == null)
				{
					r_underlayColor = new(this, "underlayColor");
					r_underlayColor.SetBelong(this.instance);
				}
				return r_underlayColor;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 underlayOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_underlayOffset;
		public virtual RUnityEngine.RVector2 RunderlayOffset
		{
			get
			{
				if(r_underlayOffset == null)
				{
					r_underlayOffset = new(this, "underlayOffset");
					r_underlayOffset.SetBelong(this.instance);
				}
				return r_underlayOffset;
			}
		}

		/// <summary>
		/// System.Single underlaySoftness
		/// </summary>
		protected RField r_underlaySoftness;
		public virtual RField RunderlaySoftness
		{
			get
			{
				if(r_underlaySoftness == null)
				{
					r_underlaySoftness = new(this, "underlaySoftness");
					r_underlaySoftness.SetBelong(this.instance);
				}
				return r_underlaySoftness;
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
		/// Boolean Equals(UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_REquals_TextCoreSettings;
		public virtual RMethod REquals_TextCoreSettings
		{
			get
			{
				if(r_REquals_TextCoreSettings == null)
				{
					r_REquals_TextCoreSettings = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_REquals_TextCoreSettings.SetBelong(this.instance);
				}
				return r_REquals_TextCoreSettings;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
