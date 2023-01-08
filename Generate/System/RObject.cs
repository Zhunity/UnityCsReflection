using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Object
	/// </summary>
    public partial class RObject : RMember //
    {

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
		/// Boolean Equals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_Equals_Object_Object;
		public static RMethod REquals_Object_Object
		{
			get
			{
				if(r_Equals_Object_Object == null)
				{
					r_Equals_Object_Object = new(typeof(System.Object), "Equals", 0, typeof(System.Object), typeof(System.Object));
					r_Equals_Object_Object.SetBelong(null);
				}
				return r_Equals_Object_Object;
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

		/// <summary>
		/// Boolean ReferenceEquals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_ReferenceEquals_Object_Object;
		public static RMethod RReferenceEquals_Object_Object
		{
			get
			{
				if(r_ReferenceEquals_Object_Object == null)
				{
					r_ReferenceEquals_Object_Object = new(typeof(System.Object), "ReferenceEquals", 0, typeof(System.Object), typeof(System.Object));
					r_ReferenceEquals_Object_Object.SetBelong(null);
				}
				return r_ReferenceEquals_Object_Object;
			}
		}

		/// <summary>
		/// Int32 InternalGetHashCode(System.Object)
		/// </summary>
		protected static RMethod r_InternalGetHashCode_Object;
		public static RMethod RInternalGetHashCode_Object
		{
			get
			{
				if(r_InternalGetHashCode_Object == null)
				{
					r_InternalGetHashCode_Object = new(typeof(System.Object), "InternalGetHashCode", 0, typeof(System.Object));
					r_InternalGetHashCode_Object.SetBelong(null);
				}
				return r_InternalGetHashCode_Object;
			}
		}

		/// <summary>
		/// Void FieldGetter(System.String, System.String, System.Object ByRef)
		/// </summary>
		protected RMethod r_FieldGetter_String_String_Ref_Object;
		public virtual RMethod RFieldGetter_String_String_Ref_Object
		{
			get
			{
				if(r_FieldGetter_String_String_Ref_Object == null)
				{
					r_FieldGetter_String_String_Ref_Object = new(this, "FieldGetter", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeByRefType());
					r_FieldGetter_String_String_Ref_Object.SetBelong(this.instance);
				}
				return r_FieldGetter_String_String_Ref_Object;
			}
		}

		/// <summary>
		/// Void FieldSetter(System.String, System.String, System.Object)
		/// </summary>
		protected RMethod r_FieldSetter_String_String_Object;
		public virtual RMethod RFieldSetter_String_String_Object
		{
			get
			{
				if(r_FieldSetter_String_String_Object == null)
				{
					r_FieldSetter_String_String_Object = new(this, "FieldSetter", 0, typeof(System.String), typeof(System.String), typeof(System.Object));
					r_FieldSetter_String_String_Object.SetBelong(this.instance);
				}
				return r_FieldSetter_String_String_Object;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean Equals(System.Object  @objA, System.Object  @objB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objA, @objB};
            var ___result = REquals_Object_Object.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean ReferenceEquals(System.Object  @objA, System.Object  @objB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objA, @objB};
            var ___result = RReferenceEquals_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 InternalGetHashCode(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RInternalGetHashCode_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FieldGetter(System.String  @typeName, System.String  @fieldName, ref System.Object  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @fieldName, @val};
            var ___result = RFieldGetter_String_String_Ref_Object.Invoke(___genericsType, ___parameters);
			@val = (System.Object)___parameters[2];

            
        }


        public virtual void FieldSetter(System.String  @typeName, System.String  @fieldName, System.Object  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @fieldName, @val};
            var ___result = RFieldSetter_String_String_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
