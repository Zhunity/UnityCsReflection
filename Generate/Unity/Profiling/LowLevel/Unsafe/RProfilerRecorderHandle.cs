using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RUnsafe
{
	/// <summary>
	/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle
	/// </summary>
    public partial class RProfilerRecorderHandle : RMember //
    {

		/// <summary>
		/// System.UInt64 k_InvalidHandle
		/// </summary>
		protected static RField r_k_InvalidHandle;
		public static RField Rk_InvalidHandle
		{
			get
			{
				if(r_k_InvalidHandle == null)
				{
					r_k_InvalidHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "k_InvalidHandle");
					r_k_InvalidHandle.SetBelong(null);
				}
				return r_k_InvalidHandle;
			}
		}

		/// <summary>
		/// System.UInt64 handle
		/// </summary>
		protected RField r_handle;
		public virtual RField Rhandle
		{
			get
			{
				if(r_handle == null)
				{
					r_handle = new(this, "handle");
					r_handle.SetBelong(this.instance);
				}
				return r_handle;
			}
		}

		/// <summary>
		/// Boolean Valid
		/// </summary>
		protected RProperty r_Valid;
		public virtual RProperty RValid
		{
			get
			{
				if(r_Valid == null)
				{
					r_Valid = new(this, "Valid", -1);
					r_Valid.SetBelong(this.instance);
				}
				return r_Valid;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerMarker)
		/// </summary>
		protected static RMethod r_Get_ProfilerMarker;
		public static RMethod RGet_ProfilerMarker
		{
			get
			{
				if(r_Get_ProfilerMarker == null)
				{
					r_Get_ProfilerMarker = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "Get", 0, typeof(Unity.Profiling.ProfilerMarker));
					r_Get_ProfilerMarker.SetBelong(null);
				}
				return r_Get_ProfilerMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerCategory, System.String)
		/// </summary>
		protected static RMethod r_Get_ProfilerCategory_String;
		public static RMethod RGet_ProfilerCategory_String
		{
			get
			{
				if(r_Get_ProfilerCategory_String == null)
				{
					r_Get_ProfilerCategory_String = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "Get", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.String));
					r_Get_ProfilerCategory_String.SetBelong(null);
				}
				return r_Get_ProfilerCategory_String;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)
		/// </summary>
		protected static RMethod r_GetDescription_ProfilerRecorderHandle;
		public static RMethod RGetDescription_ProfilerRecorderHandle
		{
			get
			{
				if(r_GetDescription_ProfilerRecorderHandle == null)
				{
					r_GetDescription_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetDescription", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle));
					r_GetDescription_ProfilerRecorderHandle.SetBelong(null);
				}
				return r_GetDescription_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetAvailable(System.Collections.Generic.List`1[Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle])
		/// </summary>
		protected static RMethod r_GetAvailable_List_d_ProfilerRecorderHandle_p_;
		public static RMethod RGetAvailable_List_d_ProfilerRecorderHandle_p_
		{
			get
			{
				if(r_GetAvailable_List_d_ProfilerRecorderHandle_p_ == null)
				{
					r_GetAvailable_List_d_ProfilerRecorderHandle_p_ = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetAvailable", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)));
					r_GetAvailable_List_d_ProfilerRecorderHandle_p_.SetBelong(null);
				}
				return r_GetAvailable_List_d_ProfilerRecorderHandle_p_;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory, System.String)
		/// </summary>
		protected static RMethod r_GetByName_ProfilerCategory_String;
		public static RMethod RGetByName_ProfilerCategory_String
		{
			get
			{
				if(r_GetByName_ProfilerCategory_String == null)
				{
					r_GetByName_ProfilerCategory_String = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.String));
					r_GetByName_ProfilerCategory_String.SetBelong(null);
				}
				return r_GetByName_ProfilerCategory_String;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory, Byte*, Int32)
		/// </summary>
		protected static RMethod r_GetByName__Unmanaged_ProfilerCategory_BytePointer_Int32;
		public static RMethod RGetByName__Unmanaged_ProfilerCategory_BytePointer_Int32
		{
			get
			{
				if(r_GetByName__Unmanaged_ProfilerCategory_BytePointer_Int32 == null)
				{
					r_GetByName__Unmanaged_ProfilerCategory_BytePointer_Int32 = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName__Unmanaged", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_GetByName__Unmanaged_ProfilerCategory_BytePointer_Int32.SetBelong(null);
				}
				return r_GetByName__Unmanaged_ProfilerCategory_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory, Char*, Int32)
		/// </summary>
		protected static RMethod r_GetByName_ProfilerCategory_CharPointer_Int32;
		public static RMethod RGetByName_ProfilerCategory_CharPointer_Int32
		{
			get
			{
				if(r_GetByName_ProfilerCategory_CharPointer_Int32 == null)
				{
					r_GetByName_ProfilerCategory_CharPointer_Int32 = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_GetByName_ProfilerCategory_CharPointer_Int32.SetBelong(null);
				}
				return r_GetByName_ProfilerCategory_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName_Unsafe(Unity.Profiling.ProfilerCategory, Char*, Int32)
		/// </summary>
		protected static RMethod r_GetByName_Unsafe_ProfilerCategory_CharPointer_Int32;
		public static RMethod RGetByName_Unsafe_ProfilerCategory_CharPointer_Int32
		{
			get
			{
				if(r_GetByName_Unsafe_ProfilerCategory_CharPointer_Int32 == null)
				{
					r_GetByName_Unsafe_ProfilerCategory_CharPointer_Int32 = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName_Unsafe", 0, typeof(Unity.Profiling.ProfilerCategory), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_GetByName_Unsafe_ProfilerCategory_CharPointer_Int32.SetBelong(null);
				}
				return r_GetByName_Unsafe_ProfilerCategory_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)
		/// </summary>
		protected static RMethod r_GetDescriptionInternal_ProfilerRecorderHandle;
		public static RMethod RGetDescriptionInternal_ProfilerRecorderHandle
		{
			get
			{
				if(r_GetDescriptionInternal_ProfilerRecorderHandle == null)
				{
					r_GetDescriptionInternal_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetDescriptionInternal", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle));
					r_GetDescriptionInternal_ProfilerRecorderHandle.SetBelong(null);
				}
				return r_GetDescriptionInternal_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetByName_Injected(Unity.Profiling.ProfilerCategory ByRef, System.String, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef)
		/// </summary>
		protected static RMethod r_GetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle;
		public static RMethod RGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle
		{
			get
			{
				if(r_GetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle == null)
				{
					r_GetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName_Injected", 0, typeof(Unity.Profiling.ProfilerCategory).MakeByRefType(), typeof(System.String), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType());
					r_GetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle.SetBelong(null);
				}
				return r_GetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetByName__Unmanaged_Injected(Unity.Profiling.ProfilerCategory ByRef, Byte*, Int32, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef)
		/// </summary>
		protected static RMethod r_GetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle;
		public static RMethod RGetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle
		{
			get
			{
				if(r_GetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle == null)
				{
					r_GetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName__Unmanaged_Injected", 0, typeof(Unity.Profiling.ProfilerCategory).MakeByRefType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType());
					r_GetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle.SetBelong(null);
				}
				return r_GetByName__Unmanaged_Injected_Ref_ProfilerCategory_BytePointer_Int32_Out_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetByName_Unsafe_Injected(Unity.Profiling.ProfilerCategory ByRef, Char*, Int32, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef)
		/// </summary>
		protected static RMethod r_GetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle;
		public static RMethod RGetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle
		{
			get
			{
				if(r_GetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle == null)
				{
					r_GetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetByName_Unsafe_Injected", 0, typeof(Unity.Profiling.ProfilerCategory).MakeByRefType(), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType());
					r_GetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle.SetBelong(null);
				}
				return r_GetByName_Unsafe_Injected_Ref_ProfilerCategory_CharPointer_Int32_Out_ProfilerRecorderHandle;
			}
		}

		/// <summary>
		/// Void GetDescriptionInternal_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ByRef, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription ByRef)
		/// </summary>
		protected static RMethod r_GetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription;
		public static RMethod RGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription
		{
			get
			{
				if(r_GetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription == null)
				{
					r_GetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription = new(typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), "GetDescriptionInternal_Injected", 0, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle).MakeByRefType(), typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription).MakeByRefType());
					r_GetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription.SetBelong(null);
				}
				return r_GetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription;
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

        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerMarker  @marker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@marker};
            var ___result = RGet_ProfilerMarker.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle Get(Unity.Profiling.ProfilerCategory  @category, System.String  @statName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @statName};
            var ___result = RGet_ProfilerCategory_String.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetDescription_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription)___result;
        }


        public static void GetAvailable(System.Collections.Generic.List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>  @outRecorderHandleList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outRecorderHandleList};
            var ___result = RGetAvailable_List_d_ProfilerRecorderHandle_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory  @category, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @name};
            var ___result = RGetByName_ProfilerCategory_String.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___result;
        }





        public static Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetDescriptionInternal_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);

            return (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription)___result;
        }


        public static void GetByName_Injected(ref Unity.Profiling.ProfilerCategory  @category, System.String  @name, out Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category, @name, @ret};
            var ___result = RGetByName_Injected_Ref_ProfilerCategory_String_Out_ProfilerRecorderHandle.Invoke(___genericsType, ___parameters);
			@category = (Unity.Profiling.ProfilerCategory)___parameters[0];
			@ret = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[2];

            
        }




        public static void GetDescriptionInternal_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle  @handle, out Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @ret};
            var ___result = RGetDescriptionInternal_Injected_Ref_ProfilerRecorderHandle_Out_ProfilerRecorderDescription.Invoke(___genericsType, ___parameters);
			@handle = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)___parameters[0];
			@ret = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription)___parameters[1];

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
