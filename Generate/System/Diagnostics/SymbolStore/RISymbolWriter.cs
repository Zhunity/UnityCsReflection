using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore
{
	/// <summary>
	/// System.Diagnostics.SymbolStore.ISymbolWriter
	/// </summary>
    public partial class RISymbolWriter : RMember //
    {

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void CloseMethod()
		/// </summary>
		protected RMethod r_RCloseMethod;
		public virtual RMethod RCloseMethod
		{
			get
			{
				if(r_RCloseMethod == null)
				{
					r_RCloseMethod = new(this, "CloseMethod", 0);
					r_RCloseMethod.SetBelong(this.instance);
				}
				return r_RCloseMethod;
			}
		}

		/// <summary>
		/// Void CloseNamespace()
		/// </summary>
		protected RMethod r_RCloseNamespace;
		public virtual RMethod RCloseNamespace
		{
			get
			{
				if(r_RCloseNamespace == null)
				{
					r_RCloseNamespace = new(this, "CloseNamespace", 0);
					r_RCloseNamespace.SetBelong(this.instance);
				}
				return r_RCloseNamespace;
			}
		}

		/// <summary>
		/// Void CloseScope(Int32)
		/// </summary>
		protected RMethod r_RCloseScope_Int32;
		public virtual RMethod RCloseScope_Int32
		{
			get
			{
				if(r_RCloseScope_Int32 == null)
				{
					r_RCloseScope_Int32 = new(this, "CloseScope", 0, typeof(System.Int32));
					r_RCloseScope_Int32.SetBelong(this.instance);
				}
				return r_RCloseScope_Int32;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String, System.Guid, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RDefineDocument_String_Guid_Guid_Guid;
		public virtual RMethod RDefineDocument_String_Guid_Guid_Guid
		{
			get
			{
				if(r_RDefineDocument_String_Guid_Guid_Guid == null)
				{
					r_RDefineDocument_String_Guid_Guid_Guid = new(this, "DefineDocument", 0, typeof(System.String), typeof(System.Guid), typeof(System.Guid), typeof(System.Guid));
					r_RDefineDocument_String_Guid_Guid_Guid.SetBelong(this.instance);
				}
				return r_RDefineDocument_String_Guid_Guid_Guid;
			}
		}

		/// <summary>
		/// Void DefineField(System.Diagnostics.SymbolStore.SymbolToken, System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineField", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineGlobalVariable(System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineGlobalVariable", 0, typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineLocalVariable(System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32 = new(this, "DefineLocalVariable", 0, typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineParameter(System.String, System.Reflection.ParameterAttributes, Int32, System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineParameter", 0, typeof(System.String), typeof(System.Reflection.ParameterAttributes), typeof(System.Int32), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32[], Int32[], Int32[], Int32[], Int32[])
		/// </summary>
		protected RMethod r_RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array;
		public virtual RMethod RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array
		{
			get
			{
				if(r_RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array == null)
				{
					r_RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array = new(this, "DefineSequencePoints", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array.SetBelong(this.instance);
				}
				return r_RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Void Initialize(IntPtr, System.String, Boolean)
		/// </summary>
		protected RMethod r_RInitialize_IntPtr_String_Boolean;
		public virtual RMethod RInitialize_IntPtr_String_Boolean
		{
			get
			{
				if(r_RInitialize_IntPtr_String_Boolean == null)
				{
					r_RInitialize_IntPtr_String_Boolean = new(this, "Initialize", 0, typeof(System.IntPtr), typeof(System.String), typeof(System.Boolean));
					r_RInitialize_IntPtr_String_Boolean.SetBelong(this.instance);
				}
				return r_RInitialize_IntPtr_String_Boolean;
			}
		}

		/// <summary>
		/// Void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_ROpenMethod_SymbolToken;
		public virtual RMethod ROpenMethod_SymbolToken
		{
			get
			{
				if(r_ROpenMethod_SymbolToken == null)
				{
					r_ROpenMethod_SymbolToken = new(this, "OpenMethod", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_ROpenMethod_SymbolToken.SetBelong(this.instance);
				}
				return r_ROpenMethod_SymbolToken;
			}
		}

		/// <summary>
		/// Void OpenNamespace(System.String)
		/// </summary>
		protected RMethod r_ROpenNamespace_String;
		public virtual RMethod ROpenNamespace_String
		{
			get
			{
				if(r_ROpenNamespace_String == null)
				{
					r_ROpenNamespace_String = new(this, "OpenNamespace", 0, typeof(System.String));
					r_ROpenNamespace_String.SetBelong(this.instance);
				}
				return r_ROpenNamespace_String;
			}
		}

		/// <summary>
		/// Int32 OpenScope(Int32)
		/// </summary>
		protected RMethod r_ROpenScope_Int32;
		public virtual RMethod ROpenScope_Int32
		{
			get
			{
				if(r_ROpenScope_Int32 == null)
				{
					r_ROpenScope_Int32 = new(this, "OpenScope", 0, typeof(System.Int32));
					r_ROpenScope_Int32.SetBelong(this.instance);
				}
				return r_ROpenScope_Int32;
			}
		}

		/// <summary>
		/// Void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32, System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32;
		public virtual RMethod RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32
		{
			get
			{
				if(r_RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32 == null)
				{
					r_RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32 = new(this, "SetMethodSourceRange", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32), typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32));
					r_RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetScopeRange(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetScopeRange_Int32_Int32_Int32;
		public virtual RMethod RSetScopeRange_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetScopeRange_Int32_Int32_Int32 == null)
				{
					r_RSetScopeRange_Int32_Int32_Int32 = new(this, "SetScopeRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetScopeRange_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetScopeRange_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken, System.String, Byte[])
		/// </summary>
		protected RMethod r_RSetSymAttribute_SymbolToken_String_ByteArray;
		public virtual RMethod RSetSymAttribute_SymbolToken_String_ByteArray
		{
			get
			{
				if(r_RSetSymAttribute_SymbolToken_String_ByteArray == null)
				{
					r_RSetSymAttribute_SymbolToken_String_ByteArray = new(this, "SetSymAttribute", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RSetSymAttribute_SymbolToken_String_ByteArray.SetBelong(this.instance);
				}
				return r_RSetSymAttribute_SymbolToken_String_ByteArray;
			}
		}

		/// <summary>
		/// Void SetUnderlyingWriter(IntPtr)
		/// </summary>
		protected RMethod r_RSetUnderlyingWriter_IntPtr;
		public virtual RMethod RSetUnderlyingWriter_IntPtr
		{
			get
			{
				if(r_RSetUnderlyingWriter_IntPtr == null)
				{
					r_RSetUnderlyingWriter_IntPtr = new(this, "SetUnderlyingWriter", 0, typeof(System.IntPtr));
					r_RSetUnderlyingWriter_IntPtr.SetBelong(this.instance);
				}
				return r_RSetUnderlyingWriter_IntPtr;
			}
		}

		/// <summary>
		/// Void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_RSetUserEntryPoint_SymbolToken;
		public virtual RMethod RSetUserEntryPoint_SymbolToken
		{
			get
			{
				if(r_RSetUserEntryPoint_SymbolToken == null)
				{
					r_RSetUserEntryPoint_SymbolToken = new(this, "SetUserEntryPoint", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_RSetUserEntryPoint_SymbolToken.SetBelong(this.instance);
				}
				return r_RSetUserEntryPoint_SymbolToken;
			}
		}

		/// <summary>
		/// Void UsingNamespace(System.String)
		/// </summary>
		protected RMethod r_RUsingNamespace_String;
		public virtual RMethod RUsingNamespace_String
		{
			get
			{
				if(r_RUsingNamespace_String == null)
				{
					r_RUsingNamespace_String = new(this, "UsingNamespace", 0, typeof(System.String));
					r_RUsingNamespace_String.SetBelong(this.instance);
				}
				return r_RUsingNamespace_String;
			}
		}


        public RISymbolWriter() : base("System.Diagnostics.SymbolStore.ISymbolWriter")
        {
        }

        public RISymbolWriter(System.Object instance) : base("System.Diagnostics.SymbolStore.ISymbolWriter")
		{
            SetInstance(instance);
		}

        public RISymbolWriter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISymbolWriter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseMethod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseNamespace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseNamespace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseScope(System.Int32  @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@endOffset};
            var ___result = RCloseScope_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String  @url, System.Guid  @language, System.Guid  @languageVendor, System.Guid  @documentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @language, @languageVendor, @documentType};
            var ___result = RDefineDocument_String_Guid_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolDocumentWriter)___result;
        }


        public virtual void DefineField(System.Diagnostics.SymbolStore.SymbolToken  @parent, System.String  @name, System.Reflection.FieldAttributes  @attributes, System.Byte[]  @signature, System.Diagnostics.SymbolStore.SymAddressKind  @addrKind, System.Int32  @addr1, System.Int32  @addr2, System.Int32  @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineGlobalVariable(System.String  @name, System.Reflection.FieldAttributes  @attributes, System.Byte[]  @signature, System.Diagnostics.SymbolStore.SymAddressKind  @addrKind, System.Int32  @addr1, System.Int32  @addr2, System.Int32  @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineLocalVariable(System.String  @name, System.Reflection.FieldAttributes  @attributes, System.Byte[]  @signature, System.Diagnostics.SymbolStore.SymAddressKind  @addrKind, System.Int32  @addr1, System.Int32  @addr2, System.Int32  @addr3, System.Int32  @startOffset, System.Int32  @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3, @startOffset, @endOffset};
            var ___result = RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineParameter(System.String  @name, System.Reflection.ParameterAttributes  @attributes, System.Int32  @sequence, System.Diagnostics.SymbolStore.SymAddressKind  @addrKind, System.Int32  @addr1, System.Int32  @addr2, System.Int32  @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @sequence, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter  @document, System.Int32[]  @offsets, System.Int32[]  @lines, System.Int32[]  @columns, System.Int32[]  @endLines, System.Int32[]  @endColumns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@document, @offsets, @lines, @columns, @endLines, @endColumns};
            var ___result = RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.IntPtr  @emitter, System.String  @filename, System.Boolean  @fFullBuild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@emitter, @filename, @fFullBuild};
            var ___result = RInitialize_IntPtr_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = ROpenMethod_SymbolToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenNamespace(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = ROpenNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 OpenScope(System.Int32  @startOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startOffset};
            var ___result = ROpenScope_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter  @startDoc, System.Int32  @startLine, System.Int32  @startColumn, System.Diagnostics.SymbolStore.ISymbolDocumentWriter  @endDoc, System.Int32  @endLine, System.Int32  @endColumn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startDoc, @startLine, @startColumn, @endDoc, @endLine, @endColumn};
            var ___result = RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScopeRange(System.Int32  @scopeID, System.Int32  @startOffset, System.Int32  @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scopeID, @startOffset, @endOffset};
            var ___result = RSetScopeRange_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken  @parent, System.String  @name, System.Byte[]  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @name, @data};
            var ___result = RSetSymAttribute_SymbolToken_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUnderlyingWriter(System.IntPtr  @underlyingWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@underlyingWriter};
            var ___result = RSetUnderlyingWriter_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken  @entryMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod};
            var ___result = RSetUserEntryPoint_SymbolToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UsingNamespace(System.String  @fullName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullName};
            var ___result = RUsingNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


    }
}
