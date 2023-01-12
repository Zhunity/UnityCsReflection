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
		protected RUnityEngine.REventModifiers r_F__0__modifiers__1__k__BackingField;
		public virtual RUnityEngine.REventModifiers RF__0__modifiers__1__k__BackingField
		{
			get
			{
				if(r_F__0__modifiers__1__k__BackingField == null)
				{
					r_F__0__modifiers__1__k__BackingField = new(this, "<modifiers>k__BackingField");
					r_F__0__modifiers__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__modifiers__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <mousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r_F__0__mousePosition__1__k__BackingField;
		public virtual RUnityEngine.RVector2 RF__0__mousePosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__mousePosition__1__k__BackingField == null)
				{
					r_F__0__mousePosition__1__k__BackingField = new(this, "<mousePosition>k__BackingField");
					r_F__0__mousePosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__mousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <localMousePosition>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r_F__0__localMousePosition__1__k__BackingField;
		public virtual RUnityEngine.RVector2 RF__0__localMousePosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__localMousePosition__1__k__BackingField == null)
				{
					r_F__0__localMousePosition__1__k__BackingField = new(this, "<localMousePosition>k__BackingField");
					r_F__0__localMousePosition__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__localMousePosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Char <character>k__BackingField
		/// </summary>
		protected RSystem.RChar r_F__0__character__1__k__BackingField;
		public virtual RSystem.RChar RF__0__character__1__k__BackingField
		{
			get
			{
				if(r_F__0__character__1__k__BackingField == null)
				{
					r_F__0__character__1__k__BackingField = new(this, "<character>k__BackingField");
					r_F__0__character__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__character__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode <keyCode>k__BackingField
		/// </summary>
		protected RUnityEngine.RKeyCode r_F__0__keyCode__1__k__BackingField;
		public virtual RUnityEngine.RKeyCode RF__0__keyCode__1__k__BackingField
		{
			get
			{
				if(r_F__0__keyCode__1__k__BackingField == null)
				{
					r_F__0__keyCode__1__k__BackingField = new(this, "<keyCode>k__BackingField");
					r_F__0__keyCode__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__keyCode__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
					r_Pmodifiers.SetBelong(this.instance);
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PmousePosition;
		public virtual RUnityEngine.RVector2 RPmousePosition
		{
			get
			{
				if(r_PmousePosition == null)
				{
					r_PmousePosition = new(this, "mousePosition", -1);
					r_PmousePosition.SetBelong(this.instance);
				}
				return r_PmousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 localMousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PlocalMousePosition;
		public virtual RUnityEngine.RVector2 RPlocalMousePosition
		{
			get
			{
				if(r_PlocalMousePosition == null)
				{
					r_PlocalMousePosition = new(this, "localMousePosition", -1);
					r_PlocalMousePosition.SetBelong(this.instance);
				}
				return r_PlocalMousePosition;
			}
		}

		/// <summary>
		/// Char character
		/// </summary>
		protected RSystem.RChar r_Pcharacter;
		public virtual RSystem.RChar RPcharacter
		{
			get
			{
				if(r_Pcharacter == null)
				{
					r_Pcharacter = new(this, "character", -1);
					r_Pcharacter.SetBelong(this.instance);
				}
				return r_Pcharacter;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode keyCode
		/// </summary>
		protected RUnityEngine.RKeyCode r_PkeyCode;
		public virtual RUnityEngine.RKeyCode RPkeyCode
		{
			get
			{
				if(r_PkeyCode == null)
				{
					r_PkeyCode = new(this, "keyCode", -1);
					r_PkeyCode.SetBelong(this.instance);
				}
				return r_PkeyCode;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
