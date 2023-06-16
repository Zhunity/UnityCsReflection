
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.InteropServices.StructLayoutAttribute
	/// </summary>
    public partial class RStructLayoutAttribute : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.InteropServices.StructLayoutAttribute);
            }
        }

        public RStructLayoutAttribute() : base("System.Runtime.InteropServices.StructLayoutAttribute")
        {
        }

        public RStructLayoutAttribute(System.Object instance) : base("System.Runtime.InteropServices.StructLayoutAttribute")
		{
            SetInstance(instance);
		}

        public RStructLayoutAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStructLayoutAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 DEFAULT_PACKING_SIZE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDEFAULT_PACKING_SIZE;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDEFAULT_PACKING_SIZE
		{
			get
			{
				if(r_FDEFAULT_PACKING_SIZE == null)
				{
					r_FDEFAULT_PACKING_SIZE = new(Type, "DEFAULT_PACKING_SIZE");
				}
				return r_FDEFAULT_PACKING_SIZE;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.LayoutKind _val
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RLayoutKind r_F_val;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RLayoutKind RF_val
		{
			get
			{
				if(r_F_val == null)
				{
					r_F_val = new(this, "_val");
				}
				return r_F_val;
			}
		}

		/// <summary>
		/// System.Int32 Pack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FPack;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFPack
		{
			get
			{
				if(r_FPack == null)
				{
					r_FPack = new(this, "Pack");
				}
				return r_FPack;
			}
		}

		/// <summary>
		/// System.Int32 Size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFSize
		{
			get
			{
				if(r_FSize == null)
				{
					r_FSize = new(this, "Size");
				}
				return r_FSize;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CharSet CharSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCharSet r_FCharSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCharSet RFCharSet
		{
			get
			{
				if(r_FCharSet == null)
				{
					r_FCharSet = new(this, "CharSet");
				}
				return r_FCharSet;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.LayoutKind Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RLayoutKind r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RLayoutKind RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PTypeId;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPTypeId
		{
			get
			{
				if(r_PTypeId == null)
				{
					r_PTypeId = new(this, "TypeId", -1);
				}
				return r_PTypeId;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.StructLayoutAttribute GetCustomAttribute(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetCustomAttribute_RuntimeType;
		public static RMethod RMGetCustomAttribute_RuntimeType
		{
			get
			{
				if(r_MGetCustomAttribute_RuntimeType == null)
				{
					r_MGetCustomAttribute_RuntimeType = new(Type, "GetCustomAttribute", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetCustomAttribute_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsDefined_RuntimeType;
		public static RMethod RMIsDefined_RuntimeType
		{
			get
			{
				if(r_MIsDefined_RuntimeType == null)
				{
					r_MIsDefined_RuntimeType = new(Type, "IsDefined", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsDefined_RuntimeType;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_MMatch_Object;
		public virtual RMethod RMMatch_Object
		{
			get
			{
				if(r_MMatch_Object == null)
				{
					r_MMatch_Object = new(this, "Match", 0, typeof(System.Object));
				}
				return r_MMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_MIsDefaultAttribute;
		public virtual RMethod RMIsDefaultAttribute
		{
			get
			{
				if(r_MIsDefaultAttribute == null)
				{
					r_MIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
				}
				return r_MIsDefaultAttribute;
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


        public static System.Runtime.InteropServices.StructLayoutAttribute GetCustomAttribute(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetCustomAttribute_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.InteropServices.StructLayoutAttribute>(___result);
        }


        public static System.Boolean IsDefined(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsDefined_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.Boolean Match(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMMatch_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
