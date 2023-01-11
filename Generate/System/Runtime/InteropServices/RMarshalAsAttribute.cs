using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.MarshalAsAttribute
	/// </summary>
    public partial class RMarshalAsAttribute : RMember //
    {

		/// <summary>
		/// System.String MarshalCookie
		/// </summary>
		protected RSystem.RString r_MarshalCookie;
		public virtual RSystem.RString RMarshalCookie
		{
			get
			{
				if(r_MarshalCookie == null)
				{
					r_MarshalCookie = new(this, "MarshalCookie");
					r_MarshalCookie.SetBelong(this.instance);
				}
				return r_MarshalCookie;
			}
		}

		/// <summary>
		/// System.String MarshalType
		/// </summary>
		protected RSystem.RString r_MarshalType;
		public virtual RSystem.RString RMarshalType
		{
			get
			{
				if(r_MarshalType == null)
				{
					r_MarshalType = new(this, "MarshalType");
					r_MarshalType.SetBelong(this.instance);
				}
				return r_MarshalType;
			}
		}

		/// <summary>
		/// System.Type MarshalTypeRef
		/// </summary>
		protected RSystem.RType r_MarshalTypeRef;
		public virtual RSystem.RType RMarshalTypeRef
		{
			get
			{
				if(r_MarshalTypeRef == null)
				{
					r_MarshalTypeRef = new(this, "MarshalTypeRef");
					r_MarshalTypeRef.SetBelong(this.instance);
				}
				return r_MarshalTypeRef;
			}
		}

		/// <summary>
		/// System.Type SafeArrayUserDefinedSubType
		/// </summary>
		protected RSystem.RType r_SafeArrayUserDefinedSubType;
		public virtual RSystem.RType RSafeArrayUserDefinedSubType
		{
			get
			{
				if(r_SafeArrayUserDefinedSubType == null)
				{
					r_SafeArrayUserDefinedSubType = new(this, "SafeArrayUserDefinedSubType");
					r_SafeArrayUserDefinedSubType.SetBelong(this.instance);
				}
				return r_SafeArrayUserDefinedSubType;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType utype
		/// </summary>
		protected RField r_utype;
		public virtual RField Rutype
		{
			get
			{
				if(r_utype == null)
				{
					r_utype = new(this, "utype");
					r_utype.SetBelong(this.instance);
				}
				return r_utype;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType ArraySubType
		/// </summary>
		protected RField r_ArraySubType;
		public virtual RField RArraySubType
		{
			get
			{
				if(r_ArraySubType == null)
				{
					r_ArraySubType = new(this, "ArraySubType");
					r_ArraySubType.SetBelong(this.instance);
				}
				return r_ArraySubType;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum SafeArraySubType
		/// </summary>
		protected RField r_SafeArraySubType;
		public virtual RField RSafeArraySubType
		{
			get
			{
				if(r_SafeArraySubType == null)
				{
					r_SafeArraySubType = new(this, "SafeArraySubType");
					r_SafeArraySubType.SetBelong(this.instance);
				}
				return r_SafeArraySubType;
			}
		}

		/// <summary>
		/// System.Int32 SizeConst
		/// </summary>
		protected RSystem.RInt32 r_SizeConst;
		public virtual RSystem.RInt32 RSizeConst
		{
			get
			{
				if(r_SizeConst == null)
				{
					r_SizeConst = new(this, "SizeConst");
					r_SizeConst.SetBelong(this.instance);
				}
				return r_SizeConst;
			}
		}

		/// <summary>
		/// System.Int32 IidParameterIndex
		/// </summary>
		protected RSystem.RInt32 r_IidParameterIndex;
		public virtual RSystem.RInt32 RIidParameterIndex
		{
			get
			{
				if(r_IidParameterIndex == null)
				{
					r_IidParameterIndex = new(this, "IidParameterIndex");
					r_IidParameterIndex.SetBelong(this.instance);
				}
				return r_IidParameterIndex;
			}
		}

		/// <summary>
		/// System.Int16 SizeParamIndex
		/// </summary>
		protected RSystem.RInt16 r_SizeParamIndex;
		public virtual RSystem.RInt16 RSizeParamIndex
		{
			get
			{
				if(r_SizeParamIndex == null)
				{
					r_SizeParamIndex = new(this, "SizeParamIndex");
					r_SizeParamIndex.SetBelong(this.instance);
				}
				return r_SizeParamIndex;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Value
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
		/// System.Runtime.InteropServices.MarshalAsAttribute Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
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


        public RMarshalAsAttribute() : base("System.Runtime.InteropServices.MarshalAsAttribute")
        {
        }

        public RMarshalAsAttribute(System.Object instance) : base("System.Runtime.InteropServices.MarshalAsAttribute")
		{
            SetInstance(instance);
		}

        public RMarshalAsAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMarshalAsAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.InteropServices.MarshalAsAttribute Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.MarshalAsAttribute)___result;
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
