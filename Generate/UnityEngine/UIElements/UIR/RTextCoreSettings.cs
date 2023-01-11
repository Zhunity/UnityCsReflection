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
		protected RSystem.RSingle r_outlineWidth;
		public virtual RSystem.RSingle RoutlineWidth
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
		protected RSystem.RSingle r_underlaySoftness;
		public virtual RSystem.RSingle RunderlaySoftness
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
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_Equals_TextCoreSettings;
		public virtual RMethod REquals_TextCoreSettings
		{
			get
			{
				if(r_Equals_TextCoreSettings == null)
				{
					r_Equals_TextCoreSettings = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_Equals_TextCoreSettings.SetBelong(this.instance);
				}
				return r_Equals_TextCoreSettings;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RUnityEngine.RUIElements.RUIR.RTextCoreSettings @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_TextCoreSettings.Invoke(___genericsType, ___parameters);

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
