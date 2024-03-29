
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Object
	/// </summary>
    public partial class RObject : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Object);
            }
        }

        public RObject() : base("System.Object")
        {
        }

        public RObject(System.Object instance) : base("System.Object")
		{
            SetInstance(instance);
		}

        public RObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
		/// Boolean Equals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MEquals_Object_Object;
		public static RMethod RMEquals_Object_Object
		{
			get
			{
				if(r_MEquals_Object_Object == null)
				{
					r_MEquals_Object_Object = new(Type, "Equals", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MEquals_Object_Object;
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

		/// <summary>
		/// Boolean ReferenceEquals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MReferenceEquals_Object_Object;
		public static RMethod RMReferenceEquals_Object_Object
		{
			get
			{
				if(r_MReferenceEquals_Object_Object == null)
				{
					r_MReferenceEquals_Object_Object = new(Type, "ReferenceEquals", 0, typeof(System.Object), typeof(System.Object));
				}
				return r_MReferenceEquals_Object_Object;
			}
		}

		/// <summary>
		/// Int32 InternalGetHashCode(System.Object)
		/// </summary>
		protected static RMethod r_MInternalGetHashCode_Object;
		public static RMethod RMInternalGetHashCode_Object
		{
			get
			{
				if(r_MInternalGetHashCode_Object == null)
				{
					r_MInternalGetHashCode_Object = new(Type, "InternalGetHashCode", 0, typeof(System.Object));
				}
				return r_MInternalGetHashCode_Object;
			}
		}

		/// <summary>
		/// Void FieldGetter(System.String, System.String, System.Object ByRef)
		/// </summary>
		protected RMethod r_MFieldGetter_String_String_Ref_Object;
		public virtual RMethod RMFieldGetter_String_String_Ref_Object
		{
			get
			{
				if(r_MFieldGetter_String_String_Ref_Object == null)
				{
					r_MFieldGetter_String_String_Ref_Object = new(this, "FieldGetter", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeByRefType());
				}
				return r_MFieldGetter_String_String_Ref_Object;
			}
		}

		/// <summary>
		/// Void FieldSetter(System.String, System.String, System.Object)
		/// </summary>
		protected RMethod r_MFieldSetter_String_String_Object;
		public virtual RMethod RMFieldSetter_String_String_Object
		{
			get
			{
				if(r_MFieldSetter_String_String_Object == null)
				{
					r_MFieldSetter_String_String_Object = new(this, "FieldSetter", 0, typeof(System.String), typeof(System.String), typeof(System.Object));
				}
				return r_MFieldSetter_String_String_Object;
			}
		}


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean Equals(System.Object @objA, System.Object @objB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objA, @objB};
            var ___result = RMEquals_Object_Object.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean ReferenceEquals(System.Object @objA, System.Object @objB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objA, @objB};
            var ___result = RMReferenceEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 InternalGetHashCode(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMInternalGetHashCode_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void FieldGetter(System.String @typeName, System.String @fieldName, ref System.Object @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @fieldName, @val};
            var ___result = RMFieldGetter_String_String_Ref_Object.Invoke(___genericsType, ___parameters);
			@val = ReflectionUtils.Convert<System.Object>(___parameters[2]);

            
        }


        public virtual void FieldSetter(System.String @typeName, System.String @fieldName, System.Object @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @fieldName, @val};
            var ___result = RMFieldSetter_String_String_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
