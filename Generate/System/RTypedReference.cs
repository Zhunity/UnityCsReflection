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
		protected static RMethod r_RMakeTypedReference_Object_FieldInfoArray;
		public static RMethod RMakeTypedReference_Object_FieldInfoArray
		{
			get
			{
				if(r_RMakeTypedReference_Object_FieldInfoArray == null)
				{
					r_RMakeTypedReference_Object_FieldInfoArray = new(typeof(System.TypedReference), "MakeTypedReference", 0, typeof(System.Object), typeof(System.Reflection.FieldInfo).MakeArrayType());
					r_RMakeTypedReference_Object_FieldInfoArray.SetBelong(null);
				}
				return r_RMakeTypedReference_Object_FieldInfoArray;
			}
		}

		/// <summary>
		/// Void InternalMakeTypedReference(Void*, System.Object, IntPtr[], System.RuntimeType)
		/// </summary>
		protected static RMethod r_RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType;
		public static RMethod RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType
		{
			get
			{
				if(r_RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType == null)
				{
					r_RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType = new(typeof(System.TypedReference), "InternalMakeTypedReference", 0, typeof(void).MakePointerType(), typeof(System.Object), typeof(System.IntPtr).MakeArrayType(),  ReleactionUtils.GetType("System.RuntimeType"));
					r_RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType.SetBelong(null);
				}
				return r_RInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType;
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
		/// System.Object ToObject(TypedReference)
		/// </summary>
		protected static RMethod r_RToObject_TypedReference;
		public static RMethod RToObject_TypedReference
		{
			get
			{
				if(r_RToObject_TypedReference == null)
				{
					r_RToObject_TypedReference = new(typeof(System.TypedReference), "ToObject", 0, typeof(System.TypedReference));
					r_RToObject_TypedReference.SetBelong(null);
				}
				return r_RToObject_TypedReference;
			}
		}

		/// <summary>
		/// System.Object InternalToObject(Void*)
		/// </summary>
		protected static RMethod r_RInternalToObject_VoidPointer;
		public static RMethod RInternalToObject_VoidPointer
		{
			get
			{
				if(r_RInternalToObject_VoidPointer == null)
				{
					r_RInternalToObject_VoidPointer = new(typeof(System.TypedReference), "InternalToObject", 0, typeof(void).MakePointerType());
					r_RInternalToObject_VoidPointer.SetBelong(null);
				}
				return r_RInternalToObject_VoidPointer;
			}
		}

		/// <summary>
		/// System.Type GetTargetType(TypedReference)
		/// </summary>
		protected static RMethod r_RGetTargetType_TypedReference;
		public static RMethod RGetTargetType_TypedReference
		{
			get
			{
				if(r_RGetTargetType_TypedReference == null)
				{
					r_RGetTargetType_TypedReference = new(typeof(System.TypedReference), "GetTargetType", 0, typeof(System.TypedReference));
					r_RGetTargetType_TypedReference.SetBelong(null);
				}
				return r_RGetTargetType_TypedReference;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle TargetTypeToken(TypedReference)
		/// </summary>
		protected static RMethod r_RTargetTypeToken_TypedReference;
		public static RMethod RTargetTypeToken_TypedReference
		{
			get
			{
				if(r_RTargetTypeToken_TypedReference == null)
				{
					r_RTargetTypeToken_TypedReference = new(typeof(System.TypedReference), "TargetTypeToken", 0, typeof(System.TypedReference));
					r_RTargetTypeToken_TypedReference.SetBelong(null);
				}
				return r_RTargetTypeToken_TypedReference;
			}
		}

		/// <summary>
		/// Void SetTypedReference(TypedReference, System.Object)
		/// </summary>
		protected static RMethod r_RSetTypedReference_TypedReference_Object;
		public static RMethod RSetTypedReference_TypedReference_Object
		{
			get
			{
				if(r_RSetTypedReference_TypedReference_Object == null)
				{
					r_RSetTypedReference_TypedReference_Object = new(typeof(System.TypedReference), "SetTypedReference", 0, typeof(System.TypedReference), typeof(System.Object));
					r_RSetTypedReference_TypedReference_Object.SetBelong(null);
				}
				return r_RSetTypedReference_TypedReference_Object;
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
