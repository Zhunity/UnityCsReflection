
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.RuntimeFieldHandle
	/// </summary>
    public partial class RRuntimeFieldHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.RuntimeFieldHandle);
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


		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPValue
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
		/// Boolean IsNullHandle()
		/// </summary>
		protected RMethod r_MIsNullHandle;
		public virtual RMethod RMIsNullHandle
		{
			get
			{
				if(r_MIsNullHandle == null)
				{
					r_MIsNullHandle = new(this, "IsNullHandle", 0);
				}
				return r_MIsNullHandle;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
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
		/// Boolean Equals(System.RuntimeFieldHandle)
		/// </summary>
		protected RMethod r_MEquals_RuntimeFieldHandle;
		public virtual RMethod RMEquals_RuntimeFieldHandle
		{
			get
			{
				if(r_MEquals_RuntimeFieldHandle == null)
				{
					r_MEquals_RuntimeFieldHandle = new(this, "Equals", 0, typeof(System.RuntimeFieldHandle));
				}
				return r_MEquals_RuntimeFieldHandle;
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
		/// Boolean op_Equality(System.RuntimeFieldHandle, System.RuntimeFieldHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_RuntimeFieldHandle_RuntimeFieldHandle;
		public static RMethod RMop_Equality_RuntimeFieldHandle_RuntimeFieldHandle
		{
			get
			{
				if(r_Mop_Equality_RuntimeFieldHandle_RuntimeFieldHandle == null)
				{
					r_Mop_Equality_RuntimeFieldHandle_RuntimeFieldHandle = new(Type, "op_Equality", 0, typeof(System.RuntimeFieldHandle), typeof(System.RuntimeFieldHandle));
				}
				return r_Mop_Equality_RuntimeFieldHandle_RuntimeFieldHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeFieldHandle, System.RuntimeFieldHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle;
		public static RMethod RMop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle
		{
			get
			{
				if(r_Mop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle == null)
				{
					r_Mop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle = new(Type, "op_Inequality", 0, typeof(System.RuntimeFieldHandle), typeof(System.RuntimeFieldHandle));
				}
				return r_Mop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle;
			}
		}

		/// <summary>
		/// Void SetValueInternal(System.Reflection.FieldInfo, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MSetValueInternal_FieldInfo_Object_Object;
		public static RMethod RMSetValueInternal_FieldInfo_Object_Object
		{
			get
			{
				if(r_MSetValueInternal_FieldInfo_Object_Object == null)
				{
					r_MSetValueInternal_FieldInfo_Object_Object = new(Type, "SetValueInternal", 0, typeof(System.Reflection.FieldInfo), typeof(System.Object), typeof(System.Object));
				}
				return r_MSetValueInternal_FieldInfo_Object_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Reflection.RuntimeFieldInfo, System.Object, System.Object, System.RuntimeType, System.Reflection.FieldAttributes, System.RuntimeType, Boolean ByRef)
		/// </summary>
		protected static RMethod r_MSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean;
		public static RMethod RMSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean
		{
			get
			{
				if(r_MSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean == null)
				{
					r_MSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean = new(Type, "SetValue", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"), typeof(System.Object), typeof(System.Object),  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Reflection.FieldAttributes),  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Boolean).MakeByRefType());
				}
				return r_MSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetValueDirect(System.Reflection.RuntimeFieldInfo, System.RuntimeType, Void*, System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType;
		public static RMethod RMGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType
		{
			get
			{
				if(r_MGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType == null)
				{
					r_MGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType = new(Type, "GetValueDirect", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"),  ReflectionUtils.GetType("System.RuntimeType"), typeof(void).MakePointerType(),  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType;
			}
		}

		/// <summary>
		/// Void SetValueDirect(System.Reflection.RuntimeFieldInfo, System.RuntimeType, Void*, System.Object, System.RuntimeType)
		/// </summary>
		protected static RMethod r_MSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType;
		public static RMethod RMSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType
		{
			get
			{
				if(r_MSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType == null)
				{
					r_MSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType = new(Type, "SetValueDirect", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"),  ReflectionUtils.GetType("System.RuntimeType"), typeof(void).MakePointerType(), typeof(System.Object),  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType;
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


        public virtual System.Boolean IsNullHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNullHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.RuntimeFieldHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEquals_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.RuntimeFieldHandle @left, System.RuntimeFieldHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_RuntimeFieldHandle_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.RuntimeFieldHandle @left, System.RuntimeFieldHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_RuntimeFieldHandle_RuntimeFieldHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void SetValueInternal(System.Reflection.FieldInfo @fi, System.Object @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fi, @obj, @value};
            var ___result = RMSetValueInternal_FieldInfo_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetValue(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo @field, System.Object @obj, System.Object @value, Hvak.Editor.Refleaction.RSystem.RRuntimeType @fieldType, System.Reflection.FieldAttributes @fieldAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType @declaringType, ref System.Boolean @domainInitialized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field.Value, @obj, @value, @fieldType.Value, @fieldAttr, @declaringType.Value, @domainInitialized};
            var ___result = RMSetValue_RuntimeFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_Ref_Boolean.Invoke(___genericsType, ___parameters);
			@domainInitialized = (System.Boolean)___parameters[6];

            
        }


        public unsafe static System.Object GetValueDirect(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo @field, Hvak.Editor.Refleaction.RSystem.RRuntimeType @fieldType, void* @pTypedRef, Hvak.Editor.Refleaction.RSystem.RRuntimeType @contextType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field.Value, @fieldType.Value, Pointer.Box(@pTypedRef, typeof(void)), @contextType.Value};
            var ___result = RMGetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public unsafe static void SetValueDirect(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo @field, Hvak.Editor.Refleaction.RSystem.RRuntimeType @fieldType, void* @pTypedRef, System.Object @value, Hvak.Editor.Refleaction.RSystem.RRuntimeType @contextType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field.Value, @fieldType.Value, Pointer.Box(@pTypedRef, typeof(void)), @value, @contextType.Value};
            var ___result = RMSetValueDirect_RuntimeFieldInfo_RuntimeType_VoidPointer_Object_RuntimeType.Invoke(___genericsType, ___parameters);

            
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
