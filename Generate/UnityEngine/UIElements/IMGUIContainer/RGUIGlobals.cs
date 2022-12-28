using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RIMGUIContainer
{
	
	/// <summary>
	/// UnityEngine.UIElements.IMGUIContainer+GUIGlobals
	/// </summary>
    public partial class RGUIGlobals : RMember //
    {

		/// <summary>
		/// UnityEngine.Matrix4x4 matrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_matrix;
		public virtual RUnityEngine.RMatrix4x4 Rmatrix
		{
			get
			{
				if(r_matrix == null)
				{
					r_matrix = new(this, "matrix");
					r_matrix.SetBelong(this.instance);
				}
				return r_matrix;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.Color contentColor
		/// </summary>
		protected RUnityEngine.RColor r_contentColor;
		public virtual RUnityEngine.RColor RcontentColor
		{
			get
			{
				if(r_contentColor == null)
				{
					r_contentColor = new(this, "contentColor");
					r_contentColor.SetBelong(this.instance);
				}
				return r_contentColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_backgroundColor;
		public virtual RUnityEngine.RColor RbackgroundColor
		{
			get
			{
				if(r_backgroundColor == null)
				{
					r_backgroundColor = new(this, "backgroundColor");
					r_backgroundColor.SetBelong(this.instance);
				}
				return r_backgroundColor;
			}
		}

		/// <summary>
		/// System.Boolean enabled
		/// </summary>
		protected RField r_enabled;
		public virtual RField Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled");
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// System.Boolean changed
		/// </summary>
		protected RField r_changed;
		public virtual RField Rchanged
		{
			get
			{
				if(r_changed == null)
				{
					r_changed = new(this, "changed");
					r_changed.SetBelong(this.instance);
				}
				return r_changed;
			}
		}

		/// <summary>
		/// System.Int32 displayIndex
		/// </summary>
		protected RField r_displayIndex;
		public virtual RField RdisplayIndex
		{
			get
			{
				if(r_displayIndex == null)
				{
					r_displayIndex = new(this, "displayIndex");
					r_displayIndex.SetBelong(this.instance);
				}
				return r_displayIndex;
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


        public RGUIGlobals() : base("UnityEngine.UIElements.IMGUIContainer+GUIGlobals")
        {
        }

        public RGUIGlobals(System.Object instance) : base("UnityEngine.UIElements.IMGUIContainer+GUIGlobals")
		{
            SetInstance(instance);
		}

        public RGUIGlobals(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIGlobals(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}