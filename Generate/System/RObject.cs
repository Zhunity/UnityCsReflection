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
		/// Boolean Equals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_REquals_Object_Object;
		public static RMethod REquals_Object_Object
		{
			get
			{
				if(r_REquals_Object_Object == null)
				{
					r_REquals_Object_Object = new(typeof(System.Object), "Equals", 0, typeof(System.Object), typeof(System.Object));
					r_REquals_Object_Object.SetBelong(null);
				}
				return r_REquals_Object_Object;
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

		/// <summary>
		/// Boolean ReferenceEquals(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_RReferenceEquals_Object_Object;
		public static RMethod RReferenceEquals_Object_Object
		{
			get
			{
				if(r_RReferenceEquals_Object_Object == null)
				{
					r_RReferenceEquals_Object_Object = new(typeof(System.Object), "ReferenceEquals", 0, typeof(System.Object), typeof(System.Object));
					r_RReferenceEquals_Object_Object.SetBelong(null);
				}
				return r_RReferenceEquals_Object_Object;
			}
		}

		/// <summary>
		/// Int32 InternalGetHashCode(System.Object)
		/// </summary>
		protected static RMethod r_RInternalGetHashCode_Object;
		public static RMethod RInternalGetHashCode_Object
		{
			get
			{
				if(r_RInternalGetHashCode_Object == null)
				{
					r_RInternalGetHashCode_Object = new(typeof(System.Object), "InternalGetHashCode", 0, typeof(System.Object));
					r_RInternalGetHashCode_Object.SetBelong(null);
				}
				return r_RInternalGetHashCode_Object;
			}
		}

		/// <summary>
		/// Void FieldGetter(System.String, System.String, System.Object ByRef)
		/// </summary>
		protected RMethod r_RFieldGetter_String_String_Ref_Object;
		public virtual RMethod RFieldGetter_String_String_Ref_Object
		{
			get
			{
				if(r_RFieldGetter_String_String_Ref_Object == null)
				{
					r_RFieldGetter_String_String_Ref_Object = new(this, "FieldGetter", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeByRefType());
					r_RFieldGetter_String_String_Ref_Object.SetBelong(this.instance);
				}
				return r_RFieldGetter_String_String_Ref_Object;
			}
		}

		/// <summary>
		/// Void FieldSetter(System.String, System.String, System.Object)
		/// </summary>
		protected RMethod r_RFieldSetter_String_String_Object;
		public virtual RMethod RFieldSetter_String_String_Object
		{
			get
			{
				if(r_RFieldSetter_String_String_Object == null)
				{
					r_RFieldSetter_String_String_Object = new(this, "FieldSetter", 0, typeof(System.String), typeof(System.String), typeof(System.Object));
					r_RFieldSetter_String_String_Object.SetBelong(this.instance);
				}
				return r_RFieldSetter_String_String_Object;
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
			val = (System.Object)___parameters[2];

            
        }


        public virtual void FieldSetter(System.String  @typeName, System.String  @fieldName, System.Object  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @fieldName, @val};
            var ___result = RFieldSetter_String_String_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
