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
		protected RMethod r_RAppendChar_Char;
		public virtual RMethod RAppendChar_Char
		{
			get
			{
				if(r_RAppendChar_Char == null)
				{
					r_RAppendChar_Char = new(this, "AppendChar", 0, typeof(System.Char));
					r_RAppendChar_Char.SetBelong(this.instance);
				}
				return r_RAppendChar_Char;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// System.Security.SecureString Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void InsertAt(Int32, Char)
		/// </summary>
		protected RMethod r_RInsertAt_Int32_Char;
		public virtual RMethod RInsertAt_Int32_Char
		{
			get
			{
				if(r_RInsertAt_Int32_Char == null)
				{
					r_RInsertAt_Int32_Char = new(this, "InsertAt", 0, typeof(System.Int32), typeof(System.Char));
					r_RInsertAt_Int32_Char.SetBelong(this.instance);
				}
				return r_RInsertAt_Int32_Char;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly()
		/// </summary>
		protected RMethod r_RIsReadOnly;
		public virtual RMethod RIsReadOnly
		{
			get
			{
				if(r_RIsReadOnly == null)
				{
					r_RIsReadOnly = new(this, "IsReadOnly", 0);
					r_RIsReadOnly.SetBelong(this.instance);
				}
				return r_RIsReadOnly;
			}
		}

		/// <summary>
		/// Void MakeReadOnly()
		/// </summary>
		protected RMethod r_RMakeReadOnly;
		public virtual RMethod RMakeReadOnly
		{
			get
			{
				if(r_RMakeReadOnly == null)
				{
					r_RMakeReadOnly = new(this, "MakeReadOnly", 0);
					r_RMakeReadOnly.SetBelong(this.instance);
				}
				return r_RMakeReadOnly;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RRemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RRemoveAt_Int32 == null)
				{
					r_RRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void SetAt(Int32, Char)
		/// </summary>
		protected RMethod r_RSetAt_Int32_Char;
		public virtual RMethod RSetAt_Int32_Char
		{
			get
			{
				if(r_RSetAt_Int32_Char == null)
				{
					r_RSetAt_Int32_Char = new(this, "SetAt", 0, typeof(System.Int32), typeof(System.Char));
					r_RSetAt_Int32_Char.SetBelong(this.instance);
				}
				return r_RSetAt_Int32_Char;
			}
		}

		/// <summary>
		/// Void Encrypt()
		/// </summary>
		protected RMethod r_REncrypt;
		public virtual RMethod REncrypt
		{
			get
			{
				if(r_REncrypt == null)
				{
					r_REncrypt = new(this, "Encrypt", 0);
					r_REncrypt.SetBelong(this.instance);
				}
				return r_REncrypt;
			}
		}

		/// <summary>
		/// Void Decrypt()
		/// </summary>
		protected RMethod r_RDecrypt;
		public virtual RMethod RDecrypt
		{
			get
			{
				if(r_RDecrypt == null)
				{
					r_RDecrypt = new(this, "Decrypt", 0);
					r_RDecrypt.SetBelong(this.instance);
				}
				return r_RDecrypt;
			}
		}

		/// <summary>
		/// Void Alloc(Int32, Boolean)
		/// </summary>
		protected RMethod r_RAlloc_Int32_Boolean;
		public virtual RMethod RAlloc_Int32_Boolean
		{
			get
			{
				if(r_RAlloc_Int32_Boolean == null)
				{
					r_RAlloc_Int32_Boolean = new(this, "Alloc", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RAlloc_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RAlloc_Int32_Boolean;
			}
		}

		/// <summary>
		/// Byte[] GetBuffer()
		/// </summary>
		protected RMethod r_RGetBuffer;
		public virtual RMethod RGetBuffer
		{
			get
			{
				if(r_RGetBuffer == null)
				{
					r_RGetBuffer = new(this, "GetBuffer", 0);
					r_RGetBuffer.SetBelong(this.instance);
				}
				return r_RGetBuffer;
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

        public virtual void AppendChar(System.Char  @c)
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


        public virtual void InsertAt(System.Int32  @index, System.Char  @c)
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


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAt(System.Int32  @index, System.Char  @c)
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


        public virtual void Alloc(System.Int32  @length, System.Boolean  @realloc)
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
