
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
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FOFFSET_UNKNOWN;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFOFFSET_UNKNOWN
		{
			get
			{
				if(r_FOFFSET_UNKNOWN == null)
				{
					r_FOFFSET_UNKNOWN = new(typeof(System.Diagnostics.StackFrame), "OFFSET_UNKNOWN");
					r_FOFFSET_UNKNOWN.SetBelong(null);
				}
				return r_FOFFSET_UNKNOWN;
			}
		}

		/// <summary>
		/// System.Int32 ilOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FilOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFilOffset
		{
			get
			{
				if(r_FilOffset == null)
				{
					r_FilOffset = new(this, "ilOffset");
					r_FilOffset.SetBelong(this.instance);
				}
				return r_FilOffset;
			}
		}

		/// <summary>
		/// System.Int32 nativeOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FnativeOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFnativeOffset
		{
			get
			{
				if(r_FnativeOffset == null)
				{
					r_FnativeOffset = new(this, "nativeOffset");
					r_FnativeOffset.SetBelong(this.instance);
				}
				return r_FnativeOffset;
			}
		}

		/// <summary>
		/// System.Int64 methodAddress
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_FmethodAddress;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFmethodAddress
		{
			get
			{
				if(r_FmethodAddress == null)
				{
					r_FmethodAddress = new(this, "methodAddress");
					r_FmethodAddress.SetBelong(this.instance);
				}
				return r_FmethodAddress;
			}
		}

		/// <summary>
		/// System.UInt32 methodIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FmethodIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFmethodIndex
		{
			get
			{
				if(r_FmethodIndex == null)
				{
					r_FmethodIndex = new(this, "methodIndex");
					r_FmethodIndex.SetBelong(this.instance);
				}
				return r_FmethodIndex;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase methodBase
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodBase r_FmethodBase;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodBase RFmethodBase
		{
			get
			{
				if(r_FmethodBase == null)
				{
					r_FmethodBase = new(this, "methodBase");
					r_FmethodBase.SetBelong(this.instance);
				}
				return r_FmethodBase;
			}
		}

		/// <summary>
		/// System.String fileName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FfileName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFfileName
		{
			get
			{
				if(r_FfileName == null)
				{
					r_FfileName = new(this, "fileName");
					r_FfileName.SetBelong(this.instance);
				}
				return r_FfileName;
			}
		}

		/// <summary>
		/// System.Int32 lineNumber
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FlineNumber;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFlineNumber
		{
			get
			{
				if(r_FlineNumber == null)
				{
					r_FlineNumber = new(this, "lineNumber");
					r_FlineNumber.SetBelong(this.instance);
				}
				return r_FlineNumber;
			}
		}

		/// <summary>
		/// System.Int32 columnNumber
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FcolumnNumber;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFcolumnNumber
		{
			get
			{
				if(r_FcolumnNumber == null)
				{
					r_FcolumnNumber = new(this, "columnNumber");
					r_FcolumnNumber.SetBelong(this.instance);
				}
				return r_FcolumnNumber;
			}
		}

		/// <summary>
		/// System.String internalMethodName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FinternalMethodName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFinternalMethodName
		{
			get
			{
				if(r_FinternalMethodName == null)
				{
					r_FinternalMethodName = new(this, "internalMethodName");
					r_FinternalMethodName.SetBelong(this.instance);
				}
				return r_FinternalMethodName;
			}
		}

		/// <summary>
		/// Boolean get_frame_info(Int32, Boolean, System.Reflection.MethodBase ByRef, Int32 ByRef, Int32 ByRef, System.String ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_Mget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32;
		public static RMethod RMget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32
		{
			get
			{
				if(r_Mget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32 == null)
				{
					r_Mget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32 = new(typeof(System.Diagnostics.StackFrame), "get_frame_info", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Reflection.MethodBase).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_Mget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32.SetBelong(null);
				}
				return r_Mget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 GetFileLineNumber()
		/// </summary>
		protected RMethod r_MGetFileLineNumber;
		public virtual RMethod RMGetFileLineNumber
		{
			get
			{
				if(r_MGetFileLineNumber == null)
				{
					r_MGetFileLineNumber = new(this, "GetFileLineNumber", 0);
					r_MGetFileLineNumber.SetBelong(this.instance);
				}
				return r_MGetFileLineNumber;
			}
		}

		/// <summary>
		/// Int32 GetFileColumnNumber()
		/// </summary>
		protected RMethod r_MGetFileColumnNumber;
		public virtual RMethod RMGetFileColumnNumber
		{
			get
			{
				if(r_MGetFileColumnNumber == null)
				{
					r_MGetFileColumnNumber = new(this, "GetFileColumnNumber", 0);
					r_MGetFileColumnNumber.SetBelong(this.instance);
				}
				return r_MGetFileColumnNumber;
			}
		}

		/// <summary>
		/// System.String GetFileName()
		/// </summary>
		protected RMethod r_MGetFileName;
		public virtual RMethod RMGetFileName
		{
			get
			{
				if(r_MGetFileName == null)
				{
					r_MGetFileName = new(this, "GetFileName", 0);
					r_MGetFileName.SetBelong(this.instance);
				}
				return r_MGetFileName;
			}
		}

		/// <summary>
		/// System.String GetSecureFileName()
		/// </summary>
		protected RMethod r_MGetSecureFileName;
		public virtual RMethod RMGetSecureFileName
		{
			get
			{
				if(r_MGetSecureFileName == null)
				{
					r_MGetSecureFileName = new(this, "GetSecureFileName", 0);
					r_MGetSecureFileName.SetBelong(this.instance);
				}
				return r_MGetSecureFileName;
			}
		}

		/// <summary>
		/// Int32 GetILOffset()
		/// </summary>
		protected RMethod r_MGetILOffset;
		public virtual RMethod RMGetILOffset
		{
			get
			{
				if(r_MGetILOffset == null)
				{
					r_MGetILOffset = new(this, "GetILOffset", 0);
					r_MGetILOffset.SetBelong(this.instance);
				}
				return r_MGetILOffset;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethod()
		/// </summary>
		protected RMethod r_MGetMethod;
		public virtual RMethod RMGetMethod
		{
			get
			{
				if(r_MGetMethod == null)
				{
					r_MGetMethod = new(this, "GetMethod", 0);
					r_MGetMethod.SetBelong(this.instance);
				}
				return r_MGetMethod;
			}
		}

		/// <summary>
		/// Int32 GetNativeOffset()
		/// </summary>
		protected RMethod r_MGetNativeOffset;
		public virtual RMethod RMGetNativeOffset
		{
			get
			{
				if(r_MGetNativeOffset == null)
				{
					r_MGetNativeOffset = new(this, "GetNativeOffset", 0);
					r_MGetNativeOffset.SetBelong(this.instance);
				}
				return r_MGetNativeOffset;
			}
		}

		/// <summary>
		/// Int64 GetMethodAddress()
		/// </summary>
		protected RMethod r_MGetMethodAddress;
		public virtual RMethod RMGetMethodAddress
		{
			get
			{
				if(r_MGetMethodAddress == null)
				{
					r_MGetMethodAddress = new(this, "GetMethodAddress", 0);
					r_MGetMethodAddress.SetBelong(this.instance);
				}
				return r_MGetMethodAddress;
			}
		}

		/// <summary>
		/// UInt32 GetMethodIndex()
		/// </summary>
		protected RMethod r_MGetMethodIndex;
		public virtual RMethod RMGetMethodIndex
		{
			get
			{
				if(r_MGetMethodIndex == null)
				{
					r_MGetMethodIndex = new(this, "GetMethodIndex", 0);
					r_MGetMethodIndex.SetBelong(this.instance);
				}
				return r_MGetMethodIndex;
			}
		}

		/// <summary>
		/// System.String GetInternalMethodName()
		/// </summary>
		protected RMethod r_MGetInternalMethodName;
		public virtual RMethod RMGetInternalMethodName
		{
			get
			{
				if(r_MGetInternalMethodName == null)
				{
					r_MGetInternalMethodName = new(this, "GetInternalMethodName", 0);
					r_MGetInternalMethodName.SetBelong(this.instance);
				}
				return r_MGetInternalMethodName;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public static System.Boolean get_frame_info(System.Int32 @skip, System.Boolean @needFileInfo, out System.Reflection.MethodBase @method, out System.Int32 @iloffset, out System.Int32 @native_offset, out System.String @file, out System.Int32 @line, out System.Int32 @column)
        {
			@method = default;
			@iloffset = default;
			@native_offset = default;
			@file = default;
			@line = default;
			@column = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skip, @needFileInfo, @method, @iloffset, @native_offset, @file, @line, @column};
            var ___result = RMget_frame_info_Int32_Boolean_Out_MethodBase_Out_Int32_Out_Int32_Out_String_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
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
            var ___result = RMGetFileLineNumber.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetFileColumnNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFileColumnNumber.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetFileName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFileName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSecureFileName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSecureFileName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetILOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetILOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Reflection.MethodBase GetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Int32 GetNativeOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 GetMethodAddress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodAddress.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt32 GetMethodIndex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodIndex.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.String GetInternalMethodName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInternalMethodName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
