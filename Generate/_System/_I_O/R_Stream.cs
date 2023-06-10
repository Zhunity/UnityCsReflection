
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.Stream
	/// </summary>
    public partial class RStream : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.IO.Stream);
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


		/// <summary>
		/// System.IO.Stream Null
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RStream r_FNull;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RStream RFNull
		{
			get
			{
				if(r_FNull == null)
				{
					r_FNull = new(typeof(System.IO.Stream), "Null");
				}
				return r_FNull;
			}
		}

		/// <summary>
		/// System.Int32 DefaultCopyBufferSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDefaultCopyBufferSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDefaultCopyBufferSize
		{
			get
			{
				if(r_FDefaultCopyBufferSize == null)
				{
					r_FDefaultCopyBufferSize = new(typeof(System.IO.Stream), "DefaultCopyBufferSize");
				}
				return r_FDefaultCopyBufferSize;
			}
		}

		/// <summary>
		/// System.IO.Stream+ReadWriteTask _activeReadWriteTask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIO.RStream.RReadWriteTask r_F_activeReadWriteTask;
		public virtual Hvak.Editor.Refleaction.RSystem.RIO.RStream.RReadWriteTask RF_activeReadWriteTask
		{
			get
			{
				if(r_F_activeReadWriteTask == null)
				{
					r_F_activeReadWriteTask = new(this, "_activeReadWriteTask");
				}
				return r_F_activeReadWriteTask;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim _asyncActiveSemaphore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim r_F_asyncActiveSemaphore;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RSemaphoreSlim RF_asyncActiveSemaphore
		{
			get
			{
				if(r_F_asyncActiveSemaphore == null)
				{
					r_F_asyncActiveSemaphore = new(this, "_asyncActiveSemaphore");
				}
				return r_F_asyncActiveSemaphore;
			}
		}

		/// <summary>
		/// Boolean CanRead
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCanRead;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCanRead
		{
			get
			{
				if(r_PCanRead == null)
				{
					r_PCanRead = new(this, "CanRead", -1);
				}
				return r_PCanRead;
			}
		}

		/// <summary>
		/// Boolean CanSeek
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCanSeek;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCanSeek
		{
			get
			{
				if(r_PCanSeek == null)
				{
					r_PCanSeek = new(this, "CanSeek", -1);
				}
				return r_PCanSeek;
			}
		}

		/// <summary>
		/// Boolean CanTimeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCanTimeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCanTimeout
		{
			get
			{
				if(r_PCanTimeout == null)
				{
					r_PCanTimeout = new(this, "CanTimeout", -1);
				}
				return r_PCanTimeout;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCanWrite;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCanWrite
		{
			get
			{
				if(r_PCanWrite == null)
				{
					r_PCanWrite = new(this, "CanWrite", -1);
				}
				return r_PCanWrite;
			}
		}

		/// <summary>
		/// Int64 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPLength
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
		/// Int64 Position
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPPosition
		{
			get
			{
				if(r_PPosition == null)
				{
					r_PPosition = new(this, "Position", -1);
				}
				return r_PPosition;
			}
		}

		/// <summary>
		/// Int32 ReadTimeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PReadTimeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPReadTimeout
		{
			get
			{
				if(r_PReadTimeout == null)
				{
					r_PReadTimeout = new(this, "ReadTimeout", -1);
				}
				return r_PReadTimeout;
			}
		}

		/// <summary>
		/// Int32 WriteTimeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PWriteTimeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPWriteTimeout
		{
			get
			{
				if(r_PWriteTimeout == null)
				{
					r_PWriteTimeout = new(this, "WriteTimeout", -1);
				}
				return r_PWriteTimeout;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity r_PObjectIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RServerIdentity RPObjectIdentity
		{
			get
			{
				if(r_PObjectIdentity == null)
				{
					r_PObjectIdentity = new(this, "ObjectIdentity", -1);
				}
				return r_PObjectIdentity;
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
				}
				return r_MCopyToAsync_Stream_Int32_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task CopyToAsyncInternal(System.IO.Stream, Int32, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_MCopyToAsyncInternal_Stream_Int32_CancellationToken;
		public virtual RMethod RMCopyToAsyncInternal_Stream_Int32_CancellationToken
		{
			get
			{
				if(r_MCopyToAsyncInternal_Stream_Int32_CancellationToken == null)
				{
					r_MCopyToAsyncInternal_Stream_Int32_CancellationToken = new(this, "CopyToAsyncInternal", 0, typeof(System.IO.Stream), typeof(System.Int32), typeof(System.Threading.CancellationToken));
				}
				return r_MCopyToAsyncInternal_Stream_Int32_CancellationToken;
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
				}
				return r_MCopyTo_Stream_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCopyBufferSize()
		/// </summary>
		protected RMethod r_MGetCopyBufferSize;
		public virtual RMethod RMGetCopyBufferSize
		{
			get
			{
				if(r_MGetCopyBufferSize == null)
				{
					r_MGetCopyBufferSize = new(this, "GetCopyBufferSize", 0);
				}
				return r_MGetCopyBufferSize;
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
				}
				return r_MDispose;
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
				}
				return r_MDispose_Boolean;
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
				}
				return r_MFlush;
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
				}
				return r_MFlushAsync;
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
				}
				return r_MFlushAsync_CancellationToken;
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
				}
				return r_MCreateWaitHandle;
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
				}
				return r_MBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
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
				}
				return r_MBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
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
				}
				return r_MEndRead_IAsyncResult;
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
				}
				return r_MReadAsync_ByteArray_Int32_Int32;
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
				}
				return r_MReadAsync_ByteArray_Int32_Int32_CancellationToken;
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
				}
				return r_MReadAsync_Memory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] BeginEndReadAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MBeginEndReadAsync_ByteArray_Int32_Int32;
		public virtual RMethod RMBeginEndReadAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MBeginEndReadAsync_ByteArray_Int32_Int32 == null)
				{
					r_MBeginEndReadAsync_ByteArray_Int32_Int32 = new(this, "BeginEndReadAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBeginEndReadAsync_ByteArray_Int32_Int32;
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
				}
				return r_MBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
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
				}
				return r_MBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void RunReadWriteTaskWhenReady(System.Threading.Tasks.Task, ReadWriteTask)
		/// </summary>
		protected RMethod r_MRunReadWriteTaskWhenReady_Task_ReadWriteTask;
		public virtual RMethod RMRunReadWriteTaskWhenReady_Task_ReadWriteTask
		{
			get
			{
				if(r_MRunReadWriteTaskWhenReady_Task_ReadWriteTask == null)
				{
					r_MRunReadWriteTaskWhenReady_Task_ReadWriteTask = new(this, "RunReadWriteTaskWhenReady", 0, typeof(System.Threading.Tasks.Task),  ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"));
				}
				return r_MRunReadWriteTaskWhenReady_Task_ReadWriteTask;
			}
		}

		/// <summary>
		/// Void RunReadWriteTask(ReadWriteTask)
		/// </summary>
		protected RMethod r_MRunReadWriteTask_ReadWriteTask;
		public virtual RMethod RMRunReadWriteTask_ReadWriteTask
		{
			get
			{
				if(r_MRunReadWriteTask_ReadWriteTask == null)
				{
					r_MRunReadWriteTask_ReadWriteTask = new(this, "RunReadWriteTask", 0,  ReflectionUtils.GetType("System.IO.Stream+ReadWriteTask"));
				}
				return r_MRunReadWriteTask_ReadWriteTask;
			}
		}

		/// <summary>
		/// Void FinishTrackingAsyncOperation()
		/// </summary>
		protected RMethod r_MFinishTrackingAsyncOperation;
		public virtual RMethod RMFinishTrackingAsyncOperation
		{
			get
			{
				if(r_MFinishTrackingAsyncOperation == null)
				{
					r_MFinishTrackingAsyncOperation = new(this, "FinishTrackingAsyncOperation", 0);
				}
				return r_MFinishTrackingAsyncOperation;
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
				}
				return r_MEndWrite_IAsyncResult;
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
				}
				return r_MWriteAsync_ByteArray_Int32_Int32;
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
				}
				return r_MWriteAsync_ByteArray_Int32_Int32_CancellationToken;
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
				}
				return r_MWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishWriteAsync(System.Threading.Tasks.Task, Byte[])
		/// </summary>
		protected RMethod r_MFinishWriteAsync_Task_ByteArray;
		public virtual RMethod RMFinishWriteAsync_Task_ByteArray
		{
			get
			{
				if(r_MFinishWriteAsync_Task_ByteArray == null)
				{
					r_MFinishWriteAsync_Task_ByteArray = new(this, "FinishWriteAsync", 0, typeof(System.Threading.Tasks.Task), typeof(System.Byte).MakeArrayType());
				}
				return r_MFinishWriteAsync_Task_ByteArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task BeginEndWriteAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_MBeginEndWriteAsync_ByteArray_Int32_Int32;
		public virtual RMethod RMBeginEndWriteAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_MBeginEndWriteAsync_ByteArray_Int32_Int32 == null)
				{
					r_MBeginEndWriteAsync_ByteArray_Int32_Int32 = new(this, "BeginEndWriteAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MBeginEndWriteAsync_ByteArray_Int32_Int32;
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
				}
				return r_MSetLength_Int64;
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
				}
				return r_MRead_ByteArray_Int32_Int32;
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
				}
				return r_MRead_Span_d_Byte_p_;
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
				}
				return r_MReadByte;
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
				}
				return r_MWrite_ByteArray_Int32_Int32;
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
				}
				return r_MWrite_ReadOnlySpan_d_Byte_p_;
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
				}
				return r_MWriteByte_Byte;
			}
		}

		/// <summary>
		/// System.IO.Stream Synchronized(System.IO.Stream)
		/// </summary>
		protected static RMethod r_MSynchronized_Stream;
		public static RMethod RMSynchronized_Stream
		{
			get
			{
				if(r_MSynchronized_Stream == null)
				{
					r_MSynchronized_Stream = new(typeof(System.IO.Stream), "Synchronized", 0, typeof(System.IO.Stream));
				}
				return r_MSynchronized_Stream;
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
				}
				return r_MBlockingBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 BlockingEndRead(System.IAsyncResult)
		/// </summary>
		protected static RMethod r_MBlockingEndRead_IAsyncResult;
		public static RMethod RMBlockingEndRead_IAsyncResult
		{
			get
			{
				if(r_MBlockingEndRead_IAsyncResult == null)
				{
					r_MBlockingEndRead_IAsyncResult = new(typeof(System.IO.Stream), "BlockingEndRead", 0, typeof(System.IAsyncResult));
				}
				return r_MBlockingEndRead_IAsyncResult;
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
				}
				return r_MBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void BlockingEndWrite(System.IAsyncResult)
		/// </summary>
		protected static RMethod r_MBlockingEndWrite_IAsyncResult;
		public static RMethod RMBlockingEndWrite_IAsyncResult
		{
			get
			{
				if(r_MBlockingEndWrite_IAsyncResult == null)
				{
					r_MBlockingEndWrite_IAsyncResult = new(typeof(System.IO.Stream), "BlockingEndWrite", 0, typeof(System.IAsyncResult));
				}
				return r_MBlockingEndWrite_IAsyncResult;
			}
		}

		/// <summary>
		/// Boolean HasOverriddenBeginEndRead()
		/// </summary>
		protected RMethod r_MHasOverriddenBeginEndRead;
		public virtual RMethod RMHasOverriddenBeginEndRead
		{
			get
			{
				if(r_MHasOverriddenBeginEndRead == null)
				{
					r_MHasOverriddenBeginEndRead = new(this, "HasOverriddenBeginEndRead", 0);
				}
				return r_MHasOverriddenBeginEndRead;
			}
		}

		/// <summary>
		/// Boolean HasOverriddenBeginEndWrite()
		/// </summary>
		protected RMethod r_MHasOverriddenBeginEndWrite;
		public virtual RMethod RMHasOverriddenBeginEndWrite
		{
			get
			{
				if(r_MHasOverriddenBeginEndWrite == null)
				{
					r_MHasOverriddenBeginEndWrite = new(this, "HasOverriddenBeginEndWrite", 0);
				}
				return r_MHasOverriddenBeginEndWrite;
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
				}
				return r_MDisposeAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] <ReadAsync>g__FinishReadAsync|44_0(System.Threading.Tasks.Task`1[System.Int32], Byte[], System.Memory`1[System.Byte])
		/// </summary>
		protected static RMethod r_M__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_;
		public static RMethod RM__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_
		{
			get
			{
				if(r_M__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_ == null)
				{
					r_M__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_ = new(typeof(System.IO.Stream), "<ReadAsync>g__FinishReadAsync|44_0", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Int32)), typeof(System.Byte).MakeArrayType(), typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)));
				}
				return r_M__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_;
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


        public virtual System.Threading.Tasks.Task CopyToAsyncInternal(System.IO.Stream @destination, System.Int32 @bufferSize, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @bufferSize, @cancellationToken};
            var ___result = RMCopyToAsyncInternal_Stream_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

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


        public virtual System.Int32 GetCopyBufferSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCopyBufferSize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cancellationToken};
            var ___result = RMFlushAsync_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.WaitHandle CreateWaitHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateWaitHandle.Invoke(___genericsType, ___parameters);

            return (System.Threading.WaitHandle)___result;
        }


        public virtual System.IAsyncResult BeginRead(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RMBeginRead_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginReadInternal(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state, System.Boolean @serializeAsynchronously, System.Boolean @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RMBeginReadInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndRead(System.IAsyncResult @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RMEndRead_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMReadAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RMReadAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> @buffer, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RMReadAsync_Memory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> BeginEndReadAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMBeginEndReadAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.IAsyncResult BeginWrite(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RMBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginWriteInternal(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state, System.Boolean @serializeAsynchronously, System.Boolean @apm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state, @serializeAsynchronously, @apm};
            var ___result = RMBeginWriteInternal_ByteArray_Int32_Int32_AsyncCallback_Object_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void RunReadWriteTaskWhenReady(System.Threading.Tasks.Task @asyncWaiter, Hvak.Editor.Refleaction.RSystem.RIO.RStream.RReadWriteTask @readWriteTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncWaiter, @readWriteTask.Value};
            var ___result = RMRunReadWriteTaskWhenReady_Task_ReadWriteTask.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RunReadWriteTask(Hvak.Editor.Refleaction.RSystem.RIO.RStream.RReadWriteTask @readWriteTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readWriteTask.Value};
            var ___result = RMRunReadWriteTask_ReadWriteTask.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishTrackingAsyncOperation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinishTrackingAsyncOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWrite(System.IAsyncResult @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RMEndWrite_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMWriteAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @cancellationToken};
            var ___result = RMWriteAsync_ByteArray_Int32_Int32_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> @buffer, System.Threading.CancellationToken @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RMWriteAsync_ReadOnlyMemory_d_Byte_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Threading.Tasks.Task FinishWriteAsync(System.Threading.Tasks.Task @writeTask, System.Byte[] @localBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writeTask, @localBuffer};
            var ___result = RMFinishWriteAsync_Task_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task BeginEndWriteAsync(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMBeginEndWriteAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
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


        public virtual System.Int32 Read(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMRead_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Read(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer.Value};
            var ___result = RMRead_Span_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadByte()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadByte.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Write(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RMWrite_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RByte> @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer.Value};
            var ___result = RMWrite_ReadOnlySpan_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteByte(System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMWriteByte_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IO.Stream Synchronized(System.IO.Stream @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RMSynchronized_Stream.Invoke(___genericsType, ___parameters);

            return (System.IO.Stream)___result;
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


        public static System.Int32 BlockingEndRead(System.IAsyncResult @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RMBlockingEndRead_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IAsyncResult BlockingBeginWrite(System.Byte[] @buffer, System.Int32 @offset, System.Int32 @count, System.AsyncCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count, @callback, @state};
            var ___result = RMBlockingBeginWrite_ByteArray_Int32_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public static void BlockingEndWrite(System.IAsyncResult @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = RMBlockingEndWrite_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasOverriddenBeginEndRead()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasOverriddenBeginEndRead.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasOverriddenBeginEndWrite()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasOverriddenBeginEndWrite.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public static System.Threading.Tasks.ValueTask<System.Int32> __0__ReadAsync__1__g__FinishReadAsync__5__44_0(System.Threading.Tasks.Task<System.Int32> @readTask, System.Byte[] @localBuffer, System.Memory<System.Byte> @localDestination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readTask, @localBuffer, @localDestination};
            var ___result = RM__0__ReadAsync__1__g__FinishReadAsync__5__44_0_Task_d_Int32_p__ByteArray_Memory_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity GetObjectIdentity(System.MarshalByRefObject @obj, out System.Boolean @IsClient)
        {
			@IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RMGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			@IsClient = (System.Boolean)___parameters[1];

            return new Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RIdentity(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
