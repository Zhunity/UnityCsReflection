using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.StructLayoutAttribute
	/// </summary>
    public partial class RStructLayoutAttribute : RMember //
    {

		/// <summary>
		/// System.Int32 DEFAULT_PACKING_SIZE
		/// </summary>
		protected static RSystem.RInt32 r_FDEFAULT_PACKING_SIZE;
		public static RSystem.RInt32 RFDEFAULT_PACKING_SIZE
		{
			get
			{
				if(r_FDEFAULT_PACKING_SIZE == null)
				{
					r_FDEFAULT_PACKING_SIZE = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "DEFAULT_PACKING_SIZE");
					r_FDEFAULT_PACKING_SIZE.SetBelong(null);
				}
				return r_FDEFAULT_PACKING_SIZE;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.LayoutKind _val
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RLayoutKind r_F_val;
		public virtual RSystem.RRuntime.RInteropServices.RLayoutKind RF_val
		{
			get
			{
				if(r_F_val == null)
				{
					r_F_val = new(this, "_val");
					r_F_val.SetBelong(this.instance);
				}
				return r_F_val;
			}
		}

		/// <summary>
		/// System.Int32 Pack
		/// </summary>
		protected RSystem.RInt32 r_FPack;
		public virtual RSystem.RInt32 RFPack
		{
			get
			{
				if(r_FPack == null)
				{
					r_FPack = new(this, "Pack");
					r_FPack.SetBelong(this.instance);
				}
				return r_FPack;
			}
		}

		/// <summary>
		/// System.Int32 Size
		/// </summary>
		protected RSystem.RInt32 r_FSize;
		public virtual RSystem.RInt32 RFSize
		{
			get
			{
				if(r_FSize == null)
				{
					r_FSize = new(this, "Size");
					r_FSize.SetBelong(this.instance);
				}
				return r_FSize;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CharSet CharSet
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RCharSet r_FCharSet;
		public virtual RSystem.RRuntime.RInteropServices.RCharSet RFCharSet
		{
			get
			{
				if(r_FCharSet == null)
				{
					r_FCharSet = new(this, "CharSet");
					r_FCharSet.SetBelong(this.instance);
				}
				return r_FCharSet;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.LayoutKind Value
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RLayoutKind r_PValue;
		public virtual RSystem.RRuntime.RInteropServices.RLayoutKind RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected RSystem.RObject r_PTypeId;
		public virtual RSystem.RObject RPTypeId
		{
			get
			{
				if(r_PTypeId == null)
				{
					r_PTypeId = new(this, "TypeId", -1);
					r_PTypeId.SetBelong(this.instance);
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
					r_MGetCustomAttribute_RuntimeType = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "GetCustomAttribute", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MGetCustomAttribute_RuntimeType.SetBelong(null);
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
					r_MIsDefined_RuntimeType = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "IsDefined", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MIsDefined_RuntimeType.SetBelong(null);
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
					r_MMatch_Object.SetBelong(this.instance);
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
					r_MIsDefaultAttribute.SetBelong(this.instance);
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

        public static System.Runtime.InteropServices.StructLayoutAttribute GetCustomAttribute(RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetCustomAttribute_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.StructLayoutAttribute)___result;
        }


        public static System.Boolean IsDefined(RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsDefined_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean Match(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
