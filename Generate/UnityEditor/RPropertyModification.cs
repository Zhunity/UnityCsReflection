using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PropertyModification
	/// </summary>
    public partial class RPropertyModification : RMember //
    {

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected RUnityEngine.RObject r_target;
		public virtual RUnityEngine.RObject Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target");
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// System.String propertyPath
		/// </summary>
		protected RSystem.RString r_propertyPath;
		public virtual RSystem.RString RpropertyPath
		{
			get
			{
				if(r_propertyPath == null)
				{
					r_propertyPath = new(this, "propertyPath");
					r_propertyPath.SetBelong(this.instance);
				}
				return r_propertyPath;
			}
		}

		/// <summary>
		/// System.String value
		/// </summary>
		protected RSystem.RString r_value;
		public virtual RSystem.RString Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// UnityEngine.Object objectReference
		/// </summary>
		protected RUnityEngine.RObject r_objectReference;
		public virtual RUnityEngine.RObject RobjectReference
		{
			get
			{
				if(r_objectReference == null)
				{
					r_objectReference = new(this, "objectReference");
					r_objectReference.SetBelong(this.instance);
				}
				return r_objectReference;
			}
		}

		/// <summary>
		/// Void Apply()
		/// </summary>
		protected RMethod r_Apply;
		public virtual RMethod RApply
		{
			get
			{
				if(r_Apply == null)
				{
					r_Apply = new(this, "Apply", 0);
					r_Apply.SetBelong(this.instance);
				}
				return r_Apply;
			}
		}

		/// <summary>
		/// Void ApplyToObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ApplyToObject_Object;
		public virtual RMethod RApplyToObject_Object
		{
			get
			{
				if(r_ApplyToObject_Object == null)
				{
					r_ApplyToObject_Object = new(this, "ApplyToObject", 0, typeof(UnityEngine.Object));
					r_ApplyToObject_Object.SetBelong(this.instance);
				}
				return r_ApplyToObject_Object;
			}
		}

		/// <summary>
		/// Void ApplyPropertyModificationToObject(UnityEngine.Object, UnityEditor.PropertyModification)
		/// </summary>
		protected static RMethod r_ApplyPropertyModificationToObject_Object_PropertyModification;
		public static RMethod RApplyPropertyModificationToObject_Object_PropertyModification
		{
			get
			{
				if(r_ApplyPropertyModificationToObject_Object_PropertyModification == null)
				{
					r_ApplyPropertyModificationToObject_Object_PropertyModification = new(typeof(UnityEditor.PropertyModification), "ApplyPropertyModificationToObject", 0, typeof(UnityEngine.Object), typeof(UnityEditor.PropertyModification));
					r_ApplyPropertyModificationToObject_Object_PropertyModification.SetBelong(null);
				}
				return r_ApplyPropertyModificationToObject_Object_PropertyModification;
			}
		}

		/// <summary>
		/// Void ApplyPropertyModificationsToObject(UnityEngine.Object, UnityEditor.PropertyModification[])
		/// </summary>
		protected static RMethod r_ApplyPropertyModificationsToObject_Object_PropertyModificationArray;
		public static RMethod RApplyPropertyModificationsToObject_Object_PropertyModificationArray
		{
			get
			{
				if(r_ApplyPropertyModificationsToObject_Object_PropertyModificationArray == null)
				{
					r_ApplyPropertyModificationsToObject_Object_PropertyModificationArray = new(typeof(UnityEditor.PropertyModification), "ApplyPropertyModificationsToObject", 0, typeof(UnityEngine.Object), typeof(UnityEditor.PropertyModification).MakeArrayType());
					r_ApplyPropertyModificationsToObject_Object_PropertyModificationArray.SetBelong(null);
				}
				return r_ApplyPropertyModificationsToObject_Object_PropertyModificationArray;
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


        public RPropertyModification() : base("UnityEditor.PropertyModification")
        {
        }

        public RPropertyModification(System.Object instance) : base("UnityEditor.PropertyModification")
		{
            SetInstance(instance);
		}

        public RPropertyModification(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyModification(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Apply()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApply.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyToObject(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RApplyToObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyPropertyModificationToObject(UnityEngine.Object @target, UnityEditor.PropertyModification @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @value};
            var ___result = RApplyPropertyModificationToObject_Object_PropertyModification.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyPropertyModificationsToObject(UnityEngine.Object @target, UnityEditor.PropertyModification[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @value};
            var ___result = RApplyPropertyModificationsToObject_Object_PropertyModificationArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
