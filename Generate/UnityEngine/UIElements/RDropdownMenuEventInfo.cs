using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DropdownMenuEventInfo
	/// </summary>
    public partial class RDropdownMenuEventInfo : RMember //
    {

		/// <summary>
		/// UnityEngine.EventModifiers <modifiers>k__BackingField
		/// </summary>
		protected RField r___1__modifiers__2__k__BackingField;
		public virtual RField R__1__modifiers__2__k__BackingField
		{
			get
			{
				if(r___1__modifiers__2__k__BackingField == null)
				{
					r___1__modifiers__2__k__BackingField = new(this, "<modifiers>k__BackingField");
					r___1__modifiers__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__modifiers__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <mousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___1__mousePosition__2__k__BackingField;
		public virtual RUnityEngine.RVector2 R__1__mousePosition__2__k__BackingField
		{
			get
			{
				if(r___1__mousePosition__2__k__BackingField == null)
				{
					r___1__mousePosition__2__k__BackingField = new(this, "<mousePosition>k__BackingField");
					r___1__mousePosition__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__mousePosition__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <localMousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___1__localMousePosition__2__k__BackingField;
		public virtual RUnityEngine.RVector2 R__1__localMousePosition__2__k__BackingField
		{
			get
			{
				if(r___1__localMousePosition__2__k__BackingField == null)
				{
					r___1__localMousePosition__2__k__BackingField = new(this, "<localMousePosition>k__BackingField");
					r___1__localMousePosition__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__localMousePosition__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Char <character>k__BackingField
		/// </summary>
		protected RField r___1__character__2__k__BackingField;
		public virtual RField R__1__character__2__k__BackingField
		{
			get
			{
				if(r___1__character__2__k__BackingField == null)
				{
					r___1__character__2__k__BackingField = new(this, "<character>k__BackingField");
					r___1__character__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__character__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode <keyCode>k__BackingField
		/// </summary>
		protected RField r___1__keyCode__2__k__BackingField;
		public virtual RField R__1__keyCode__2__k__BackingField
		{
			get
			{
				if(r___1__keyCode__2__k__BackingField == null)
				{
					r___1__keyCode__2__k__BackingField = new(this, "<keyCode>k__BackingField");
					r___1__keyCode__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__keyCode__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RProperty r_modifiers;
		public virtual RProperty Rmodifiers
		{
			get
			{
				if(r_modifiers == null)
				{
					r_modifiers = new(this, "modifiers", -1);
					r_modifiers.SetBelong(this.instance);
				}
				return r_modifiers;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_mousePosition;
		public virtual RUnityEngine.RVector2 RmousePosition
		{
			get
			{
				if(r_mousePosition == null)
				{
					r_mousePosition = new(this, "mousePosition", -1);
					r_mousePosition.SetBelong(this.instance);
				}
				return r_mousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 localMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_localMousePosition;
		public virtual RUnityEngine.RVector2 RlocalMousePosition
		{
			get
			{
				if(r_localMousePosition == null)
				{
					r_localMousePosition = new(this, "localMousePosition", -1);
					r_localMousePosition.SetBelong(this.instance);
				}
				return r_localMousePosition;
			}
		}

		/// <summary>
		/// Char character
		/// </summary>
		protected RProperty r_character;
		public virtual RProperty Rcharacter
		{
			get
			{
				if(r_character == null)
				{
					r_character = new(this, "character", -1);
					r_character.SetBelong(this.instance);
				}
				return r_character;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode keyCode
		/// </summary>
		protected RProperty r_keyCode;
		public virtual RProperty RkeyCode
		{
			get
			{
				if(r_keyCode == null)
				{
					r_keyCode = new(this, "keyCode", -1);
					r_keyCode.SetBelong(this.instance);
				}
				return r_keyCode;
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


        public RDropdownMenuEventInfo() : base("UnityEngine.UIElements.DropdownMenuEventInfo")
        {
        }

        public RDropdownMenuEventInfo(System.Object instance) : base("UnityEngine.UIElements.DropdownMenuEventInfo")
		{
            SetInstance(instance);
		}

        public RDropdownMenuEventInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDropdownMenuEventInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
