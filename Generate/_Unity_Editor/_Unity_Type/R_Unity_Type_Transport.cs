
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{public partial class RUnityType
{
	
	/// <summary>
	/// UnityEditor.UnityType+UnityTypeTransport
	/// </summary>
    public partial class RUnityTypeTransport : RMember //
    {

		/// <summary>
		/// System.UInt32 runtimeTypeIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FruntimeTypeIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFruntimeTypeIndex
		{
			get
			{
				if(r_FruntimeTypeIndex == null)
				{
					r_FruntimeTypeIndex = new(this, "runtimeTypeIndex");
				}
				return r_FruntimeTypeIndex;
			}
		}

		/// <summary>
		/// System.UInt32 descendantCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdescendantCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdescendantCount
		{
			get
			{
				if(r_FdescendantCount == null)
				{
					r_FdescendantCount = new(this, "descendantCount");
				}
				return r_FdescendantCount;
			}
		}

		/// <summary>
		/// System.UInt32 baseClassIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FbaseClassIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFbaseClassIndex
		{
			get
			{
				if(r_FbaseClassIndex == null)
				{
					r_FbaseClassIndex = new(this, "baseClassIndex");
				}
				return r_FbaseClassIndex;
			}
		}

		/// <summary>
		/// System.String className
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FclassName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFclassName
		{
			get
			{
				if(r_FclassName == null)
				{
					r_FclassName = new(this, "className");
				}
				return r_FclassName;
			}
		}

		/// <summary>
		/// System.String classNamespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FclassNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFclassNamespace
		{
			get
			{
				if(r_FclassNamespace == null)
				{
					r_FclassNamespace = new(this, "classNamespace");
				}
				return r_FclassNamespace;
			}
		}

		/// <summary>
		/// System.String module
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fmodule;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFmodule
		{
			get
			{
				if(r_Fmodule == null)
				{
					r_Fmodule = new(this, "module");
				}
				return r_Fmodule;
			}
		}

		/// <summary>
		/// System.Int32 persistentTypeID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FpersistentTypeID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpersistentTypeID
		{
			get
			{
				if(r_FpersistentTypeID == null)
				{
					r_FpersistentTypeID = new(this, "persistentTypeID");
				}
				return r_FpersistentTypeID;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fflags;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
				}
				return r_Fflags;
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


        public RUnityTypeTransport() : base("UnityEditor.UnityType+UnityTypeTransport")
        {
        }

        public RUnityTypeTransport(System.Object instance) : base("UnityEditor.UnityType+UnityTypeTransport")
		{
            SetInstance(instance);
		}

        public RUnityTypeTransport(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityTypeTransport(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}