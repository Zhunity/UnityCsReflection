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
		protected static RField r_DEFAULT_PACKING_SIZE;
		public static RField RDEFAULT_PACKING_SIZE
		{
			get
			{
				if(r_DEFAULT_PACKING_SIZE == null)
				{
					r_DEFAULT_PACKING_SIZE = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "DEFAULT_PACKING_SIZE");
					r_DEFAULT_PACKING_SIZE.SetBelong(null);
				}
				return r_DEFAULT_PACKING_SIZE;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.LayoutKind _val
		/// </summary>
		protected RField r__val;
		public virtual RField R_val
		{
			get
			{
				if(r__val == null)
				{
					r__val = new(this, "_val");
					r__val.SetBelong(this.instance);
				}
				return r__val;
			}
		}

		/// <summary>
		/// System.Int32 Pack
		/// </summary>
		protected RField r_Pack;
		public virtual RField RPack
		{
			get
			{
				if(r_Pack == null)
				{
					r_Pack = new(this, "Pack");
					r_Pack.SetBelong(this.instance);
				}
				return r_Pack;
			}
		}

		/// <summary>
		/// System.Int32 Size
		/// </summary>
		protected RField r_Size;
		public virtual RField RSize
		{
			get
			{
				if(r_Size == null)
				{
					r_Size = new(this, "Size");
					r_Size.SetBelong(this.instance);
				}
				return r_Size;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CharSet CharSet
		/// </summary>
		protected RField r_CharSet;
		public virtual RField RCharSet
		{
			get
			{
				if(r_CharSet == null)
				{
					r_CharSet = new(this, "CharSet");
					r_CharSet.SetBelong(this.instance);
				}
				return r_CharSet;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.LayoutKind Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected RSystem.RObject r_TypeId;
		public virtual RSystem.RObject RTypeId
		{
			get
			{
				if(r_TypeId == null)
				{
					r_TypeId = new(this, "TypeId", -1);
					r_TypeId.SetBelong(this.instance);
				}
				return r_TypeId;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.StructLayoutAttribute GetCustomAttribute(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetCustomAttribute_RuntimeType;
		public static RMethod RGetCustomAttribute_RuntimeType
		{
			get
			{
				if(r_RGetCustomAttribute_RuntimeType == null)
				{
					r_RGetCustomAttribute_RuntimeType = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "GetCustomAttribute", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetCustomAttribute_RuntimeType.SetBelong(null);
				}
				return r_RGetCustomAttribute_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsDefined_RuntimeType;
		public static RMethod RIsDefined_RuntimeType
		{
			get
			{
				if(r_RIsDefined_RuntimeType == null)
				{
					r_RIsDefined_RuntimeType = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "IsDefined", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsDefined_RuntimeType.SetBelong(null);
				}
				return r_RIsDefined_RuntimeType;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_RMatch_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_RMatch_Object == null)
				{
					r_RMatch_Object = new(this, "Match", 0, typeof(System.Object));
					r_RMatch_Object.SetBelong(this.instance);
				}
				return r_RMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_RIsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_RIsDefaultAttribute == null)
				{
					r_RIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_RIsDefaultAttribute.SetBelong(this.instance);
				}
				return r_RIsDefaultAttribute;
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


        public virtual System.Boolean Match(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
