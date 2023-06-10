
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.Binder
	/// </summary>
    public partial class RBinder : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Binder);
            }
        }

        public RBinder() : base("System.Reflection.Binder")
        {
        }

        public RBinder(System.Object instance) : base("System.Reflection.Binder")
		{
            SetInstance(instance);
		}

        public RBinder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBinder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags, System.Reflection.FieldInfo[], System.Object, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo;
		public virtual RMethod RMBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo
		{
			get
			{
				if(r_MBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo == null)
				{
					r_MBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo = new(this, "BindToField", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.FieldInfo).MakeArrayType(), typeof(System.Object), typeof(System.Globalization.CultureInfo));
				}
				return r_MBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags, System.Reflection.MethodBase[], System.Object[] ByRef, System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[], System.Object ByRef)
		/// </summary>
		protected RMethod r_MBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object;
		public virtual RMethod RMBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object
		{
			get
			{
				if(r_MBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object == null)
				{
					r_MBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object = new(this, "BindToMethod", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MethodBase).MakeArrayType(), typeof(System.Object).MakeArrayType().MakeByRefType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType(), typeof(System.Object).MakeByRefType());
				}
				return r_MBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Object, System.Type, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MChangeType_Object_Type_CultureInfo;
		public virtual RMethod RMChangeType_Object_Type_CultureInfo
		{
			get
			{
				if(r_MChangeType_Object_Type_CultureInfo == null)
				{
					r_MChangeType_Object_Type_CultureInfo = new(this, "ChangeType", 0, typeof(System.Object), typeof(System.Type), typeof(System.Globalization.CultureInfo));
				}
				return r_MChangeType_Object_Type_CultureInfo;
			}
		}

		/// <summary>
		/// Void ReorderArgumentArray(System.Object[] ByRef, System.Object)
		/// </summary>
		protected RMethod r_MReorderArgumentArray_Ref_ObjectArray_Object;
		public virtual RMethod RMReorderArgumentArray_Ref_ObjectArray_Object
		{
			get
			{
				if(r_MReorderArgumentArray_Ref_ObjectArray_Object == null)
				{
					r_MReorderArgumentArray_Ref_ObjectArray_Object = new(this, "ReorderArgumentArray", 0, typeof(System.Object).MakeArrayType().MakeByRefType(), typeof(System.Object));
				}
				return r_MReorderArgumentArray_Ref_ObjectArray_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags, System.Reflection.MethodBase[], System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray;
		public virtual RMethod RMSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray == null)
				{
					r_MSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray = new(this, "SelectMethod", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MethodBase).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags, System.Reflection.PropertyInfo[], System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray = new(this, "SelectProperty", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.PropertyInfo).MakeArrayType(), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// Boolean CanChangeType(System.Object, System.Type, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MCanChangeType_Object_Type_CultureInfo;
		public virtual RMethod RMCanChangeType_Object_Type_CultureInfo
		{
			get
			{
				if(r_MCanChangeType_Object_Type_CultureInfo == null)
				{
					r_MCanChangeType_Object_Type_CultureInfo = new(this, "CanChangeType", 0, typeof(System.Object), typeof(System.Type), typeof(System.Globalization.CultureInfo));
				}
				return r_MCanChangeType_Object_Type_CultureInfo;
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


        public virtual System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags @bindingAttr, System.Reflection.FieldInfo[] @match, System.Object @value, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @value, @culture};
            var ___result = RMBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags @bindingAttr, System.Reflection.MethodBase[] @match, ref System.Object[] @args, System.Reflection.ParameterModifier[] @modifiers, System.Globalization.CultureInfo @culture, System.String[] @names, out System.Object @state)
        {
			@state = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @args, @modifiers, @culture, @names, @state};
            var ___result = RMBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object.Invoke(___genericsType, ___parameters);
			@args = (System.Object[])___parameters[2];
			@state = (System.Object)___parameters[6];

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Object ChangeType(System.Object @value, System.Type @type, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type, @culture};
            var ___result = RMChangeType_Object_Type_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ReorderArgumentArray(ref System.Object[] @args, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args, @state};
            var ___result = RMReorderArgumentArray_Ref_ObjectArray_Object.Invoke(___genericsType, ___parameters);
			@args = (System.Object[])___parameters[0];

            
        }


        public virtual System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags @bindingAttr, System.Reflection.MethodBase[] @match, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @types, @modifiers};
            var ___result = RMSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags @bindingAttr, System.Reflection.PropertyInfo[] @match, System.Type @returnType, System.Type[] @indexes, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @returnType, @indexes, @modifiers};
            var ___result = RMSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Boolean CanChangeType(System.Object @value, System.Type @type, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type, @culture};
            var ___result = RMCanChangeType_Object_Type_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
