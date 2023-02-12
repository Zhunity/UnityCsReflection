
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
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
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FruntimeTypeIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFruntimeTypeIndex
		{
			get
			{
				if(r_FruntimeTypeIndex == null)
				{
					r_FruntimeTypeIndex = new(this, "runtimeTypeIndex");
					r_FruntimeTypeIndex.SetBelong(this.instance);
				}
				return r_FruntimeTypeIndex;
			}
		}

		/// <summary>
		/// System.UInt32 descendantCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FdescendantCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFdescendantCount
		{
			get
			{
				if(r_FdescendantCount == null)
				{
					r_FdescendantCount = new(this, "descendantCount");
					r_FdescendantCount.SetBelong(this.instance);
				}
				return r_FdescendantCount;
			}
		}

		/// <summary>
		/// System.UInt32 baseClassIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FbaseClassIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFbaseClassIndex
		{
			get
			{
				if(r_FbaseClassIndex == null)
				{
					r_FbaseClassIndex = new(this, "baseClassIndex");
					r_FbaseClassIndex.SetBelong(this.instance);
				}
				return r_FbaseClassIndex;
			}
		}

		/// <summary>
		/// System.String className
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FclassName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFclassName
		{
			get
			{
				if(r_FclassName == null)
				{
					r_FclassName = new(this, "className");
					r_FclassName.SetBelong(this.instance);
				}
				return r_FclassName;
			}
		}

		/// <summary>
		/// System.String classNamespace
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FclassNamespace;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFclassNamespace
		{
			get
			{
				if(r_FclassNamespace == null)
				{
					r_FclassNamespace = new(this, "classNamespace");
					r_FclassNamespace.SetBelong(this.instance);
				}
				return r_FclassNamespace;
			}
		}

		/// <summary>
		/// System.String module
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fmodule;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFmodule
		{
			get
			{
				if(r_Fmodule == null)
				{
					r_Fmodule = new(this, "module");
					r_Fmodule.SetBelong(this.instance);
				}
				return r_Fmodule;
			}
		}

		/// <summary>
		/// System.Int32 persistentTypeID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FpersistentTypeID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFpersistentTypeID
		{
			get
			{
				if(r_FpersistentTypeID == null)
				{
					r_FpersistentTypeID = new(this, "persistentTypeID");
					r_FpersistentTypeID.SetBelong(this.instance);
				}
				return r_FpersistentTypeID;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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