using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.SecureString
	/// </summary>
    public partial class RSecureString : RMember //
    {

		/// <summary>
		/// System.Int32 BlockSize
		/// </summary>
		protected static RField r_BlockSize;
		public static RField RBlockSize
		{
			get
			{
				if(r_BlockSize == null)
				{
					r_BlockSize = new(typeof(System.Security.SecureString), "BlockSize");
					r_BlockSize.SetBelong(null);
				}
				return r_BlockSize;
			}
		}

		/// <summary>
		/// System.Int32 MaxSize
		/// </summary>
		protected static RField r_MaxSize;
		public static RField RMaxSize
		{
			get
			{
				if(r_MaxSize == null)
				{
					r_MaxSize = new(typeof(System.Security.SecureString), "MaxSize");
					r_MaxSize.SetBelong(null);
				}
				return r_MaxSize;
			}
		}

		/// <summary>
		/// System.Int32 length
		/// </summary>
		protected RField r_length;
		public virtual RField Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length");
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// System.Boolean disposed
		/// </summary>
		protected RField r_disposed;
		public virtual RField Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed");
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// System.Boolean read_only
		/// </summary>
		protected RField r_read_only;
		public virtual RField Rread_only
		{
			get
			{
				if(r_read_only == null)
				{
					r_read_only = new(this, "read_only");
					r_read_only.SetBelong(this.instance);
				}
				return r_read_only;
			}
		}

		/// <summary>
		/// System.Byte[] data
		/// </summary>
		protected RFieldArray<RField> r_data;
		public virtual RFieldArray<RField> Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// Void AppendChar(Char)
		/// </summary>
		protected RMethod r_AppendChar_Char;
		public virtual RMethod RAppendChar_Char
		{
			get
			{
				if(r_AppendChar_Char == null)
				{
					r_AppendChar_Char = new(this, "AppendChar", 0, typeof(System.Char));
					r_AppendChar_Char.SetBelong(this.instance);
				}
				return r_AppendChar_Char;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// System.Security.SecureString Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void InsertAt(Int32, Char)
		/// </summary>
		protected RMethod r_InsertAt_Int32_Char;
		public virtual RMethod RInsertAt_Int32_Char
		{
			get
			{
				if(r_InsertAt_Int32_Char == null)
				{
					r_InsertAt_Int32_Char = new(this, "InsertAt", 0, typeof(System.Int32), typeof(System.Char));
					r_InsertAt_Int32_Char.SetBelong(this.instance);
				}
				return r_InsertAt_Int32_Char;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly()
		/// </summary>
		protected RMethod r_IsReadOnly;
		public virtual RMethod RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", 0);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Void MakeReadOnly()
		/// </summary>
		protected RMethod r_MakeReadOnly;
		public virtual RMethod RMakeReadOnly
		{
			get
			{
				if(r_MakeReadOnly == null)
				{
					r_MakeReadOnly = new(this, "MakeReadOnly", 0);
					r_MakeReadOnly.SetBelong(this.instance);
				}
				return r_MakeReadOnly;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RemoveAt_Int32 == null)
				{
					r_RemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void SetAt(Int32, Char)
		/// </summary>
		protected RMethod r_SetAt_Int32_Char;
		public virtual RMethod RSetAt_Int32_Char
		{
			get
			{
				if(r_SetAt_Int32_Char == null)
				{
					r_SetAt_Int32_Char = new(this, "SetAt", 0, typeof(System.Int32), typeof(System.Char));
					r_SetAt_Int32_Char.SetBelong(this.instance);
				}
				return r_SetAt_Int32_Char;
			}
		}

		/// <summary>
		/// Void Encrypt()
		/// </summary>
		protected RMethod r_Encrypt;
		public virtual RMethod REncrypt
		{
			get
			{
				if(r_Encrypt == null)
				{
					r_Encrypt = new(this, "Encrypt", 0);
					r_Encrypt.SetBelong(this.instance);
				}
				return r_Encrypt;
			}
		}

		/// <summary>
		/// Void Decrypt()
		/// </summary>
		protected RMethod r_Decrypt;
		public virtual RMethod RDecrypt
		{
			get
			{
				if(r_Decrypt == null)
				{
					r_Decrypt = new(this, "Decrypt", 0);
					r_Decrypt.SetBelong(this.instance);
				}
				return r_Decrypt;
			}
		}

		/// <summary>
		/// Void Alloc(Int32, Boolean)
		/// </summary>
		protected RMethod r_Alloc_Int32_Boolean;
		public virtual RMethod RAlloc_Int32_Boolean
		{
			get
			{
				if(r_Alloc_Int32_Boolean == null)
				{
					r_Alloc_Int32_Boolean = new(this, "Alloc", 0, typeof(System.Int32), typeof(System.Boolean));
					r_Alloc_Int32_Boolean.SetBelong(this.instance);
				}
				return r_Alloc_Int32_Boolean;
			}
		}

		/// <summary>
		/// Byte[] GetBuffer()
		/// </summary>
		protected RMethod r_GetBuffer;
		public virtual RMethod RGetBuffer
		{
			get
			{
				if(r_GetBuffer == null)
				{
					r_GetBuffer = new(this, "GetBuffer", 0);
					r_GetBuffer.SetBelong(this.instance);
				}
				return r_GetBuffer;
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


        public RSecureString() : base("System.Security.SecureString")
        {
        }

        public RSecureString(System.Object instance) : base("System.Security.SecureString")
		{
            SetInstance(instance);
		}

        public RSecureString(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSecureString(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AppendChar(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RAppendChar_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecureString Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.SecureString)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAt(System.Int32 @index, System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RInsertAt_Int32_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsReadOnly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void MakeReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeReadOnly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAt(System.Int32 @index, System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RSetAt_Int32_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Encrypt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REncrypt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Decrypt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDecrypt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Alloc(System.Int32 @length, System.Boolean @realloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @realloc};
            var ___result = RAlloc_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBuffer.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
