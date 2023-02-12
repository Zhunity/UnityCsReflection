
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
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FDefaultBufferSize;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFDefaultBufferSize
		{
			get
			{
				if(r_FDefaultBufferSize == null)
				{
					r_FDefaultBufferSize = new(typeof(System.IO.FileStream), "DefaultBufferSize");
					r_FDefaultBufferSize.SetBelong(null);
				}
				return r_FDefaultBufferSize;
			}
		}

		/// <summary>
		/// System.Byte[] buf_recycle
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_Fbuf_recycle;
		public static SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RFbuf_recycle
		{
			get
			{
				if(r_Fbuf_recycle == null)
				{
					r_Fbuf_recycle = new(typeof(System.IO.FileStream), "buf_recycle");
					r_Fbuf_recycle.SetBelong(null);
				}
				return r_Fbuf_recycle;
			}
		}

		/// <summary>
		/// System.Object buf_recycle_lock
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RObject r_Fbuf_recycle_lock;
		public static SMFrame.Editor.Refleaction.RSystem.RObject RFbuf_recycle_lock
		{
			get
			{
				if(r_Fbuf_recycle_lock == null)
				{
					r_Fbuf_recycle_lock = new(typeof(System.IO.FileStream), "buf_recycle_lock");
					r_Fbuf_recycle_lock.SetBelong(null);
				}
				return r_Fbuf_recycle_lock;
			}
		}

		/// <summary>
		/// System.Byte[] buf
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_Fbuf;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RFbuf
		{
			get
			{
				if(r_Fbuf == null)
				{
					r_Fbuf = new(this, "buf");
					r_Fbuf.SetBelong(this.instance);
				}
				return r_Fbuf;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeFileHandle safeHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle r_FsafeHandle;
		public virtual SMFrame.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle RFsafeHandle
		{
			get
			{
				if(r_FsafeHandle == null)
				{
					r_FsafeHandle = new(this, "safeHandle");
					r_FsafeHandle.SetBelong(this.instance);
				}
				return r_FsafeHandle;
			}
		}

		/// <summary>
		/// System.Boolean isExposed
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisExposed;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFisExposed
		{
			get
			{
				if(r_FisExposed == null)
				{
					r_FisExposed = new(this, "isExposed");
					r_FisExposed.SetBelong(this.instance);
				}
				return r_FisExposed;
			}
		}

		/// <summary>
		/// System.Int64 append_startpos
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fappend_startpos;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFappend_startpos
		{
			get
			{
				if(r_Fappend_startpos == null)
				{
					r_Fappend_startpos = new(this, "append_startpos");
					r_Fappend_startpos.SetBelong(this.instance);
				}
				return r_Fappend_startpos;
			}
		}

		/// <summary>
		/// System.IO.FileAccess access
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIO.RFileAccess r_Faccess;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIO.RFileAccess RFaccess
		{
			get
			{
				if(r_Faccess == null)
				{
					r_Faccess = new(this, "access");
					r_Faccess.SetBelong(this.instance);
				}
				return r_Faccess;
			}
		}

		/// <summary>
		/// System.Boolean owner
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fowner;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFowner
		{
			get
			{
				if(r_Fowner == null)
				{
					r_Fowner = new(this, "owner");
					r_Fowner.SetBelong(this.instance);
				}
				return r_Fowner;
			}
		}

		/// <summary>
		/// System.Boolean async
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fasync;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFasync
		{
			get
			{
				if(r_Fasync == null)
				{
					r_Fasync = new(this, "async");
					r_Fasync.SetBelong(this.instance);
				}
				return r_Fasync;
			}
		}

		/// <summary>
		/// System.Boolean canseek
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fcanseek;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFcanseek
		{
			get
			{
				if(r_Fcanseek == null)
				{
					r_Fcanseek = new(this, "canseek");
					r_Fcanseek.SetBelong(this.instance);
				}
				return r_Fcanseek;
			}
		}

		/// <summary>
		/// System.Boolean anonymous
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fanonymous;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFanonymous
		{
			get
			{
				if(r_Fanonymous == null)
				{
					r_Fanonymous = new(this, "anonymous");
					r_Fanonymous.SetBelong(this.instance);
				}
				return r_Fanonymous;
			}
		}

		/// <summary>
		/// System.Boolean buf_dirty
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fbuf_dirty;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFbuf_dirty
		{
			get
			{
				if(r_Fbuf_dirty == null)
				{
					r_Fbuf_dirty = new(this, "buf_dirty");
					r_Fbuf_dirty.SetBelong(this.instance);
				}
				return r_Fbuf_dirty;
			}
		}

		/// <summary>
		/// System.Int32 buf_size
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fbuf_size;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFbuf_size
		{
			get
			{
				if(r_Fbuf_size == null)
				{
					r_Fbuf_size = new(this, "buf_size");
					r_Fbuf_size.SetBelong(this.instance);
				}
				return r_Fbuf_size;
			}
		}

		/// <summary>
		/// System.Int32 buf_length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fbuf_length;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFbuf_length
		{
			get
			{
				if(r_Fbuf_length == null)
				{
					r_Fbuf_length = new(this, "buf_length");
					r_Fbuf_length.SetBelong(this.instance);
				}
				return r_Fbuf_length;
			}
		}

		/// <summary>
		/// System.Int32 buf_offset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fbuf_offset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFbuf_offset
		{
			get
			{
				if(r_Fbuf_offset == null)
				{
					r_Fbuf_offset = new(this, "buf_offset");
					r_Fbuf_offset.SetBelong(this.instance);
				}
				return r_Fbuf_offset;
			}
		}

		/// <summary>
		/// System.Int64 buf_start
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fbuf_start;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFbuf_start
		{
			get
			{
				if(r_Fbuf_start == null)
				{
					r_Fbuf_start = new(this, "buf_start");
					r_Fbuf_start.SetBelong(this.instance);
				}
				return r_Fbuf_start;
			}
		}

		/// <summary>
		/// Boolean CanRead
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanRead;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanRead
		{
			get
			{
				if(r_PCanRead == null)
				{
					r_PCanRead = new(this, "CanRead", -1);
					r_PCanRead.SetBelong(this.instance);
				}
				return r_PCanRead;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanWrite;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanWrite
		{
			get
			{
				if(r_PCanWrite == null)
				{
					r_PCanWrite = new(this, "CanWrite", -1);
					r_PCanWrite.SetBelong(this.instance);
				}
				return r_PCanWrite;
			}
		}

		/// <summary>
		/// Boolean CanSeek
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanSeek;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanSeek
		{
			get
			{
				if(r_PCanSeek == null)
				{
					r_PCanSeek = new(this, "CanSeek", -1);
					r_PCanSeek.SetBelong(this.instance);
				}
				return r_PCanSeek;
			}
		}

		/// <summary>
		/// Boolean IsAsync
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAsync;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAsync
		{
			get
			{
				if(r_PIsAsync == null)
				{
					r_PIsAsync = new(this, "IsAsync", -1);
					r_PIsAsync.SetBelong(this.instance);
				}
				return r_PIsAsync;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Int64 Length
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PLength;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
					r_PLength.SetBelong(this.instance);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// Int64 Position
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PPosition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPPosition
		{
			get
			{
				if(r_PPosition == null)
				{
					r_PPosition = new(this, "Position", -1);
					r_PPosition.SetBelong(this.instance);
				}
				return r_PPosition;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_PHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RPHandle
		{
			get
			{
				if(r_PHandle == null)
				{
					r_PHandle = new(this, "Handle", -1);
					r_PHandle.SetBelong(this.instance);
				}
				return r_PHandle;
			}
		}

		/// <summary>
		/// Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle r_PSafeFileHandle;
		public virtual SMFrame.Editor.Refleaction.RMicrosoft.RWin32.RSafeHandles.RSafeFileHandle RPSafeFileHandle
		{
			get
			{
				if(r_PSafeFileHandle == null)
				{
					r_PSafeFileHandle = new(this, "SafeFileHandle", -1);
					r_PSafeFileHandle.SetBelong(this.instance);
				}
				return r_PSafeFileHandle;
			}
		}

		/// <summary>
		/// Boolean CanTimeout
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PCanTimeout;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPCanTimeout
		{
			get
			{
				if(r_PCanTimeout == null)
				{
					r_PCanTimeout = new(this, "CanTimeout", -1);
					r_PCanTimeout.SetBelong(this.instance);
				}
				return r_PCanTimeout;
			}
		}

		/// <summary>
		/// Int32 ReadTimeout
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PReadTimeout;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPReadTimeout
		{
			get
			{
				if(r_PReadTimeout == null)
				{
					r_PReadTimeout = new(this, "ReadTimeout", -1);
					r_PReadTimeout.SetBelong(this.instance);
				}
				return r_PReadTimeout;
			}
		}

		/// <summary>
		/// Int32 WriteTimeout
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PWriteTimeout;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPWriteTimeout
		{
			get
			{
				if(r_PWriteTimeout == null)
				{
					r_PWriteTimeout = new(this, "WriteTimeout", -1);
					r_PWriteTimeout.SetBelong(this.instance);
				}
				return r_PWriteTimeout;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity r_PObjectIdentity;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity RPObjectIdentity
		{
			get
			{
				if(r_PObjectIdentity == null)
				{
					r_PObjectIdentity = new(this, "ObjectIdentity", -1);
					r_PObjectIdentity.SetBelong(this.instance);
				}
				return r_PObjectIdentity;
			}
		}

		/// <summary>
		/// Void Init(Microsoft.Win32.SafeHandles.SafeFileHandle, System.IO.FileAccess, Boolean, Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean;
		public virtual RMethod RMInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean == null)
				{
					r_MInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean = new(this, "Init", 0, typeof(Microsoft.Win32.SafeHandles.SafeFileHandle), typeof(System.IO.FileAccess), typeof(System.Boolean), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_MInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ExposeHandle()
		/// </summary>
		protected RMethod r_MExposeHandle;
		public virtual RMethod RMExposeHandle
		{
			get
			{
				if(r_MExposeHandle == null)
				{
					r_MExposeHandle = new(this, "ExposeHandle", 0);
					r_MExposeHandle.SetBelong(this.instance);
				}
				return r_MExposeHandle;
			}
		}

		/// <summary>
		/// Int32 ReadByte()
		/// </summary>
		protected RMethod r_MReadByte;
		public virtual RMethod RMReadByte
		{
			get
			{
				if(r_MReadByte == null)
				{
					r_MReadByte = new(this, "ReadByte", 0);
					r_MReadByte.SetBelong(this.instance);
				}
				return r_MReadByte;
			}
		}

		/// <summary>
		/// Void WriteByte(Byte)
		/// </summary>
		protected RMethod r_MWriteByte_Byte;
		public virtual RMethod RMWriteByte_Byte
		{
			get
			{
				if(r_MWriteByte_Byte == null)
				{
					r_MWriteByte_Byte = new(this, "WriteByte", 0, typeof(System.Byte));
					r_MWriteByte_Byte.SetBelong(this.instance);
				}
				return r_MWriteByte_Byte;
			}
		}

		/// <summary>
		/// Int32 Read(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MRead_ByteArray_Int32_Int32;
		public virtual RMethod RMRead_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MRead_ByteArray_Int32_Int32 == null)
				{
					r_MRead_ByteArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MRead_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MRead_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInternal(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MReadInternal_ByteArray_Int32_Int32;
		public virtual RMethod RMReadInternal_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MReadInternal_ByteArray_Int32_Int32 == null)
				{
					r_MReadInternal_ByteArray_Int32_Int32 = new(this, "ReadInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MReadInternal_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MReadInternal_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginRead(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_MBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RMBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_MBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_MBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BeginRead", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_MBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_MBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndRead(System.IAsyncResult)
		/// </summary>
		protected RMethod r_MEndRead_IAsyncResult;
		public virtual RMethod RMEndRead_IAsyncResult
		{
			get
			{
				if(r_MEndRead_IAsyncResult == null)
				{
					r_MEndRead_IAsyncResult = new(this, "EndRead", 0, typeof(System.IAsyncResult));
					r_MEndRead_IAsyncResult.SetBelong(this.instance);
				}
				return r_MEndRead_IAsyncResult;
			}
		}

		/// <summary>
		/// Void Write(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MWrite_ByteArray_Int32_Int32;
		public virtual RMethod RMWrite_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MWrite_ByteArray_Int32_Int32 == null)
				{
					r_MWrite_ByteArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MWrite_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MWrite_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteInternal(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MWriteInternal_ByteArray_Int32_Int32;
		public virtual RMethod RMWriteInternal_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MWriteInternal_ByteArray_Int32_Int32 == null)
				{
					r_MWriteInternal_ByteArray_Int32_Int32 = new(this, "WriteInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MWriteInternal_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MWriteInternal_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginWrite(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_MBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RMBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_MBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_MBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BeginWrite", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_MBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_MBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndWrite(System.IAsyncResult)
		/// </summary>
		protected RMethod r_MEndWrite_IAsyncResult;
		public virtual RMethod RMEndWrite_IAsyncResult
		{
			get
			{
				if(r_MEndWrite_IAsyncResult == null)
				{
					r_MEndWrite_IAsyncResult = new(this, "EndWrite", 0, typeof(System.IAsyncResult));
					r_MEndWrite_IAsyncResult.SetBelong(this.instance);
				}
				return r_MEndWrite_IAsyncResult;
			}
		}

		/// <summary>
		/// Int64 Seek(Int64, System.IO.SeekOrigin)
		/// </summary>
		protected RMethod r_MSeek_Int64_SeekOrigin;
		public virtual RMethod RMSeek_Int64_SeekOrigin
		{
			get
			{
				if(r_MSeek_Int64_SeekOrigin == null)
				{
					r_MSeek_Int64_SeekOrigin = new(this, "Seek", 0, typeof(System.Int64), typeof(System.IO.SeekOrigin));
					r_MSeek_Int64_SeekOrigin.SetBelong(this.instance);
				}
				return r_MSeek_Int64_SeekOrigin;
			}
		}

		/// <summary>
		/// Void SetLength(Int64)
		/// </summary>
		protected RMethod r_MSetLength_Int64;
		public virtual RMethod RMSetLength_Int64
		{
			get
			{
				if(r_MSetLength_Int64 == null)
				{
					r_MSetLength_Int64 = new(this, "SetLength", 0, typeof(System.Int64));
					r_MSetLength_Int64.SetBelong(this.instance);
				}
				return r_MSetLength_Int64;
			}
		}

		/// <summary>
		/// Void Flush()
		/// </summary>
		protected RMethod r_MFlush;
		public virtual RMethod RMFlush
		{
			get
			{
				if(r_MFlush == null)
				{
					r_MFlush = new(this, "Flush", 0);
					r_MFlush.SetBelong(this.instance);
				}
				return r_MFlush;
			}
		}

		/// <summary>
		/// Void Flush(Boolean)
		/// </summary>
		protected RMethod r_MFlush_Boolean;
		public virtual RMethod RMFlush_Boolean
		{
			get
			{
				if(r_MFlush_Boolean == null)
				{
					r_MFlush_Boolean = new(this, "Flush", 0, typeof(System.Boolean));
					r_MFlush_Boolean.SetBelong(this.instance);
				}
				return r_MFlush_Boolean;
			}
		}

		/// <summary>
		/// Void Lock(Int64, Int64)
		/// </summary>
		protected RMethod r_MLock_Int64_Int64;
		public virtual RMethod RMLock_Int64_Int64
		{
			get
			{
				if(r_MLock_Int64_Int64 == null)
				{
					r_MLock_Int64_Int64 = new(this, "Lock", 0, typeof(System.Int64), typeof(System.Int64));
					r_MLock_Int64_Int64.SetBelong(this.instance);
				}
				return r_MLock_Int64_Int64;
			}
		}

		/// <summary>
		/// Void Unlock(Int64, Int64)
		/// </summary>
		protected RMethod r_MUnlock_Int64_Int64;
		public virtual RMethod RMUnlock_Int64_Int64
		{
			get
			{
				if(r_MUnlock_Int64_Int64 == null)
				{
					r_MUnlock_Int64_Int64 = new(this, "Unlock", 0, typeof(System.Int64), typeof(System.Int64));
					r_MUnlock_Int64_Int64.SetBelong(this.instance);
				}
				return r_MUnlock_Int64_Int64;
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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSecurity GetAccessControl()
		/// </summary>
		protected RMethod r_MGetAccessControl;
		public virtual RMethod RMGetAccessControl
		{
			get
			{
				if(r_MGetAccessControl == null)
				{
					r_MGetAccessControl = new(this, "GetAccessControl", 0);
					r_MGetAccessControl.SetBelong(this.instance);
				}
				return r_MGetAccessControl;
			}
		}

		/// <summary>
		/// Void SetAccessControl(System.Security.AccessControl.FileSecurity)
		/// </summary>
		protected RMethod r_MSetAccessControl_FileSecurity;
		public virtual RMethod RMSetAccessControl_FileSecurity
		{
			get
			{
				if(r_MSetAccessControl_FileSecurity == null)
				{
					r_MSetAccessControl_FileSecurity = new(this, "SetAccessControl", 0, typeof(System.Security.AccessControl.FileSecurity));
					r_MSetAccessControl_FileSecurity.SetBelong(this.instance);
				}
				return r_MSetAccessControl_FileSecurity;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MFlushAsync_CancellationToken;
		public virtual RMethod RMFlushAsync_CancellationToken
		{
			get
			{
				if(r_MFlushAsync_CancellationToken == null)
				{
					r_MFlushAsync_CancellationToken = new(this, "FlushAsync", 0, typeof(System.Threading.CancellationToken));
					r_MFlushAsync_CancellationToken.SetBelong(this.instance);
				}
				return r_MFlushAsync_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Byte[], Int32, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MReadAsync_ByteArray_Int32_Int32_CancellationToken;
		public virtual RMethod RMReadAsync_ByteArray_Int32_Int32_CancellationToken
		{
			get
			{
				if(r_MReadAsync_ByteArray_Int32_Int32_CancellationToken == null)
				{
					r_MReadAsync_ByteArray_Int32_Int32_CancellationToken = new(this, "ReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_MReadAsync_ByteArray_Int32_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MReadAsync_ByteArray_Int32_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Byte[], Int32, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWriteAsync_ByteArray_Int32_Int32_CancellationToken;
		public virtual RMethod RMWriteAsync_ByteArray_Int32_Int32_CancellationToken
		{
			get
			{
				if(r_MWriteAsync_ByteArray_Int32_Int32_CancellationToken == null)
				{
					r_MWriteAsync_ByteArray_Int32_Int32_CancellationToken = new(this, "WriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_MWriteAsync_ByteArray_Int32_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MWriteAsync_ByteArray_Int32_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Int32 ReadSegment(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MReadSegment_ByteArray_Int32_Int32;
		public virtual RMethod RMReadSegment_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MReadSegment_ByteArray_Int32_Int32 == null)
				{
					r_MReadSegment_ByteArray_Int32_Int32 = new(this, "ReadSegment", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MReadSegment_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MReadSegment_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 WriteSegment(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MWriteSegment_ByteArray_Int32_Int32;
		public virtual RMethod RMWriteSegment_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MWriteSegment_ByteArray_Int32_Int32 == null)
				{
					r_MWriteSegment_ByteArray_Int32_Int32 = new(this, "WriteSegment", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MWriteSegment_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MWriteSegment_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void FlushBuffer()
		/// </summary>
		protected RMethod r_MFlushBuffer;
		public virtual RMethod RMFlushBuffer
		{
			get
			{
				if(r_MFlushBuffer == null)
				{
					r_MFlushBuffer = new(this, "FlushBuffer", 0);
					r_MFlushBuffer.SetBelong(this.instance);
				}
				return r_MFlushBuffer;
			}
		}

		/// <summary>
		/// Void FlushBufferIfDirty()
		/// </summary>
		protected RMethod r_MFlushBufferIfDirty;
		public virtual RMethod RMFlushBufferIfDirty
		{
			get
			{
				if(r_MFlushBufferIfDirty == null)
				{
					r_MFlushBufferIfDirty = new(this, "FlushBufferIfDirty", 0);
					r_MFlushBufferIfDirty.SetBelong(this.instance);
				}
				return r_MFlushBufferIfDirty;
			}
		}

		/// <summary>
		/// Void RefillBuffer()
		/// </summary>
		protected RMethod r_MRefillBuffer;
		public virtual RMethod RMRefillBuffer
		{
			get
			{
				if(r_MRefillBuffer == null)
				{
					r_MRefillBuffer = new(this, "RefillBuffer", 0);
					r_MRefillBuffer.SetBelong(this.instance);
				}
				return r_MRefillBuffer;
			}
		}

		/// <summary>
		/// Int32 ReadData(System.Runtime.InteropServices.SafeHandle, Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MReadData_SafeHandle_ByteArray_Int32_Int32;
		public virtual RMethod RMReadData_SafeHandle_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MReadData_SafeHandle_ByteArray_Int32_Int32 == null)
				{
					r_MReadData_SafeHandle_ByteArray_Int32_Int32 = new(this, "ReadData", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MReadData_SafeHandle_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MReadData_SafeHandle_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InitBuffer(Int32, Boolean)
		/// </summary>
		protected RMethod r_MInitBuffer_Int32_Boolean;
		public virtual RMethod RMInitBuffer_Int32_Boolean
		{
			get
			{
				if(r_MInitBuffer_Int32_Boolean == null)
				{
					r_MInitBuffer_Int32_Boolean = new(this, "InitBuffer", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MInitBuffer_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MInitBuffer_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSecureFileName(System.String)
		/// </summary>
		protected RMethod r_MGetSecureFileName_String;
		public virtual RMethod RMGetSecureFileName_String
		{
			get
			{
				if(r_MGetSecureFileName_String == null)
				{
					r_MGetSecureFileName_String = new(this, "GetSecureFileName", 0, typeof(System.String));
					r_MGetSecureFileName_String.SetBelong(this.instance);
				}
				return r_MGetSecureFileName_String;
			}
		}

		/// <summary>
		/// System.String GetSecureFileName(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetSecureFileName_String_Boolean;
		public virtual RMethod RMGetSecureFileName_String_Boolean
		{
			get
			{
				if(r_MGetSecureFileName_String_Boolean == null)
				{
					r_MGetSecureFileName_String_Boolean = new(this, "GetSecureFileName", 0, typeof(System.String), typeof(System.Boolean));
					r_MGetSecureFileName_String_Boolean.SetBelong(this.instance);
				}
				return r_MGetSecureFileName_String_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		/// </summary>
		protected RMethod r_MEnsureAsyncActiveSemaphoreInitialized;
		public virtual RMethod RMEnsureAsyncActiveSemaphoreInitialized
		{
			get
			{
				if(r_MEnsureAsyncActiveSemaphoreInitialized == null)
				{
					r_MEnsureAsyncActiveSemaphoreInitialized = new(this, "EnsureAsyncActiveSemaphoreInitialized", 0);
					r_MEnsureAsyncActiveSemaphoreInitialized.SetBelong(this.instance);
				}
				return r_MEnsureAsyncActiveSemaphoreInitialized;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream)
		/// </summary>
		protected RMethod r_MCopyToAsync_Stream;
		public virtual RMethod RMCopyToAsync_Stream
		{
			get
			{
				if(r_MCopyToAsync_Stream == null)
				{
					r_MCopyToAsync_Stream = new(this, "CopyToAsync", 0, typeof(System.IO.Stream));
					r_MCopyToAsync_Stream.SetBelong(this.instance);
				}
				return r_MCopyToAsync_Stream;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, Int32)
		/// </summary>
		protected RMethod r_MCopyToAsync_Stream_Int32;
		public virtual RMethod RMCopyToAsync_Stream_Int32
		{
			get
			{
				if(r_MCopyToAsync_Stream_Int32 == null)
				{
					r_MCopyToAsync_Stream_Int32 = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Int32));
					r_MCopyToAsync_Stream_Int32.SetBelong(this.instance);
				}
				return r_MCopyToAsync_Stream_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MCopyToAsync_Stream_CancellationToken;
		public virtual RMethod RMCopyToAsync_Stream_CancellationToken
		{
			get
			{
				if(r_MCopyToAsync_Stream_CancellationToken == null)
				{
					r_MCopyToAsync_Stream_CancellationToken = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Threading.CancellationToken));
					r_MCopyToAsync_Stream_CancellationToken.SetBelong(this.instance);
				}
				return r_MCopyToAsync_Stream_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MCopyToAsync_Stream_Int32_CancellationToken;
		public virtual RMethod RMCopyToAsync_Stream_Int32_CancellationToken
		{
			get
			{
				if(r_MCopyToAsync_Stream_Int32_CancellationToken == null)
				{
					r_MCopyToAsync_Stream_Int32_CancellationToken = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_MCopyToAsync_Stream_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_MCopyToAsync_Stream_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void CopyTo(System.IO.Stream)
		/// </summary>
		protected RMethod r_MCopyTo_Stream;
		public virtual RMethod RMCopyTo_Stream
		{
			get
			{
				if(r_MCopyTo_Stream == null)
				{
					r_MCopyTo_Stream = new(this, "CopyTo", 0, typeof(System.IO.Stream));
					r_MCopyTo_Stream.SetBelong(this.instance);
				}
				return r_MCopyTo_Stream;
			}
		}

		/// <summary>
		/// Void CopyTo(System.IO.Stream, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Stream_Int32;
		public virtual RMethod RMCopyTo_Stream_Int32
		{
			get
			{
				if(r_MCopyTo_Stream_Int32 == null)
				{
					r_MCopyTo_Stream_Int32 = new(this, "CopyTo", 0, typeof(System.IO.Stream), typeof(System.Int32));
					r_MCopyTo_Stream_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_Stream_Int32;
			}
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
					r_MClose.SetBelong(this.instance);
				}
				return r_MClose;
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
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync()
		/// </summary>
		protected RMethod r_MFlushAsync;
		public virtual RMethod RMFlushAsync
		{
			get
			{
				if(r_MFlushAsync == null)
				{
					r_MFlushAsync = new(this, "FlushAsync", 0);
					r_MFlushAsync.SetBelong(this.instance);
				}
				return r_MFlushAsync;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle CreateWaitHandle()
		/// </summary>
		protected RMethod r_MCreateWaitHandle;
		public virtual RMethod RMCreateWaitHandle
		{
			get
			{
				if(r_MCreateWaitHandle == null)
				{
					r_MCreateWaitHandle = new(this, "CreateWaitHandle", 0);
					r_MCreateWaitHandle.SetBelong(this.instance);
				}
				return r_MCreateWaitHandle;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReadInternal(Byte[], Int32, Int32, System.AsyncCallback, System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
		public virtual RMethod RMBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean
		{
			get
			{
				if(r_MBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean == null)
				{
					r_MBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean = new(this, "BeginReadInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_MBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MReadAsync_ByteArray_Int32_Int32;
		public virtual RMethod RMReadAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MReadAsync_ByteArray_Int32_Int32 == null)
				{
					r_MReadAsync_ByteArray_Int32_Int32 = new(this, "ReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MReadAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MReadAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsync(System.Memory`1[System.Byte], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MReadAsync_Memory_d_Byte_p__CancellationToken;
		public virtual RMethod RMReadAsync_Memory_d_Byte_p__CancellationToken
		{
			get
			{
				if(r_MReadAsync_Memory_d_Byte_p__CancellationToken == null)
				{
					r_MReadAsync_Memory_d_Byte_p__CancellationToken = new(this, "ReadAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Threading.CancellationToken));
					r_MReadAsync_Memory_d_Byte_p__CancellationToken.SetBelong(this.instance);
				}
				return r_MReadAsync_Memory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginWriteInternal(Byte[], Int32, Int32, System.AsyncCallback, System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
		public virtual RMethod RMBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean
		{
			get
			{
				if(r_MBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean == null)
				{
					r_MBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean = new(this, "BeginWriteInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_MBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MWriteAsync_ByteArray_Int32_Int32;
		public virtual RMethod RMWriteAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MWriteAsync_ByteArray_Int32_Int32 == null)
				{
					r_MWriteAsync_ByteArray_Int32_Int32 = new(this, "WriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MWriteAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_MWriteAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory`1[System.Byte], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
		public virtual RMethod RMWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken
		{
			get
			{
				if(r_MWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken == null)
				{
					r_MWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken = new(this, "WriteAsync", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Threading.CancellationToken));
					r_MWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.SetBelong(this.instance);
				}
				return r_MWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_MRead_Span_d_Byte_p_;
		public virtual RMethod RMRead_Span_d_Byte_p_
		{
			get
			{
				if(r_MRead_Span_d_Byte_p_ == null)
				{
					r_MRead_Span_d_Byte_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_MRead_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_MRead_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_MWrite_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RMWrite_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_MWrite_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_MWrite_ReadOnlySpan_d_Byte_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_MWrite_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_MWrite_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void ObjectInvariant()
		/// </summary>
		protected RMethod r_MObjectInvariant;
		public virtual RMethod RMObjectInvariant
		{
			get
			{
				if(r_MObjectInvariant == null)
				{
					r_MObjectInvariant = new(this, "ObjectInvariant", 0);
					r_MObjectInvariant.SetBelong(this.instance);
				}
				return r_MObjectInvariant;
			}
		}

		/// <summary>
		/// System.IAsyncResult BlockingBeginRead(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_MBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RMBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_MBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_MBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BlockingBeginRead", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_MBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_MBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BlockingBeginWrite(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_MBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RMBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_MBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_MBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BlockingBeginWrite", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_MBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_MBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_MDisposeAsync;
		public virtual RMethod RMDisposeAsync
		{
			get
			{
				if(r_MDisposeAsync == null)
				{
					r_MDisposeAsync = new(this, "DisposeAsync", 0);
					r_MDisposeAsync.SetBelong(this.instance);
				}
				return r_MDisposeAsync;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RMGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_MGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_MCreateObjRef_Type;
		public virtual RMethod RMCreateObjRef_Type
		{
			get
			{
				if(r_MCreateObjRef_Type == null)
				{
					r_MCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_MCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_MCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_MGetLifetimeService;
		public virtual RMethod RMGetLifetimeService
		{
			get
			{
				if(r_MGetLifetimeService == null)
				{
					r_MGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_MGetLifetimeService.SetBelong(this.instance);
				}
				return r_MGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_MInitializeLifetimeService;
		public virtual RMethod RMInitializeLifetimeService
		{
			get
			{
				if(r_MInitializeLifetimeService == null)
				{
					r_MInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_MInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_MInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MMemberwiseClone_Boolean;
		public virtual RMethod RMMemberwiseClone_Boolean
		{
			get
			{
				if(r_MMemberwiseClone_Boolean == null)
				{
					r_MMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MMemberwiseClone_Boolean;
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

        public virtual void Init(Microsoft.Win32.SafeHandles.SafeFileHandle @safeHandle, System.IO.FileAccess @access, System.Boolean @ownsHandle, System.Int32 @bufferSize, System.Boolean @isAsync, System.Boolean @isConsoleWrapper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safeHandle, @access, @ownsHandle, @bufferSize, @isAsync, @isConsoleWrapper};
            var ___result = RMInit_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExposeHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExposeHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadByte()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadByte.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void WriteByte(System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWriteByte_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Read(System.Byte[] @array, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @count};
            var ___result = RMRead_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadInternal(System.Byte[] @dest, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @offset, @count};
            var ___result = RMReadInternal_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IAsyncResult BeginRead(System.Byte[] @array, System.Int32 @offset, System.Int32 @numBytes, System.AsyncCallback @userCallback, System.Object @stateObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @numBytes, @userCallback, @stateObject};
            var ___result = RMBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndRead(System.IAsyncResult @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RMEndRead_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Write(System.Byte[] @array, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @count};
            var ___result = RMWrite_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteInternal(System.Byte[] @src, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @offset, @count};
            var ___result = RMWriteInternal_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginWrite(System.Byte[] @array, System.Int32 @offset, System.Int32 @numBytes, System.AsyncCallback @userCallback, System.Object @stateObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @numBytes, @userCallback, @stateObject};
            var ___result = RMBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndWrite(System.IAsyncResult @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RMEndWrite_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int64 Seek(System.Int64 @offset, System.IO.SeekOrigin @origin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @origin};
            var ___result = RMSeek_Int64_SeekOrigin.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void SetLength(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetLength_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush(System.Boolean @flushToDisk)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flushToDisk};
            var ___result = RMFlush_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Lock(System.Int64 @position, System.Int64 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @length};
            var ___result = RMLock_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Unlock(System.Int64 @position, System.Int64 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @length};
            var ___result = RMUnlock_Int64_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.FileSecurity GetAccessControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAccessControl.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.FileSecurity)___result;
        }


        public virtual void SetAccessControl(System.Security.AccessControl.FileSecurity @fileSecurity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileSecurity};
            var ___result = RMSetAccessControl_FileSecurity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMFlushAsync_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RMReadAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RMWriteAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Int32 ReadSegment(System.Byte[] @dest, System.Int32 @dest_offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest, @dest_offset, @count};
            var ___result = RMReadSegment_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 WriteSegment(System.Byte[] @src, System.Int32 @src_offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @src_offset, @count};
            var ___result = RMWriteSegment_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FlushBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlushBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlushBufferIfDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlushBufferIfDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefillBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefillBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadData(System.Runtime.InteropServices.SafeHandle @safeHandle, System.Byte[] @buf, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@safeHandle, @buf, @offset, @count};
            var ___result = RMReadData_SafeHandle_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitBuffer(System.Int32 @size, System.Boolean @isZeroSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size, @isZeroSize};
            var ___result = RMInitBuffer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSecureFileName(System.String @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RMGetSecureFileName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSecureFileName(System.String @filename, System.Boolean @full)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename, @full};
            var ___result = RMGetSecureFileName_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureAsyncActiveSemaphoreInitialized.Invoke(___genericsType, ___parameters);

            return (System.Threading.SemaphoreSlim)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMCopyToAsync_Stream.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream @destination, System.Int32 @bufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize};
            var ___result = RMCopyToAsync_Stream_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream @destination, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @cancellationToken};
            var ___result = RMCopyToAsync_Stream_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream @destination, System.Int32 @bufferSize, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize, @cancellationToken};
            var ___result = RMCopyToAsync_Stream_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual void CopyTo(System.IO.Stream @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination};
            var ___result = RMCopyTo_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.IO.Stream @destination, System.Int32 @bufferSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize};
            var ___result = RMCopyTo_Stream_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.WaitHandle CreateWaitHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateWaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Threading.WaitHandle)___result;
        }


        public virtual System.IAsyncResult BeginReadInternal(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state, System.Boolean @serializeAsynchronously, System.Boolean @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RMBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMReadAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> @buffer, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RMReadAsync_Memory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.IAsyncResult BeginWriteInternal(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state, System.Boolean @serializeAsynchronously, System.Boolean @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RMBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMWriteAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> @buffer, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RMWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Int32 Read(SMFrame.Editor.Refleaction.RSystem.RSpan<SMFrame.Editor.Refleaction.RSystem.RByte> @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer.Value};
            var ___result = RMRead_Span_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Write(SMFrame.Editor.Refleaction.RSystem.RReadOnlySpan<SMFrame.Editor.Refleaction.RSystem.RByte> @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer.Value};
            var ___result = RMWrite_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ObjectInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMObjectInvariant.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BlockingBeginRead(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RMBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BlockingBeginWrite(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RMBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity(___result);
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RMCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
