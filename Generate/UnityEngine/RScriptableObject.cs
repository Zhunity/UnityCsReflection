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
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.String)
		/// </summary>
		protected static RMethod r_CreateInstance_String;
		public static RMethod RCreateInstance_String
		{
			get
			{
				if(r_CreateInstance_String == null)
				{
					r_CreateInstance_String = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.String));
					r_CreateInstance_String.SetBelong(null);
				}
				return r_CreateInstance_String;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.Type)
		/// </summary>
		protected static RMethod r_CreateInstance_Type;
		public static RMethod RCreateInstance_Type
		{
			get
			{
				if(r_CreateInstance_Type == null)
				{
					r_CreateInstance_Type = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.Type));
					r_CreateInstance_Type.SetBelong(null);
				}
				return r_CreateInstance_Type;
			}
		}

		/// <summary>
		/// T CreateInstance[T]()
		/// </summary>
		protected static RMethod r_CreateInstance_GT;
		public static RMethod RCreateInstance_GT
		{
			get
			{
				if(r_CreateInstance_GT == null)
				{
					r_CreateInstance_GT = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 1);
					r_CreateInstance_GT.SetBelong(null);
				}
				return r_CreateInstance_GT;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateInstance(System.Type, System.Action`1[UnityEngine.ScriptableObject])
		/// </summary>
		protected static RMethod r_CreateInstance_Type_Action_d_ScriptableObject_p_;
		public static RMethod RCreateInstance_Type_Action_d_ScriptableObject_p_
		{
			get
			{
				if(r_CreateInstance_Type_Action_d_ScriptableObject_p_ == null)
				{
					r_CreateInstance_Type_Action_d_ScriptableObject_p_ = new(typeof(UnityEngine.ScriptableObject), "CreateInstance", 0, typeof(System.Type), typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.ScriptableObject)));
					r_CreateInstance_Type_Action_d_ScriptableObject_p_.SetBelong(null);
				}
				return r_CreateInstance_Type_Action_d_ScriptableObject_p_;
			}
		}

		/// <summary>
		/// Void CreateScriptableObject(UnityEngine.ScriptableObject)
		/// </summary>
		protected static RMethod r_CreateScriptableObject_ScriptableObject;
		public static RMethod RCreateScriptableObject_ScriptableObject
		{
			get
			{
				if(r_CreateScriptableObject_ScriptableObject == null)
				{
					r_CreateScriptableObject_ScriptableObject = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObject", 0, typeof(UnityEngine.ScriptableObject));
					r_CreateScriptableObject_ScriptableObject.SetBelong(null);
				}
				return r_CreateScriptableObject_ScriptableObject;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String)
		/// </summary>
		protected static RMethod r_CreateScriptableObjectInstanceFromName_String;
		public static RMethod RCreateScriptableObjectInstanceFromName_String
		{
			get
			{
				if(r_CreateScriptableObjectInstanceFromName_String == null)
				{
					r_CreateScriptableObjectInstanceFromName_String = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObjectInstanceFromName", 0, typeof(System.String));
					r_CreateScriptableObjectInstanceFromName_String.SetBelong(null);
				}
				return r_CreateScriptableObjectInstanceFromName_String;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type, Boolean)
		/// </summary>
		protected static RMethod r_CreateScriptableObjectInstanceFromType_Type_Boolean;
		public static RMethod RCreateScriptableObjectInstanceFromType_Type_Boolean
		{
			get
			{
				if(r_CreateScriptableObjectInstanceFromType_Type_Boolean == null)
				{
					r_CreateScriptableObjectInstanceFromType_Type_Boolean = new(typeof(UnityEngine.ScriptableObject), "CreateScriptableObjectInstanceFromType", 0, typeof(System.Type), typeof(System.Boolean));
					r_CreateScriptableObjectInstanceFromType_Type_Boolean.SetBelong(null);
				}
				return r_CreateScriptableObjectInstanceFromType_Type_Boolean;
			}
		}

		/// <summary>
		/// Void ResetAndApplyDefaultInstances(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_ResetAndApplyDefaultInstances_Object;
		public static RMethod RResetAndApplyDefaultInstances_Object
		{
			get
			{
				if(r_ResetAndApplyDefaultInstances_Object == null)
				{
					r_ResetAndApplyDefaultInstances_Object = new(typeof(UnityEngine.ScriptableObject), "ResetAndApplyDefaultInstances", 0, typeof(UnityEngine.Object));
					r_ResetAndApplyDefaultInstances_Object.SetBelong(null);
				}
				return r_ResetAndApplyDefaultInstances_Object;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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
