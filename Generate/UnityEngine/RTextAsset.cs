using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextAsset
	/// </summary>
    public partial class RTextAsset : RMember //
    {

		/// <summary>
		/// Byte[] bytes
		/// </summary>
		protected RPropertyArray<RProperty> r_bytes;
		public virtual RPropertyArray<RProperty> Rbytes
		{
			get
			{
				if(r_bytes == null)
				{
					r_bytes = new(this, "bytes", -1);
					r_bytes.SetBelong(this.instance);
				}
				return r_bytes;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RProperty r_text;
		public virtual RProperty Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text", -1);
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// Int64 dataSize
		/// </summary>
		protected RProperty r_dataSize;
		public virtual RProperty RdataSize
		{
			get
			{
				if(r_dataSize == null)
				{
					r_dataSize = new(this, "dataSize", -1);
					r_dataSize.SetBelong(this.instance);
				}
				return r_dataSize;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Byte[] GetPreviewBytes(Int32)
		/// </summary>
		protected RMethod r_GetPreviewBytes_Int32;
		public virtual RMethod RGetPreviewBytes_Int32
		{
			get
			{
				if(r_GetPreviewBytes_Int32 == null)
				{
					r_GetPreviewBytes_Int32 = new(this, "GetPreviewBytes", 0, typeof(System.Int32));
					r_GetPreviewBytes_Int32.SetBelong(this.instance);
				}
				return r_GetPreviewBytes_Int32;
			}
		}

		/// <summary>
		/// Void Internal_CreateInstance(UnityEngine.TextAsset, System.String)
		/// </summary>
		protected static RMethod r_Internal_CreateInstance_TextAsset_String;
		public static RMethod RInternal_CreateInstance_TextAsset_String
		{
			get
			{
				if(r_Internal_CreateInstance_TextAsset_String == null)
				{
					r_Internal_CreateInstance_TextAsset_String = new(typeof(UnityEngine.TextAsset), "Internal_CreateInstance", 0, typeof(UnityEngine.TextAsset), typeof(System.String));
					r_Internal_CreateInstance_TextAsset_String.SetBelong(null);
				}
				return r_Internal_CreateInstance_TextAsset_String;
			}
		}

		/// <summary>
		/// IntPtr GetDataPtr()
		/// </summary>
		protected RMethod r_GetDataPtr;
		public virtual RMethod RGetDataPtr
		{
			get
			{
				if(r_GetDataPtr == null)
				{
					r_GetDataPtr = new(this, "GetDataPtr", 0);
					r_GetDataPtr.SetBelong(this.instance);
				}
				return r_GetDataPtr;
			}
		}

		/// <summary>
		/// Int64 GetDataSize()
		/// </summary>
		protected RMethod r_GetDataSize;
		public virtual RMethod RGetDataSize
		{
			get
			{
				if(r_GetDataSize == null)
				{
					r_GetDataSize = new(this, "GetDataSize", 0);
					r_GetDataSize.SetBelong(this.instance);
				}
				return r_GetDataSize;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.TextAsset)
		/// </summary>
		protected static RMethod r_GetSafetyHandle_TextAsset;
		public static RMethod RGetSafetyHandle_TextAsset
		{
			get
			{
				if(r_GetSafetyHandle_TextAsset == null)
				{
					r_GetSafetyHandle_TextAsset = new(typeof(UnityEngine.TextAsset), "GetSafetyHandle", 0, typeof(UnityEngine.TextAsset));
					r_GetSafetyHandle_TextAsset.SetBelong(null);
				}
				return r_GetSafetyHandle_TextAsset;
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
		/// Unity.Collections.NativeArray`1[T] GetData[T]()
		/// </summary>
		protected RMethod r_GetData_GT;
		public virtual RMethod RGetData_GT
		{
			get
			{
				if(r_GetData_GT == null)
				{
					r_GetData_GT = new(this, "GetData", 1);
					r_GetData_GT.SetBelong(this.instance);
				}
				return r_GetData_GT;
			}
		}

		/// <summary>
		/// System.String GetPreview(Int32)
		/// </summary>
		protected RMethod r_GetPreview_Int32;
		public virtual RMethod RGetPreview_Int32
		{
			get
			{
				if(r_GetPreview_Int32 == null)
				{
					r_GetPreview_Int32 = new(this, "GetPreview", 0, typeof(System.Int32));
					r_GetPreview_Int32.SetBelong(this.instance);
				}
				return r_GetPreview_Int32;
			}
		}

		/// <summary>
		/// System.String DecodeString(Byte[])
		/// </summary>
		protected static RMethod r_DecodeString_ByteArray;
		public static RMethod RDecodeString_ByteArray
		{
			get
			{
				if(r_DecodeString_ByteArray == null)
				{
					r_DecodeString_ByteArray = new(typeof(UnityEngine.TextAsset), "DecodeString", 0, typeof(System.Byte).MakeArrayType());
					r_DecodeString_ByteArray.SetBelong(null);
				}
				return r_DecodeString_ByteArray;
			}
		}

		/// <summary>
		/// Void GetSafetyHandle_Injected(UnityEngine.TextAsset, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_GetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle;
		public static RMethod RGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_GetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle == null)
				{
					r_GetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle = new(typeof(UnityEngine.TextAsset), "GetSafetyHandle_Injected", 0, typeof(UnityEngine.TextAsset), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_GetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_GetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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


        public RTextAsset() : base("UnityEngine.TextAsset")
        {
        }

        public RTextAsset(System.Object instance) : base("UnityEngine.TextAsset")
		{
            SetInstance(instance);
		}

        public RTextAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Byte[] GetPreviewBytes(System.Int32  @maxByteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxByteCount};
            var ___result = RGetPreviewBytes_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static void Internal_CreateInstance(UnityEngine.TextAsset  @self, System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @text};
            var ___result = RInternal_CreateInstance_TextAsset_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetDataPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Int64 GetDataSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataSize.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.TextAsset  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetSafetyHandle_TextAsset.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetData<T>() where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetData_GT.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetPreview(System.Int32  @maxChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxChars};
            var ___result = RGetPreview_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String DecodeString(System.Byte[]  @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RDecodeString_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void GetSafetyHandle_Injected(UnityEngine.TextAsset  @self, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @ret};
            var ___result = RGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
