
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextColorGradient
	/// </summary>
    public partial class RTextColorGradient : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.TextColorGradient);
            }
        }

        public RTextColorGradient() : base("UnityEngine.TextCore.Text.TextColorGradient")
        {
        }

        public RTextColorGradient(System.Object instance) : base("UnityEngine.TextCore.Text.TextColorGradient")
		{
            SetInstance(instance);
		}

        public RTextColorGradient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextColorGradient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.TextCore.Text.ColorGradientMode colorMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RColorGradientMode r_FcolorMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RColorGradientMode RFcolorMode
		{
			get
			{
				if(r_FcolorMode == null)
				{
					r_FcolorMode = new(this, "colorMode");
				}
				return r_FcolorMode;
			}
		}

		/// <summary>
		/// UnityEngine.Color topLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FtopLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFtopLeft
		{
			get
			{
				if(r_FtopLeft == null)
				{
					r_FtopLeft = new(this, "topLeft");
				}
				return r_FtopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Color topRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FtopRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFtopRight
		{
			get
			{
				if(r_FtopRight == null)
				{
					r_FtopRight = new(this, "topRight");
				}
				return r_FtopRight;
			}
		}

		/// <summary>
		/// UnityEngine.Color bottomLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FbottomLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFbottomLeft
		{
			get
			{
				if(r_FbottomLeft == null)
				{
					r_FbottomLeft = new(this, "bottomLeft");
				}
				return r_FbottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Color bottomRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FbottomRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFbottomRight
		{
			get
			{
				if(r_FbottomRight == null)
				{
					r_FbottomRight = new(this, "bottomRight");
				}
				return r_FbottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.ColorGradientMode k_DefaultColorMode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RColorGradientMode r_Fk_DefaultColorMode;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RColorGradientMode RFk_DefaultColorMode
		{
			get
			{
				if(r_Fk_DefaultColorMode == null)
				{
					r_Fk_DefaultColorMode = new(typeof(UnityEngine.TextCore.Text.TextColorGradient), "k_DefaultColorMode");
				}
				return r_Fk_DefaultColorMode;
			}
		}

		/// <summary>
		/// UnityEngine.Color k_DefaultColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor r_Fk_DefaultColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor RFk_DefaultColor
		{
			get
			{
				if(r_Fk_DefaultColor == null)
				{
					r_Fk_DefaultColor = new(typeof(UnityEngine.TextCore.Text.TextColorGradient), "k_DefaultColor");
				}
				return r_Fk_DefaultColor;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
