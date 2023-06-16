
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.UnmanagedMarshal
	/// </summary>
    public partial class RUnmanagedMarshal : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.UnmanagedMarshal);
            }
        }

        public RUnmanagedMarshal() : base("System.Reflection.Emit.UnmanagedMarshal")
        {
        }

        public RUnmanagedMarshal(System.Object instance) : base("System.Reflection.Emit.UnmanagedMarshal")
		{
            SetInstance(instance);
		}

        public RUnmanagedMarshal(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnmanagedMarshal(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcount
		{
			get
			{
				if(r_Fcount == null)
				{
					r_Fcount = new(this, "count");
				}
				return r_Fcount;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType t
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_Ft;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFt
		{
			get
			{
				if(r_Ft == null)
				{
					r_Ft = new(this, "t");
				}
				return r_Ft;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType tbase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_Ftbase;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFtbase
		{
			get
			{
				if(r_Ftbase == null)
				{
					r_Ftbase = new(this, "tbase");
				}
				return r_Ftbase;
			}
		}

		/// <summary>
		/// System.String guid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fguid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFguid
		{
			get
			{
				if(r_Fguid == null)
				{
					r_Fguid = new(this, "guid");
				}
				return r_Fguid;
			}
		}

		/// <summary>
		/// System.String mcookie
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fmcookie;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmcookie
		{
			get
			{
				if(r_Fmcookie == null)
				{
					r_Fmcookie = new(this, "mcookie");
				}
				return r_Fmcookie;
			}
		}

		/// <summary>
		/// System.String marshaltype
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fmarshaltype;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmarshaltype
		{
			get
			{
				if(r_Fmarshaltype == null)
				{
					r_Fmarshaltype = new(this, "marshaltype");
				}
				return r_Fmarshaltype;
			}
		}

		/// <summary>
		/// System.Type marshaltyperef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fmarshaltyperef;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFmarshaltyperef
		{
			get
			{
				if(r_Fmarshaltyperef == null)
				{
					r_Fmarshaltyperef = new(this, "marshaltyperef");
				}
				return r_Fmarshaltyperef;
			}
		}

		/// <summary>
		/// System.Int32 param_num
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fparam_num;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFparam_num
		{
			get
			{
				if(r_Fparam_num == null)
				{
					r_Fparam_num = new(this, "param_num");
				}
				return r_Fparam_num;
			}
		}

		/// <summary>
		/// System.Boolean has_size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fhas_size;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhas_size
		{
			get
			{
				if(r_Fhas_size == null)
				{
					r_Fhas_size = new(this, "has_size");
				}
				return r_Fhas_size;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType BaseType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_PBaseType;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RPBaseType
		{
			get
			{
				if(r_PBaseType == null)
				{
					r_PBaseType = new(this, "BaseType", -1);
				}
				return r_PBaseType;
			}
		}

		/// <summary>
		/// Int32 ElementCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PElementCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPElementCount
		{
			get
			{
				if(r_PElementCount == null)
				{
					r_PElementCount = new(this, "ElementCount", -1);
				}
				return r_PElementCount;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType GetUnmanagedType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_PGetUnmanagedType;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RPGetUnmanagedType
		{
			get
			{
				if(r_PGetUnmanagedType == null)
				{
					r_PGetUnmanagedType = new(this, "GetUnmanagedType", -1);
				}
				return r_PGetUnmanagedType;
			}
		}

		/// <summary>
		/// System.Guid IIDGuid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PIIDGuid;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPIIDGuid
		{
			get
			{
				if(r_PIIDGuid == null)
				{
					r_PIIDGuid = new(this, "IIDGuid", -1);
				}
				return r_PIIDGuid;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineByValArray(Int32)
		/// </summary>
		protected static RMethod r_MDefineByValArray_Int32;
		public static RMethod RMDefineByValArray_Int32
		{
			get
			{
				if(r_MDefineByValArray_Int32 == null)
				{
					r_MDefineByValArray_Int32 = new(Type, "DefineByValArray", 0, typeof(System.Int32));
				}
				return r_MDefineByValArray_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineByValTStr(Int32)
		/// </summary>
		protected static RMethod r_MDefineByValTStr_Int32;
		public static RMethod RMDefineByValTStr_Int32
		{
			get
			{
				if(r_MDefineByValTStr_Int32 == null)
				{
					r_MDefineByValTStr_Int32 = new(Type, "DefineByValTStr", 0, typeof(System.Int32));
				}
				return r_MDefineByValTStr_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineLPArray(System.Runtime.InteropServices.UnmanagedType)
		/// </summary>
		protected static RMethod r_MDefineLPArray_UnmanagedType;
		public static RMethod RMDefineLPArray_UnmanagedType
		{
			get
			{
				if(r_MDefineLPArray_UnmanagedType == null)
				{
					r_MDefineLPArray_UnmanagedType = new(Type, "DefineLPArray", 0, typeof(System.Runtime.InteropServices.UnmanagedType));
				}
				return r_MDefineLPArray_UnmanagedType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineSafeArray(System.Runtime.InteropServices.UnmanagedType)
		/// </summary>
		protected static RMethod r_MDefineSafeArray_UnmanagedType;
		public static RMethod RMDefineSafeArray_UnmanagedType
		{
			get
			{
				if(r_MDefineSafeArray_UnmanagedType == null)
				{
					r_MDefineSafeArray_UnmanagedType = new(Type, "DefineSafeArray", 0, typeof(System.Runtime.InteropServices.UnmanagedType));
				}
				return r_MDefineSafeArray_UnmanagedType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineUnmanagedMarshal(System.Runtime.InteropServices.UnmanagedType)
		/// </summary>
		protected static RMethod r_MDefineUnmanagedMarshal_UnmanagedType;
		public static RMethod RMDefineUnmanagedMarshal_UnmanagedType
		{
			get
			{
				if(r_MDefineUnmanagedMarshal_UnmanagedType == null)
				{
					r_MDefineUnmanagedMarshal_UnmanagedType = new(Type, "DefineUnmanagedMarshal", 0, typeof(System.Runtime.InteropServices.UnmanagedType));
				}
				return r_MDefineUnmanagedMarshal_UnmanagedType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineCustom(System.Type, System.String, System.String, System.Guid)
		/// </summary>
		protected static RMethod r_MDefineCustom_Type_String_String_Guid;
		public static RMethod RMDefineCustom_Type_String_String_Guid
		{
			get
			{
				if(r_MDefineCustom_Type_String_String_Guid == null)
				{
					r_MDefineCustom_Type_String_String_Guid = new(Type, "DefineCustom", 0, typeof(System.Type), typeof(System.String), typeof(System.String), typeof(System.Guid));
				}
				return r_MDefineCustom_Type_String_String_Guid;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal DefineLPArrayInternal(System.Runtime.InteropServices.UnmanagedType, Int32, Int32)
		/// </summary>
		protected static RMethod r_MDefineLPArrayInternal_UnmanagedType_Int32_Int32;
		public static RMethod RMDefineLPArrayInternal_UnmanagedType_Int32_Int32
		{
			get
			{
				if(r_MDefineLPArrayInternal_UnmanagedType_Int32_Int32 == null)
				{
					r_MDefineLPArrayInternal_UnmanagedType_Int32_Int32 = new(Type, "DefineLPArrayInternal", 0, typeof(System.Runtime.InteropServices.UnmanagedType), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDefineLPArrayInternal_UnmanagedType_Int32_Int32;
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


        public static System.Reflection.Emit.UnmanagedMarshal DefineByValArray(System.Int32 @elemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemCount};
            var ___result = RMDefineByValArray_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineByValTStr(System.Int32 @elemCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemCount};
            var ___result = RMDefineByValTStr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineLPArray(System.Runtime.InteropServices.UnmanagedType @elemType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemType};
            var ___result = RMDefineLPArray_UnmanagedType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineSafeArray(System.Runtime.InteropServices.UnmanagedType @elemType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemType};
            var ___result = RMDefineSafeArray_UnmanagedType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineUnmanagedMarshal(System.Runtime.InteropServices.UnmanagedType @unmanagedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedType};
            var ___result = RMDefineUnmanagedMarshal_UnmanagedType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineCustom(System.Type @typeref, System.String @cookie, System.String @mtype, System.Guid @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeref, @cookie, @mtype, @id};
            var ___result = RMDefineCustom_Type_String_String_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal DefineLPArrayInternal(System.Runtime.InteropServices.UnmanagedType @elemType, System.Int32 @sizeConst, System.Int32 @sizeParamIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemType, @sizeConst, @sizeParamIndex};
            var ___result = RMDefineLPArrayInternal_UnmanagedType_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
