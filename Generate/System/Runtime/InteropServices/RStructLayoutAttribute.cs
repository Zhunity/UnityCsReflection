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
		protected static RSystem.RInt32 r_DEFAULT_PACKING_SIZE;
		public static RSystem.RInt32 RDEFAULT_PACKING_SIZE
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
		protected RSystem.RInt32 r_Pack;
		public virtual RSystem.RInt32 RPack
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
		protected RSystem.RInt32 r_Size;
		public virtual RSystem.RInt32 RSize
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
		protected static RMethod r_GetCustomAttribute_RuntimeType;
		public static RMethod RGetCustomAttribute_RuntimeType
		{
			get
			{
				if(r_GetCustomAttribute_RuntimeType == null)
				{
					r_GetCustomAttribute_RuntimeType = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "GetCustomAttribute", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetCustomAttribute_RuntimeType.SetBelong(null);
				}
				return r_GetCustomAttribute_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsDefined_RuntimeType;
		public static RMethod RIsDefined_RuntimeType
		{
			get
			{
				if(r_IsDefined_RuntimeType == null)
				{
					r_IsDefined_RuntimeType = new(typeof(System.Runtime.InteropServices.StructLayoutAttribute), "IsDefined", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsDefined_RuntimeType.SetBelong(null);
				}
				return r_IsDefined_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_Match_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_Match_Object == null)
				{
					r_Match_Object = new(this, "Match", 0, typeof(System.Object));
					r_Match_Object.SetBelong(this.instance);
				}
				return r_Match_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_IsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_IsDefaultAttribute == null)
				{
					r_IsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_IsDefaultAttribute.SetBelong(this.instance);
				}
				return r_IsDefaultAttribute;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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
            var ___result = RGetCustomAttribute_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.StructLayoutAttribute)___result;
        }


        public static System.Boolean IsDefined(RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsDefined_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.Boolean Match(System.Object @obj)
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
