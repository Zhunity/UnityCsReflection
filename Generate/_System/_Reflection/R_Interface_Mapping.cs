
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.InterfaceMapping
	/// </summary>
    public partial class RInterfaceMapping : RMember //
    {

		/// <summary>
		/// System.Type TargetType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_FTargetType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFTargetType
		{
			get
			{
				if(r_FTargetType == null)
				{
					r_FTargetType = new(this, "TargetType");
				}
				return r_FTargetType;
			}
		}

		/// <summary>
		/// System.Type InterfaceType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_FInterfaceType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFInterfaceType
		{
			get
			{
				if(r_FInterfaceType == null)
				{
					r_FInterfaceType = new(this, "InterfaceType");
				}
				return r_FInterfaceType;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] TargetMethods
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> r_FTargetMethods;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> RFTargetMethods
		{
			get
			{
				if(r_FTargetMethods == null)
				{
					r_FTargetMethods = new(this, "TargetMethods");
				}
				return r_FTargetMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] InterfaceMethods
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> r_FInterfaceMethods;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> RFInterfaceMethods
		{
			get
			{
				if(r_FInterfaceMethods == null)
				{
					r_FInterfaceMethods = new(this, "InterfaceMethods");
				}
				return r_FInterfaceMethods;
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


        public RInterfaceMapping() : base("System.Reflection.InterfaceMapping")
        {
        }

        public RInterfaceMapping(System.Object instance) : base("System.Reflection.InterfaceMapping")
		{
            SetInstance(instance);
		}

        public RInterfaceMapping(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInterfaceMapping(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
