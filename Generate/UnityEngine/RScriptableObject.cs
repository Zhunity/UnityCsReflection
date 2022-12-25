using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ScriptableObject
	/// </summary>
    public partial class RScriptableObject : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.String)
		/// </summary>
		protected static RMethod r_RCreateInstance_String;
		public static RMethod RCreateInstance_String
		{
			get
			{
				if(r_RCreateInstance_String == null)
				{
					r_RCreateInstance_String = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.String));
					r_RCreateInstance_String.SetBelong(null);
				}
				return r_RCreateInstance_String;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.Type)
		/// </summary>
		protected static RMethod r_RCreateInstance_Type;
		public static RMethod RCreateInstance_Type
		{
			get
			{
				if(r_RCreateInstance_Type == null)
				{
					r_RCreateInstance_Type = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.Type));
					r_RCreateInstance_Type.SetBelong(null);
				}
				return r_RCreateInstance_Type;
			}
		}

		/// <summary>
		/// T CreateInstance[T]()
		/// </summary>
		protected static RMethod r_RCreateInstance_GT;
		public static RMethod RCreateInstance_GT
		{
			get
			{
				if(r_RCreateInstance_GT == null)
				{
					r_RCreateInstance_GT = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 1);
					r_RCreateInstance_GT.SetBelong(null);
				}
				return r_RCreateInstance_GT;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.Type, System.Action`1[UnityEngine.ScriptableObject])
		/// </summary>
		protected static RMethod r_RCreateInstance_Type_Action_d_ScriptableObject_p_;
		public static RMethod RCreateInstance_Type_Action_d_ScriptableObject_p_
		{
			get
			{
				if(r_RCreateInstance_Type_Action_d_ScriptableObject_p_ == null)
				{
					r_RCreateInstance_Type_Action_d_ScriptableObject_p_ = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.Type), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.ScriptableObject)));
					r_RCreateInstance_Type_Action_d_ScriptableObject_p_.SetBelong(null);
				}
				return r_RCreateInstance_Type_Action_d_ScriptableObject_p_;
			}
		}

		/// <summary>
		/// Void CreateScriptableObject(UnityEngine.ScriptableObject)
		/// </summary>
		protected static RMethod r_RCreateScriptableObject_ScriptableObject;
		public static RMethod RCreateScriptableObject_ScriptableObject
		{
			get
			{
				if(r_RCreateScriptableObject_ScriptableObject == null)
				{
					r_RCreateScriptableObject_ScriptableObject = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObject", 0, typeof(UnityEngine.ScriptableObject));
					r_RCreateScriptableObject_ScriptableObject.SetBelong(null);
				}
				return r_RCreateScriptableObject_ScriptableObject;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String)
		/// </summary>
		protected static RMethod r_RCreateScriptableObjectInstanceFromName_String;
		public static RMethod RCreateScriptableObjectInstanceFromName_String
		{
			get
			{
				if(r_RCreateScriptableObjectInstanceFromName_String == null)
				{
					r_RCreateScriptableObjectInstanceFromName_String = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObjectInstanceFromName", 0, typeof(System.String));
					r_RCreateScriptableObjectInstanceFromName_String.SetBelong(null);
				}
				return r_RCreateScriptableObjectInstanceFromName_String;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_RCreateScriptableObjectInstanceFromType_Type_Boolean;
		public static RMethod RCreateScriptableObjectInstanceFromType_Type_Boolean
		{
			get
			{
				if(r_RCreateScriptableObjectInstanceFromType_Type_Boolean == null)
				{
					r_RCreateScriptableObjectInstanceFromType_Type_Boolean = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObjectInstanceFromType", 0, typeof(System.Type), typeof(System.Boolean));
					r_RCreateScriptableObjectInstanceFromType_Type_Boolean.SetBelong(null);
				}
				return r_RCreateScriptableObjectInstanceFromType_Type_Boolean;
			}
		}

		/// <summary>
		/// Void ResetAndApplyDefaultInstances(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_RResetAndApplyDefaultInstances_Object;
		public static RMethod RResetAndApplyDefaultInstances_Object
		{
			get
			{
				if(r_RResetAndApplyDefaultInstances_Object == null)
				{
					r_RResetAndApplyDefaultInstances_Object = new(typeof(UnityEngine.ScriptableObject), "ResetAndApplyDefaultInstances", 0, typeof(UnityEngine.Object));
					r_RResetAndApplyDefaultInstances_Object.SetBelong(null);
				}
				return r_RResetAndApplyDefaultInstances_Object;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.ScriptableObject CreateInstance(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RCreateInstance_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static UnityEngine.ScriptableObject CreateInstance(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RCreateInstance_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static T CreateInstance<T>() where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RCreateInstance_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public static UnityEngine.ScriptableObject CreateInstance(System.Type  @type, System.Action<UnityEngine.ScriptableObject>  @initialize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @initialize};
            var ___result = RCreateInstance_Type_Action_d_ScriptableObject_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static void CreateScriptableObject(UnityEngine.ScriptableObject  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RCreateScriptableObject_ScriptableObject.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RCreateScriptableObjectInstanceFromName_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type  @type, System.Boolean  @applyDefaultsAndReset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @applyDefaultsAndReset};
            var ___result = RCreateScriptableObjectInstanceFromType_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.ScriptableObject)___result;
        }


        public static void ResetAndApplyDefaultInstances(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RResetAndApplyDefaultInstances_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
