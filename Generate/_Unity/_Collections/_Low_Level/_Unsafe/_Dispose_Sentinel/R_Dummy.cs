
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe
{public partial class RDisposeSentinel
{
	
	/// <summary>
	/// Unity.Collections.LowLevel.Unsafe.DisposeSentinel+Dummy
	/// </summary>
    public partial class RDummy : RMember //
    {

		/// <summary>
		/// Dummy op_Implicit(Class)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Class;
		public static RMethod RMop_Implicit_Class
		{
			get
			{
				if(r_Mop_Implicit_Class == null)
				{
					r_Mop_Implicit_Class = new( ReflectionUtils.GetType("Unity.Collections.LowLevel.Unsafe.DisposeSentinel+Dummy"), "op_Implicit", 0,  ReflectionUtils.GetType("Unity.Collections.LowLevel.Unsafe.DisposeSentinel+Dummy+Class"));
				}
				return r_Mop_Implicit_Class;
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


        public RDummy() : base("Unity.Collections.LowLevel.Unsafe.DisposeSentinel+Dummy")
        {
        }

        public RDummy(System.Object instance) : base("Unity.Collections.LowLevel.Unsafe.DisposeSentinel+Dummy")
		{
            SetInstance(instance);
		}

        public RDummy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDummy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy op_Implicit(Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy.RClass @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMop_Implicit_Class.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RDisposeSentinel.RDummy(___result);
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
}