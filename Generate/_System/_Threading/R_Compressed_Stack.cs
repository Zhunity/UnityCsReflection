
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.CompressedStack
	/// </summary>
    public partial class RCompressedStack : RMember //
    {

		/// <summary>
		/// System.Collections.ArrayList _list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_F_list;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RF_list
		{
			get
			{
				if(r_F_list == null)
				{
					r_F_list = new(this, "_list");
					r_F_list.SetBelong(this.instance);
				}
				return r_F_list;
			}
		}

		/// <summary>
		/// System.Collections.IList List
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIList r_PList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIList RPList
		{
			get
			{
				if(r_PList == null)
				{
					r_PList = new(this, "List", -1);
					r_PList.SetBelong(this.instance);
				}
				return r_PList;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack CreateCopy()
		/// </summary>
		protected RMethod r_MCreateCopy;
		public virtual RMethod RMCreateCopy
		{
			get
			{
				if(r_MCreateCopy == null)
				{
					r_MCreateCopy = new(this, "CreateCopy", 0);
					r_MCreateCopy.SetBelong(this.instance);
				}
				return r_MCreateCopy;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack Capture()
		/// </summary>
		protected static RMethod r_MCapture;
		public static RMethod RMCapture
		{
			get
			{
				if(r_MCapture == null)
				{
					r_MCapture = new(typeof(System.Threading.CompressedStack), "Capture", 0);
					r_MCapture.SetBelong(null);
				}
				return r_MCapture;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack GetCompressedStack()
		/// </summary>
		protected static RMethod r_MGetCompressedStack;
		public static RMethod RMGetCompressedStack
		{
			get
			{
				if(r_MGetCompressedStack == null)
				{
					r_MGetCompressedStack = new(typeof(System.Threading.CompressedStack), "GetCompressedStack", 0);
					r_MGetCompressedStack.SetBelong(null);
				}
				return r_MGetCompressedStack;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void Run(System.Threading.CompressedStack, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_MRun_CompressedStack_ContextCallback_Object;
		public static RMethod RMRun_CompressedStack_ContextCallback_Object
		{
			get
			{
				if(r_MRun_CompressedStack_ContextCallback_Object == null)
				{
					r_MRun_CompressedStack_ContextCallback_Object = new(typeof(System.Threading.CompressedStack), "Run", 0, typeof(System.Threading.CompressedStack), typeof(System.Threading.ContextCallback), typeof(System.Object));
					r_MRun_CompressedStack_ContextCallback_Object.SetBelong(null);
				}
				return r_MRun_CompressedStack_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Threading.CompressedStack)
		/// </summary>
		protected RMethod r_MEquals_CompressedStack;
		public virtual RMethod RMEquals_CompressedStack
		{
			get
			{
				if(r_MEquals_CompressedStack == null)
				{
					r_MEquals_CompressedStack = new(this, "Equals", 0, typeof(System.Threading.CompressedStack));
					r_MEquals_CompressedStack.SetBelong(this.instance);
				}
				return r_MEquals_CompressedStack;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_MIsEmpty;
		public virtual RMethod RMIsEmpty
		{
			get
			{
				if(r_MIsEmpty == null)
				{
					r_MIsEmpty = new(this, "IsEmpty", 0);
					r_MIsEmpty.SetBelong(this.instance);
				}
				return r_MIsEmpty;
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


        public RCompressedStack() : base("System.Threading.CompressedStack")
        {
        }

        public RCompressedStack(System.Object instance) : base("System.Threading.CompressedStack")
		{
            SetInstance(instance);
		}

        public RCompressedStack(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCompressedStack(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.CompressedStack CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateCopy.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public static System.Threading.CompressedStack Capture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCapture.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public static System.Threading.CompressedStack GetCompressedStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCompressedStack.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.CompressedStack @compressedStack, System.Threading.ContextCallback @callback, System.Object @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@compressedStack, @callback, @state};
            var ___result = RMRun_CompressedStack_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Threading.CompressedStack @cs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cs};
            var ___result = RMEquals_CompressedStack.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
