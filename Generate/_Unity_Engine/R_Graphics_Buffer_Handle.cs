
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.GraphicsBufferHandle
	/// </summary>
    public partial class RGraphicsBufferHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.GraphicsBufferHandle);
            }
        }

        public RGraphicsBufferHandle() : base("UnityEngine.GraphicsBufferHandle")
        {
        }

        public RGraphicsBufferHandle(System.Object instance) : base("UnityEngine.GraphicsBufferHandle")
		{
            SetInstance(instance);
		}

        public RGraphicsBufferHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGraphicsBufferHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.UInt32 value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
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
		/// Boolean Equals(UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_MEquals_GraphicsBufferHandle;
		public virtual RMethod RMEquals_GraphicsBufferHandle
		{
			get
			{
				if(r_MEquals_GraphicsBufferHandle == null)
				{
					r_MEquals_GraphicsBufferHandle = new(this, "Equals", 0, typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_MEquals_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Int32 CompareTo(UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected RMethod r_MCompareTo_GraphicsBufferHandle;
		public virtual RMethod RMCompareTo_GraphicsBufferHandle
		{
			get
			{
				if(r_MCompareTo_GraphicsBufferHandle == null)
				{
					r_MCompareTo_GraphicsBufferHandle = new(this, "CompareTo", 0, typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_MCompareTo_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.GraphicsBufferHandle, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_GraphicsBufferHandle_GraphicsBufferHandle;
		public static RMethod RMop_Equality_GraphicsBufferHandle_GraphicsBufferHandle
		{
			get
			{
				if(r_Mop_Equality_GraphicsBufferHandle_GraphicsBufferHandle == null)
				{
					r_Mop_Equality_GraphicsBufferHandle_GraphicsBufferHandle = new(Type, "op_Equality", 0, typeof(UnityEngine.GraphicsBufferHandle), typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_Mop_Equality_GraphicsBufferHandle_GraphicsBufferHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.GraphicsBufferHandle, UnityEngine.GraphicsBufferHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle;
		public static RMethod RMop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle
		{
			get
			{
				if(r_Mop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle == null)
				{
					r_Mop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle = new(Type, "op_Inequality", 0, typeof(UnityEngine.GraphicsBufferHandle), typeof(UnityEngine.GraphicsBufferHandle));
				}
				return r_Mop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.GraphicsBufferHandle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 CompareTo(UnityEngine.GraphicsBufferHandle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMCompareTo_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.GraphicsBufferHandle @a, UnityEngine.GraphicsBufferHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_GraphicsBufferHandle_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.GraphicsBufferHandle @a, UnityEngine.GraphicsBufferHandle @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_GraphicsBufferHandle_GraphicsBufferHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
