
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Diagnostics.SymbolStore.ISymbolWriter
	/// </summary>
    public partial class RISymbolWriter : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Diagnostics.SymbolStore.ISymbolWriter);
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


		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Void CloseMethod()
		/// </summary>
		protected RMethod r_MCloseMethod;
		public virtual RMethod RMCloseMethod
		{
			get
			{
				if(r_MCloseMethod == null)
				{
					r_MCloseMethod = new(this, "CloseMethod", 0);
				}
				return r_MCloseMethod;
			}
		}

		/// <summary>
		/// Void CloseNamespace()
		/// </summary>
		protected RMethod r_MCloseNamespace;
		public virtual RMethod RMCloseNamespace
		{
			get
			{
				if(r_MCloseNamespace == null)
				{
					r_MCloseNamespace = new(this, "CloseNamespace", 0);
				}
				return r_MCloseNamespace;
			}
		}

		/// <summary>
		/// Void CloseScope(Int32)
		/// </summary>
		protected RMethod r_MCloseScope_Int32;
		public virtual RMethod RMCloseScope_Int32
		{
			get
			{
				if(r_MCloseScope_Int32 == null)
				{
					r_MCloseScope_Int32 = new(this, "CloseScope", 0, typeof(System.Int32));
				}
				return r_MCloseScope_Int32;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String, System.Guid, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MDefineDocument_String_Guid_Guid_Guid;
		public virtual RMethod RMDefineDocument_String_Guid_Guid_Guid
		{
			get
			{
				if(r_MDefineDocument_String_Guid_Guid_Guid == null)
				{
					r_MDefineDocument_String_Guid_Guid_Guid = new(this, "DefineDocument", 0, typeof(System.String), typeof(System.Guid), typeof(System.Guid), typeof(System.Guid));
				}
				return r_MDefineDocument_String_Guid_Guid_Guid;
			}
		}

		/// <summary>
		/// Void DefineField(System.Diagnostics.SymbolStore.SymbolToken, System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RMDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_MDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_MDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineField", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineGlobalVariable(System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RMDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_MDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_MDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineGlobalVariable", 0, typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineLocalVariable(System.String, System.Reflection.FieldAttributes, Byte[], System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32 = new(this, "DefineLocalVariable", 0, typeof(System.String), typeof(System.Reflection.FieldAttributes), typeof(System.Byte).MakeArrayType(), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineParameter(System.String, System.Reflection.ParameterAttributes, Int32, System.Diagnostics.SymbolStore.SymAddressKind, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32;
		public virtual RMethod RMDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32
		{
			get
			{
				if(r_MDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32 == null)
				{
					r_MDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32 = new(this, "DefineParameter", 0, typeof(System.String), typeof(System.Reflection.ParameterAttributes), typeof(System.Int32), typeof(System.Diagnostics.SymbolStore.SymAddressKind), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32[], Int32[], Int32[], Int32[], Int32[])
		/// </summary>
		protected RMethod r_MDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array;
		public virtual RMethod RMDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array
		{
			get
			{
				if(r_MDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array == null)
				{
					r_MDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array = new(this, "DefineSequencePoints", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType(), typeof(System.Int32).MakeArrayType());
				}
				return r_MDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array;
			}
		}

		/// <summary>
		/// Void Initialize(IntPtr, System.String, Boolean)
		/// </summary>
		protected RMethod r_MInitialize_IntPtr_String_Boolean;
		public virtual RMethod RMInitialize_IntPtr_String_Boolean
		{
			get
			{
				if(r_MInitialize_IntPtr_String_Boolean == null)
				{
					r_MInitialize_IntPtr_String_Boolean = new(this, "Initialize", 0, typeof(System.IntPtr), typeof(System.String), typeof(System.Boolean));
				}
				return r_MInitialize_IntPtr_String_Boolean;
			}
		}

		/// <summary>
		/// Void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_MOpenMethod_SymbolToken;
		public virtual RMethod RMOpenMethod_SymbolToken
		{
			get
			{
				if(r_MOpenMethod_SymbolToken == null)
				{
					r_MOpenMethod_SymbolToken = new(this, "OpenMethod", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
				}
				return r_MOpenMethod_SymbolToken;
			}
		}

		/// <summary>
		/// Void OpenNamespace(System.String)
		/// </summary>
		protected RMethod r_MOpenNamespace_String;
		public virtual RMethod RMOpenNamespace_String
		{
			get
			{
				if(r_MOpenNamespace_String == null)
				{
					r_MOpenNamespace_String = new(this, "OpenNamespace", 0, typeof(System.String));
				}
				return r_MOpenNamespace_String;
			}
		}

		/// <summary>
		/// Int32 OpenScope(Int32)
		/// </summary>
		protected RMethod r_MOpenScope_Int32;
		public virtual RMethod RMOpenScope_Int32
		{
			get
			{
				if(r_MOpenScope_Int32 == null)
				{
					r_MOpenScope_Int32 = new(this, "OpenScope", 0, typeof(System.Int32));
				}
				return r_MOpenScope_Int32;
			}
		}

		/// <summary>
		/// Void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32, System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32;
		public virtual RMethod RMSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32
		{
			get
			{
				if(r_MSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32 == null)
				{
					r_MSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32 = new(this, "SetMethodSourceRange", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32), typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetScopeRange(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetScopeRange_Int32_Int32_Int32;
		public virtual RMethod RMSetScopeRange_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetScopeRange_Int32_Int32_Int32 == null)
				{
					r_MSetScopeRange_Int32_Int32_Int32 = new(this, "SetScopeRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetScopeRange_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken, System.String, Byte[])
		/// </summary>
		protected RMethod r_MSetSymAttribute_SymbolToken_String_ByteArray;
		public virtual RMethod RMSetSymAttribute_SymbolToken_String_ByteArray
		{
			get
			{
				if(r_MSetSymAttribute_SymbolToken_String_ByteArray == null)
				{
					r_MSetSymAttribute_SymbolToken_String_ByteArray = new(this, "SetSymAttribute", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.String), typeof(System.Byte).MakeArrayType());
				}
				return r_MSetSymAttribute_SymbolToken_String_ByteArray;
			}
		}

		/// <summary>
		/// Void SetUnderlyingWriter(IntPtr)
		/// </summary>
		protected RMethod r_MSetUnderlyingWriter_IntPtr;
		public virtual RMethod RMSetUnderlyingWriter_IntPtr
		{
			get
			{
				if(r_MSetUnderlyingWriter_IntPtr == null)
				{
					r_MSetUnderlyingWriter_IntPtr = new(this, "SetUnderlyingWriter", 0, typeof(System.IntPtr));
				}
				return r_MSetUnderlyingWriter_IntPtr;
			}
		}

		/// <summary>
		/// Void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_MSetUserEntryPoint_SymbolToken;
		public virtual RMethod RMSetUserEntryPoint_SymbolToken
		{
			get
			{
				if(r_MSetUserEntryPoint_SymbolToken == null)
				{
					r_MSetUserEntryPoint_SymbolToken = new(this, "SetUserEntryPoint", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
				}
				return r_MSetUserEntryPoint_SymbolToken;
			}
		}

		/// <summary>
		/// Void UsingNamespace(System.String)
		/// </summary>
		protected RMethod r_MUsingNamespace_String;
		public virtual RMethod RMUsingNamespace_String
		{
			get
			{
				if(r_MUsingNamespace_String == null)
				{
					r_MUsingNamespace_String = new(this, "UsingNamespace", 0, typeof(System.String));
				}
				return r_MUsingNamespace_String;
			}
		}


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCloseMethod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseNamespace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCloseNamespace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseScope(System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@endOffset};
            var ___result = RMCloseScope_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String @url, System.Guid @language, System.Guid @languageVendor, System.Guid @documentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @language, @languageVendor, @documentType};
            var ___result = RMDefineDocument_String_Guid_Guid_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Diagnostics.SymbolStore.ISymbolDocumentWriter>(___result);
        }


        public virtual void DefineField(System.Diagnostics.SymbolStore.SymbolToken @parent, System.String @name, System.Reflection.FieldAttributes @attributes, System.Byte[] @signature, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RMDefineField_SymbolToken_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineGlobalVariable(System.String @name, System.Reflection.FieldAttributes @attributes, System.Byte[] @signature, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RMDefineGlobalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineLocalVariable(System.String @name, System.Reflection.FieldAttributes @attributes, System.Byte[] @signature, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3, System.Int32 @startOffset, System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @signature, @addrKind, @addr1, @addr2, @addr3, @startOffset, @endOffset};
            var ___result = RMDefineLocalVariable_String_FieldAttributes_ByteArray_SymAddressKind_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineParameter(System.String @name, System.Reflection.ParameterAttributes @attributes, System.Int32 @sequence, System.Diagnostics.SymbolStore.SymAddressKind @addrKind, System.Int32 @addr1, System.Int32 @addr2, System.Int32 @addr3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @sequence, @addrKind, @addr1, @addr2, @addr3};
            var ___result = RMDefineParameter_String_ParameterAttributes_Int32_SymAddressKind_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter @document, System.Int32[] @offsets, System.Int32[] @lines, System.Int32[] @columns, System.Int32[] @endLines, System.Int32[] @endColumns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@document, @offsets, @lines, @columns, @endLines, @endColumns};
            var ___result = RMDefineSequencePoints_ISymbolDocumentWriter_Int32Array_Int32Array_Int32Array_Int32Array_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.IntPtr @emitter, System.String @filename, System.Boolean @fFullBuild)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@emitter, @filename, @fFullBuild};
            var ___result = RMInitialize_IntPtr_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RMOpenMethod_SymbolToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenNamespace(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMOpenNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 OpenScope(System.Int32 @startOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startOffset};
            var ___result = RMOpenScope_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter @startDoc, System.Int32 @startLine, System.Int32 @startColumn, System.Diagnostics.SymbolStore.ISymbolDocumentWriter @endDoc, System.Int32 @endLine, System.Int32 @endColumn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startDoc, @startLine, @startColumn, @endDoc, @endLine, @endColumn};
            var ___result = RMSetMethodSourceRange_ISymbolDocumentWriter_Int32_Int32_ISymbolDocumentWriter_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScopeRange(System.Int32 @scopeID, System.Int32 @startOffset, System.Int32 @endOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scopeID, @startOffset, @endOffset};
            var ___result = RMSetScopeRange_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken @parent, System.String @name, System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent, @name, @data};
            var ___result = RMSetSymAttribute_SymbolToken_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUnderlyingWriter(System.IntPtr @underlyingWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@underlyingWriter};
            var ___result = RMSetUnderlyingWriter_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken @entryMethod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryMethod};
            var ___result = RMSetUserEntryPoint_SymbolToken.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UsingNamespace(System.String @fullName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullName};
            var ___result = RMUsingNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


    }
}
