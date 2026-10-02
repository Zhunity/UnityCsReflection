
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// Unity.Collections.LowLevel.Unsafe.DisposeSentinel
	/// </summary>
    public partial class RDisposeSentinel : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(Unity.Collections.LowLevel.Unsafe.DisposeSentinel);
            }
        }

        public RDisposeSentinel() : base("Unity.Collections.LowLevel.Unsafe.DisposeSentinel")
        {
        }

        public RDisposeSentinel(System.Object instance) : base("Unity.Collections.LowLevel.Unsafe.DisposeSentinel")
		{
            SetInstance(instance);
		}

        public RDisposeSentinel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDisposeSentinel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.IntPtr s_CreateProfilerMarkerPtr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fs_CreateProfilerMarkerPtr;
		public static Hvak.Editor.Refleaction.RSystem.RIntPtr RFs_CreateProfilerMarkerPtr
		{
			get
			{
				if(r_Fs_CreateProfilerMarkerPtr == null)
				{
					r_Fs_CreateProfilerMarkerPtr = new(Type, "s_CreateProfilerMarkerPtr");
				}
				return r_Fs_CreateProfilerMarkerPtr;
			}
		}

		/// <summary>
		/// System.IntPtr s_LogErrorProfilerMarkerPtr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fs_LogErrorProfilerMarkerPtr;
		public static Hvak.Editor.Refleaction.RSystem.RIntPtr RFs_LogErrorProfilerMarkerPtr
		{
			get
			{
				if(r_Fs_LogErrorProfilerMarkerPtr == null)
				{
					r_Fs_LogErrorProfilerMarkerPtr = new(Type, "s_LogErrorProfilerMarkerPtr");
				}
				return r_Fs_LogErrorProfilerMarkerPtr;
			}
		}

		/// <summary>
		/// System.Int32 m_IsCreated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_IsCreated;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_IsCreated
		{
			get
			{
				if(r_Fm_IsCreated == null)
				{
					r_Fm_IsCreated = new(this, "m_IsCreated");
				}
				return r_Fm_IsCreated;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackTrace m_StackTrace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace r_Fm_StackTrace;
		public virtual Hvak.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace RFm_StackTrace
		{
			get
			{
				if(r_Fm_StackTrace == null)
				{
					r_Fm_StackTrace = new(this, "m_StackTrace");
				}
				return r_Fm_StackTrace;
			}
		}

		/// <summary>
		/// Void Dispose(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Unity.Collections.LowLevel.Unsafe.DisposeSentinel ByRef)
		/// </summary>
		protected static RMethod r_MDispose_Ref_AtomicSafetyHandle_Ref_DisposeSentinel;
		public static RMethod RMDispose_Ref_AtomicSafetyHandle_Ref_DisposeSentinel
		{
			get
			{
				if(r_MDispose_Ref_AtomicSafetyHandle_Ref_DisposeSentinel == null)
				{
					r_MDispose_Ref_AtomicSafetyHandle_Ref_DisposeSentinel = new(Type, "Dispose", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(Unity.Collections.LowLevel.Unsafe.DisposeSentinel).MakeByRefType());
				}
				return r_MDispose_Ref_AtomicSafetyHandle_Ref_DisposeSentinel;
			}
		}

		/// <summary>
		/// Void Create(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef, Unity.Collections.LowLevel.Unsafe.DisposeSentinel ByRef, Int32, Unity.Collections.Allocator)
		/// </summary>
		protected static RMethod r_MCreate_Out_AtomicSafetyHandle_Out_DisposeSentinel_Int32_Allocator;
		public static RMethod RMCreate_Out_AtomicSafetyHandle_Out_DisposeSentinel_Int32_Allocator
		{
			get
			{
				if(r_MCreate_Out_AtomicSafetyHandle_Out_DisposeSentinel_Int32_Allocator == null)
				{
					r_MCreate_Out_AtomicSafetyHandle_Out_DisposeSentinel_Int32_Allocator = new(Type, "Create", 0, typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType(), typeof(Unity.Collections.LowLevel.Unsafe.DisposeSentinel).MakeByRefType(), typeof(System.Int32), typeof(Unity.Collections.Allocator));
				}
				return r_MCreate_Out_AtomicSafetyHandle_Out_DisposeSentinel_Int32_Allocator;
			}
		}

		/// <summary>
		/// Void CreateInternal(Unity.Collections.LowLevel.Unsafe.DisposeSentinel ByRef, Int32)
		/// </summary>
		protected static RMethod r_MCreateInternal_Ref_DisposeSentinel_Int32;
		public static RMethod RMCreateInternal_Ref_DisposeSentinel_Int32
		{
			get
			{
				if(r_MCreateInternal_Ref_DisposeSentinel_Int32 == null)
				{
					r_MCreateInternal_Ref_DisposeSentinel_Int32 = new(Type, "CreateInternal", 0, typeof(Unity.Collections.LowLevel.Unsafe.DisposeSentinel).MakeByRefType(), typeof(System.Int32));
				}
				return r_MCreateInternal_Ref_DisposeSentinel_Int32;
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
		/// Void Clear(Unity.Collections.LowLevel.Unsafe.DisposeSentinel ByRef)
		/// </summary>
		protected static RMethod r_MClear_Ref_DisposeSentinel;
		public static RMethod RMClear_Ref_DisposeSentinel
		{
			get
			{
				if(r_MClear_Ref_DisposeSentinel == null)
				{
					r_MClear_Ref_DisposeSentinel = new(Type, "Clear", 0, typeof(Unity.Collections.LowLevel.Unsafe.DisposeSentinel).MakeByRefType());
				}
				return r_MClear_Ref_DisposeSentinel;
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


		public static void Dispose(ref Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @safety, ref Unity.Collections.LowLevel.Unsafe.DisposeSentinel @sentinel)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@safety, @sentinel};
			var ___result = RMDispose_Ref_AtomicSafetyHandle_Ref_DisposeSentinel.Invoke(___genericsType, ___parameters);
			@safety = ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle>(___parameters[0]);
			@sentinel = ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.DisposeSentinel>(___parameters[1]);
		}


		public static void Create(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @safety, out Unity.Collections.LowLevel.Unsafe.DisposeSentinel @sentinel, System.Int32 @callSiteStackDepth, Unity.Collections.Allocator @allocator)
		{
			@safety = default;
			@sentinel = default;
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@safety, @sentinel, @callSiteStackDepth, @allocator};
			var ___result = RMCreate_Out_AtomicSafetyHandle_Out_DisposeSentinel_Int32_Allocator.Invoke(___genericsType, ___parameters);
			@safety = ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle>(___parameters[0]);
			@sentinel = ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.DisposeSentinel>(___parameters[1]);
		}


		public static void CreateInternal(ref Unity.Collections.LowLevel.Unsafe.DisposeSentinel @sentinel, System.Int32 @callSiteStackDepth)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@sentinel, @callSiteStackDepth};
			var ___result = RMCreateInternal_Ref_DisposeSentinel_Int32.Invoke(___genericsType, ___parameters);
			@sentinel = ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.DisposeSentinel>(___parameters[0]);
		}


		public virtual void Finalize()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMFinalize.Invoke(___genericsType, ___parameters);
		}


		public static void Clear(ref Unity.Collections.LowLevel.Unsafe.DisposeSentinel @sentinel)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@sentinel};
			var ___result = RMClear_Ref_DisposeSentinel.Invoke(___genericsType, ___parameters);
			@sentinel = ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.DisposeSentinel>(___parameters[0]);
		}


		public virtual System.Boolean Equals(System.Object @obj)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@obj};
			var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
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
