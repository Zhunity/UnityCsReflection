using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.IllogicalCallContext
	/// </summary>
    public partial class RIllogicalCallContext : RMember //
    {

		/// <summary>
		/// System.Collections.Hashtable m_Datastore
		/// </summary>
		protected RSystem.RCollections.RHashtable r_m_Datastore;
		public virtual RSystem.RCollections.RHashtable Rm_Datastore
		{
			get
			{
				if(r_m_Datastore == null)
				{
					r_m_Datastore = new(this, "m_Datastore");
					r_m_Datastore.SetBelong(this.instance);
				}
				return r_m_Datastore;
			}
		}

		/// <summary>
		/// System.Object m_HostContext
		/// </summary>
		protected RSystem.RObject r_m_HostContext;
		public virtual RSystem.RObject Rm_HostContext
		{
			get
			{
				if(r_m_HostContext == null)
				{
					r_m_HostContext = new(this, "m_HostContext");
					r_m_HostContext.SetBelong(this.instance);
				}
				return r_m_HostContext;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Datastore
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Datastore;
		public virtual RSystem.RCollections.RHashtable RDatastore
		{
			get
			{
				if(r_Datastore == null)
				{
					r_Datastore = new(this, "Datastore", -1);
					r_Datastore.SetBelong(this.instance);
				}
				return r_Datastore;
			}
		}

		/// <summary>
		/// System.Object HostContext
		/// </summary>
		protected RSystem.RObject r_HostContext;
		public virtual RSystem.RObject RHostContext
		{
			get
			{
				if(r_HostContext == null)
				{
					r_HostContext = new(this, "HostContext", -1);
					r_HostContext.SetBelong(this.instance);
				}
				return r_HostContext;
			}
		}

		/// <summary>
		/// Boolean HasUserData
		/// </summary>
		protected RSystem.RBoolean r_HasUserData;
		public virtual RSystem.RBoolean RHasUserData
		{
			get
			{
				if(r_HasUserData == null)
				{
					r_HasUserData = new(this, "HasUserData", -1);
					r_HasUserData.SetBelong(this.instance);
				}
				return r_HasUserData;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_FreeNamedDataSlot_String;
		public virtual RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_FreeNamedDataSlot_String == null)
				{
					r_FreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
					r_FreeNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_FreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_GetData_String;
		public virtual RMethod RGetData_String
		{
			get
			{
				if(r_GetData_String == null)
				{
					r_GetData_String = new(this, "GetData", 0, typeof(System.String));
					r_GetData_String.SetBelong(this.instance);
				}
				return r_GetData_String;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_SetData_String_Object;
		public virtual RMethod RSetData_String_Object
		{
			get
			{
				if(r_SetData_String_Object == null)
				{
					r_SetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
					r_SetData_String_Object.SetBelong(this.instance);
				}
				return r_SetData_String_Object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext CreateCopy()
		/// </summary>
		protected RMethod r_CreateCopy;
		public virtual RMethod RCreateCopy
		{
			get
			{
				if(r_CreateCopy == null)
				{
					r_CreateCopy = new(this, "CreateCopy", 0);
					r_CreateCopy.SetBelong(this.instance);
				}
				return r_CreateCopy;
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
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.String @name, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateCopy.Invoke(___genericsType, ___parameters);

            return new RSystem.RRuntime.RRemoting.RMessaging.RIllogicalCallContext(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
