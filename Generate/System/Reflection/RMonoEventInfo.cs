using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.MonoEventInfo
	/// </summary>
    public partial class RMonoEventInfo : RMember //
    {

		/// <summary>
		/// System.Type declaring_type
		/// </summary>
		protected RSystem.RType r_declaring_type;
		public virtual RSystem.RType Rdeclaring_type
		{
			get
			{
				if(r_declaring_type == null)
				{
					r_declaring_type = new(this, "declaring_type");
					r_declaring_type.SetBelong(this.instance);
				}
				return r_declaring_type;
			}
		}

		/// <summary>
		/// System.Type reflected_type
		/// </summary>
		protected RSystem.RType r_reflected_type;
		public virtual RSystem.RType Rreflected_type
		{
			get
			{
				if(r_reflected_type == null)
				{
					r_reflected_type = new(this, "reflected_type");
					r_reflected_type.SetBelong(this.instance);
				}
				return r_reflected_type;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo add_method
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_add_method;
		public virtual RSystem.RReflection.RMethodInfo Radd_method
		{
			get
			{
				if(r_add_method == null)
				{
					r_add_method = new(this, "add_method");
					r_add_method.SetBelong(this.instance);
				}
				return r_add_method;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo remove_method
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_remove_method;
		public virtual RSystem.RReflection.RMethodInfo Rremove_method
		{
			get
			{
				if(r_remove_method == null)
				{
					r_remove_method = new(this, "remove_method");
					r_remove_method.SetBelong(this.instance);
				}
				return r_remove_method;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo raise_method
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_raise_method;
		public virtual RSystem.RReflection.RMethodInfo Rraise_method
		{
			get
			{
				if(r_raise_method == null)
				{
					r_raise_method = new(this, "raise_method");
					r_raise_method.SetBelong(this.instance);
				}
				return r_raise_method;
			}
		}

		/// <summary>
		/// System.Reflection.EventAttributes attrs
		/// </summary>
		protected RField r_attrs;
		public virtual RField Rattrs
		{
			get
			{
				if(r_attrs == null)
				{
					r_attrs = new(this, "attrs");
					r_attrs.SetBelong(this.instance);
				}
				return r_attrs;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] other_methods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RMethodInfo> r_other_methods;
		public virtual RFieldArray<RSystem.RReflection.RMethodInfo> Rother_methods
		{
			get
			{
				if(r_other_methods == null)
				{
					r_other_methods = new(this, "other_methods");
					r_other_methods.SetBelong(this.instance);
				}
				return r_other_methods;
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


        public RMonoEventInfo() : base("System.Reflection.MonoEventInfo")
        {
        }

        public RMonoEventInfo(System.Object instance) : base("System.Reflection.MonoEventInfo")
		{
            SetInstance(instance);
		}

        public RMonoEventInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMonoEventInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
