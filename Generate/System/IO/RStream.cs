using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.Stream
	/// </summary>
    public partial class RStream : RMember //
    {

		/// <summary>
		/// System.IO.Stream Null
		/// </summary>
		protected static RSystem.RIO.RStream r_Null;
		public static RSystem.RIO.RStream RNull
		{
			get
			{
				if(r_Null == null)
				{
					r_Null = new(typeof(System.IO.Stream), "Null");
					r_Null.SetBelong(null);
				}
				return r_Null;
			}
		}

		/// <summary>
		/// System.Int32 DefaultCopyBufferSize
		/// </summary>
		protected static RField r_DefaultCopyBufferSize;
		public static RField RDefaultCopyBufferSize
		{
			get
			{
				if(r_DefaultCopyBufferSize == null)
				{
					r_DefaultCopyBufferSize = new(typeof(System.IO.Stream), "DefaultCopyBufferSize");
					r_DefaultCopyBufferSize.SetBelong(null);
				}
				return r_DefaultCopyBufferSize;
			}
		}

		/// <summary>
		/// System.IO.Stream+ReadWriteTask _activeReadWriteTask
		/// </summary>
		protected RSystem.RIO.RStream.RReadWriteTask r__activeReadWriteTask;
		public virtual RSystem.RIO.RStream.RReadWriteTask R_activeReadWriteTask
		{
			get
			{
				if(r__activeReadWriteTask == null)
				{
					r__activeReadWriteTask = new(this, "_activeReadWriteTask");
					r__activeReadWriteTask.SetBelong(this.instance);
				}
				return r__activeReadWriteTask;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim _asyncActiveSemaphore
		/// </summary>
		protected RSystem.RThreading.RSemaphoreSlim r__asyncActiveSemaphore;
		public virtual RSystem.RThreading.RSemaphoreSlim R_asyncActiveSemaphore
		{
			get
			{
				if(r__asyncActiveSemaphore == null)
				{
					r__asyncActiveSemaphore = new(this, "_asyncActiveSemaphore");
					r__asyncActiveSemaphore.SetBelong(this.instance);
				}
				return r__asyncActiveSemaphore;
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
		/// Int32 ReadTimeout
		/// </summary>
		protected RProperty r_ReadTimeout;
		public virtual RProperty RReadTimeout
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
		/// System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		/// </summary>
		protected RMethod r_EnsureAsyncActiveSemaphoreInitialized;
		public virtual RMethod REnsureAsyncActiveSemaphoreInitialized
		{
			get
			{
				if(r_EnsureAsyncActiveSemaphoreInitialized == null)
				{
					r_EnsureAsyncActiveSemaphoreInitialized = new(this, "EnsureAsyncActiveSemaphoreInitialized", 0);
					r_EnsureAsyncActiveSemaphoreInitialized.SetBelong(this.instance);
				}
				return r_EnsureAsyncActiveSemaphoreInitialized;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream)
		/// </summary>
		protected RMethod r_CopyToAsync_Stream;
		public virtual RMethod RCopyToAsync_Stream
		{
			get
			{
				if(r_CopyToAsync_Stream == null)
				{
					r_CopyToAsync_Stream = new(this, "CopyToAsync", 0, typeof(System.IO.Stream));
					r_CopyToAsync_Stream.SetBelong(this.instance);
				}
				return r_CopyToAsync_Stream;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, Int32)
		/// </summary>
		protected RMethod r_CopyToAsync_Stream_Int32;
		public virtual RMethod RCopyToAsync_Stream_Int32
		{
			get
			{
				if(r_CopyToAsync_Stream_Int32 == null)
				{
					r_CopyToAsync_Stream_Int32 = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Int32));
					r_CopyToAsync_Stream_Int32.SetBelong(this.instance);
				}
				return r_CopyToAsync_Stream_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_CopyToAsync_Stream_CancellationToken;
		public virtual RMethod RCopyToAsync_Stream_CancellationToken
		{
			get
			{
				if(r_CopyToAsync_Stream_CancellationToken == null)
				{
					r_CopyToAsync_Stream_CancellationToken = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Threading.CancellationToken));
					r_CopyToAsync_Stream_CancellationToken.SetBelong(this.instance);
				}
				return r_CopyToAsync_Stream_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsync(System.IO.Stream, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_CopyToAsync_Stream_Int32_CancellationToken;
		public virtual RMethod RCopyToAsync_Stream_Int32_CancellationToken
		{
			get
			{
				if(r_CopyToAsync_Stream_Int32_CancellationToken == null)
				{
					r_CopyToAsync_Stream_Int32_CancellationToken = new(this, "CopyToAsync", 0, typeof(System.IO.Stream), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_CopyToAsync_Stream_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_CopyToAsync_Stream_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsyncInternal(System.IO.Stream, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_CopyToAsyncInternal_Stream_Int32_CancellationToken;
		public virtual RMethod RCopyToAsyncInternal_Stream_Int32_CancellationToken
		{
			get
			{
				if(r_CopyToAsyncInternal_Stream_Int32_CancellationToken == null)
				{
					r_CopyToAsyncInternal_Stream_Int32_CancellationToken = new(this, "CopyToAsyncInternal", 0, typeof(System.IO.Stream), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_CopyToAsyncInternal_Stream_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_CopyToAsyncInternal_Stream_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// Void CopyTo(System.IO.Stream)
		/// </summary>
		protected RMethod r_CopyTo_Stream;
		public virtual RMethod RCopyTo_Stream
		{
			get
			{
				if(r_CopyTo_Stream == null)
				{
					r_CopyTo_Stream = new(this, "CopyTo", 0, typeof(System.IO.Stream));
					r_CopyTo_Stream.SetBelong(this.instance);
				}
				return r_CopyTo_Stream;
			}
		}

		/// <summary>
		/// Void CopyTo(System.IO.Stream, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Stream_Int32;
		public virtual RMethod RCopyTo_Stream_Int32
		{
			get
			{
				if(r_CopyTo_Stream_Int32 == null)
				{
					r_CopyTo_Stream_Int32 = new(this, "CopyTo", 0, typeof(System.IO.Stream), typeof(System.Int32));
					r_CopyTo_Stream_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Stream_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCopyBufferSize()
		/// </summary>
		protected RMethod r_GetCopyBufferSize;
		public virtual RMethod RGetCopyBufferSize
		{
			get
			{
				if(r_GetCopyBufferSize == null)
				{
					r_GetCopyBufferSize = new(this, "GetCopyBufferSize", 0);
					r_GetCopyBufferSize.SetBelong(this.instance);
				}
				return r_GetCopyBufferSize;
			}
		}

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
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// Void Flush()
		/// </summary>
		protected RMethod r_Flush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_Flush == null)
				{
					r_Flush = new(this, "Flush", 0);
					r_Flush.SetBelong(this.instance);
				}
				return r_Flush;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync()
		/// </summary>
		protected RMethod r_FlushAsync;
		public virtual RMethod RFlushAsync
		{
			get
			{
				if(r_FlushAsync == null)
				{
					r_FlushAsync = new(this, "FlushAsync", 0);
					r_FlushAsync.SetBelong(this.instance);
				}
				return r_FlushAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_FlushAsync_CancellationToken;
		public virtual RMethod RFlushAsync_CancellationToken
		{
			get
			{
				if(r_FlushAsync_CancellationToken == null)
				{
					r_FlushAsync_CancellationToken = new(this, "FlushAsync", 0, typeof(System.Threading.CancellationToken));
					r_FlushAsync_CancellationToken.SetBelong(this.instance);
				}
				return r_FlushAsync_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle CreateWaitHandle()
		/// </summary>
		protected RMethod r_CreateWaitHandle;
		public virtual RMethod RCreateWaitHandle
		{
			get
			{
				if(r_CreateWaitHandle == null)
				{
					r_CreateWaitHandle = new(this, "CreateWaitHandle", 0);
					r_CreateWaitHandle.SetBelong(this.instance);
				}
				return r_CreateWaitHandle;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginRead(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_BeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_BeginRead_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_BeginRead_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BeginRead", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_BeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_BeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReadInternal(Byte[], Int32, Int32, System.AsyncCallback, System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_BeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
		public virtual RMethod RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean
		{
			get
			{
				if(r_BeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean == null)
				{
					r_BeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean = new(this, "BeginReadInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_BeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_BeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 EndRead(System.IAsyncResult)
		/// </summary>
		protected RMethod r_EndRead_IAsyncResult;
		public virtual RMethod REndRead_IAsyncResult
		{
			get
			{
				if(r_EndRead_IAsyncResult == null)
				{
					r_EndRead_IAsyncResult = new(this, "EndRead", 0, typeof(System.IAsyncResult));
					r_EndRead_IAsyncResult.SetBelong(this.instance);
				}
				return r_EndRead_IAsyncResult;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_ReadAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_ReadAsync_ByteArray_Int32_Int32 == null)
				{
					r_ReadAsync_ByteArray_Int32_Int32 = new(this, "ReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_ReadAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_ReadAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Byte[], Int32, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ReadAsync_ByteArray_Int32_Int32_CancellationToken;
		public virtual RMethod RReadAsync_ByteArray_Int32_Int32_CancellationToken
		{
			get
			{
				if(r_ReadAsync_ByteArray_Int32_Int32_CancellationToken == null)
				{
					r_ReadAsync_ByteArray_Int32_Int32_CancellationToken = new(this, "ReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_ReadAsync_ByteArray_Int32_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_ReadAsync_ByteArray_Int32_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsync(System.Memory`1[System.Byte], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_ReadAsync_Memory_d_Byte_p__CancellationToken;
		public virtual RMethod RReadAsync_Memory_d_Byte_p__CancellationToken
		{
			get
			{
				if(r_ReadAsync_Memory_d_Byte_p__CancellationToken == null)
				{
					r_ReadAsync_Memory_d_Byte_p__CancellationToken = new(this, "ReadAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Threading.CancellationToken));
					r_ReadAsync_Memory_d_Byte_p__CancellationToken.SetBelong(this.instance);
				}
				return r_ReadAsync_Memory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] BeginEndReadAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_BeginEndReadAsync_ByteArray_Int32_Int32;
		public virtual RMethod RBeginEndReadAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_BeginEndReadAsync_ByteArray_Int32_Int32 == null)
				{
					r_BeginEndReadAsync_ByteArray_Int32_Int32 = new(this, "BeginEndReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_BeginEndReadAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_BeginEndReadAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginWrite(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_BeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_BeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_BeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BeginWrite", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_BeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_BeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginWriteInternal(Byte[], Int32, Int32, System.AsyncCallback, System.Object, Boolean, Boolean)
		/// </summary>
		protected RMethod r_BeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
		public virtual RMethod RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean
		{
			get
			{
				if(r_BeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean == null)
				{
					r_BeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean = new(this, "BeginWriteInternal", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean));
					r_BeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_BeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void RunReadWriteTaskWhenReady(System.Threading.Tasks.Task, ReadWriteTask)
		/// </summary>
		protected RMethod r_RunReadWriteTaskWhenReady_Task_ReadWriteTask;
		public virtual RMethod RRunReadWriteTaskWhenReady_Task_ReadWriteTask
		{
			get
			{
				if(r_RunReadWriteTaskWhenReady_Task_ReadWriteTask == null)
				{
					r_RunReadWriteTaskWhenReady_Task_ReadWriteTask = new(this, "RunReadWriteTaskWhenReady", 0, typeof(System.Threading.Tasks.Task),  ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"));
					r_RunReadWriteTaskWhenReady_Task_ReadWriteTask.SetBelong(this.instance);
				}
				return r_RunReadWriteTaskWhenReady_Task_ReadWriteTask;
			}
		}

		/// <summary>
		/// Void RunReadWriteTask(ReadWriteTask)
		/// </summary>
		protected RMethod r_RunReadWriteTask_ReadWriteTask;
		public virtual RMethod RRunReadWriteTask_ReadWriteTask
		{
			get
			{
				if(r_RunReadWriteTask_ReadWriteTask == null)
				{
					r_RunReadWriteTask_ReadWriteTask = new(this, "RunReadWriteTask", 0,  ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"));
					r_RunReadWriteTask_ReadWriteTask.SetBelong(this.instance);
				}
				return r_RunReadWriteTask_ReadWriteTask;
			}
		}

		/// <summary>
		/// Void FinishTrackingAsyncOperation()
		/// </summary>
		protected RMethod r_FinishTrackingAsyncOperation;
		public virtual RMethod RFinishTrackingAsyncOperation
		{
			get
			{
				if(r_FinishTrackingAsyncOperation == null)
				{
					r_FinishTrackingAsyncOperation = new(this, "FinishTrackingAsyncOperation", 0);
					r_FinishTrackingAsyncOperation.SetBelong(this.instance);
				}
				return r_FinishTrackingAsyncOperation;
			}
		}

		/// <summary>
		/// Void EndWrite(System.IAsyncResult)
		/// </summary>
		protected RMethod r_EndWrite_IAsyncResult;
		public virtual RMethod REndWrite_IAsyncResult
		{
			get
			{
				if(r_EndWrite_IAsyncResult == null)
				{
					r_EndWrite_IAsyncResult = new(this, "EndWrite", 0, typeof(System.IAsyncResult));
					r_EndWrite_IAsyncResult.SetBelong(this.instance);
				}
				return r_EndWrite_IAsyncResult;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_WriteAsync_ByteArray_Int32_Int32;
		public virtual RMethod RWriteAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_WriteAsync_ByteArray_Int32_Int32 == null)
				{
					r_WriteAsync_ByteArray_Int32_Int32 = new(this, "WriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_WriteAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_WriteAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Byte[], Int32, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_WriteAsync_ByteArray_Int32_Int32_CancellationToken;
		public virtual RMethod RWriteAsync_ByteArray_Int32_Int32_CancellationToken
		{
			get
			{
				if(r_WriteAsync_ByteArray_Int32_Int32_CancellationToken == null)
				{
					r_WriteAsync_ByteArray_Int32_Int32_CancellationToken = new(this, "WriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Threading.CancellationToken));
					r_WriteAsync_ByteArray_Int32_Int32_CancellationToken.SetBelong(this.instance);
				}
				return r_WriteAsync_ByteArray_Int32_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory`1[System.Byte], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_WriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
		public virtual RMethod RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken
		{
			get
			{
				if(r_WriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken == null)
				{
					r_WriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken = new(this, "WriteAsync", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Threading.CancellationToken));
					r_WriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.SetBelong(this.instance);
				}
				return r_WriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishWriteAsync(System.Threading.Tasks.Task, Byte[])
		/// </summary>
		protected RMethod r_FinishWriteAsync_Task_ByteArray;
		public virtual RMethod RFinishWriteAsync_Task_ByteArray
		{
			get
			{
				if(r_FinishWriteAsync_Task_ByteArray == null)
				{
					r_FinishWriteAsync_Task_ByteArray = new(this, "FinishWriteAsync", 0, typeof(System.Threading.Tasks.Task), typeof(System.Byte).MakeArrayType());
					r_FinishWriteAsync_Task_ByteArray.SetBelong(this.instance);
				}
				return r_FinishWriteAsync_Task_ByteArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task BeginEndWriteAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_BeginEndWriteAsync_ByteArray_Int32_Int32;
		public virtual RMethod RBeginEndWriteAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_BeginEndWriteAsync_ByteArray_Int32_Int32 == null)
				{
					r_BeginEndWriteAsync_ByteArray_Int32_Int32 = new(this, "BeginEndWriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_BeginEndWriteAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_BeginEndWriteAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int64 Seek(Int64, System.IO.SeekOrigin)
		/// </summary>
		protected RMethod r_Seek_Int64_SeekOrigin;
		public virtual RMethod RSeek_Int64_SeekOrigin
		{
			get
			{
				if(r_Seek_Int64_SeekOrigin == null)
				{
					r_Seek_Int64_SeekOrigin = new(this, "Seek", 0, typeof(System.Int64), typeof(System.IO.SeekOrigin));
					r_Seek_Int64_SeekOrigin.SetBelong(this.instance);
				}
				return r_Seek_Int64_SeekOrigin;
			}
		}

		/// <summary>
		/// Void SetLength(Int64)
		/// </summary>
		protected RMethod r_SetLength_Int64;
		public virtual RMethod RSetLength_Int64
		{
			get
			{
				if(r_SetLength_Int64 == null)
				{
					r_SetLength_Int64 = new(this, "SetLength", 0, typeof(System.Int64));
					r_SetLength_Int64.SetBelong(this.instance);
				}
				return r_SetLength_Int64;
			}
		}

		/// <summary>
		/// Int32 Read(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_Read_ByteArray_Int32_Int32;
		public virtual RMethod RRead_ByteArray_Int32_Int32
		{
			get
			{
				if(r_Read_ByteArray_Int32_Int32 == null)
				{
					r_Read_ByteArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Read_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_Read_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_Read_Span_d_Byte_p_;
		public virtual RMethod RRead_Span_d_Byte_p_
		{
			get
			{
				if(r_Read_Span_d_Byte_p_ == null)
				{
					r_Read_Span_d_Byte_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_Read_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_Read_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Int32 ReadByte()
		/// </summary>
		protected RMethod r_ReadByte;
		public virtual RMethod RReadByte
		{
			get
			{
				if(r_ReadByte == null)
				{
					r_ReadByte = new(this, "ReadByte", 0);
					r_ReadByte.SetBelong(this.instance);
				}
				return r_ReadByte;
			}
		}

		/// <summary>
		/// Void Write(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_Write_ByteArray_Int32_Int32;
		public virtual RMethod RWrite_ByteArray_Int32_Int32
		{
			get
			{
				if(r_Write_ByteArray_Int32_Int32 == null)
				{
					r_Write_ByteArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Write_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_Write_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_Write_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RWrite_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_Write_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_Write_ReadOnlySpan_d_Byte_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_Write_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_Write_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void WriteByte(Byte)
		/// </summary>
		protected RMethod r_WriteByte_Byte;
		public virtual RMethod RWriteByte_Byte
		{
			get
			{
				if(r_WriteByte_Byte == null)
				{
					r_WriteByte_Byte = new(this, "WriteByte", 0, typeof(System.Byte));
					r_WriteByte_Byte.SetBelong(this.instance);
				}
				return r_WriteByte_Byte;
			}
		}

		/// <summary>
		/// System.IO.Stream Synchronized(System.IO.Stream)
		/// </summary>
		protected static RMethod r_Synchronized_Stream;
		public static RMethod RSynchronized_Stream
		{
			get
			{
				if(r_Synchronized_Stream == null)
				{
					r_Synchronized_Stream = new(typeof(System.IO.Stream), "Synchronized", 0, typeof(System.IO.Stream));
					r_Synchronized_Stream.SetBelong(null);
				}
				return r_Synchronized_Stream;
			}
		}

		/// <summary>
		/// Void ObjectInvariant()
		/// </summary>
		protected RMethod r_ObjectInvariant;
		public virtual RMethod RObjectInvariant
		{
			get
			{
				if(r_ObjectInvariant == null)
				{
					r_ObjectInvariant = new(this, "ObjectInvariant", 0);
					r_ObjectInvariant.SetBelong(this.instance);
				}
				return r_ObjectInvariant;
			}
		}

		/// <summary>
		/// System.IAsyncResult BlockingBeginRead(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_BlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_BlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_BlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BlockingBeginRead", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_BlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_BlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 BlockingEndRead(System.IAsyncResult)
		/// </summary>
		protected static RMethod r_BlockingEndRead_IAsyncResult;
		public static RMethod RBlockingEndRead_IAsyncResult
		{
			get
			{
				if(r_BlockingEndRead_IAsyncResult == null)
				{
					r_BlockingEndRead_IAsyncResult = new(typeof(System.IO.Stream), "BlockingEndRead", 0, typeof(System.IAsyncResult));
					r_BlockingEndRead_IAsyncResult.SetBelong(null);
				}
				return r_BlockingEndRead_IAsyncResult;
			}
		}

		/// <summary>
		/// System.IAsyncResult BlockingBeginWrite(Byte[], Int32, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_BlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
		public virtual RMethod RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_BlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object == null)
				{
					r_BlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object = new(this, "BlockingBeginWrite", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_BlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_BlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void BlockingEndWrite(System.IAsyncResult)
		/// </summary>
		protected static RMethod r_BlockingEndWrite_IAsyncResult;
		public static RMethod RBlockingEndWrite_IAsyncResult
		{
			get
			{
				if(r_BlockingEndWrite_IAsyncResult == null)
				{
					r_BlockingEndWrite_IAsyncResult = new(typeof(System.IO.Stream), "BlockingEndWrite", 0, typeof(System.IAsyncResult));
					r_BlockingEndWrite_IAsyncResult.SetBelong(null);
				}
				return r_BlockingEndWrite_IAsyncResult;
			}
		}

		/// <summary>
		/// Boolean HasOverriddenBeginEndRead()
		/// </summary>
		protected RMethod r_HasOverriddenBeginEndRead;
		public virtual RMethod RHasOverriddenBeginEndRead
		{
			get
			{
				if(r_HasOverriddenBeginEndRead == null)
				{
					r_HasOverriddenBeginEndRead = new(this, "HasOverriddenBeginEndRead", 0);
					r_HasOverriddenBeginEndRead.SetBelong(this.instance);
				}
				return r_HasOverriddenBeginEndRead;
			}
		}

		/// <summary>
		/// Boolean HasOverriddenBeginEndWrite()
		/// </summary>
		protected RMethod r_HasOverriddenBeginEndWrite;
		public virtual RMethod RHasOverriddenBeginEndWrite
		{
			get
			{
				if(r_HasOverriddenBeginEndWrite == null)
				{
					r_HasOverriddenBeginEndWrite = new(this, "HasOverriddenBeginEndWrite", 0);
					r_HasOverriddenBeginEndWrite.SetBelong(this.instance);
				}
				return r_HasOverriddenBeginEndWrite;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_DisposeAsync;
		public virtual RMethod RDisposeAsync
		{
			get
			{
				if(r_DisposeAsync == null)
				{
					r_DisposeAsync = new(this, "DisposeAsync", 0);
					r_DisposeAsync.SetBelong(this.instance);
				}
				return r_DisposeAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] <ReadAsync>g__FinishReadAsync|44_0(System.Threading.Tasks.Task`1[System.Int32], Byte[], System.Memory`1[System.Byte])
		/// </summary>
		protected static RMethod r___0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_;
		public static RMethod R__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_
		{
			get
			{
				if(r___0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_ == null)
				{
					r___0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_ = new(typeof(System.IO.Stream), "<ReadAsync>g__FinishReadAsync|44_0", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Byte).MakeArrayType(), typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)));
					r___0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_.SetBelong(null);
				}
				return r___0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_GetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_GetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_CreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_CreateObjRef_Type == null)
				{
					r_CreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_CreateObjRef_Type.SetBelong(this.instance);
				}
				return r_CreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_GetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_GetLifetimeService == null)
				{
					r_GetLifetimeService = new(this, "GetLifetimeService", 0);
					r_GetLifetimeService.SetBelong(this.instance);
				}
				return r_GetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_InitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_InitializeLifetimeService == null)
				{
					r_InitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_InitializeLifetimeService.SetBelong(this.instance);
				}
				return r_InitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_MemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_MemberwiseClone_Boolean == null)
				{
					r_MemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_MemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_MemberwiseClone_Boolean;
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


        public RStream() : base("System.IO.Stream")
        {
        }

        public RStream(System.Object instance) : base("System.IO.Stream")
		{
            SetInstance(instance);
		}

        public RStream(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStream(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Threading.Tasks.Task CopyToAsyncInternal(System.IO.Stream  @destination, System.Int32  @bufferSize, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize, @cancellationToken};
            var ___result = RCopyToAsyncInternal_Stream_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

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


        public virtual System.Int32 GetCopyBufferSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCopyBufferSize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RFlushAsync_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.WaitHandle CreateWaitHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateWaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Threading.WaitHandle)___result;
        }


        public virtual System.IAsyncResult BeginRead(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginReadInternal(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state, System.Boolean  @serializeAsynchronously, System.Boolean  @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndRead(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndRead_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RReadAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RReadAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadAsync_Memory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> BeginEndReadAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RBeginEndReadAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.IAsyncResult BeginWrite(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginWriteInternal(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state, System.Boolean  @serializeAsynchronously, System.Boolean  @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }




        public virtual void FinishTrackingAsyncOperation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishTrackingAsyncOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWrite(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndWrite_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RWriteAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RWriteAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Threading.Tasks.Task FinishWriteAsync(System.Threading.Tasks.Task  @writeTask, System.Byte[]  @localBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writeTask, @localBuffer};
            var ___result = RFinishWriteAsync_Task_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task BeginEndWriteAsync(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RBeginEndWriteAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
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


        public virtual System.Int32 Read(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RRead_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 ReadByte()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadByte.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Write(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RWrite_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void WriteByte(System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteByte_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IO.Stream Synchronized(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RSynchronized_Stream.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
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


        public static System.Int32 BlockingEndRead(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RBlockingEndRead_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IAsyncResult BlockingBeginWrite(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public static void BlockingEndWrite(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RBlockingEndWrite_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasOverriddenBeginEndRead()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasOverriddenBeginEndRead.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasOverriddenBeginEndWrite()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasOverriddenBeginEndWrite.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public static System.Threading.Tasks.ValueTask<System.Int32> __0__ReadAsync__1__g__FinishReadAsync__5__44_0(System.Threading.Tasks.Task<System.Int32>  @readTask, System.Byte[]  @localBuffer, System.Memory<System.Byte>  @localDestination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readTask, @localBuffer, @localDestination};
            var ___result = R__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
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
