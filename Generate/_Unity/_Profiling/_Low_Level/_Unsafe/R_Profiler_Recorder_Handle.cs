
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RUnsafe
{
	/// <summary>
	/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle
	/// </summary>
    public partial class RProfilerRecorderHandle : RMember //
    {

		/// <summary>
		/// System.UInt64 k_InvalidHandle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fk_InvalidHandle;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFk_InvalidHandle
		{
			get
			{
				if(r_Fk_InvalidHandle == null)
				{
					r_Fk_InvalidHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "k_InvalidHandle");
				}
				return r_Fk_InvalidHandle;
			}
		}

		/// <summary>
		/// System.UInt64 handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// Boolean Valid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPValid
		{
			get
			{
				if(r_PValid == null)
				{
					r_PValid = new(this, "Valid", -1);
				}
				return r_PValid;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerMarker)
		/// </summary>
		protected static RMethod r_MGet_ProfilerMarker;
		public static RMethod RMGet_ProfilerMarker
		{
			get
			{
				if(r_MGet_ProfilerMarker == null)
				{
					r_MGet_ProfilerMarker = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "Get", 0, typeof(Unity.Profiling.ProfilerMarker));
				}
				return r_MGet_ProfilerMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerCategory, System.String)
		/// </summary>
		protected static RMethod r_MGet_ProfilerCategory_String;
		public static RMethod RMGet_ProfilerCategory_String
		{
			get
			{
				if(r_MGet_ProfilerCategory_String == null)
				{
					r_MGet_ProfilerCategory_String = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "Get", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.String));
				}
				return r_MGet_ProfilerCategory_String;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)
		/// </summary>
		protected static RMethod r_MGetDescription_ProfilerRecorderHandle;
		public static RMethod RMGetDescription_ProfilerRecorderHandle
		{
			get
			{
				if(r_MGetDescription_ProfilerRecorderHandle == null)
				{
					r_MGetDescription_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetDescription", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle));
				}
				return r_MGetDescription_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetAvailable(System.Collections.Generic.List`1[Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle])
		/// </summary>
		protected static RMethod r_MGetAvailable_List_d_ProfilerRecorderHandle_p_;
		public static RMethod RMGetAvailable_List_d_ProfilerRecorderHandle_p_
		{
			get
			{
				if(r_MGetAvailable_List_d_ProfilerRecorderHandle_p_ == null)
				{
					r_MGetAvailable_List_d_ProfilerRecorderHandle_p_ = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetAvailable", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)));
				}
				return r_MGetAvailable_List_d_ProfilerRecorderHandle_p_;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory, System.String)
		/// </summary>
		protected static RMethod r_MGetByName_ProfilerCategory_String;
		public static RMethod RMGetByName_ProfilerCategory_String
		{
			get
			{
				if(r_MGetByName_ProfilerCategory_String == null)
				{
					r_MGetByName_ProfilerCategory_String = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.String));
				}
				return r_MGetByName_ProfilerCategory_String;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory, Byte*, Int32)
		/// </summary>
		protected static RMethod r_MGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32;
		public static RMethod RMGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32
		{
			get
			{
				if(r_MGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32 == null)
				{
					r_MGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32 = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName__Unmanaged", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
				}
				return r_MGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory, Char*, Int32)
		/// </summary>
		protected static RMethod r_MGetByName_ProfilerCategory_CharPointer_Int32;
		public static RMethod RMGetByName_ProfilerCategory_CharPointer_Int32
		{
			get
			{
				if(r_MGetByName_ProfilerCategory_CharPointer_Int32 == null)
				{
					r_MGetByName_ProfilerCategory_CharPointer_Int32 = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.Char).MakePointerType(), typeof(System.Int32));
				}
				return r_MGetByName_ProfilerCategory_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName_Unsafe(Unity.Profiling.ProfilerCategory, Char*, Int32)
		/// </summary>
		protected static RMethod r_MGetByName_Unsafe_ProfilerCategory_CharPointer_Int32;
		public static RMethod RMGetByName_Unsafe_ProfilerCategory_CharPointer_Int32
		{
			get
			{
				if(r_MGetByName_Unsafe_ProfilerCategory_CharPointer_Int32 == null)
				{
					r_MGetByName_Unsafe_ProfilerCategory_CharPointer_Int32 = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName_Unsafe", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.Char).MakePointerType(), typeof(System.Int32));
				}
				return r_MGetByName_Unsafe_ProfilerCategory_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)
		/// </summary>
		protected static RMethod r_MGetDescriptionInternal_ProfilerRecorderHandle;
		public static RMethod RMGetDescriptionInternal_ProfilerRecorderHandle
		{
			get
			{
				if(r_MGetDescriptionInternal_ProfilerRecorderHandle == null)
				{
					r_MGetDescriptionInternal_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetDescriptionInternal", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle));
				}
				return r_MGetDescriptionInternal_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetByName_Injected(Unity.Profiling.ProfilerCategory ByRef, System.String, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle;
		public static RMethod RMGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle
		{
			get
			{
				if(r_MGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle == null)
				{
					r_MGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName_Injected", 0, typeof(Unity.Profiling.ProfilerCategory).MakeByRefType(), typeof(System.String), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType());
				}
				return r_MGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetByName__Unmanaged_Injected(Unity.Profiling.ProfilerCategory ByRef, Byte*, Int32, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle;
		public static RMethod RMGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle
		{
			get
			{
				if(r_MGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle == null)
				{
					r_MGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName__Unmanaged_Injected", 0, typeof(Unity.Profiling.ProfilerCategory).MakeByRefType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType());
				}
				return r_MGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetByName_Unsafe_Injected(Unity.Profiling.ProfilerCategory ByRef, Char*, Int32, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle;
		public static RMethod RMGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle
		{
			get
			{
				if(r_MGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle == null)
				{
					r_MGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName_Unsafe_Injected", 0, typeof(Unity.Profiling.ProfilerCategory).MakeByRefType(), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType());
				}
				return r_MGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetDescriptionInternal_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription ByRef)
		/// </summary>
		protected static RMethod r_MGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription;
		public static RMethod RMGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription
		{
			get
			{
				if(r_MGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription == null)
				{
					r_MGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetDescriptionInternal_Injected", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType(), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription).MakeByRefType());
				}
				return r_MGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription;
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


        public RProfilerRecorderHandle() : base("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle")
        {
        }

        public RProfilerRecorderHandle(System.Object instance) : base("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle")
		{
            SetInstance(instance);
		}

        public RProfilerRecorderHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerRecorderHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerMarker @marker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker};
            var ___result = RMGet_ProfilerMarker.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerCategory @category, System.String @statName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @statName};
            var ___result = RMGet_ProfilerCategory_String.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetDescription_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription)___result;
        }


        public static void GetAvailable(System.Collections.Generic.List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle> @outRecorderHandleList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outRecorderHandleList};
            var ___result = RMGetAvailable_List_d_ProfilerRecorderHandle_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory @category, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @name};
            var ___result = RMGetByName_ProfilerCategory_String.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public unsafe static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory @category, System.Byte* @name, System.Int32 @nameLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, Pointer.Box(@name, typeof(System.Byte)), @nameLen};
            var ___result = RMGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public unsafe static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory @category, System.Char* @name, System.Int32 @nameLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, Pointer.Box(@name, typeof(System.Char)), @nameLen};
            var ___result = RMGetByName_ProfilerCategory_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public unsafe static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName_Unsafe(Unity.Profiling.ProfilerCategory @category, System.Char* @name, System.Int32 @nameLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, Pointer.Box(@name, typeof(System.Char)), @nameLen};
            var ___result = RMGetByName_Unsafe_ProfilerCategory_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetDescriptionInternal_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription)___result;
        }


        public static void GetByName_Injected(ref Unity.Profiling.ProfilerCategory @category, System.String @name, out Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @name, @ret};
            var ___result = RMGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);
			@category = (Unity.Profiling.ProfilerCategory)___parameters[0];
			@ret = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[2];

            
        }


        public unsafe static void GetByName__Unmanaged_Injected(ref Unity.Profiling.ProfilerCategory @category, System.Byte* @name, System.Int32 @nameLen, out Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, Pointer.Box(@name, typeof(System.Byte)), @nameLen, @ret};
            var ___result = RMGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);
			@category = (Unity.Profiling.ProfilerCategory)___parameters[0];
			@ret = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[3];

            
        }


        public unsafe static void GetByName_Unsafe_Injected(ref Unity.Profiling.ProfilerCategory @category, System.Char* @name, System.Int32 @nameLen, out Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, Pointer.Box(@name, typeof(System.Char)), @nameLen, @ret};
            var ___result = RMGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);
			@category = (Unity.Profiling.ProfilerCategory)___parameters[0];
			@ret = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[3];

            
        }


        public static void GetDescriptionInternal_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle @handle, out Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @ret};
            var ___result = RMGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[0];
			@ret = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription)___parameters[1];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
