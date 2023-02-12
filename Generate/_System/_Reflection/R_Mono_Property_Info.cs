
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.MonoPropertyInfo
	/// </summary>
    public partial class RMonoPropertyInfo : RMember //
    {

		/// <summary>
		/// System.Type parent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Fparent;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFparent
		{
			get
			{
				if(r_Fparent == null)
				{
					r_Fparent = new(this, "parent");
					r_Fparent.SetBelong(this.instance);
				}
				return r_Fparent;
			}
		}

		/// <summary>
		/// System.Type declaring_type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Fdeclaring_type;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFdeclaring_type
		{
			get
			{
				if(r_Fdeclaring_type == null)
				{
					r_Fdeclaring_type = new(this, "declaring_type");
					r_Fdeclaring_type.SetBelong(this.instance);
				}
				return r_Fdeclaring_type;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo get_method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Fget_method;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RFget_method
		{
			get
			{
				if(r_Fget_method == null)
				{
					r_Fget_method = new(this, "get_method");
					r_Fget_method.SetBelong(this.instance);
				}
				return r_Fget_method;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo set_method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Fset_method;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RFset_method
		{
			get
			{
				if(r_Fset_method == null)
				{
					r_Fset_method = new(this, "set_method");
					r_Fset_method.SetBelong(this.instance);
				}
				return r_Fset_method;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyAttributes attrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes r_Fattrs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
					r_Fattrs.SetBelong(this.instance);
				}
				return r_Fattrs;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RMonoPropertyInfo() : base("System.Reflection.MonoPropertyInfo")
        {
        }

        public RMonoPropertyInfo(System.Object instance) : base("System.Reflection.MonoPropertyInfo")
		{
            SetInstance(instance);
		}

        public RMonoPropertyInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMonoPropertyInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}