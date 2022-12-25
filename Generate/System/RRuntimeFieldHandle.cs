using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.RuntimeFieldHandle
	/// </summary>
    public partial class RRuntimeFieldHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// IntPtr Value
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
		/// Boolean IsNullHandle()
		/// </summary>
		protected RMethod r_RIsNullHandle;
		public virtual RMethod RIsNullHandle
		{
			get
			{
				if(r_RIsNullHandle == null)
				{
					r_RIsNullHandle = new(this, "IsNullHandle", 0);
					r_RIsNullHandle.SetBelong(this.instance);
				}
				return r_RIsNullHandle;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
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
		/// Boolean Equals(System.RuntimeFieldHandle)
		/// </summary>
		protected RMethod r_REquals_RuntimeFieldHandle;
		public virtual RMethod REquals_RuntimeFieldHandle
		{
			get
			{
				if(r_REquals_RuntimeFieldHandle == null)
				{
					r_REquals_RuntimeFieldHandle = new(this, "Equals", 0, typeof(System.RuntimeFieldHandle));
					r_REquals_RuntimeFieldHandle.SetBelong(this.instance);
				}
				return r_REquals_RuntimeFieldHandle;
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
		/// Boolean op_Equality(System.RuntimeFieldHandle, System.RuntimeFieldHandle)
		/// </summary>
		protected static RMethod r_Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle;
		public static RMethod Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle
		{
			get
			{
				if(r_Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle == null)
				{
					r_Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle = new(typeof(System.RuntimeFieldHandle), "op_Equality", 0, typeof(System.RuntimeFieldHandle), typeof(System.RuntimeFieldHandle));
					r_Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle.SetBelong(null);
				}
				return r_Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeFieldHandle, System.RuntimeFieldHandle)
		/// </summary>
		protected static RMethod r_Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle;
		public static RMethod Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle
		{
			get
			{
				if(r_Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle == null)
				{
					r_Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle = new(typeof(System.RuntimeFieldHandle), "op_Inequality", 0, typeof(System.RuntimeFieldHandle), typeof(System.RuntimeFieldHandle));
					r_Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle.SetBelong(null);
				}
				return r_Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle;
			}
		}

		/// <summary>
		/// Void SetValueInternal(System.Reflection.FieldInfo, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_RSetValueInternal_FieldInfo_Object_Object;
		public static RMethod RSetValueInternal_FieldInfo_Object_Object
		{
			get
			{
				if(r_RSetValueInternal_FieldInfo_Object_Object == null)
				{
					r_RSetValueInternal_FieldInfo_Object_Object = new(typeof(System.RuntimeFieldHandle), "SetValueInternal", 0, typeof(System.Reflection.FieldInfo), typeof(System.Object), typeof(System.Object));
					r_RSetValueInternal_FieldInfo_Object_Object.SetBelong(null);
				}
				return r_RSetValueInternal_FieldInfo_Object_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Reflection.RuntimeFieldInfo, System.Object, System.Object, System.RuntimeType, System.Reflection.FieldAttributes, System.RuntimeType, Boolean ByRef)
		/// </summary>
		protected static RMethod r_RSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean;
		public static RMethod RSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean
		{
			get
			{
				if(r_RSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean == null)
				{
					r_RSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean = new(typeof(System.RuntimeFieldHandle), "SetValue", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeFieldInfo"), typeof(System.Object), typeof(System.Object),  ReleactionUtils.GetType("System.RuntimeType"), typeof(System.Reflection.FieldAttributes),  ReleactionUtils.GetType("System.RuntimeType"), typeof(System.Boolean).MakeByRefType());
					r_RSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean.SetBelong(null);
				}
				return r_RSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetValueDirect(System.Reflection.RuntimeFieldInfo, System.RuntimeType, Void*, System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType;
		public static RMethod RGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType
		{
			get
			{
				if(r_RGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType == null)
				{
					r_RGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType = new(typeof(System.RuntimeFieldHandle), "GetValueDirect", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeFieldInfo"),  ReleactionUtils.GetType("System.RuntimeType"), typeof(void).MakePointerType(),  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType.SetBelong(null);
				}
				return r_RGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType;
			}
		}

		/// <summary>
		/// Void SetValueDirect(System.Reflection.RuntimeFieldInfo, System.RuntimeType, Void*, System.Object, System.RuntimeType)
		/// </summary>
		protected static RMethod r_RSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType;
		public static RMethod RSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType
		{
			get
			{
				if(r_RSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType == null)
				{
					r_RSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType = new(typeof(System.RuntimeFieldHandle), "SetValueDirect", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeFieldInfo"),  ReleactionUtils.GetType("System.RuntimeType"), typeof(void).MakePointerType(), typeof(System.Object),  ReleactionUtils.GetType("System.RuntimeType"));
					r_RSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType.SetBelong(null);
				}
				return r_RSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType;
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


        public RRuntimeFieldHandle() : base("System.RuntimeFieldHandle")
        {
        }

        public RRuntimeFieldHandle(System.Object instance) : base("System.RuntimeFieldHandle")
		{
            SetInstance(instance);
		}

        public RRuntimeFieldHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeFieldHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsNullHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsNullHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.RuntimeFieldHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REquals_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.RuntimeFieldHandle  @left, System.RuntimeFieldHandle  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_RuntimeFieldHandle_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.RuntimeFieldHandle  @left, System.RuntimeFieldHandle  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetValueInternal(System.Reflection.FieldInfo  @fi, System.Object  @obj, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fi, @obj, @value};
            var ___result = RSetValueInternal_FieldInfo_Object_Object.Invoke(___genericsType, ___parameters);

            
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
