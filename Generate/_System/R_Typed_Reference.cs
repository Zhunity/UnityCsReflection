
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.TypedReference
	/// </summary>
    public partial class RTypedReference : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.TypedReference);
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


		/// <summary>
		/// System.RuntimeTypeHandle type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle r_Ftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.IntPtr Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_FValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFValue
		{
			get
			{
				if(r_FValue == null)
				{
					r_FValue = new(this, "Value");
				}
				return r_FValue;
			}
		}

		/// <summary>
		/// System.IntPtr Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_FType;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFType
		{
			get
			{
				if(r_FType == null)
				{
					r_FType = new(this, "Type");
				}
				return r_FType;
			}
		}

		/// <summary>
		/// Boolean IsNull
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNull;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNull
		{
			get
			{
				if(r_PIsNull == null)
				{
					r_PIsNull = new(this, "IsNull", -1);
				}
				return r_PIsNull;
			}
		}

		/// <summary>
		/// TypedReference MakeTypedReference(System.Object, System.Reflection.FieldInfo[])
		/// </summary>
		protected static RMethod r_MMakeTypedReference_Object_FieldInfoArray;
		public static RMethod RMMakeTypedReference_Object_FieldInfoArray
		{
			get
			{
				if(r_MMakeTypedReference_Object_FieldInfoArray == null)
				{
					r_MMakeTypedReference_Object_FieldInfoArray = new(Type, "MakeTypedReference", 0, typeof(System.Object), typeof(System.Reflection.FieldInfo).MakeArrayType());
				}
				return r_MMakeTypedReference_Object_FieldInfoArray;
			}
		}

		/// <summary>
		/// Void InternalMakeTypedReference(Void*, System.Object, IntPtr[], System.RuntimeType)
		/// </summary>
		protected static RMethod r_MInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType;
		public static RMethod RMInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType
		{
			get
			{
				if(r_MInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType == null)
				{
					r_MInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType = new(Type, "InternalMakeTypedReference", 0, typeof(void).MakePointerType(), typeof(System.Object), typeof(System.IntPtr).MakeArrayType(),  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType;
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
		/// System.Object ToObject(TypedReference)
		/// </summary>
		protected static RMethod r_MToObject_TypedReference;
		public static RMethod RMToObject_TypedReference
		{
			get
			{
				if(r_MToObject_TypedReference == null)
				{
					r_MToObject_TypedReference = new(Type, "ToObject", 0, typeof(System.TypedReference));
				}
				return r_MToObject_TypedReference;
			}
		}

		/// <summary>
		/// System.Object InternalToObject(Void*)
		/// </summary>
		protected static RMethod r_MInternalToObject_VoidPointer;
		public static RMethod RMInternalToObject_VoidPointer
		{
			get
			{
				if(r_MInternalToObject_VoidPointer == null)
				{
					r_MInternalToObject_VoidPointer = new(Type, "InternalToObject", 0, typeof(void).MakePointerType());
				}
				return r_MInternalToObject_VoidPointer;
			}
		}

		/// <summary>
		/// System.Type GetTargetType(TypedReference)
		/// </summary>
		protected static RMethod r_MGetTargetType_TypedReference;
		public static RMethod RMGetTargetType_TypedReference
		{
			get
			{
				if(r_MGetTargetType_TypedReference == null)
				{
					r_MGetTargetType_TypedReference = new(Type, "GetTargetType", 0, typeof(System.TypedReference));
				}
				return r_MGetTargetType_TypedReference;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle TargetTypeToken(TypedReference)
		/// </summary>
		protected static RMethod r_MTargetTypeToken_TypedReference;
		public static RMethod RMTargetTypeToken_TypedReference
		{
			get
			{
				if(r_MTargetTypeToken_TypedReference == null)
				{
					r_MTargetTypeToken_TypedReference = new(Type, "TargetTypeToken", 0, typeof(System.TypedReference));
				}
				return r_MTargetTypeToken_TypedReference;
			}
		}

		/// <summary>
		/// Void SetTypedReference(TypedReference, System.Object)
		/// </summary>
		protected static RMethod r_MSetTypedReference_TypedReference_Object;
		public static RMethod RMSetTypedReference_TypedReference_Object
		{
			get
			{
				if(r_MSetTypedReference_TypedReference_Object == null)
				{
					r_MSetTypedReference_TypedReference_Object = new(Type, "SetTypedReference", 0, typeof(System.TypedReference), typeof(System.Object));
				}
				return r_MSetTypedReference_TypedReference_Object;
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


        public static Hvak.Editor.Refleaction.RSystem.RTypedReference MakeTypedReference(System.Object @target, System.Reflection.FieldInfo[] @flds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @flds};
            var ___result = RMMakeTypedReference_Object_FieldInfoArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RTypedReference>(___result);
        }


        public unsafe static void InternalMakeTypedReference(void* @result, System.Object @target, System.IntPtr[] @flds, Hvak.Editor.Refleaction.RSystem.RRuntimeType @lastFieldType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@result, typeof(void)), @target, @flds, @lastFieldType.Value};
            var ___result = RMInternalMakeTypedReference_VoidPointer_Object_IntPtrArray_RuntimeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Object ToObject(Hvak.Editor.Refleaction.RSystem.RTypedReference @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMToObject_TypedReference.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public unsafe static System.Object InternalToObject(void* @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(void))};
            var ___result = RMInternalToObject_VoidPointer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static System.Type GetTargetType(Hvak.Editor.Refleaction.RSystem.RTypedReference @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMGetTargetType_TypedReference.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public static System.RuntimeTypeHandle TargetTypeToken(Hvak.Editor.Refleaction.RSystem.RTypedReference @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMTargetTypeToken_TypedReference.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.RuntimeTypeHandle>(___result);
        }


        public static void SetTypedReference(Hvak.Editor.Refleaction.RSystem.RTypedReference @target, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target.Value, @value};
            var ___result = RMSetTypedReference_TypedReference_Object.Invoke(___genericsType, ___parameters);

            
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
