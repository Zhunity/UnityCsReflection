
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.IllogicalCallContext
	/// </summary>
    public partial class RIllogicalCallContext : RMember //
    {

		/// <summary>
		/// System.Collections.Hashtable m_Datastore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fm_Datastore;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFm_Datastore
		{
			get
			{
				if(r_Fm_Datastore == null)
				{
					r_Fm_Datastore = new(this, "m_Datastore");
				}
				return r_Fm_Datastore;
			}
		}

		/// <summary>
		/// System.Object m_HostContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_HostContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_HostContext
		{
			get
			{
				if(r_Fm_HostContext == null)
				{
					r_Fm_HostContext = new(this, "m_HostContext");
				}
				return r_Fm_HostContext;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Datastore
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_PDatastore;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RPDatastore
		{
			get
			{
				if(r_PDatastore == null)
				{
					r_PDatastore = new(this, "Datastore", -1);
				}
				return r_PDatastore;
			}
		}

		/// <summary>
		/// System.Object HostContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PHostContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPHostContext
		{
			get
			{
				if(r_PHostContext == null)
				{
					r_PHostContext = new(this, "HostContext", -1);
				}
				return r_PHostContext;
			}
		}

		/// <summary>
		/// Boolean HasUserData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasUserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasUserData
		{
			get
			{
				if(r_PHasUserData == null)
				{
					r_PHasUserData = new(this, "HasUserData", -1);
				}
				return r_PHasUserData;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_MFreeNamedDataSlot_String;
		public virtual RMethod RMFreeNamedDataSlot_String
		{
			get
			{
				if(r_MFreeNamedDataSlot_String == null)
				{
					r_MFreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
				}
				return r_MFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_MGetData_String;
		public virtual RMethod RMGetData_String
		{
			get
			{
				if(r_MGetData_String == null)
				{
					r_MGetData_String = new(this, "GetData", 0, typeof(System.String));
				}
				return r_MGetData_String;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_MSetData_String_Object;
		public virtual RMethod RMSetData_String_Object
		{
			get
			{
				if(r_MSetData_String_Object == null)
				{
					r_MSetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MSetData_String_Object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext CreateCopy()
		/// </summary>
		protected RMethod r_MCreateCopy;
		public virtual RMethod RMCreateCopy
		{
			get
			{
				if(r_MCreateCopy == null)
				{
					r_MCreateCopy = new(this, "CreateCopy", 0);
				}
				return r_MCreateCopy;
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


        public RIllogicalCallContext() : base("System.Runtime.Remoting.Messaging.IllogicalCallContext")
        {
        }

        public RIllogicalCallContext(System.Object instance) : base("System.Runtime.Remoting.Messaging.IllogicalCallContext")
		{
            SetInstance(instance);
		}

        public RIllogicalCallContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIllogicalCallContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void FreeNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.String @name, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RMSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateCopy.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext(___result);
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
