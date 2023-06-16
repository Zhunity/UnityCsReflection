
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.MonoPropertyInfo
	/// </summary>
    public partial class RMonoPropertyInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Reflection.MonoPropertyInfo");
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


		/// <summary>
		/// System.Type parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fparent;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFparent
		{
			get
			{
				if(r_Fparent == null)
				{
					r_Fparent = new(this, "parent");
				}
				return r_Fparent;
			}
		}

		/// <summary>
		/// System.Type declaring_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fdeclaring_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFdeclaring_type
		{
			get
			{
				if(r_Fdeclaring_type == null)
				{
					r_Fdeclaring_type = new(this, "declaring_type");
				}
				return r_Fdeclaring_type;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo get_method
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Fget_method;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RFget_method
		{
			get
			{
				if(r_Fget_method == null)
				{
					r_Fget_method = new(this, "get_method");
				}
				return r_Fget_method;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo set_method
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Fset_method;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RFset_method
		{
			get
			{
				if(r_Fset_method == null)
				{
					r_Fset_method = new(this, "set_method");
				}
				return r_Fset_method;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyAttributes attrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes r_Fattrs;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyAttributes RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
