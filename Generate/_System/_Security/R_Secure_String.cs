
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Security.SecureString
	/// </summary>
    public partial class RSecureString : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.SecureString);
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


		/// <summary>
		/// System.Int32 BlockSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FBlockSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFBlockSize
		{
			get
			{
				if(r_FBlockSize == null)
				{
					r_FBlockSize = new(Type, "BlockSize");
				}
				return r_FBlockSize;
			}
		}

		/// <summary>
		/// System.Int32 MaxSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxSize
		{
			get
			{
				if(r_FMaxSize == null)
				{
					r_FMaxSize = new(Type, "MaxSize");
				}
				return r_FMaxSize;
			}
		}

		/// <summary>
		/// System.Int32 length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Flength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlength
		{
			get
			{
				if(r_Flength == null)
				{
					r_Flength = new(this, "length");
				}
				return r_Flength;
			}
		}

		/// <summary>
		/// System.Boolean disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fdisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFdisposed
		{
			get
			{
				if(r_Fdisposed == null)
				{
					r_Fdisposed = new(this, "disposed");
				}
				return r_Fdisposed;
			}
		}

		/// <summary>
		/// System.Boolean read_only
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fread_only;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFread_only
		{
			get
			{
				if(r_Fread_only == null)
				{
					r_Fread_only = new(this, "read_only");
				}
				return r_Fread_only;
			}
		}

		/// <summary>
		/// System.Byte[] data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fdata;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// Void AppendChar(Char)
		/// </summary>
		protected RMethod r_MAppendChar_Char;
		public virtual RMethod RMAppendChar_Char
		{
			get
			{
				if(r_MAppendChar_Char == null)
				{
					r_MAppendChar_Char = new(this, "AppendChar", 0, typeof(System.Char));
				}
				return r_MAppendChar_Char;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// System.Security.SecureString Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void InsertAt(Int32, Char)
		/// </summary>
		protected RMethod r_MInsertAt_Int32_Char;
		public virtual RMethod RMInsertAt_Int32_Char
		{
			get
			{
				if(r_MInsertAt_Int32_Char == null)
				{
					r_MInsertAt_Int32_Char = new(this, "InsertAt", 0, typeof(System.Int32), typeof(System.Char));
				}
				return r_MInsertAt_Int32_Char;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly()
		/// </summary>
		protected RMethod r_MIsReadOnly;
		public virtual RMethod RMIsReadOnly
		{
			get
			{
				if(r_MIsReadOnly == null)
				{
					r_MIsReadOnly = new(this, "IsReadOnly", 0);
				}
				return r_MIsReadOnly;
			}
		}

		/// <summary>
		/// Void MakeReadOnly()
		/// </summary>
		protected RMethod r_MMakeReadOnly;
		public virtual RMethod RMMakeReadOnly
		{
			get
			{
				if(r_MMakeReadOnly == null)
				{
					r_MMakeReadOnly = new(this, "MakeReadOnly", 0);
				}
				return r_MMakeReadOnly;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveAt_Int32;
		public virtual RMethod RMRemoveAt_Int32
		{
			get
			{
				if(r_MRemoveAt_Int32 == null)
				{
					r_MRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
				}
				return r_MRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void SetAt(Int32, Char)
		/// </summary>
		protected RMethod r_MSetAt_Int32_Char;
		public virtual RMethod RMSetAt_Int32_Char
		{
			get
			{
				if(r_MSetAt_Int32_Char == null)
				{
					r_MSetAt_Int32_Char = new(this, "SetAt", 0, typeof(System.Int32), typeof(System.Char));
				}
				return r_MSetAt_Int32_Char;
			}
		}

		/// <summary>
		/// Void Encrypt()
		/// </summary>
		protected RMethod r_MEncrypt;
		public virtual RMethod RMEncrypt
		{
			get
			{
				if(r_MEncrypt == null)
				{
					r_MEncrypt = new(this, "Encrypt", 0);
				}
				return r_MEncrypt;
			}
		}

		/// <summary>
		/// Void Decrypt()
		/// </summary>
		protected RMethod r_MDecrypt;
		public virtual RMethod RMDecrypt
		{
			get
			{
				if(r_MDecrypt == null)
				{
					r_MDecrypt = new(this, "Decrypt", 0);
				}
				return r_MDecrypt;
			}
		}

		/// <summary>
		/// Void Alloc(Int32, Boolean)
		/// </summary>
		protected RMethod r_MAlloc_Int32_Boolean;
		public virtual RMethod RMAlloc_Int32_Boolean
		{
			get
			{
				if(r_MAlloc_Int32_Boolean == null)
				{
					r_MAlloc_Int32_Boolean = new(this, "Alloc", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MAlloc_Int32_Boolean;
			}
		}

		/// <summary>
		/// Byte[] GetBuffer()
		/// </summary>
		protected RMethod r_MGetBuffer;
		public virtual RMethod RMGetBuffer
		{
			get
			{
				if(r_MGetBuffer == null)
				{
					r_MGetBuffer = new(this, "GetBuffer", 0);
				}
				return r_MGetBuffer;
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


        public virtual void AppendChar(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMAppendChar_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecureString Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.SecureString>(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAt(System.Int32 @index, System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RMInsertAt_Int32_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsReadOnly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void MakeReadOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeReadOnly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAt(System.Int32 @index, System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @c};
            var ___result = RMSetAt_Int32_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Encrypt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEncrypt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Decrypt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDecrypt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Alloc(System.Int32 @length, System.Boolean @realloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @realloc};
            var ___result = RMAlloc_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBuffer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
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
