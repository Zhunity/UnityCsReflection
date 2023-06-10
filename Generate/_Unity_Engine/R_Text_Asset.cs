
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextAsset
	/// </summary>
    public partial class RTextAsset : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextAsset);
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


		/// <summary>
		/// Byte[] bytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Pbytes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPbytes
		{
			get
			{
				if(r_Pbytes == null)
				{
					r_Pbytes = new(this, "bytes", -1);
				}
				return r_Pbytes;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Int64 dataSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PdataSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPdataSize
		{
			get
			{
				if(r_PdataSize == null)
				{
					r_PdataSize = new(this, "dataSize", -1);
				}
				return r_PdataSize;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Byte[] GetPreviewBytes(Int32)
		/// </summary>
		protected RMethod r_MGetPreviewBytes_Int32;
		public virtual RMethod RMGetPreviewBytes_Int32
		{
			get
			{
				if(r_MGetPreviewBytes_Int32 == null)
				{
					r_MGetPreviewBytes_Int32 = new(this, "GetPreviewBytes", 0, typeof(System.Int32));
				}
				return r_MGetPreviewBytes_Int32;
			}
		}

		/// <summary>
		/// Void Internal_CreateInstance(UnityEngine.TextAsset, System.String)
		/// </summary>
		protected static RMethod r_MInternal_CreateInstance_TextAsset_String;
		public static RMethod RMInternal_CreateInstance_TextAsset_String
		{
			get
			{
				if(r_MInternal_CreateInstance_TextAsset_String == null)
				{
					r_MInternal_CreateInstance_TextAsset_String = new(typeof(UnityEngine.TextAsset), "Internal_CreateInstance", 0, typeof(UnityEngine.TextAsset), typeof(System.String));
				}
				return r_MInternal_CreateInstance_TextAsset_String;
			}
		}

		/// <summary>
		/// IntPtr GetDataPtr()
		/// </summary>
		protected RMethod r_MGetDataPtr;
		public virtual RMethod RMGetDataPtr
		{
			get
			{
				if(r_MGetDataPtr == null)
				{
					r_MGetDataPtr = new(this, "GetDataPtr", 0);
				}
				return r_MGetDataPtr;
			}
		}

		/// <summary>
		/// Int64 GetDataSize()
		/// </summary>
		protected RMethod r_MGetDataSize;
		public virtual RMethod RMGetDataSize
		{
			get
			{
				if(r_MGetDataSize == null)
				{
					r_MGetDataSize = new(this, "GetDataSize", 0);
				}
				return r_MGetDataSize;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.TextAsset)
		/// </summary>
		protected static RMethod r_MGetSafetyHandle_TextAsset;
		public static RMethod RMGetSafetyHandle_TextAsset
		{
			get
			{
				if(r_MGetSafetyHandle_TextAsset == null)
				{
					r_MGetSafetyHandle_TextAsset = new(typeof(UnityEngine.TextAsset), "GetSafetyHandle", 0, typeof(UnityEngine.TextAsset));
				}
				return r_MGetSafetyHandle_TextAsset;
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
		/// Unity.Collections.NativeArray`1[T] GetData[T]()
		/// </summary>
		protected RMethod r_MGetData_GT;
		public virtual RMethod RMGetData_GT
		{
			get
			{
				if(r_MGetData_GT == null)
				{
					r_MGetData_GT = new(this, "GetData", 1);
				}
				return r_MGetData_GT;
			}
		}

		/// <summary>
		/// System.String GetPreview(Int32)
		/// </summary>
		protected RMethod r_MGetPreview_Int32;
		public virtual RMethod RMGetPreview_Int32
		{
			get
			{
				if(r_MGetPreview_Int32 == null)
				{
					r_MGetPreview_Int32 = new(this, "GetPreview", 0, typeof(System.Int32));
				}
				return r_MGetPreview_Int32;
			}
		}

		/// <summary>
		/// System.String DecodeString(Byte[])
		/// </summary>
		protected static RMethod r_MDecodeString_ByteArray;
		public static RMethod RMDecodeString_ByteArray
		{
			get
			{
				if(r_MDecodeString_ByteArray == null)
				{
					r_MDecodeString_ByteArray = new(typeof(UnityEngine.TextAsset), "DecodeString", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MDecodeString_ByteArray;
			}
		}

		/// <summary>
		/// Void GetSafetyHandle_Injected(UnityEngine.TextAsset, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle;
		public static RMethod RMGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle == null)
				{
					r_MGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle = new(typeof(UnityEngine.TextAsset), "GetSafetyHandle_Injected", 0, typeof(UnityEngine.TextAsset), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public virtual System.Byte[] GetPreviewBytes(System.Int32 @maxByteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxByteCount};
            var ___result = RMGetPreviewBytes_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static void Internal_CreateInstance(UnityEngine.TextAsset @self, System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @text};
            var ___result = RMInternal_CreateInstance_TextAsset_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetDataPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Int64 GetDataSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataSize.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.TextAsset @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetSafetyHandle_TextAsset.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetData<T>() where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetData_GT.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual System.String GetPreview(System.Int32 @maxChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxChars};
            var ___result = RMGetPreview_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String DecodeString(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RMDecodeString_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void GetSafetyHandle_Injected(UnityEngine.TextAsset @self, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @ret};
            var ___result = RMGetSafetyHandle_Injected_TextAsset_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
