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
		protected RUnityEngine.RGUIContent r_Fcontent;
		public virtual RUnityEngine.RGUIContent RFcontent
		{
			get
			{
				if(r_Fcontent == null)
				{
					r_Fcontent = new(this, "content");
					r_Fcontent.SetBelong(this.instance);
				}
				return r_Fcontent;
			}
		}

		/// <summary>
		/// System.Boolean separator
		/// </summary>
		protected RSystem.RBoolean r_Fseparator;
		public virtual RSystem.RBoolean RFseparator
		{
			get
			{
				if(r_Fseparator == null)
				{
					r_Fseparator = new(this, "separator");
					r_Fseparator.SetBelong(this.instance);
				}
				return r_Fseparator;
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
		/// UnityEditor.GenericMenu+MenuFunction func
		/// </summary>
		protected RUnityEditor.RGenericMenu.RMenuFunction r_Ffunc;
		public virtual RUnityEditor.RGenericMenu.RMenuFunction RFfunc
		{
			get
			{
				if(r_Ffunc == null)
				{
					r_Ffunc = new(this, "func");
					r_Ffunc.SetBelong(this.instance);
				}
				return r_Ffunc;
			}
		}

		/// <summary>
		/// UnityEditor.GenericMenu+MenuFunction2 func2
		/// </summary>
		protected RUnityEditor.RGenericMenu.RMenuFunction2 r_Ffunc2;
		public virtual RUnityEditor.RGenericMenu.RMenuFunction2 RFfunc2
		{
			get
			{
				if(r_Ffunc2 == null)
				{
					r_Ffunc2 = new(this, "func2");
					r_Ffunc2.SetBelong(this.instance);
				}
				return r_Ffunc2;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_FuserData;
		public virtual RSystem.RObject RFuserData
		{
			get
			{
				if(r_FuserData == null)
				{
					r_FuserData = new(this, "userData");
					r_FuserData.SetBelong(this.instance);
				}
				return r_FuserData;
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
}