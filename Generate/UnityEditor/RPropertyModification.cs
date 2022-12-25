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
		protected RField r_propertyPath;
		public virtual RField RpropertyPath
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
		protected RField r_value;
		public virtual RField Rvalue
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
		protected RMethod r_RApply;
		public virtual RMethod RApply
		{
			get
			{
				if(r_RApply == null)
				{
					r_RApply = new(this, "Apply", 0);
					r_RApply.SetBelong(this.instance);
				}
				return r_RApply;
			}
		}

		/// <summary>
		/// Void ApplyToObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RApplyToObject_Object;
		public virtual RMethod RApplyToObject_Object
		{
			get
			{
				if(r_RApplyToObject_Object == null)
				{
					r_RApplyToObject_Object = new(this, "ApplyToObject", 0, typeof(UnityEngine.Object));
					r_RApplyToObject_Object.SetBelong(this.instance);
				}
				return r_RApplyToObject_Object;
			}
		}

		/// <summary>
		/// Void ApplyPropertyModificationToObject(UnityEngine.Object, UnityEditor.PropertyModification)
		/// </summary>
		protected static RMethod r_RApplyPropertyModificationToObject_Object_PropertyModification;
		public static RMethod RApplyPropertyModificationToObject_Object_PropertyModification
		{
			get
			{
				if(r_RApplyPropertyModificationToObject_Object_PropertyModification == null)
				{
					r_RApplyPropertyModificationToObject_Object_PropertyModification = new(typeof(UnityEditor.PropertyModification), "ApplyPropertyModificationToObject", 0, typeof(UnityEngine.Object), typeof(UnityEditor.PropertyModification));
					r_RApplyPropertyModificationToObject_Object_PropertyModification.SetBelong(null);
				}
				return r_RApplyPropertyModificationToObject_Object_PropertyModification;
			}
		}

		/// <summary>
		/// Void ApplyPropertyModificationsToObject(UnityEngine.Object, UnityEditor.PropertyModification[])
		/// </summary>
		protected static RMethod r_RApplyPropertyModificationsToObject_Object_PropertyModificationArray;
		public static RMethod RApplyPropertyModificationsToObject_Object_PropertyModificationArray
		{
			get
			{
				if(r_RApplyPropertyModificationsToObject_Object_PropertyModificationArray == null)
				{
					r_RApplyPropertyModificationsToObject_Object_PropertyModificationArray = new(typeof(UnityEditor.PropertyModification), "ApplyPropertyModificationsToObject", 0, typeof(UnityEngine.Object), typeof(UnityEditor.PropertyModification).MakeArrayType());
					r_RApplyPropertyModificationsToObject_Object_PropertyModificationArray.SetBelong(null);
				}
				return r_RApplyPropertyModificationsToObject_Object_PropertyModificationArray;
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


        public virtual void ApplyToObject(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RApplyToObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyPropertyModificationToObject(UnityEngine.Object  @target, UnityEditor.PropertyModification  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @value};
            var ___result = RApplyPropertyModificationToObject_Object_PropertyModification.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyPropertyModificationsToObject(UnityEngine.Object  @target, UnityEditor.PropertyModification[]  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @value};
            var ___result = RApplyPropertyModificationsToObject_Object_PropertyModificationArray.Invoke(___genericsType, ___parameters);

            
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
