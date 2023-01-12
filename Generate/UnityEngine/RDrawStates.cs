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
		protected RSystem.RInt32 r_FcontrolId;
		public virtual RSystem.RInt32 RFcontrolId
		{
			get
			{
				if(r_FcontrolId == null)
				{
					r_FcontrolId = new(this, "controlId");
					r_FcontrolId.SetBelong(this.instance);
				}
				return r_FcontrolId;
			}
		}

		/// <summary>
		/// System.Boolean isHover
		/// </summary>
		protected RSystem.RBoolean r_FisHover;
		public virtual RSystem.RBoolean RFisHover
		{
			get
			{
				if(r_FisHover == null)
				{
					r_FisHover = new(this, "isHover");
					r_FisHover.SetBelong(this.instance);
				}
				return r_FisHover;
			}
		}

		/// <summary>
		/// System.Boolean isActive
		/// </summary>
		protected RSystem.RBoolean r_FisActive;
		public virtual RSystem.RBoolean RFisActive
		{
			get
			{
				if(r_FisActive == null)
				{
					r_FisActive = new(this, "isActive");
					r_FisActive.SetBelong(this.instance);
				}
				return r_FisActive;
			}
		}

		/// <summary>
		/// System.Boolean on
		/// </summary>
		protected RSystem.RBoolean r_Fon;
		public virtual RSystem.RBoolean RFon
		{
			get
			{
				if(r_Fon == null)
				{
					r_Fon = new(this, "on");
					r_Fon.SetBelong(this.instance);
				}
				return r_Fon;
			}
		}

		/// <summary>
		/// System.Boolean hasKeyboardFocus
		/// </summary>
		protected RSystem.RBoolean r_FhasKeyboardFocus;
		public virtual RSystem.RBoolean RFhasKeyboardFocus
		{
			get
			{
				if(r_FhasKeyboardFocus == null)
				{
					r_FhasKeyboardFocus = new(this, "hasKeyboardFocus");
					r_FhasKeyboardFocus.SetBelong(this.instance);
				}
				return r_FhasKeyboardFocus;
			}
		}

		/// <summary>
		/// System.Boolean hasTextInput
		/// </summary>
		protected RSystem.RBoolean r_FhasTextInput;
		public virtual RSystem.RBoolean RFhasTextInput
		{
			get
			{
				if(r_FhasTextInput == null)
				{
					r_FhasTextInput = new(this, "hasTextInput");
					r_FhasTextInput.SetBelong(this.instance);
				}
				return r_FhasTextInput;
			}
		}

		/// <summary>
		/// System.Boolean drawSelectionAsComposition
		/// </summary>
		protected RSystem.RBoolean r_FdrawSelectionAsComposition;
		public virtual RSystem.RBoolean RFdrawSelectionAsComposition
		{
			get
			{
				if(r_FdrawSelectionAsComposition == null)
				{
					r_FdrawSelectionAsComposition = new(this, "drawSelectionAsComposition");
					r_FdrawSelectionAsComposition.SetBelong(this.instance);
				}
				return r_FdrawSelectionAsComposition;
			}
		}

		/// <summary>
		/// System.Int32 cursorFirst
		/// </summary>
		protected RSystem.RInt32 r_FcursorFirst;
		public virtual RSystem.RInt32 RFcursorFirst
		{
			get
			{
				if(r_FcursorFirst == null)
				{
					r_FcursorFirst = new(this, "cursorFirst");
					r_FcursorFirst.SetBelong(this.instance);
				}
				return r_FcursorFirst;
			}
		}

		/// <summary>
		/// System.Int32 cursorLast
		/// </summary>
		protected RSystem.RInt32 r_FcursorLast;
		public virtual RSystem.RInt32 RFcursorLast
		{
			get
			{
				if(r_FcursorLast == null)
				{
					r_FcursorLast = new(this, "cursorLast");
					r_FcursorLast.SetBelong(this.instance);
				}
				return r_FcursorLast;
			}
		}

		/// <summary>
		/// UnityEngine.Color cursorColor
		/// </summary>
		protected RUnityEngine.RColor r_FcursorColor;
		public virtual RUnityEngine.RColor RFcursorColor
		{
			get
			{
				if(r_FcursorColor == null)
				{
					r_FcursorColor = new(this, "cursorColor");
					r_FcursorColor.SetBelong(this.instance);
				}
				return r_FcursorColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color selectionColor
		/// </summary>
		protected RUnityEngine.RColor r_FselectionColor;
		public virtual RUnityEngine.RColor RFselectionColor
		{
			get
			{
				if(r_FselectionColor == null)
				{
					r_FselectionColor = new(this, "selectionColor");
					r_FselectionColor.SetBelong(this.instance);
				}
				return r_FselectionColor;
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
