
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.PropertyModification
	/// </summary>
    public partial class RPropertyModification : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PropertyModification);
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


		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Ftarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RFtarget
		{
			get
			{
				if(r_Ftarget == null)
				{
					r_Ftarget = new(this, "target");
				}
				return r_Ftarget;
			}
		}

		/// <summary>
		/// System.String propertyPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpropertyPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpropertyPath
		{
			get
			{
				if(r_FpropertyPath == null)
				{
					r_FpropertyPath = new(this, "propertyPath");
				}
				return r_FpropertyPath;
			}
		}

		/// <summary>
		/// System.String value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// UnityEngine.Object objectReference
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_FobjectReference;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RFobjectReference
		{
			get
			{
				if(r_FobjectReference == null)
				{
					r_FobjectReference = new(this, "objectReference");
				}
				return r_FobjectReference;
			}
		}

		/// <summary>
		/// Void Apply()
		/// </summary>
		protected RMethod r_MApply;
		public virtual RMethod RMApply
		{
			get
			{
				if(r_MApply == null)
				{
					r_MApply = new(this, "Apply", 0);
				}
				return r_MApply;
			}
		}

		/// <summary>
		/// Void ApplyToObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MApplyToObject_Object;
		public virtual RMethod RMApplyToObject_Object
		{
			get
			{
				if(r_MApplyToObject_Object == null)
				{
					r_MApplyToObject_Object = new(this, "ApplyToObject", 0, typeof(UnityEngine.Object));
				}
				return r_MApplyToObject_Object;
			}
		}

		/// <summary>
		/// Void ApplyPropertyModificationToObject(UnityEngine.Object, UnityEditor.PropertyModification)
		/// </summary>
		protected static RMethod r_MApplyPropertyModificationToObject_Object_PropertyModification;
		public static RMethod RMApplyPropertyModificationToObject_Object_PropertyModification
		{
			get
			{
				if(r_MApplyPropertyModificationToObject_Object_PropertyModification == null)
				{
					r_MApplyPropertyModificationToObject_Object_PropertyModification = new(Type, "ApplyPropertyModificationToObject", 0, typeof(UnityEngine.Object), typeof(UnityEditor.PropertyModification));
				}
				return r_MApplyPropertyModificationToObject_Object_PropertyModification;
			}
		}

		/// <summary>
		/// Void ApplyPropertyModificationsToObject(UnityEngine.Object, UnityEditor.PropertyModification[])
		/// </summary>
		protected static RMethod r_MApplyPropertyModificationsToObject_Object_PropertyModificationArray;
		public static RMethod RMApplyPropertyModificationsToObject_Object_PropertyModificationArray
		{
			get
			{
				if(r_MApplyPropertyModificationsToObject_Object_PropertyModificationArray == null)
				{
					r_MApplyPropertyModificationsToObject_Object_PropertyModificationArray = new(Type, "ApplyPropertyModificationsToObject", 0, typeof(UnityEngine.Object), typeof(UnityEditor.PropertyModification).MakeArrayType());
				}
				return r_MApplyPropertyModificationsToObject_Object_PropertyModificationArray;
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


        public virtual void Apply()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApply.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyToObject(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMApplyToObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyPropertyModificationToObject(UnityEngine.Object @target, UnityEditor.PropertyModification @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @value};
            var ___result = RMApplyPropertyModificationToObject_Object_PropertyModification.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyPropertyModificationsToObject(UnityEngine.Object @target, UnityEditor.PropertyModification[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @value};
            var ___result = RMApplyPropertyModificationsToObject_Object_PropertyModificationArray.Invoke(___genericsType, ___parameters);

            
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
