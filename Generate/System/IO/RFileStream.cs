using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.FileStream
	/// </summary>
    public partial class RFileStream : RMember //
    {

		/// <summary>
		/// System.Int32 DefaultBufferSize
		/// </summary>
		protected static RField r_DefaultBufferSize;
		public static RField RDefaultBufferSize
		{
			get
			{
				if(r_DefaultBufferSize == null)
				{
					r_DefaultBufferSize = new(typeof(System.IO.FileStream), "DefaultBufferSize");
					r_DefaultBufferSize.SetBelong(null);
				}
				return r_DefaultBufferSize;
			}
		}

		/// <summary>
		/// System.Byte[] buf_recycle
		/// </summary>
		protected static RFieldArray<RField> r_buf_recycle;
		public static RFieldArray<RField> Rbuf_recycle
		{
			get
			{
				if(r_buf_recycle == null)
				{
					r_buf_recycle = new(typeof(System.IO.FileStream), "buf_recycle");
					r_buf_recycle.SetBelong(null);
				}
				return r_buf_recycle;
			}
		}

		/// <summary>
		/// System.Object buf_recycle_lock
		/// </summary>
		protected static RSystem.RObject r_buf_recycle_lock;
		public static RSystem.RObject Rbuf_recycle_lock
		{
			get
			{
				if(r_buf_recycle_lock == null)
				{
					r_buf_recycle_lock = new(typeof(System.IO.FileStream), "buf_recycle_lock");
					r_buf_recycle_lock.SetBelong(null);
				}
				return r_buf_recycle_lock;
			}
		}

		/// <summary>
		/// System.Byte[] buf
		/// </summary>
		protected RFieldArray<RField> r_buf;
		public virtual RFieldArray<RField> Rbuf
		{
			get
			{
				if(r_buf == null)
				{
					r_buf = new(this, "buf");
					r_buf.SetBelong(this.instance);
				}
				return r_buf;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeFileHandle safeHandle
		/// </summary>
		protected RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle r_safeHandle;
		public virtual RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle RsafeHandle
		{
			get
			{
				if(r_safeHandle == null)
				{
					r_safeHandle = new(this, "safeHandle");
					r_safeHandle.SetBelong(this.instance);
				}
				return r_safeHandle;
			}
		}

		/// <summary>
		/// System.Boolean isExposed
		/// </summary>
		protected RField r_isExposed;
		public virtual RField RisExposed
		{
			get
			{
				if(r_isExposed == null)
				{
					r_isExposed = new(this, "isExposed");
					r_isExposed.SetBelong(this.instance);
				}
				return r_isExposed;
			}
		}

		/// <summary>
		/// System.Int64 append_startpos
		/// </summary>
		protected RField r_append_startpos;
		public virtual RField Rappend_startpos
		{
			get
			{
				if(r_append_startpos == null)
				{
					r_append_startpos = new(this, "append_startpos");
					r_append_startpos.SetBelong(this.instance);
				}
				return r_append_startpos;
			}
		}

		/// <summary>
		/// System.IO.FileAccess access
		/// </summary>
		protected RField r_access;
		public virtual RField Raccess
		{
			get
			{
				if(r_access == null)
				{
					r_access = new(this, "access");
					r_access.SetBelong(this.instance);
				}
				return r_access;
			}
		}

		/// <summary>
		/// System.Boolean owner
		/// </summary>
		protected RField r_owner;
		public virtual RField Rowner
		{
			get
			{
				if(r_owner == null)
				{
					r_owner = new(this, "owner");
					r_owner.SetBelong(this.instance);
				}
				return r_owner;
			}
		}

		/// <summary>
		/// System.Boolean async
		/// </summary>
		protected RField r_async;
		public virtual RField Rasync
		{
			get
			{
				if(r_async == null)
				{
					r_async = new(this, "async");
					r_async.SetBelong(this.instance);
				}
				return r_async;
			}
		}

		/// <summary>
		/// System.Boolean canseek
		/// </summary>
		protected RField r_canseek;
		public virtual RField Rcanseek
		{
			get
			{
				if(r_canseek == null)
				{
					r_canseek = new(this, "canseek");
					r_canseek.SetBelong(this.instance);
				}
				return r_canseek;
			}
		}

		/// <summary>
		/// System.Boolean anonymous
		/// </summary>
		protected RField r_anonymous;
		public virtual RField Ranonymous
		{
			get
			{
				if(r_anonymous == null)
				{
					r_anonymous = new(this, "anonymous");
					r_anonymous.SetBelong(this.instance);
				}
				return r_anonymous;
			}
		}

		/// <summary>
		/// System.Boolean buf_dirty
		/// </summary>
		protected RField r_buf_dirty;
		public virtual RField Rbuf_dirty
		{
			get
			{
				if(r_buf_dirty == null)
				{
					r_buf_dirty = new(this, "buf_dirty");
					r_buf_dirty.SetBelong(this.instance);
				}
				return r_buf_dirty;
			}
		}

		/// <summary>
		/// System.Int32 buf_size
		/// </summary>
		protected RField r_buf_size;
		public virtual RField Rbuf_size
		{
			get
			{
				if(r_buf_size == null)
				{
					r_buf_size = new(this, "buf_size");
					r_buf_size.SetBelong(this.instance);
				}
				return r_buf_size;
			}
		}

		/// <summary>
		/// System.Int32 buf_length
		/// </summary>
		protected RField r_buf_length;
		public virtual RField Rbuf_length
		{
			get
			{
				if(r_buf_length == null)
				{
					r_buf_length = new(this, "buf_length");
					r_buf_length.SetBelong(this.instance);
				}
				return r_buf_length;
			}
		}

		/// <summary>
		/// System.Int32 buf_offset
		/// </summary>
		protected RField r_buf_offset;
		public virtual RField Rbuf_offset
		{
			get
			{
				if(r_buf_offset == null)
				{
					r_buf_offset = new(this, "buf_offset");
					r_buf_offset.SetBelong(this.instance);
				}
				return r_buf_offset;
			}
		}

		/// <summary>
		/// System.Int64 buf_start
		/// </summary>
		protected RField r_buf_start;
		public virtual RField Rbuf_start
		{
			get
			{
				if(r_buf_start == null)
				{
					r_buf_start = new(this, "buf_start");
					r_buf_start.SetBelong(this.instance);
				}
				return r_buf_start;
			}
		}

		/// <summary>
		/// Boolean CanRead
		/// </summary>
		protected RProperty r_CanRead;
		public virtual RProperty RCanRead
		{
			get
			{
				if(r_CanRead == null)
				{
					r_CanRead = new(this, "CanRead", -1);
					r_CanRead.SetBelong(this.instance);
				}
				return r_CanRead;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected RProperty r_CanWrite;
		public virtual RProperty RCanWrite
		{
			get
			{
				if(r_CanWrite == null)
				{
					r_CanWrite = new(this, "CanWrite", -1);
					r_CanWrite.SetBelong(this.instance);
				}
				return r_CanWrite;
			}
		}

		/// <summary>
		/// Boolean CanSeek
		/// </summary>
		protected RProperty r_CanSeek;
		public virtual RProperty RCanSeek
		{
			get
			{
				if(r_CanSeek == null)
				{
					r_CanSeek = new(this, "CanSeek", -1);
					r_CanSeek.SetBelong(this.instance);
				}
				return r_CanSeek;
			}
		}

		/// <summary>
		/// Boolean IsAsync
		/// </summary>
		protected RProperty r_IsAsync;
		public virtual RProperty RIsAsync
		{
			get
			{
				if(r_IsAsync == null)
				{
					r_IsAsync = new(this, "IsAsync", -1);
					r_IsAsync.SetBelong(this.instance);
				}
				return r_IsAsync;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// Int64 Length
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
		/// Int64 Position
		/// </summary>
		protected RProperty r_Position;
		public virtual RProperty RPosition
		{
			get
			{
				if(r_Position == null)
				{
					r_Position = new(this, "Position", -1);
					r_Position.SetBelong(this.instance);
				}
				return r_Position;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected RProperty r_Handle;
		public virtual RProperty RHandle
		{
			get
			{
				if(r_Handle == null)
				{
					r_Handle = new(this, "Handle", -1);
					r_Handle.SetBelong(this.instance);
				}
				return r_Handle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle
		/// </summary>
		protected RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle r_SafeFileHandle;
		public virtual RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle RSafeFileHandle
		{
			get
			{
				if(r_SafeFileHandle == null)
				{
					r_SafeFileHandle = new(this, "SafeFileHandle", -1);
					r_SafeFileHandle.SetBelong(this.instance);
				}
				return r_SafeFileHandle;
			}
		}

		/// <summary>
		/// Boolean CanTimeout
		/// </summary>
		protected RProperty r_CanTimeout;
		public virtual RProperty RCanTimeout
		{
			get
			{
				if(r_CanTimeout == null)
				{
					r_CanTimeout = new(this, "CanTimeout", -1);
					r_CanTimeout.SetBelong(this.instance);
				}
				return r_CanTimeout;
			}
		}

		/// <summary>
		/// Int32 ReadTimeout
		/// </summary>
		protected RProperty r_ReadTimeout;
		public virtual RProperty ReadTimeout
		{
			get
			{
				if(r_ReadTimeout == null)
				{
					r_ReadTimeout = new(this, "ReadTimeout", -1);
					r_ReadTimeout.SetBelong(this.instance);
				}
				return r_ReadTimeout;
			}
		}

		/// <summary>
		/// Int32 WriteTimeout
		/// </summary>
		protected RProperty r_WriteTimeout;
		public virtual RProperty RWriteTimeout
		{
			get
			{
				if(r_WriteTimeout == null)
				{
					r_WriteTimeout = new(this, "WriteTimeout", -1);
					r_WriteTimeout.SetBelong(this.instance);
				}
				return r_WriteTimeout;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Void Init(Microsoft.Win32.SafeHandles.SafeFileHandle, System.IO.FileAccess, Boolean, Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean;
		public virtual RMethod RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean
		{
			get
			{
				if(r_RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean == null)
				{
					r_RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean = new(this, "Init", 0, typeof(Microsoft.Win32.SafeHandles.SafeFileHandle), typeof(System.IO.FileAccess), typeof(System.Boolean), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ExposeHandle()
		/// </summary>
		protected RMethod r_RExposeHandle;
		public virtual RMethod RExposeHandle
		{
			get
			{
				if(r_RExposeHandle == null)
				{
					r_RExposeHandle = new(this, "ExposeHandle", 0);
					r_RExposeHandle.SetBelong(this.instance);
				}
				return r_RExposeHandle;
			}
		}

		/// <summary>
		/// Int32 ReadByte()
		/// </summary>
		protected RMethod r_RReadByte;
		public virtual RMethod RReadByte
		{
			get
			{
				if(r_RReadByte == null)
				{
					r_RReadByte = new(this, "ReadByte", 0);
					r_RReadByte.SetBelong(this.instance);
				}
				return r_RReadByte;
			}
		}

		/// <summary>
		/// Void WriteByte(Byte)
		/// </summary>
		protected RMethod r_RWriteByte_Byte;
		public virtual RMethod RWriteByte_Byte
		{
			get
			{
				if(r_RWriteByte_Byte == null)
				{
					r_RWriteByte_Byte = new(this, "WriteByte", 0, typeof(System.Byte));
					r_RWriteByte_Byte.SetBelong(this.instance);
				}
				return r_RWriteByte_Byte;
			}
		}

		/// <summary>
		/// Int32 Read(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RRead_ByteArray_Int32_Int32;
		public virtual RMethod RRead_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RRead_ByteArray_Int32_Int32 == null)
				{
					r_RRead_ByteArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RRead_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRead_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInternal(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadInternal_ByteArray_Int32_Int32;
		public virtual RMethod RReadInternal_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadInternal_ByteArray_Int32_Int32 == null)
				{
					r_RReadInternal_ByteArray_Int32_Int32 = new(this, "ReadInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadInternal_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadInternal_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginRead(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BeginRead", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndRead(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndRead_IAsyncResult;
		public virtual RMethod REndRead_IAsyncResult
		{
			get
			{
				if(r_REndRead_IAsyncResult == null)
				{
					r_REndRead_IAsyncResult = new(this, "EndRead", 0, typeof(System.IAsyncResult));
					r_REndRead_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndRead_IAsyncResult;
			}
		}

		/// <summary>
		/// Void Write(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWrite_ByteArray_Int32_Int32;
		public virtual RMethod RWrite_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWrite_ByteArray_Int32_Int32 == null)
				{
					r_RWrite_ByteArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWrite_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWrite_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteInternal(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteInternal_ByteArray_Int32_Int32;
		public virtual RMethod RWriteInternal_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteInternal_ByteArray_Int32_Int32 == null)
				{
					r_RWriteInternal_ByteArray_Int32_Int32 = new(this, "WriteInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteInternal_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteInternal_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginWrite(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BeginWrite", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndWrite(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndWrite_IAsyncResult;
		public virtual RMethod REndWrite_IAsyncResult
		{
			get
			{
				if(r_REndWrite_IAsyncResult == null)
				{
					r_REndWrite_IAsyncResult = new(this, "EndWrite", 0, typeof(System.IAsyncResult));
					r_REndWrite_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndWrite_IAsyncResult;
			}
		}

		/// <summary>
		/// Int64 Seek(Int64, System.IO.SeekOrigin)
		/// </summary>
		protected RMethod r_RSeek_Int64_SeekOrigin;
		public virtual RMethod RSeek_Int64_SeekOrigin
		{
			get
			{
				if(r_RSeek_Int64_SeekOrigin == null)
				{
					r_RSeek_Int64_SeekOrigin = new(this, "Seek", 0, typeof(System.Int64), typeof(System.IO.SeekOrigin));
					r_RSeek_Int64_SeekOrigin.SetBelong(this.instance);
				}
				return r_RSeek_Int64_SeekOrigin;
			}
		}

		/// <summary>
		/// Void SetLength(Int64)
		/// </summary>
		protected RMethod r_RSetLength_Int64;
		public virtual RMethod RSetLength_Int64
		{
			get
			{
				if(r_RSetLength_Int64 == null)
				{
					r_RSetLength_Int64 = new(this, "SetLength", 0, typeof(System.Int64));
					r_RSetLength_Int64.SetBelong(this.instance);
				}
				return r_RSetLength_Int64;
			}
		}

		/// <summary>
		/// Void Flush()
		/// </summary>
		protected RMethod r_RFlush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_RFlush == null)
				{
					r_RFlush = new(this, "Flush", 0);
					r_RFlush.SetBelong(this.instance);
				}
				return r_RFlush;
			}
		}

		/// <summary>
		/// Void Flush(Boolean)
		/// </summary>
		protected RMethod r_RFlush_Boolean;
		public virtual RMethod RFlush_Boolean
		{
			get
			{
				if(r_RFlush_Boolean == null)
				{
					r_RFlush_Boolean = new(this, "Flush", 0, typeof(System.Boolean));
					r_RFlush_Boolean.SetBelong(this.instance);
				}
				return r_RFlush_Boolean;
			}
		}

		/// <summary>
		/// Void Lock(Int64, Int64)
		/// </summary>
		protected RMethod r_RLock_Int64_Int64;
		public virtual RMethod RLock_Int64_Int64
		{
			get
			{
				if(r_RLock_Int64_Int64 == null)
				{
					r_RLock_Int64_Int64 = new(this, "Lock", 0, typeof(System.Int64), typeof(System.Int64));
					r_RLock_Int64_Int64.SetBelong(this.instance);
				}
				return r_RLock_Int64_Int64;
			}
		}

		/// <summary>
		/// Void Unlock(Int64, Int64)
		/// </summary>
		protected RMethod r_RUnlock_Int64_Int64;
		public virtual RMethod RUnlock_Int64_Int64
		{
			get
			{
				if(r_RUnlock_Int64_Int64 == null)
				{
					r_RUnlock_Int64_Int64 = new(this, "Unlock", 0, typeof(System.Int64), typeof(System.Int64));
					r_RUnlock_Int64_Int64.SetBelong(this.instance);
				}
				return r_RUnlock_Int64_Int64;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSecurity GetAccessControl()
		/// </summary>
		protected RMethod r_RGetAccessControl;
		public virtual RMethod RGetAccessControl
		{
			get
			{
				if(r_RGetAccessControl == null)
				{
					r_RGetAccessControl = new(this, "GetAccessControl", 0);
					r_RGetAccessControl.SetBelong(this.instance);
				}
				return r_RGetAccessControl;
			}
		}

		/// <summary>
		/// Void SetAccessControl(System.Security.AccessControl.FileSecurity)
		/// </summary>
		protected RMethod r_RSetAccessControl_FileSecurity;
		public virtual RMethod RSetAccessControl_FileSecurity
		{
			get
			{
				if(r_RSetAccessControl_FileSecurity == null)
				{
					r_RSetAccessControl_FileSecurity = new(this, "SetAccessControl", 0, typeof(System.Security.AccessControl.FileSecurity));
					r_RSetAccessControl_FileSecurity.SetBelong(this.instance);
				}
				return r_RSetAccessControl_FileSecurity;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RFlushAsync_CancellationToken;
		public virtual RMethod RFlushAsync_CancellationToken
		{
			get
			{
				if(r_RFlushAsync_CancellationToken == null)
				{
					r_RFlushAsync_CancellationToken = new(this, "FlushAsync", 0, typeof(System.Threading.CancellationToken));
					r_RFlushAsync_CancellationToken.SetBelong(this.instance);
				}
				return r_RFlushAsync_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Byte[], Int32, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadAsync_ByteArray_Int32_Int32_CancellationToken;
		public virtual RMethod RReadAsync_ByteArray_Int32_Int32_CancellationToken
		{
			get
			{
				if(r_RReadAsync_ByteArray_Int32_Int32_CancellationToken == null)
				{
					r_RReadAsync_ByteArray_Int32_Int32_CancellationToken = new(this, "ReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RReadAsync_ByteArray_Int32_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RReadAsync_ByteArray_Int32_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Byte[], Int32, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWriteAsync_ByteArray_Int32_Int32_CancellationToken;
		public virtual RMethod RWriteAsync_ByteArray_Int32_Int32_CancellationToken
		{
			get
			{
				if(r_RWriteAsync_ByteArray_Int32_Int32_CancellationToken == null)
				{
					r_RWriteAsync_ByteArray_Int32_Int32_CancellationToken = new(this, "WriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RWriteAsync_ByteArray_Int32_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RWriteAsync_ByteArray_Int32_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Int32 ReadSegment(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadSegment_ByteArray_Int32_Int32;
		public virtual RMethod RReadSegment_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadSegment_ByteArray_Int32_Int32 == null)
				{
					r_RReadSegment_ByteArray_Int32_Int32 = new(this, "ReadSegment", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadSegment_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadSegment_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 WriteSegment(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteSegment_ByteArray_Int32_Int32;
		public virtual RMethod RWriteSegment_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteSegment_ByteArray_Int32_Int32 == null)
				{
					r_RWriteSegment_ByteArray_Int32_Int32 = new(this, "WriteSegment", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteSegment_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteSegment_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void FlushBuffer()
		/// </summary>
		protected RMethod r_RFlushBuffer;
		public virtual RMethod RFlushBuffer
		{
			get
			{
				if(r_RFlushBuffer == null)
				{
					r_RFlushBuffer = new(this, "FlushBuffer", 0);
					r_RFlushBuffer.SetBelong(this.instance);
				}
				return r_RFlushBuffer;
			}
		}

		/// <summary>
		/// Void FlushBufferIfDirty()
		/// </summary>
		protected RMethod r_RFlushBufferIfDirty;
		public virtual RMethod RFlushBufferIfDirty
		{
			get
			{
				if(r_RFlushBufferIfDirty == null)
				{
					r_RFlushBufferIfDirty = new(this, "FlushBufferIfDirty", 0);
					r_RFlushBufferIfDirty.SetBelong(this.instance);
				}
				return r_RFlushBufferIfDirty;
			}
		}

		/// <summary>
		/// Void RefillBuffer()
		/// </summary>
		protected RMethod r_RRefillBuffer;
		public virtual RMethod RRefillBuffer
		{
			get
			{
				if(r_RRefillBuffer == null)
				{
					r_RRefillBuffer = new(this, "RefillBuffer", 0);
					r_RRefillBuffer.SetBelong(this.instance);
				}
				return r_RRefillBuffer;
			}
		}

		/// <summary>
		/// Int32 ReadData(System.Runtime.InteropServices.SafeHandle, Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadData_SafeHandle_ByteArray_Int32_Int32;
		public virtual RMethod RReadData_SafeHandle_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadData_SafeHandle_ByteArray_Int32_Int32 == null)
				{
					r_RReadData_SafeHandle_ByteArray_Int32_Int32 = new(this, "ReadData", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadData_SafeHandle_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadData_SafeHandle_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InitBuffer(Int32, Boolean)
		/// </summary>
		protected RMethod r_RInitBuffer_Int32_Boolean;
		public virtual RMethod RInitBuffer_Int32_Boolean
		{
			get
			{
				if(r_RInitBuffer_Int32_Boolean == null)
				{
					r_RInitBuffer_Int32_Boolean = new(this, "InitBuffer", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RInitBuffer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInitBuffer_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSecureFileName(System.String)
		/// </summary>
		protected RMethod r_RGetSecureFileName_String;
		public virtual RMethod RGetSecureFileName_String
		{
			get
			{
				if(r_RGetSecureFileName_String == null)
				{
					r_RGetSecureFileName_String = new(this, "GetSecureFileName", 0, typeof(System.String));
					r_RGetSecureFileName_String.SetBelong(this.instance);
				}
				return r_RGetSecureFileName_String;
			}
		}

		/// <summary>
		/// System.String GetSecureFileName(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetSecureFileName_String_Boolean;
		public virtual RMethod RGetSecureFileName_String_Boolean
		{
			get
			{
				if(r_RGetSecureFileName_String_Boolean == null)
				{
					r_RGetSecureFileName_String_Boolean = new(this, "GetSecureFileName", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetSecureFileName_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetSecureFileName_String_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		/// </summary>
		protected RMethod r_REnsureAsyncActiveSemaphoreInitialized;
		public virtual RMethod REnsureAsyncActiveSemaphoreInitialized
		{
			get
			{
				if(r_REnsureAsyncActiveSemaphoreInitialized == null)
				{
					r_REnsureAsyncActiveSemaphoreInitialized = new(this, "EnsureAsyncActiveSemaphoreInitialized", 0);
					r_REnsureAsyncActiveSemaphoreInitialized.SetBelong(this.instance);
				}
				return r_REnsureAsyncActiveSemaphoreInitialized;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream)
		/// </summary>
		protected RMethod r_RCopyToAsync_Stream;
		public virtual RMethod RCopyToAsync_Stream
		{
			get
			{
				if(r_RCopyToAsync_Stream == null)
				{
					r_RCopyToAsync_Stream = new(this, "CopyToAsync", 0, typeof(System.IO.Stream));
					r_RCopyToAsync_Stream.SetBelong(this.instance);
				}
				return r_RCopyToAsync_Stream;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, Int32)
		/// </summary>
		protected RMethod r_RCopyToAsync_Stream_Int32;
		public virtual RMethod RCopyToAsync_Stream_Int32
		{
			get
			{
				if(r_RCopyToAsync_Stream_Int32 == null)
				{
					r_RCopyToAsync_Stream_Int32 = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Int32));
					r_RCopyToAsync_Stream_Int32.SetBelong(this.instance);
				}
				return r_RCopyToAsync_Stream_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RCopyToAsync_Stream_CancellationToken;
		public virtual RMethod RCopyToAsync_Stream_CancellationToken
		{
			get
			{
				if(r_RCopyToAsync_Stream_CancellationToken == null)
				{
					r_RCopyToAsync_Stream_CancellationToken = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Threading.CancellationToken));
					r_RCopyToAsync_Stream_CancellationToken.SetBelong(this.instance);
				}
				return r_RCopyToAsync_Stream_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RCopyToAsync_Stream_Int32_CancellationToken;
		public virtual RMethod RCopyToAsync_Stream_Int32_CancellationToken
		{
			get
			{
				if(r_RCopyToAsync_Stream_Int32_CancellationToken == null)
				{
					r_RCopyToAsync_Stream_Int32_CancellationToken = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_RCopyToAsync_Stream_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_RCopyToAsync_Stream_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void CopyTo(System.IO.Stream)
		/// </summary>
		protected RMethod r_RCopyTo_Stream;
		public virtual RMethod RCopyTo_Stream
		{
			get
			{
				if(r_RCopyTo_Stream == null)
				{
					r_RCopyTo_Stream = new(this, "CopyTo", 0, typeof(System.IO.Stream));
					r_RCopyTo_Stream.SetBelong(this.instance);
				}
				return r_RCopyTo_Stream;
			}
		}

		/// <summary>
		/// Void CopyTo(System.IO.Stream, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Stream_Int32;
		public virtual RMethod RCopyTo_Stream_Int32
		{
			get
			{
				if(r_RCopyTo_Stream_Int32 == null)
				{
					r_RCopyTo_Stream_Int32 = new(this, "CopyTo", 0, typeof(System.IO.Stream), typeof(System.Int32));
					r_RCopyTo_Stream_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Stream_Int32;
			}
		}

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
		/// System.Threading.Tasks.Task FlushAsync()
		/// </summary>
		protected RMethod r_RFlushAsync;
		public virtual RMethod RFlushAsync
		{
			get
			{
				if(r_RFlushAsync == null)
				{
					r_RFlushAsync = new(this, "FlushAsync", 0);
					r_RFlushAsync.SetBelong(this.instance);
				}
				return r_RFlushAsync;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle CreateWaitHandle()
		/// </summary>
		protected RMethod r_RCreateWaitHandle;
		public virtual RMethod RCreateWaitHandle
		{
			get
			{
				if(r_RCreateWaitHandle == null)
				{
					r_RCreateWaitHandle = new(this, "CreateWaitHandle", 0);
					r_RCreateWaitHandle.SetBelong(this.instance);
				}
				return r_RCreateWaitHandle;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReadInternal(Byte[], Int32, Int32, System.AsyncCallback, System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
		public virtual RMethod RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean
		{
			get
			{
				if(r_RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean == null)
				{
					r_RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean = new(this, "BeginReadInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadAsync_ByteArray_Int32_Int32 = new(this, "ReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsync(System.Memory`1[System.Byte], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadAsync_Memory_d_Byte_p__CancellationToken;
		public virtual RMethod RReadAsync_Memory_d_Byte_p__CancellationToken
		{
			get
			{
				if(r_RReadAsync_Memory_d_Byte_p__CancellationToken == null)
				{
					r_RReadAsync_Memory_d_Byte_p__CancellationToken = new(this, "ReadAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Threading.CancellationToken));
					r_RReadAsync_Memory_d_Byte_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadAsync_Memory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginWriteInternal(Byte[], Int32, Int32, System.AsyncCallback, System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
		public virtual RMethod RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean
		{
			get
			{
				if(r_RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean == null)
				{
					r_RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean = new(this, "BeginWriteInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteAsync_ByteArray_Int32_Int32;
		public virtual RMethod RWriteAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RWriteAsync_ByteArray_Int32_Int32 == null)
				{
					r_RWriteAsync_ByteArray_Int32_Int32 = new(this, "WriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory`1[System.Byte], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
		public virtual RMethod RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken
		{
			get
			{
				if(r_RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken == null)
				{
					r_RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken = new(this, "WriteAsync", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Threading.CancellationToken));
					r_RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RRead_Span_d_Byte_p_;
		public virtual RMethod RRead_Span_d_Byte_p_
		{
			get
			{
				if(r_RRead_Span_d_Byte_p_ == null)
				{
					r_RRead_Span_d_Byte_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RRead_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RRead_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RWrite_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RWrite_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RWrite_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RWrite_ReadOnlySpan_d_Byte_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RWrite_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RWrite_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void ObjectInvariant()
		/// </summary>
		protected RMethod r_RObjectInvariant;
		public virtual RMethod RObjectInvariant
		{
			get
			{
				if(r_RObjectInvariant == null)
				{
					r_RObjectInvariant = new(this, "ObjectInvariant", 0);
					r_RObjectInvariant.SetBelong(this.instance);
				}
				return r_RObjectInvariant;
			}
		}

		/// <summary>
		/// System.IAsyncResult BlockingBeginRead(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BlockingBeginRead", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BlockingBeginWrite(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BlockingBeginWrite", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_RDisposeAsync;
		public virtual RMethod RDisposeAsync
		{
			get
			{
				if(r_RDisposeAsync == null)
				{
					r_RDisposeAsync = new(this, "DisposeAsync", 0);
					r_RDisposeAsync.SetBelong(this.instance);
				}
				return r_RDisposeAsync;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_RCreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_RCreateObjRef_Type == null)
				{
					r_RCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_RCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_RCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_RGetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_RGetLifetimeService == null)
				{
					r_RGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_RGetLifetimeService.SetBelong(this.instance);
				}
				return r_RGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_RInitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_RInitializeLifetimeService == null)
				{
					r_RInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_RInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_RInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_RMemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_RMemberwiseClone_Boolean == null)
				{
					r_RMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_RMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_RMemberwiseClone_Boolean;
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


        public RFileStream() : base("System.IO.FileStream")
        {
        }

        public RFileStream(System.Object instance) : base("System.IO.FileStream")
		{
            SetInstance(instance);
		}

        public RFileStream(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFileStream(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(Microsoft.Win32.SafeHandles.SafeFileHandle  @safeHandle, System.IO.FileAccess  @access, System.Boolean  @ownsHandle, System.Int32  @bufferSize, System.Boolean  @isAsync, System.Boolean  @isConsoleWrapper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safeHandle, @access, @ownsHandle, @bufferSize, @isAsync, @isConsoleWrapper};
            var ___result = RInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExposeHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExposeHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadByte()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadByte.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void WriteByte(System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteByte_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Read(System.Byte[]  @array, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @count};
            var ___result = RRead_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadInternal(System.Byte[]  @dest, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @offset, @count};
            var ___result = RReadInternal_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IAsyncResult BeginRead(System.Byte[]  @array, System.Int32  @offset, System.Int32  @numBytes, System.AsyncCallback  @userCallback, System.Object  @stateObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @numBytes, @userCallback, @stateObject};
            var ___result = RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndRead(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndRead_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Write(System.Byte[]  @array, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @count};
            var ___result = RWrite_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteInternal(System.Byte[]  @src, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @offset, @count};
            var ___result = RWriteInternal_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginWrite(System.Byte[]  @array, System.Int32  @offset, System.Int32  @numBytes, System.AsyncCallback  @userCallback, System.Object  @stateObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @numBytes, @userCallback, @stateObject};
            var ___result = RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndWrite(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndWrite_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 Seek(System.Int64  @offset, System.IO.SeekOrigin  @origin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @origin};
            var ___result = RSeek_Int64_SeekOrigin.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void SetLength(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetLength_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush(System.Boolean  @flushToDisk)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flushToDisk};
            var ___result = RFlush_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Lock(System.Int64  @position, System.Int64  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @length};
            var ___result = RLock_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Unlock(System.Int64  @position, System.Int64  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @length};
            var ___result = RUnlock_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.FileSecurity GetAccessControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccessControl.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.FileSecurity)___result;
        }


        public virtual void SetAccessControl(System.Security.AccessControl.FileSecurity  @fileSecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileSecurity};
            var ___result = RSetAccessControl_FileSecurity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RFlushAsync_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RReadAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RWriteAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Int32 ReadSegment(System.Byte[]  @dest, System.Int32  @dest_offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @dest_offset, @count};
            var ___result = RReadSegment_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 WriteSegment(System.Byte[]  @src, System.Int32  @src_offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @src_offset, @count};
            var ___result = RWriteSegment_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FlushBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlushBufferIfDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushBufferIfDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefillBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefillBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadData(System.Runtime.InteropServices.SafeHandle  @safeHandle, System.Byte[]  @buf, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safeHandle, @buf, @offset, @count};
            var ___result = RReadData_SafeHandle_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitBuffer(System.Int32  @size, System.Boolean  @isZeroSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size, @isZeroSize};
            var ___result = RInitBuffer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSecureFileName(System.String  @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RGetSecureFileName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSecureFileName(System.String  @filename, System.Boolean  @full)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename, @full};
            var ___result = RGetSecureFileName_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureAsyncActiveSemaphoreInitialized.Invoke(___genericsType, ___parameters);

            return (System.Threading.SemaphoreSlim)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream  @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyToAsync_Stream.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream  @destination, System.Int32  @bufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize};
            var ___result = RCopyToAsync_Stream_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream  @destination, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @cancellationToken};
            var ___result = RCopyToAsync_Stream_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream  @destination, System.Int32  @bufferSize, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize, @cancellationToken};
            var ___result = RCopyToAsync_Stream_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual void CopyTo(System.IO.Stream  @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RCopyTo_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.IO.Stream  @destination, System.Int32  @bufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize};
            var ___result = RCopyTo_Stream_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.WaitHandle CreateWaitHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateWaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Threading.WaitHandle)___result;
        }


        public virtual System.IAsyncResult BeginReadInternal(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state, System.Boolean  @serializeAsynchronously, System.Boolean  @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RReadAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadAsync_Memory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.IAsyncResult BeginWriteInternal(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state, System.Boolean  @serializeAsynchronously, System.Boolean  @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RWriteAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }




        public virtual void ObjectInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RObjectInvariant.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BlockingBeginRead(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BlockingBeginWrite(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
