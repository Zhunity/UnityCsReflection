using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class RGenericMenu
{
	
	/// <summary>
	/// UnityEditor.GenericMenu+MenuItem
	/// </summary>
    public partial class RMenuItem : RMember //
    {

		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected RUnityEngine.RGUIContent r_content;
		public virtual RUnityEngine.RGUIContent Rcontent
		{
			get
			{
				if(r_content == null)
				{
					r_content = new(this, "content");
					r_content.SetBelong(this.instance);
				}
				return r_content;
			}
		}

		/// <summary>
		/// System.Boolean separator
		/// </summary>
		protected RField r_separator;
		public virtual RField Rseparator
		{
			get
			{
				if(r_separator == null)
				{
					r_separator = new(this, "separator");
					r_separator.SetBelong(this.instance);
				}
				return r_separator;
			}
		}

		/// <summary>
		/// System.Boolean on
		/// </summary>
		protected RField r_on;
		public virtual RField Ron
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
		/// UnityEditor.GenericMenu+MenuFunction func
		/// </summary>
		protected RUnityEditor.RGenericMenu.RMenuFunction r_func;
		public virtual RUnityEditor.RGenericMenu.RMenuFunction Rfunc
		{
			get
			{
				if(r_func == null)
				{
					r_func = new(this, "func");
					r_func.SetBelong(this.instance);
				}
				return r_func;
			}
		}

		/// <summary>
		/// UnityEditor.GenericMenu+MenuFunction2 func2
		/// </summary>
		protected RUnityEditor.RGenericMenu.RMenuFunction2 r_func2;
		public virtual RUnityEditor.RGenericMenu.RMenuFunction2 Rfunc2
		{
			get
			{
				if(r_func2 == null)
				{
					r_func2 = new(this, "func2");
					r_func2.SetBelong(this.instance);
				}
				return r_func2;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData");
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
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


        public RMenuItem() : base("UnityEditor.GenericMenu+MenuItem")
        {
        }

        public RMenuItem(System.Object instance) : base("UnityEditor.GenericMenu+MenuItem")
		{
            SetInstance(instance);
		}

        public RMenuItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMenuItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}