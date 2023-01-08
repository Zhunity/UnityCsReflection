using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RDiagnostics
{
	/// <summary>
	/// System.Diagnostics.StackFrame
	/// </summary>
    public partial class RStackFrame : RMember //
    {

		/// <summary>
		/// System.Int32 OFFSET_UNKNOWN
		/// </summary>
		protected static RField r_OFFSET_UNKNOWN;
		public static RField ROFFSET_UNKNOWN
		{
			get
			{
				if(r_OFFSET_UNKNOWN == null)
				{
					r_OFFSET_UNKNOWN = new(typeof(System.Diagnostics.StackFrame), "OFFSET_UNKNOWN");
					r_OFFSET_UNKNOWN.SetBelong(null);
				}
				return r_OFFSET_UNKNOWN;
			}
		}

		/// <summary>
		/// System.Int32 ilOffset
		/// </summary>
		protected RField r_ilOffset;
		public virtual RField RilOffset
		{
			get
			{
				if(r_ilOffset == null)
				{
					r_ilOffset = new(this, "ilOffset");
					r_ilOffset.SetBelong(this.instance);
				}
				return r_ilOffset;
			}
		}

		/// <summary>
		/// System.Int32 nativeOffset
		/// </summary>
		protected RField r_nativeOffset;
		public virtual RField RnativeOffset
		{
			get
			{
				if(r_nativeOffset == null)
				{
					r_nativeOffset = new(this, "nativeOffset");
					r_nativeOffset.SetBelong(this.instance);
				}
				return r_nativeOffset;
			}
		}

		/// <summary>
		/// System.Int64 methodAddress
		/// </summary>
		protected RField r_methodAddress;
		public virtual RField RmethodAddress
		{
			get
			{
				if(r_methodAddress == null)
				{
					r_methodAddress = new(this, "methodAddress");
					r_methodAddress.SetBelong(this.instance);
				}
				return r_methodAddress;
			}
		}

		/// <summary>
		/// System.UInt32 methodIndex
		/// </summary>
		protected RField r_methodIndex;
		public virtual RField RmethodIndex
		{
			get
			{
				if(r_methodIndex == null)
				{
					r_methodIndex = new(this, "methodIndex");
					r_methodIndex.SetBelong(this.instance);
				}
				return r_methodIndex;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase methodBase
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_methodBase;
		public virtual RSystem.RReflection.RMethodBase RmethodBase
		{
			get
			{
				if(r_methodBase == null)
				{
					r_methodBase = new(this, "methodBase");
					r_methodBase.SetBelong(this.instance);
				}
				return r_methodBase;
			}
		}

		/// <summary>
		/// System.String fileName
		/// </summary>
		protected RField r_fileName;
		public virtual RField RfileName
		{
			get
			{
				if(r_fileName == null)
				{
					r_fileName = new(this, "fileName");
					r_fileName.SetBelong(this.instance);
				}
				return r_fileName;
			}
		}

		/// <summary>
		/// System.Int32 lineNumber
		/// </summary>
		protected RField r_lineNumber;
		public virtual RField RlineNumber
		{
			get
			{
				if(r_lineNumber == null)
				{
					r_lineNumber = new(this, "lineNumber");
					r_lineNumber.SetBelong(this.instance);
				}
				return r_lineNumber;
			}
		}

		/// <summary>
		/// System.Int32 columnNumber
		/// </summary>
		protected RField r_columnNumber;
		public virtual RField RcolumnNumber
		{
			get
			{
				if(r_columnNumber == null)
				{
					r_columnNumber = new(this, "columnNumber");
					r_columnNumber.SetBelong(this.instance);
				}
				return r_columnNumber;
			}
		}

		/// <summary>
		/// System.String internalMethodName
		/// </summary>
		protected RField r_internalMethodName;
		public virtual RField RinternalMethodName
		{
			get
			{
				if(r_internalMethodName == null)
				{
					r_internalMethodName = new(this, "internalMethodName");
					r_internalMethodName.SetBelong(this.instance);
				}
				return r_internalMethodName;
			}
		}

		/// <summary>
		/// Boolean get_frame_info(Int32, Boolean, System.Reflection.MethodBase ByRef, Int32 ByRef, Int32 ByRef, System.String ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_get_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32;
		public static RMethod Rget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32
		{
			get
			{
				if(r_get_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32 == null)
				{
					r_get_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32 = new(typeof(System.Diagnostics.StackFrame), "get_frame_info", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Reflection.MethodBase).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_get_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32.SetBelong(null);
				}
				return r_get_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 GetFileLineNumber()
		/// </summary>
		protected RMethod r_GetFileLineNumber;
		public virtual RMethod RGetFileLineNumber
		{
			get
			{
				if(r_GetFileLineNumber == null)
				{
					r_GetFileLineNumber = new(this, "GetFileLineNumber", 0);
					r_GetFileLineNumber.SetBelong(this.instance);
				}
				return r_GetFileLineNumber;
			}
		}

		/// <summary>
		/// Int32 GetFileColumnNumber()
		/// </summary>
		protected RMethod r_GetFileColumnNumber;
		public virtual RMethod RGetFileColumnNumber
		{
			get
			{
				if(r_GetFileColumnNumber == null)
				{
					r_GetFileColumnNumber = new(this, "GetFileColumnNumber", 0);
					r_GetFileColumnNumber.SetBelong(this.instance);
				}
				return r_GetFileColumnNumber;
			}
		}

		/// <summary>
		/// System.String GetFileName()
		/// </summary>
		protected RMethod r_GetFileName;
		public virtual RMethod RGetFileName
		{
			get
			{
				if(r_GetFileName == null)
				{
					r_GetFileName = new(this, "GetFileName", 0);
					r_GetFileName.SetBelong(this.instance);
				}
				return r_GetFileName;
			}
		}

		/// <summary>
		/// System.String GetSecureFileName()
		/// </summary>
		protected RMethod r_GetSecureFileName;
		public virtual RMethod RGetSecureFileName
		{
			get
			{
				if(r_GetSecureFileName == null)
				{
					r_GetSecureFileName = new(this, "GetSecureFileName", 0);
					r_GetSecureFileName.SetBelong(this.instance);
				}
				return r_GetSecureFileName;
			}
		}

		/// <summary>
		/// Int32 GetILOffset()
		/// </summary>
		protected RMethod r_GetILOffset;
		public virtual RMethod RGetILOffset
		{
			get
			{
				if(r_GetILOffset == null)
				{
					r_GetILOffset = new(this, "GetILOffset", 0);
					r_GetILOffset.SetBelong(this.instance);
				}
				return r_GetILOffset;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethod()
		/// </summary>
		protected RMethod r_GetMethod;
		public virtual RMethod RGetMethod
		{
			get
			{
				if(r_GetMethod == null)
				{
					r_GetMethod = new(this, "GetMethod", 0);
					r_GetMethod.SetBelong(this.instance);
				}
				return r_GetMethod;
			}
		}

		/// <summary>
		/// Int32 GetNativeOffset()
		/// </summary>
		protected RMethod r_GetNativeOffset;
		public virtual RMethod RGetNativeOffset
		{
			get
			{
				if(r_GetNativeOffset == null)
				{
					r_GetNativeOffset = new(this, "GetNativeOffset", 0);
					r_GetNativeOffset.SetBelong(this.instance);
				}
				return r_GetNativeOffset;
			}
		}

		/// <summary>
		/// Int64 GetMethodAddress()
		/// </summary>
		protected RMethod r_GetMethodAddress;
		public virtual RMethod RGetMethodAddress
		{
			get
			{
				if(r_GetMethodAddress == null)
				{
					r_GetMethodAddress = new(this, "GetMethodAddress", 0);
					r_GetMethodAddress.SetBelong(this.instance);
				}
				return r_GetMethodAddress;
			}
		}

		/// <summary>
		/// UInt32 GetMethodIndex()
		/// </summary>
		protected RMethod r_GetMethodIndex;
		public virtual RMethod RGetMethodIndex
		{
			get
			{
				if(r_GetMethodIndex == null)
				{
					r_GetMethodIndex = new(this, "GetMethodIndex", 0);
					r_GetMethodIndex.SetBelong(this.instance);
				}
				return r_GetMethodIndex;
			}
		}

		/// <summary>
		/// System.String GetInternalMethodName()
		/// </summary>
		protected RMethod r_GetInternalMethodName;
		public virtual RMethod RGetInternalMethodName
		{
			get
			{
				if(r_GetInternalMethodName == null)
				{
					r_GetInternalMethodName = new(this, "GetInternalMethodName", 0);
					r_GetInternalMethodName.SetBelong(this.instance);
				}
				return r_GetInternalMethodName;
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


        public RStackFrame() : base("System.Diagnostics.StackFrame")
        {
        }

        public RStackFrame(System.Object instance) : base("System.Diagnostics.StackFrame")
		{
            SetInstance(instance);
		}

        public RStackFrame(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStackFrame(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean get_frame_info(System.Int32  @skip, System.Boolean  @needFileInfo, out System.Reflection.MethodBase  @method, out System.Int32  @iloffset, out System.Int32  @native_offset, out System.String  @file, out System.Int32  @line, out System.Int32  @column)
        {
			@method = default;
			@iloffset = default;
			@native_offset = default;
			@file = default;
			@line = default;
			@column = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skip, @needFileInfo, @method, @iloffset, @native_offset, @file, @line, @column};
            var ___result = Rget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@method = (System.Reflection.MethodBase)___parameters[2];
			@iloffset = (System.Int32)___parameters[3];
			@native_offset = (System.Int32)___parameters[4];
			@file = (System.String)___parameters[5];
			@line = (System.Int32)___parameters[6];
			@column = (System.Int32)___parameters[7];

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetFileLineNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFileLineNumber.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetFileColumnNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFileColumnNumber.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetFileName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFileName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSecureFileName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSecureFileName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetILOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetILOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Reflection.MethodBase GetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Int32 GetNativeOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 GetMethodAddress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodAddress.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt32 GetMethodIndex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodIndex.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.String GetInternalMethodName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInternalMethodName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
