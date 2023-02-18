
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.CustomAttributeData
	/// </summary>
    public partial class RCustomAttributeData : RMember //
    {

		/// <summary>
		/// System.Reflection.ConstructorInfo ctorInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo r_FctorInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo RFctorInfo
		{
			get
			{
				if(r_FctorInfo == null)
				{
					r_FctorInfo = new(this, "ctorInfo");
				}
				return r_FctorInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeTypedArgument] ctorArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument> r_FctorArgs;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument> RFctorArgs
		{
			get
			{
				if(r_FctorArgs == null)
				{
					r_FctorArgs = new(this, "ctorArgs");
				}
				return r_FctorArgs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeNamedArgument] namedArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeNamedArgument> r_FnamedArgs;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeNamedArgument> RFnamedArgs
		{
			get
			{
				if(r_FnamedArgs == null)
				{
					r_FnamedArgs = new(this, "namedArgs");
				}
				return r_FnamedArgs;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData+LazyCAttrData lazyData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData.RLazyCAttrData r_FlazyData;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData.RLazyCAttrData RFlazyData
		{
			get
			{
				if(r_FlazyData == null)
				{
					r_FlazyData = new(this, "lazyData");
				}
				return r_FlazyData;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo Constructor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo r_PConstructor;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo RPConstructor
		{
			get
			{
				if(r_PConstructor == null)
				{
					r_PConstructor = new(this, "Constructor", -1);
				}
				return r_PConstructor;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeTypedArgument] ConstructorArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument> r_PConstructorArguments;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument> RPConstructorArguments
		{
			get
			{
				if(r_PConstructorArguments == null)
				{
					r_PConstructorArguments = new(this, "ConstructorArguments", -1);
				}
				return r_PConstructorArguments;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeNamedArgument] NamedArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeNamedArgument> r_PNamedArguments;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeNamedArgument> RPNamedArguments
		{
			get
			{
				if(r_PNamedArguments == null)
				{
					r_PNamedArguments = new(this, "NamedArguments", -1);
				}
				return r_PNamedArguments;
			}
		}

		/// <summary>
		/// System.Type AttributeType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PAttributeType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPAttributeType
		{
			get
			{
				if(r_PAttributeType == null)
				{
					r_PAttributeType = new(this, "AttributeType", -1);
				}
				return r_PAttributeType;
			}
		}

		/// <summary>
		/// Void ResolveArgumentsInternal(System.Reflection.ConstructorInfo, System.Reflection.Assembly, IntPtr, UInt32, System.Object[] ByRef, System.Object[] ByRef)
		/// </summary>
		protected static RMethod r_MResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray;
		public static RMethod RMResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray
		{
			get
			{
				if(r_MResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray == null)
				{
					r_MResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray = new(typeof(System.Reflection.CustomAttributeData), "ResolveArgumentsInternal", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Reflection.Assembly), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.Object).MakeArrayType().MakeByRefType(), typeof(System.Object).MakeArrayType().MakeByRefType());
				}
				return r_MResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray;
			}
		}

		/// <summary>
		/// Void ResolveArguments()
		/// </summary>
		protected RMethod r_MResolveArguments;
		public virtual RMethod RMResolveArguments
		{
			get
			{
				if(r_MResolveArguments == null)
				{
					r_MResolveArguments = new(this, "ResolveArguments", 0);
				}
				return r_MResolveArguments;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MGetCustomAttributes_Assembly;
		public static RMethod RMGetCustomAttributes_Assembly
		{
			get
			{
				if(r_MGetCustomAttributes_Assembly == null)
				{
					r_MGetCustomAttributes_Assembly = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.Assembly));
				}
				return r_MGetCustomAttributes_Assembly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.MemberInfo)
		/// </summary>
		protected static RMethod r_MGetCustomAttributes_MemberInfo;
		public static RMethod RMGetCustomAttributes_MemberInfo
		{
			get
			{
				if(r_MGetCustomAttributes_MemberInfo == null)
				{
					r_MGetCustomAttributes_MemberInfo = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.MemberInfo));
				}
				return r_MGetCustomAttributes_MemberInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesInternal(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetCustomAttributesInternal_RuntimeType;
		public static RMethod RMGetCustomAttributesInternal_RuntimeType
		{
			get
			{
				if(r_MGetCustomAttributesInternal_RuntimeType == null)
				{
					r_MGetCustomAttributesInternal_RuntimeType = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributesInternal", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetCustomAttributesInternal_RuntimeType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_MGetCustomAttributes_Module;
		public static RMethod RMGetCustomAttributes_Module
		{
			get
			{
				if(r_MGetCustomAttributes_Module == null)
				{
					r_MGetCustomAttributes_Module = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.Module));
				}
				return r_MGetCustomAttributes_Module;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributes(System.Reflection.ParameterInfo)
		/// </summary>
		protected static RMethod r_MGetCustomAttributes_ParameterInfo;
		public static RMethod RMGetCustomAttributes_ParameterInfo
		{
			get
			{
				if(r_MGetCustomAttributes_ParameterInfo == null)
				{
					r_MGetCustomAttributes_ParameterInfo = new(typeof(System.Reflection.CustomAttributeData), "GetCustomAttributes", 0, typeof(System.Reflection.ParameterInfo));
				}
				return r_MGetCustomAttributes_ParameterInfo;
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
		/// T[] UnboxValues[T](System.Object[])
		/// </summary>
		protected static RMethod r_MUnboxValues_GT_ObjectArray;
		public static RMethod RMUnboxValues_GT_ObjectArray
		{
			get
			{
				if(r_MUnboxValues_GT_ObjectArray == null)
				{
					r_MUnboxValues_GT_ObjectArray = new(typeof(System.Reflection.CustomAttributeData), "UnboxValues", 1, typeof(System.Object).MakeArrayType());
				}
				return r_MUnboxValues_GT_ObjectArray;
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

        public static void ResolveArgumentsInternal(System.Reflection.ConstructorInfo @ctor, System.Reflection.Assembly @assembly, System.IntPtr @data, System.UInt32 @data_length, out System.Object[] @ctorArgs, out System.Object[] @namedArgs)
        {
			@ctorArgs = default;
			@namedArgs = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctor, @assembly, @data, @data_length, @ctorArgs, @namedArgs};
            var ___result = RMResolveArgumentsInternal_ConstructorInfo_Assembly_IntPtr_UInt32_Out_ObjectArray_Out_ObjectArray.Invoke(___genericsType, ___parameters);
			@ctorArgs = (System.Object[])___parameters[4];
			@namedArgs = (System.Object[])___parameters[5];

            
        }


        public virtual void ResolveArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveArguments.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Assembly @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMGetCustomAttributes_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.MemberInfo @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMGetCustomAttributes_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesInternal(Hvak.Editor.Refleaction.RSystem.RRuntimeType @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target.Value};
            var ___result = RMGetCustomAttributesInternal_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Module @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMGetCustomAttributes_Module.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.ParameterInfo @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMGetCustomAttributes_ParameterInfo.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static T[] UnboxValues<T>(System.Object[] @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@values};
            var ___result = RMUnboxValues_GT_ObjectArray.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
