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
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
			}
		}

		/// <summary>
		/// Void CloseMethod()
		/// </summary>
		protected RMethod r_CloseMethod;
		public virtual RMethod RCloseMethod
		{
			get
			{
				if(r_CloseMethod == null)
				{
					r_CloseMethod = new(this, "CloseMethod", 0);
					r_CloseMethod.SetBelong(this.instance);
				}
				return r_CloseMethod;
			}
		}

		/// <summary>
		/// Void CloseNamespace()
		/// </summary>
		protected RMethod r_CloseNamespace;
		public virtual RMethod RCloseNamespace
		{
			get
			{
				if(r_CloseNamespace == null)
				{
					r_CloseNamespace = new(this, "CloseNamespace", 0);
					r_CloseNamespace.SetBelong(this.instance);
				}
				return r_CloseNamespace;
			}
		}

		/// <summary>
		/// Void CloseScope(Int32)
		/// </summary>
		protected RMethod r_CloseScope_Int32;
		public virtual RMethod RCloseScope_Int32
		{
			get
			{
				if(r_CloseScope_Int32 == null)
				{
					r_CloseScope_Int32 = new(this, "CloseScope", 0, typeof(System.Int32));
					r_CloseScope_Int32.SetBelong(this.instance);
				}
				return r_CloseScope_Int32;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String, System.Guid, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_DefineDocument_String_Guid_Guid_Guid;
		public virtual RMethod RDefineDocument_String_Guid_Guid_Guid
		{
			get
			{
				if(r_DefineDocument_String_Guid_Guid_Guid == null)
				{
					r_DefineDocument_String_Guid_Guid_Guid = new(this, "DefineDocument", 0, typeof(System.String), typeof(System.Guid), typeof(System.Guid), typeof(System.Guid));
					r_DefineDocument_String_Guid_Guid_Guid.SetBelong(this.instance);
				}
				return r_DefineDocument_String_Guid_Guid_Guid;
			}
		}

		/// <summary>
		/// Void DefineField(System.Diagnostics.SymbolStore.SymbolToken, System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_DefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_DefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_DefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineField", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_DefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_DefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineGlobalVariable(System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_DefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_DefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_DefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineGlobalVariable", 0, typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_DefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_DefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineLocalVariable(System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_DefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_DefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_DefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32 = new(this, "DefineLocalVariable", 0, typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_DefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_DefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineParameter(System.String, System.Reflection.ParameterAttributes, Int32, System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_DefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_DefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_DefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineParameter", 0, typeof(System.String), typeof(System.Reflection.ParameterAttributes), typeof(System.Int32), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_DefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_DefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32[], Int32[], Int32[], Int32[], Int32[])
		/// </summary>
		protected RMethod r_DefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array;
		public virtual RMethod RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array
		{
			get
			{
				if(r_DefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array == null)
				{
					r_DefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array = new(this, "DefineSequencePoints", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
					r_DefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array.SetBelong(this.instance);
				}
				return r_DefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Void Initialize(IntPtr, System.String, Boolean)
		/// </summary>
		protected RMethod r_Initialize_IntPtr_String_Boolean;
		public virtual RMethod RInitialize_IntPtr_String_Boolean
		{
			get
			{
				if(r_Initialize_IntPtr_String_Boolean == null)
				{
					r_Initialize_IntPtr_String_Boolean = new(this, "Initialize", 0, typeof(System.IntPtr), typeof(System.String), typeof(System.Boolean));
					r_Initialize_IntPtr_String_Boolean.SetBelong(this.instance);
				}
				return r_Initialize_IntPtr_String_Boolean;
			}
		}

		/// <summary>
		/// Void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_OpenMethod_SymbolToken;
		public virtual RMethod ROpenMethod_SymbolToken
		{
			get
			{
				if(r_OpenMethod_SymbolToken == null)
				{
					r_OpenMethod_SymbolToken = new(this, "OpenMethod", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_OpenMethod_SymbolToken.SetBelong(this.instance);
				}
				return r_OpenMethod_SymbolToken;
			}
		}

		/// <summary>
		/// Void OpenNamespace(System.String)
		/// </summary>
		protected RMethod r_OpenNamespace_String;
		public virtual RMethod ROpenNamespace_String
		{
			get
			{
				if(r_OpenNamespace_String == null)
				{
					r_OpenNamespace_String = new(this, "OpenNamespace", 0, typeof(System.String));
					r_OpenNamespace_String.SetBelong(this.instance);
				}
				return r_OpenNamespace_String;
			}
		}

		/// <summary>
		/// Int32 OpenScope(Int32)
		/// </summary>
		protected RMethod r_OpenScope_Int32;
		public virtual RMethod ROpenScope_Int32
		{
			get
			{
				if(r_OpenScope_Int32 == null)
				{
					r_OpenScope_Int32 = new(this, "OpenScope", 0, typeof(System.Int32));
					r_OpenScope_Int32.SetBelong(this.instance);
				}
				return r_OpenScope_Int32;
			}
		}

		/// <summary>
		/// Void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32, System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32)
		/// </summary>
		protected RMethod r_SetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32;
		public virtual RMethod RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32
		{
			get
			{
				if(r_SetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32 == null)
				{
					r_SetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32 = new(this, "SetMethodSourceRange", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32), typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32));
					r_SetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetScopeRange(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetScopeRange_Int32_Int32_Int32;
		public virtual RMethod RSetScopeRange_Int32_Int32_Int32
		{
			get
			{
				if(r_SetScopeRange_Int32_Int32_Int32 == null)
				{
					r_SetScopeRange_Int32_Int32_Int32 = new(this, "SetScopeRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetScopeRange_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetScopeRange_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken, System.String, Byte[])
		/// </summary>
		protected RMethod r_SetSymAttribute_SymbolToken_String_ByteArray;
		public virtual RMethod RSetSymAttribute_SymbolToken_String_ByteArray
		{
			get
			{
				if(r_SetSymAttribute_SymbolToken_String_ByteArray == null)
				{
					r_SetSymAttribute_SymbolToken_String_ByteArray = new(this, "SetSymAttribute", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_SetSymAttribute_SymbolToken_String_ByteArray.SetBelong(this.instance);
				}
				return r_SetSymAttribute_SymbolToken_String_ByteArray;
			}
		}

		/// <summary>
		/// Void SetUnderlyingWriter(IntPtr)
		/// </summary>
		protected RMethod r_SetUnderlyingWriter_IntPtr;
		public virtual RMethod RSetUnderlyingWriter_IntPtr
		{
			get
			{
				if(r_SetUnderlyingWriter_IntPtr == null)
				{
					r_SetUnderlyingWriter_IntPtr = new(this, "SetUnderlyingWriter", 0, typeof(System.IntPtr));
					r_SetUnderlyingWriter_IntPtr.SetBelong(this.instance);
				}
				return r_SetUnderlyingWriter_IntPtr;
			}
		}

		/// <summary>
		/// Void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_SetUserEntryPoint_SymbolToken;
		public virtual RMethod RSetUserEntryPoint_SymbolToken
		{
			get
			{
				if(r_SetUserEntryPoint_SymbolToken == null)
				{
					r_SetUserEntryPoint_SymbolToken = new(this, "SetUserEntryPoint", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_SetUserEntryPoint_SymbolToken.SetBelong(this.instance);
				}
				return r_SetUserEntryPoint_SymbolToken;
			}
		}

		/// <summary>
		/// Void UsingNamespace(System.String)
		/// </summary>
		protected RMethod r_UsingNamespace_String;
		public virtual RMethod RUsingNamespace_String
		{
			get
			{
				if(r_UsingNamespace_String == null)
				{
					r_UsingNamespace_String = new(this, "UsingNamespace", 0, typeof(System.String));
					r_UsingNamespace_String.SetBelong(this.instance);
				}
				return r_UsingNamespace_String;
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


        public virtual void CloseScope(System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@endOffset};
            var ___result = RCloseScope_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String @url, System.Guid @language, System.Guid @languageVendor, System.Guid @documentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @language, @languageVendor, @documentType};
            var ___result = RDefineDocument_String_Guid_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolDocumentWriter)___result;
        }


        public virtual void DefineField(System.Diagnostics.SymbolStore.SymbolToken @parent, System.String @name, System.Reflection.FieldAttributes @attributes, System.Byte[] @signature, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineGlobalVariable(System.String @name, System.Reflection.FieldAttributes @attributes, System.Byte[] @signature, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineLocalVariable(System.String @name, System.Reflection.FieldAttributes @attributes, System.Byte[] @signature, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3, System.Int32 @startOffset, System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3, @startOffset, @endOffset};
            var ___result = RDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineParameter(System.String @name, System.Reflection.ParameterAttributes @attributes, System.Int32 @sequence, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @sequence, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter @document, System.Int32[] @offsets, System.Int32[] @lines, System.Int32[] @columns, System.Int32[] @endLines, System.Int32[] @endColumns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@document, @offsets, @lines, @columns, @endLines, @endColumns};
            var ___result = RDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.IntPtr @emitter, System.String @filename, System.Boolean @fFullBuild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@emitter, @filename, @fFullBuild};
            var ___result = RInitialize_IntPtr_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = ROpenMethod_SymbolToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenNamespace(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = ROpenNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 OpenScope(System.Int32 @startOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startOffset};
            var ___result = ROpenScope_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter @startDoc, System.Int32 @startLine, System.Int32 @startColumn, System.Diagnostics.SymbolStore.ISymbolDocumentWriter @endDoc, System.Int32 @endLine, System.Int32 @endColumn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startDoc, @startLine, @startColumn, @endDoc, @endLine, @endColumn};
            var ___result = RSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScopeRange(System.Int32 @scopeID, System.Int32 @startOffset, System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scopeID, @startOffset, @endOffset};
            var ___result = RSetScopeRange_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken @parent, System.String @name, System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @name, @data};
            var ___result = RSetSymAttribute_SymbolToken_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUnderlyingWriter(System.IntPtr @underlyingWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@underlyingWriter};
            var ___result = RSetUnderlyingWriter_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken @entryMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod};
            var ___result = RSetUserEntryPoint_SymbolToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UsingNamespace(System.String @fullName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullName};
            var ___result = RUsingNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


    }
}
