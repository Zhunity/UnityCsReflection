using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.CustomAttributeData
	/// </summary>
    public partial class RCustomAttributeData : RMember //
    {

		/// <summary>
		/// System.Reflection.ConstructorInfo ctorInfo
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_ctorInfo;
		public virtual RSystem.RReflection.RConstructorInfo RctorInfo
		{
			get
			{
				if(r_ctorInfo == null)
				{
					r_ctorInfo = new(this, "ctorInfo");
					r_ctorInfo.SetBelong(this.instance);
				}
				return r_ctorInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeTypedArgument] ctorArgs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeTypedArgument> r_ctorArgs;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeTypedArgument> RctorArgs
		{
			get
			{
				if(r_ctorArgs == null)
				{
					r_ctorArgs = new(this, "ctorArgs");
					r_ctorArgs.SetBelong(this.instance);
				}
				return r_ctorArgs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeNamedArgument] namedArgs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeNamedArgument> r_namedArgs;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeNamedArgument> RnamedArgs
		{
			get
			{
				if(r_namedArgs == null)
				{
					r_namedArgs = new(this, "namedArgs");
					r_namedArgs.SetBelong(this.instance);
				}
				return r_namedArgs;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData+LazyCAttrData lazyData
		/// </summary>
		protected RSystem.RReflection.RCustomAttributeData.RLazyCAttrData r_lazyData;
		public virtual RSystem.RReflection.RCustomAttributeData.RLazyCAttrData RlazyData
		{
			get
			{
				if(r_lazyData == null)
				{
					r_lazyData = new(this, "lazyData");
					r_lazyData.SetBelong(this.instance);
				}
				return r_lazyData;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo Constructor
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_Constructor;
		public virtual RSystem.RReflection.RConstructorInfo RConstructor
		{
			get
			{
				if(r_Constructor == null)
				{
					r_Constructor = new(this, "Constructor", -1);
					r_Constructor.SetBelong(this.instance);
				}
				return r_Constructor;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeTypedArgument] ConstructorArguments
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeTypedArgument> r_ConstructorArguments;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeTypedArgument> RConstructorArguments
		{
			get
			{
				if(r_ConstructorArguments == null)
				{
					r_ConstructorArguments = new(this, "ConstructorArguments", -1);
					r_ConstructorArguments.SetBelong(this.instance);
				}
				return r_ConstructorArguments;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeNamedArgument] NamedArguments
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeNamedArgument> r_NamedArguments;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RReflection.RCustomAttributeNamedArgument> RNamedArguments
		{
			get
			{
				if(r_NamedArguments == null)
				{
					r_NamedArguments = new(this, "NamedArguments", -1);
					r_NamedArguments.SetBelong(this.instance);
				}
				return r_NamedArguments;
			}
		}

		/// <summary>
		/// System.Type AttributeType
		/// </summary>
		protected RSystem.RType r_AttributeType;
		public virtual RSystem.RType RAttributeType
		{
			get
			{
				if(r_AttributeType == null)
				{
					r_AttributeType = new(this, "AttributeType", -1);
					r_AttributeType.SetBelong(this.instance);
				}
				return r_AttributeType;
			}
		}

		/// <summary>
		/// Void ResolveArgumentsInternal(System.Reflection.ConstructorInfo, System.Reflection.Assembly, IntPtr, UInt32, System.Object[] ByRef, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray;
		public static RMethod RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray
		{
			get
			{
				if(r_RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray == null)
				{
					r_RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray = new(typeof(System.Reflection.CustomAttributeData), "ResolveArgumentsInternal", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Reflection.Assembly), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.Object).MakeArrayType().MakeByRefType(), typeof(System.Object).MakeArrayType().MakeByRefType());
					r_RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray.SetBelong(null);
				}
				return r_RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray;
			}
		}

		/// <summary>
		/// Void ResolveArguments()
		/// </summary>
		protected RMethod r_RResolveArguments;
		public virtual RMethod RResolveArguments
		{
			get
			{
				if(r_RResolveArguments == null)
				{
					r_RResolveArguments = new(this, "ResolveArguments", 0);
					r_RResolveArguments.SetBelong(this.instance);
				}
				return r_RResolveArguments;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RGetCustomAttributes_Assembly;
		public static RMethod RGetCustomAttributes_Assembly
		{
			get
			{
				if(r_RGetCustomAttributes_Assembly == null)
				{
					r_RGetCustomAttributes_Assembly = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.Assembly));
					r_RGetCustomAttributes_Assembly.SetBelong(null);
				}
				return r_RGetCustomAttributes_Assembly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.MemberInfo)
		/// </summary>
		protected static RMethod r_RGetCustomAttributes_MemberInfo;
		public static RMethod RGetCustomAttributes_MemberInfo
		{
			get
			{
				if(r_RGetCustomAttributes_MemberInfo == null)
				{
					r_RGetCustomAttributes_MemberInfo = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.MemberInfo));
					r_RGetCustomAttributes_MemberInfo.SetBelong(null);
				}
				return r_RGetCustomAttributes_MemberInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesInternal(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetCustomAttributesInternal_RuntimeType;
		public static RMethod RGetCustomAttributesInternal_RuntimeType
		{
			get
			{
				if(r_RGetCustomAttributesInternal_RuntimeType == null)
				{
					r_RGetCustomAttributesInternal_RuntimeType = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributesInternal", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetCustomAttributesInternal_RuntimeType.SetBelong(null);
				}
				return r_RGetCustomAttributesInternal_RuntimeType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_RGetCustomAttributes_Module;
		public static RMethod RGetCustomAttributes_Module
		{
			get
			{
				if(r_RGetCustomAttributes_Module == null)
				{
					r_RGetCustomAttributes_Module = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.Module));
					r_RGetCustomAttributes_Module.SetBelong(null);
				}
				return r_RGetCustomAttributes_Module;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.ParameterInfo)
		/// </summary>
		protected static RMethod r_RGetCustomAttributes_ParameterInfo;
		public static RMethod RGetCustomAttributes_ParameterInfo
		{
			get
			{
				if(r_RGetCustomAttributes_ParameterInfo == null)
				{
					r_RGetCustomAttributes_ParameterInfo = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.ParameterInfo));
					r_RGetCustomAttributes_ParameterInfo.SetBelong(null);
				}
				return r_RGetCustomAttributes_ParameterInfo;
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
		/// T[] UnboxValues[T](System.Object[])
		/// </summary>
		protected static RMethod r_RUnboxValues_GT_ObjectArray;
		public static RMethod RUnboxValues_GT_ObjectArray
		{
			get
			{
				if(r_RUnboxValues_GT_ObjectArray == null)
				{
					r_RUnboxValues_GT_ObjectArray = new(typeof(System.Reflection.CustomAttributeData), "UnboxValues", 1, typeof(System.Object).MakeArrayType());
					r_RUnboxValues_GT_ObjectArray.SetBelong(null);
				}
				return r_RUnboxValues_GT_ObjectArray;
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


        public RCustomAttributeData() : base("System.Reflection.CustomAttributeData")
        {
        }

        public RCustomAttributeData(System.Object instance) : base("System.Reflection.CustomAttributeData")
		{
            SetInstance(instance);
		}

        public RCustomAttributeData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomAttributeData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void ResolveArgumentsInternal(System.Reflection.ConstructorInfo  @ctor, System.Reflection.Assembly  @assembly, System.IntPtr  @data, System.UInt32  @data_length, out System.Object[]  @ctorArgs, out System.Object[]  @namedArgs)
        {
			ctorArgs = default;
			namedArgs = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctor, @assembly, @data, @data_length, @ctorArgs, @namedArgs};
            var ___result = RResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			ctorArgs = (System.Object[])___parameters[4];
			namedArgs = (System.Object[])___parameters[5];

            
        }


        public virtual void ResolveArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Assembly  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RGetCustomAttributes_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.MemberInfo  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RGetCustomAttributes_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }



        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Module  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RGetCustomAttributes_Module.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.ParameterInfo  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RGetCustomAttributes_ParameterInfo.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static T[] UnboxValues<T>(System.Object[]  @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@values};
            var ___result = RUnboxValues_GT_ObjectArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
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
