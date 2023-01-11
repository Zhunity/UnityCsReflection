using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.DrawStates
	/// </summary>
    public partial class RDrawStates : RMember //
    {

		/// <summary>
		/// System.Int32 controlId
		/// </summary>
		protected RSystem.RInt32 r_controlId;
		public virtual RSystem.RInt32 RcontrolId
		{
			get
			{
				if(r_controlId == null)
				{
					r_controlId = new(this, "controlId");
					r_controlId.SetBelong(this.instance);
				}
				return r_controlId;
			}
		}

		/// <summary>
		/// System.Boolean isHover
		/// </summary>
		protected RSystem.RBoolean r_isHover;
		public virtual RSystem.RBoolean RisHover
		{
			get
			{
				if(r_isHover == null)
				{
					r_isHover = new(this, "isHover");
					r_isHover.SetBelong(this.instance);
				}
				return r_isHover;
			}
		}

		/// <summary>
		/// System.Boolean isActive
		/// </summary>
		protected RSystem.RBoolean r_isActive;
		public virtual RSystem.RBoolean RisActive
		{
			get
			{
				if(r_isActive == null)
				{
					r_isActive = new(this, "isActive");
					r_isActive.SetBelong(this.instance);
				}
				return r_isActive;
			}
		}

		/// <summary>
		/// System.Boolean on
		/// </summary>
		protected RSystem.RBoolean r_on;
		public virtual RSystem.RBoolean Ron
		{
			get
			{
				if(r_on == null)
				{
					r_on = new(this, "on");
					r_on.SetBelong(this.instance);
				}
				return r_on;
			}
		}

		/// <summary>
		/// System.Boolean hasKeyboardFocus
		/// </summary>
		protected RSystem.RBoolean r_hasKeyboardFocus;
		public virtual RSystem.RBoolean RhasKeyboardFocus
		{
			get
			{
				if(r_hasKeyboardFocus == null)
				{
					r_hasKeyboardFocus = new(this, "hasKeyboardFocus");
					r_hasKeyboardFocus.SetBelong(this.instance);
				}
				return r_hasKeyboardFocus;
			}
		}

		/// <summary>
		/// System.Boolean hasTextInput
		/// </summary>
		protected RSystem.RBoolean r_hasTextInput;
		public virtual RSystem.RBoolean RhasTextInput
		{
			get
			{
				if(r_hasTextInput == null)
				{
					r_hasTextInput = new(this, "hasTextInput");
					r_hasTextInput.SetBelong(this.instance);
				}
				return r_hasTextInput;
			}
		}

		/// <summary>
		/// System.Boolean drawSelectionAsComposition
		/// </summary>
		protected RSystem.RBoolean r_drawSelectionAsComposition;
		public virtual RSystem.RBoolean RdrawSelectionAsComposition
		{
			get
			{
				if(r_drawSelectionAsComposition == null)
				{
					r_drawSelectionAsComposition = new(this, "drawSelectionAsComposition");
					r_drawSelectionAsComposition.SetBelong(this.instance);
				}
				return r_drawSelectionAsComposition;
			}
		}

		/// <summary>
		/// System.Int32 cursorFirst
		/// </summary>
		protected RSystem.RInt32 r_cursorFirst;
		public virtual RSystem.RInt32 RcursorFirst
		{
			get
			{
				if(r_cursorFirst == null)
				{
					r_cursorFirst = new(this, "cursorFirst");
					r_cursorFirst.SetBelong(this.instance);
				}
				return r_cursorFirst;
			}
		}

		/// <summary>
		/// System.Int32 cursorLast
		/// </summary>
		protected RSystem.RInt32 r_cursorLast;
		public virtual RSystem.RInt32 RcursorLast
		{
			get
			{
				if(r_cursorLast == null)
				{
					r_cursorLast = new(this, "cursorLast");
					r_cursorLast.SetBelong(this.instance);
				}
				return r_cursorLast;
			}
		}

		/// <summary>
		/// UnityEngine.Color cursorColor
		/// </summary>
		protected RUnityEngine.RColor r_cursorColor;
		public virtual RUnityEngine.RColor RcursorColor
		{
			get
			{
				if(r_cursorColor == null)
				{
					r_cursorColor = new(this, "cursorColor");
					r_cursorColor.SetBelong(this.instance);
				}
				return r_cursorColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color selectionColor
		/// </summary>
		protected RUnityEngine.RColor r_selectionColor;
		public virtual RUnityEngine.RColor RselectionColor
		{
			get
			{
				if(r_selectionColor == null)
				{
					r_selectionColor = new(this, "selectionColor");
					r_selectionColor.SetBelong(this.instance);
				}
				return r_selectionColor;
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


        public RDrawStates() : base("UnityEngine.DrawStates")
        {
        }

        public RDrawStates(System.Object instance) : base("UnityEngine.DrawStates")
		{
            SetInstance(instance);
		}

        public RDrawStates(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDrawStates(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
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
