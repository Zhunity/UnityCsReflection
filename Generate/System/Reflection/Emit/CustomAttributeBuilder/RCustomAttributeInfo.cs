using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{public partial class RCustomAttributeBuilder
{
	
	/// <summary>
	/// System.Reflection.Emit.CustomAttributeBuilder+CustomAttributeInfo
	/// </summary>
    public partial class RCustomAttributeInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.ConstructorInfo ctor
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_ctor;
		public virtual RSystem.RReflection.RConstructorInfo Rctor
		{
			get
			{
				if(r_ctor == null)
				{
					r_ctor = new(this, "ctor");
					r_ctor.SetBelong(this.instance);
				}
				return r_ctor;
			}
		}

		/// <summary>
		/// System.Object[] ctorArgs
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_ctorArgs;
		public virtual RFieldArray<RSystem.RObject> RctorArgs
		{
			get
			{
				if(r_ctorArgs == null)
				{
					r_ctorArgs = new(this, "ctorArgs");
					r_ctorArgs.SetBelong(this.instance);
				}
				return r_ctorArgs;
			}
		}

		/// <summary>
		/// System.String[] namedParamNames
		/// </summary>
		protected RFieldArray<RField> r_namedParamNames;
		public virtual RFieldArray<RField> RnamedParamNames
		{
			get
			{
				if(r_namedParamNames == null)
				{
					r_namedParamNames = new(this, "namedParamNames");
					r_namedParamNames.SetBelong(this.instance);
				}
				return r_namedParamNames;
			}
		}

		/// <summary>
		/// System.Object[] namedParamValues
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_namedParamValues;
		public virtual RFieldArray<RSystem.RObject> RnamedParamValues
		{
			get
			{
				if(r_namedParamValues == null)
				{
					r_namedParamValues = new(this, "namedParamValues");
					r_namedParamValues.SetBelong(this.instance);
				}
				return r_namedParamValues;
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


        public RCustomAttributeInfo() : base("System.Reflection.Emit.CustomAttributeBuilder+CustomAttributeInfo")
        {
        }

        public RCustomAttributeInfo(System.Object instance) : base("System.Reflection.Emit.CustomAttributeBuilder+CustomAttributeInfo")
		{
            SetInstance(instance);
		}

        public RCustomAttributeInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomAttributeInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
}