using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TypedReference
	/// </summary>
    public partial class RTypedReference : RMember //
    {

		/// <summary>
		/// System.RuntimeTypeHandle type
		/// </summary>
		protected RSystem.RRuntimeTypeHandle r_type;
		public virtual RSystem.RRuntimeTypeHandle Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.IntPtr Value
		/// </summary>
		protected RField r_Value;
		public virtual RField RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value");
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// System.IntPtr Type
		/// </summary>
		protected RField r_Type;
		public virtual RField RType
		{
			get
			{
				if(r_Type == null)
				{
					r_Type = new(this, "Type");
					r_Type.SetBelong(this.instance);
				}
				return r_Type;
			}
		}

		/// <summary>
		/// Boolean IsNull
		/// </summary>
		protected RProperty r_IsNull;
		public virtual RProperty RIsNull
		{
			get
			{
				if(r_IsNull == null)
				{
					r_IsNull = new(this, "IsNull", -1);
					r_IsNull.SetBelong(this.instance);
				}
				return r_IsNull;
			}
		}

		/// <summary>
		/// TypedReference MakeTypedReference(System.Object, System.Reflection.FieldInfo[])
		/// </summary>
		protected static RMethod r_MakeTypedReference_Object_FieldInfoArray;
		public static RMethod RMakeTypedReference_Object_FieldInfoArray
		{
			get
			{
				if(r_MakeTypedReference_Object_FieldInfoArray == null)
				{
					r_MakeTypedReference_Object_FieldInfoArray = new(typeof(System.TypedReference), "MakeTypedReference", 0, typeof(System.Object), typeof(System.Reflection.FieldInfo).MakeArrayType());
					r_MakeTypedReference_Object_FieldInfoArray.SetBelong(null);
				}
				return r_MakeTypedReference_Object_FieldInfoArray;
			}
		}

		/// <summary>
		/// Void InternalMakeTypedReference(Void*, System.Object, IntPtr[], System.RuntimeType)
		/// </summary>
		protected static RMethod r_InternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType;
		public static RMethod RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType
		{
			get
			{
				if(r_InternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType == null)
				{
					r_InternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType = new(typeof(System.TypedReference), "InternalMakeTypedReference", 0, typeof(void).MakePointerType(), typeof(System.Object), typeof(System.IntPtr).MakeArrayType(),  ReleactionUtils.GetType("System.RuntimeType"));
					r_InternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType.SetBelong(null);
				}
				return r_InternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType;
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
		/// System.Object ToObject(TypedReference)
		/// </summary>
		protected static RMethod r_ToObject_TypedReference;
		public static RMethod RToObject_TypedReference
		{
			get
			{
				if(r_ToObject_TypedReference == null)
				{
					r_ToObject_TypedReference = new(typeof(System.TypedReference), "ToObject", 0, typeof(System.TypedReference));
					r_ToObject_TypedReference.SetBelong(null);
				}
				return r_ToObject_TypedReference;
			}
		}

		/// <summary>
		/// System.Object InternalToObject(Void*)
		/// </summary>
		protected static RMethod r_InternalToObject_VoidPointer;
		public static RMethod RInternalToObject_VoidPointer
		{
			get
			{
				if(r_InternalToObject_VoidPointer == null)
				{
					r_InternalToObject_VoidPointer = new(typeof(System.TypedReference), "InternalToObject", 0, typeof(void).MakePointerType());
					r_InternalToObject_VoidPointer.SetBelong(null);
				}
				return r_InternalToObject_VoidPointer;
			}
		}

		/// <summary>
		/// System.Type GetTargetType(TypedReference)
		/// </summary>
		protected static RMethod r_GetTargetType_TypedReference;
		public static RMethod RGetTargetType_TypedReference
		{
			get
			{
				if(r_GetTargetType_TypedReference == null)
				{
					r_GetTargetType_TypedReference = new(typeof(System.TypedReference), "GetTargetType", 0, typeof(System.TypedReference));
					r_GetTargetType_TypedReference.SetBelong(null);
				}
				return r_GetTargetType_TypedReference;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle TargetTypeToken(TypedReference)
		/// </summary>
		protected static RMethod r_TargetTypeToken_TypedReference;
		public static RMethod RTargetTypeToken_TypedReference
		{
			get
			{
				if(r_TargetTypeToken_TypedReference == null)
				{
					r_TargetTypeToken_TypedReference = new(typeof(System.TypedReference), "TargetTypeToken", 0, typeof(System.TypedReference));
					r_TargetTypeToken_TypedReference.SetBelong(null);
				}
				return r_TargetTypeToken_TypedReference;
			}
		}

		/// <summary>
		/// Void SetTypedReference(TypedReference, System.Object)
		/// </summary>
		protected static RMethod r_SetTypedReference_TypedReference_Object;
		public static RMethod RSetTypedReference_TypedReference_Object
		{
			get
			{
				if(r_SetTypedReference_TypedReference_Object == null)
				{
					r_SetTypedReference_TypedReference_Object = new(typeof(System.TypedReference), "SetTypedReference", 0, typeof(System.TypedReference), typeof(System.Object));
					r_SetTypedReference_TypedReference_Object.SetBelong(null);
				}
				return r_SetTypedReference_TypedReference_Object;
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


        public RTypedReference() : base("System.TypedReference")
        {
        }

        public RTypedReference(System.Object instance) : base("System.TypedReference")
		{
            SetInstance(instance);
		}

        public RTypedReference(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypedReference(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object MakeTypedReference(System.Object  @target, System.Reflection.FieldInfo[]  @flds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @flds};
            var ___result = RMakeTypedReference_Object_FieldInfoArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
