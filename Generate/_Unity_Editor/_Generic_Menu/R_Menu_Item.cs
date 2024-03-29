
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{public partial class RGenericMenu
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.GenericMenu+MenuItem
	/// </summary>
    public partial class RMenuItem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.GenericMenu+MenuItem");
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


		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fcontent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFcontent
		{
			get
			{
				if(r_Fcontent == null)
				{
					r_Fcontent = new(this, "content");
				}
				return r_Fcontent;
			}
		}

		/// <summary>
		/// System.Boolean separator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fseparator;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFseparator
		{
			get
			{
				if(r_Fseparator == null)
				{
					r_Fseparator = new(this, "separator");
				}
				return r_Fseparator;
			}
		}

		/// <summary>
		/// System.Boolean on
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fon;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFon
		{
			get
			{
				if(r_Fon == null)
				{
					r_Fon = new(this, "on");
				}
				return r_Fon;
			}
		}

		/// <summary>
		/// UnityEditor.GenericMenu+MenuFunction func
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuFunction r_Ffunc;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuFunction RFfunc
		{
			get
			{
				if(r_Ffunc == null)
				{
					r_Ffunc = new(this, "func");
				}
				return r_Ffunc;
			}
		}

		/// <summary>
		/// UnityEditor.GenericMenu+MenuFunction2 func2
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuFunction2 r_Ffunc2;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RGenericMenu.RMenuFunction2 RFfunc2
		{
			get
			{
				if(r_Ffunc2 == null)
				{
					r_Ffunc2 = new(this, "func2");
				}
				return r_Ffunc2;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_FuserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFuserData
		{
			get
			{
				if(r_FuserData == null)
				{
					r_FuserData = new(this, "userData");
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
}