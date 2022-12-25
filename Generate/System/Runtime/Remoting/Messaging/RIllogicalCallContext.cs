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
		protected RProperty r_HasUserData;
		public virtual RProperty RHasUserData
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
		protected RMethod r_RFreeNamedDataSlot_String;
		public virtual RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_RFreeNamedDataSlot_String == null)
				{
					r_RFreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
					r_RFreeNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_RFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_RGetData_String;
		public virtual RMethod RGetData_String
		{
			get
			{
				if(r_RGetData_String == null)
				{
					r_RGetData_String = new(this, "GetData", 0, typeof(System.String));
					r_RGetData_String.SetBelong(this.instance);
				}
				return r_RGetData_String;
			}
		}

		/// <summary>
		/// Void SetData(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSetData_String_Object;
		public virtual RMethod RSetData_String_Object
		{
			get
			{
				if(r_RSetData_String_Object == null)
				{
					r_RSetData_String_Object = new(this, "SetData", 0, typeof(System.String), typeof(System.Object));
					r_RSetData_String_Object.SetBelong(this.instance);
				}
				return r_RSetData_String_Object;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.IllogicalCallContext CreateCopy()
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

        public virtual void FreeNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.String  @name, System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetData_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object CreateCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateCopy.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
