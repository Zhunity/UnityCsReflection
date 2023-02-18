
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ScriptableObject
	/// </summary>
    public partial class RScriptableObject : RMember //
    {

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
		/// UnityEngine.ScriptableObject CreateInstance(System.String)
		/// </summary>
		protected static RMethod r_MCreateInstance_String;
		public static RMethod RMCreateInstance_String
		{
			get
			{
				if(r_MCreateInstance_String == null)
				{
					r_MCreateInstance_String = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.String));
				}
				return r_MCreateInstance_String;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.Type)
		/// </summary>
		protected static RMethod r_MCreateInstance_Type;
		public static RMethod RMCreateInstance_Type
		{
			get
			{
				if(r_MCreateInstance_Type == null)
				{
					r_MCreateInstance_Type = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.Type));
				}
				return r_MCreateInstance_Type;
			}
		}

		/// <summary>
		/// T CreateInstance[T]()
		/// </summary>
		protected static RMethod r_MCreateInstance_GT;
		public static RMethod RMCreateInstance_GT
		{
			get
			{
				if(r_MCreateInstance_GT == null)
				{
					r_MCreateInstance_GT = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 1);
				}
				return r_MCreateInstance_GT;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.Type, System.Action`1[UnityEngine.ScriptableObject])
		/// </summary>
		protected static RMethod r_MCreateInstance_Type_Action_d_ScriptableObject_p_;
		public static RMethod RMCreateInstance_Type_Action_d_ScriptableObject_p_
		{
			get
			{
				if(r_MCreateInstance_Type_Action_d_ScriptableObject_p_ == null)
				{
					r_MCreateInstance_Type_Action_d_ScriptableObject_p_ = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.Type), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.ScriptableObject)));
				}
				return r_MCreateInstance_Type_Action_d_ScriptableObject_p_;
			}
		}

		/// <summary>
		/// Void CreateScriptableObject(UnityEngine.ScriptableObject)
		/// </summary>
		protected static RMethod r_MCreateScriptableObject_ScriptableObject;
		public static RMethod RMCreateScriptableObject_ScriptableObject
		{
			get
			{
				if(r_MCreateScriptableObject_ScriptableObject == null)
				{
					r_MCreateScriptableObject_ScriptableObject = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObject", 0, typeof(UnityEngine.ScriptableObject));
				}
				return r_MCreateScriptableObject_ScriptableObject;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String)
		/// </summary>
		protected static RMethod r_MCreateScriptableObjectInstanceFromName_String;
		public static RMethod RMCreateScriptableObjectInstanceFromName_String
		{
			get
			{
				if(r_MCreateScriptableObjectInstanceFromName_String == null)
				{
					r_MCreateScriptableObjectInstanceFromName_String = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObjectInstanceFromName", 0, typeof(System.String));
				}
				return r_MCreateScriptableObjectInstanceFromName_String;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_MCreateScriptableObjectInstanceFromType_Type_Boolean;
		public static RMethod RMCreateScriptableObjectInstanceFromType_Type_Boolean
		{
			get
			{
				if(r_MCreateScriptableObjectInstanceFromType_Type_Boolean == null)
				{
					r_MCreateScriptableObjectInstanceFromType_Type_Boolean = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObjectInstanceFromType", 0, typeof(System.Type), typeof(System.Boolean));
				}
				return r_MCreateScriptableObjectInstanceFromType_Type_Boolean;
			}
		}

		/// <summary>
		/// Void ResetAndApplyDefaultInstances(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MResetAndApplyDefaultInstances_Object;
		public static RMethod RMResetAndApplyDefaultInstances_Object
		{
			get
			{
				if(r_MResetAndApplyDefaultInstances_Object == null)
				{
					r_MResetAndApplyDefaultInstances_Object = new(typeof(UnityEngine.ScriptableObject), "ResetAndApplyDefaultInstances", 0, typeof(UnityEngine.Object));
				}
				return r_MResetAndApplyDefaultInstances_Object;
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


        public RScriptableObject() : base("UnityEngine.ScriptableObject")
        {
        }

        public RScriptableObject(System.Object instance) : base("UnityEngine.ScriptableObject")
		{
            SetInstance(instance);
		}

        public RScriptableObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScriptableObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.ScriptableObject CreateInstance(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMCreateInstance_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static UnityEngine.ScriptableObject CreateInstance(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMCreateInstance_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static T CreateInstance<T>() where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMCreateInstance_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static UnityEngine.ScriptableObject CreateInstance(System.Type @type, System.Action<UnityEngine.ScriptableObject> @initialize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @initialize};
            var ___result = RMCreateInstance_Type_Action_d_ScriptableObject_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static void CreateScriptableObject(UnityEngine.ScriptableObject @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMCreateScriptableObject_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMCreateScriptableObjectInstanceFromName_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type @type, System.Boolean @applyDefaultsAndReset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @applyDefaultsAndReset};
            var ___result = RMCreateScriptableObjectInstanceFromType_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static void ResetAndApplyDefaultInstances(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMResetAndApplyDefaultInstances_Object.Invoke(___genericsType, ___parameters);

            
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
