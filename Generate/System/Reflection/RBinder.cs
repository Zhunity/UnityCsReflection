using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.Binder
	/// </summary>
    public partial class RBinder : RMember //
    {

		/// <summary>
		/// System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags, System.Reflection.FieldInfo[], System.Object, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo;
		public virtual RMethod RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo
		{
			get
			{
				if(r_RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo == null)
				{
					r_RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo = new(this, "BindToField", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.FieldInfo).MakeArrayType(), typeof(System.Object), typeof(System.Globalization.CultureInfo));
					r_RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo.SetBelong(this.instance);
				}
				return r_RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags, System.Reflection.MethodBase[], System.Object[] ByRef, System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[], System.Object ByRef)
		/// </summary>
		protected RMethod r_RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object;
		public virtual RMethod RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object
		{
			get
			{
				if(r_RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object == null)
				{
					r_RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object = new(this, "BindToMethod", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MethodBase).MakeArrayType(), typeof(System.Object).MakeArrayType().MakeByRefType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType(), typeof(System.Object).MakeByRefType());
					r_RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object.SetBelong(this.instance);
				}
				return r_RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Object, System.Type, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RChangeType_Object_Type_CultureInfo;
		public virtual RMethod RChangeType_Object_Type_CultureInfo
		{
			get
			{
				if(r_RChangeType_Object_Type_CultureInfo == null)
				{
					r_RChangeType_Object_Type_CultureInfo = new(this, "ChangeType", 0, typeof(System.Object), typeof(System.Type), typeof(System.Globalization.CultureInfo));
					r_RChangeType_Object_Type_CultureInfo.SetBelong(this.instance);
				}
				return r_RChangeType_Object_Type_CultureInfo;
			}
		}

		/// <summary>
		/// Void ReorderArgumentArray(System.Object[] ByRef, System.Object)
		/// </summary>
		protected RMethod r_RReorderArgumentArray_Ref_ObjectArray_Object;
		public virtual RMethod RReorderArgumentArray_Ref_ObjectArray_Object
		{
			get
			{
				if(r_RReorderArgumentArray_Ref_ObjectArray_Object == null)
				{
					r_RReorderArgumentArray_Ref_ObjectArray_Object = new(this, "ReorderArgumentArray", 0, typeof(System.Object).MakeArrayType().MakeByRefType(), typeof(System.Object));
					r_RReorderArgumentArray_Ref_ObjectArray_Object.SetBelong(this.instance);
				}
				return r_RReorderArgumentArray_Ref_ObjectArray_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags, System.Reflection.MethodBase[], System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray;
		public virtual RMethod RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray == null)
				{
					r_RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray = new(this, "SelectMethod", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MethodBase).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags, System.Reflection.PropertyInfo[], System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray == null)
				{
					r_RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray = new(this, "SelectProperty", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.PropertyInfo).MakeArrayType(), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// Boolean CanChangeType(System.Object, System.Type, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RCanChangeType_Object_Type_CultureInfo;
		public virtual RMethod RCanChangeType_Object_Type_CultureInfo
		{
			get
			{
				if(r_RCanChangeType_Object_Type_CultureInfo == null)
				{
					r_RCanChangeType_Object_Type_CultureInfo = new(this, "CanChangeType", 0, typeof(System.Object), typeof(System.Type), typeof(System.Globalization.CultureInfo));
					r_RCanChangeType_Object_Type_CultureInfo.SetBelong(this.instance);
				}
				return r_RCanChangeType_Object_Type_CultureInfo;
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

        public virtual System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.FieldInfo[]  @match, System.Object  @value, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @value, @culture};
            var ___result = RBindToField_BindingFlags_FieldInfoArray_Object_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.MethodBase[]  @match, ref System.Object[]  @args, System.Reflection.ParameterModifier[]  @modifiers, System.Globalization.CultureInfo  @culture, System.String[]  @names, out System.Object  @state)
        {
			state = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @args, @modifiers, @culture, @names, @state};
            var ___result = RBindToMethod_BindingFlags_MethodBaseArray_Ref_ObjectArray_ParameterModifierArray_CultureInfo_StringArray_Out_Object.Invoke(___genericsType, ___parameters);
			args = (System.Object[])___parameters[2];
			state = (System.Object)___parameters[6];

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Object ChangeType(System.Object  @value, System.Type  @type, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type, @culture};
            var ___result = RChangeType_Object_Type_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ReorderArgumentArray(ref System.Object[]  @args, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args, @state};
            var ___result = RReorderArgumentArray_Ref_ObjectArray_Object.Invoke(___genericsType, ___parameters);
			args = (System.Object[])___parameters[0];

            
        }


        public virtual System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.MethodBase[]  @match, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @types, @modifiers};
            var ___result = RSelectMethod_BindingFlags_MethodBaseArray_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.PropertyInfo[]  @match, System.Type  @returnType, System.Type[]  @indexes, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @match, @returnType, @indexes, @modifiers};
            var ___result = RSelectProperty_BindingFlags_PropertyInfoArray_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Boolean CanChangeType(System.Object  @value, System.Type  @type, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type, @culture};
            var ___result = RCanChangeType_Object_Type_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
