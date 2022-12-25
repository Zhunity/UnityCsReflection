using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.CompressedStack
	/// </summary>
    public partial class RCompressedStack : RMember //
    {

		/// <summary>
		/// System.Collections.ArrayList _list
		/// </summary>
		protected RSystem.RCollections.RArrayList r__list;
		public virtual RSystem.RCollections.RArrayList R_list
		{
			get
			{
				if(r__list == null)
				{
					r__list = new(this, "_list");
					r__list.SetBelong(this.instance);
				}
				return r__list;
			}
		}

		/// <summary>
		/// System.Collections.IList List
		/// </summary>
		protected RSystem.RCollections.RIList r_List;
		public virtual RSystem.RCollections.RIList RList
		{
			get
			{
				if(r_List == null)
				{
					r_List = new(this, "List", -1);
					r_List.SetBelong(this.instance);
				}
				return r_List;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack CreateCopy()
		/// </summary>
		protected RMethod r_RCreateCopy;
		public virtual RMethod RCreateCopy
		{
			get
			{
				if(r_RCreateCopy == null)
				{
					r_RCreateCopy = new(this, "CreateCopy", 0);
					r_RCreateCopy.SetBelong(this.instance);
				}
				return r_RCreateCopy;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack Capture()
		/// </summary>
		protected static RMethod r_RCapture;
		public static RMethod RCapture
		{
			get
			{
				if(r_RCapture == null)
				{
					r_RCapture = new(typeof(System.Threading.CompressedStack), "Capture", 0);
					r_RCapture.SetBelong(null);
				}
				return r_RCapture;
			}
		}

		/// <summary>
		/// System.Threading.CompressedStack GetCompressedStack()
		/// </summary>
		protected static RMethod r_RGetCompressedStack;
		public static RMethod RGetCompressedStack
		{
			get
			{
				if(r_RGetCompressedStack == null)
				{
					r_RGetCompressedStack = new(typeof(System.Threading.CompressedStack), "GetCompressedStack", 0);
					r_RGetCompressedStack.SetBelong(null);
				}
				return r_RGetCompressedStack;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void Run(System.Threading.CompressedStack, System.Threading.ContextCallback, System.Object)
		/// </summary>
		protected static RMethod r_RRun_CompressedStack_ContextCallback_Object;
		public static RMethod RRun_CompressedStack_ContextCallback_Object
		{
			get
			{
				if(r_RRun_CompressedStack_ContextCallback_Object == null)
				{
					r_RRun_CompressedStack_ContextCallback_Object = new(typeof(System.Threading.CompressedStack), "Run", 0, typeof(System.Threading.CompressedStack), typeof(System.Threading.ContextCallback), typeof(System.Object));
					r_RRun_CompressedStack_ContextCallback_Object.SetBelong(null);
				}
				return r_RRun_CompressedStack_ContextCallback_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Threading.CompressedStack)
		/// </summary>
		protected RMethod r_REquals_CompressedStack;
		public virtual RMethod REquals_CompressedStack
		{
			get
			{
				if(r_REquals_CompressedStack == null)
				{
					r_REquals_CompressedStack = new(this, "Equals", 0, typeof(System.Threading.CompressedStack));
					r_REquals_CompressedStack.SetBelong(this.instance);
				}
				return r_REquals_CompressedStack;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_RIsEmpty;
		public virtual RMethod RIsEmpty
		{
			get
			{
				if(r_RIsEmpty == null)
				{
					r_RIsEmpty = new(this, "IsEmpty", 0);
					r_RIsEmpty.SetBelong(this.instance);
				}
				return r_RIsEmpty;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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
            var ___result = RCreateCopy.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public static System.Threading.CompressedStack Capture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCapture.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public static System.Threading.CompressedStack GetCompressedStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCompressedStack.Invoke(___genericsType, ___parameters);

            return (System.Threading.CompressedStack)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public static void Run(System.Threading.CompressedStack  @compressedStack, System.Threading.ContextCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@compressedStack, @callback, @state};
            var ___result = RRun_CompressedStack_ContextCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Threading.CompressedStack  @cs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cs};
            var ___result = REquals_CompressedStack.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
