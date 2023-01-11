using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
	/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection
	/// </summary>
    public partial class RDynamicPropertyCollection : RMember //
    {

		/// <summary>
		/// System.Collections.ArrayList _properties
		/// </summary>
		protected RSystem.RCollections.RArrayList r__properties;
		public virtual RSystem.RCollections.RArrayList R_properties
		{
			get
			{
				if(r__properties == null)
				{
					r__properties = new(this, "_properties");
					r__properties.SetBelong(this.instance);
				}
				return r__properties;
			}
		}

		/// <summary>
		/// Boolean HasProperties
		/// </summary>
		protected RSystem.RBoolean r_HasProperties;
		public virtual RSystem.RBoolean RHasProperties
		{
			get
			{
				if(r_HasProperties == null)
				{
					r_HasProperties = new(this, "HasProperties", -1);
					r_HasProperties.SetBelong(this.instance);
				}
				return r_HasProperties;
			}
		}

		/// <summary>
		/// Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty)
		/// </summary>
		protected RMethod r_RegisterDynamicProperty_IDynamicProperty;
		public virtual RMethod RRegisterDynamicProperty_IDynamicProperty
		{
			get
			{
				if(r_RegisterDynamicProperty_IDynamicProperty == null)
				{
					r_RegisterDynamicProperty_IDynamicProperty = new(this, "RegisterDynamicProperty", 0, typeof(System.Runtime.Remoting.Contexts.IDynamicProperty));
					r_RegisterDynamicProperty_IDynamicProperty.SetBelong(this.instance);
				}
				return r_RegisterDynamicProperty_IDynamicProperty;
			}
		}

		/// <summary>
		/// Boolean UnregisterDynamicProperty(System.String)
		/// </summary>
		protected RMethod r_UnregisterDynamicProperty_String;
		public virtual RMethod RUnregisterDynamicProperty_String
		{
			get
			{
				if(r_UnregisterDynamicProperty_String == null)
				{
					r_UnregisterDynamicProperty_String = new(this, "UnregisterDynamicProperty", 0, typeof(System.String));
					r_UnregisterDynamicProperty_String.SetBelong(this.instance);
				}
				return r_UnregisterDynamicProperty_String;
			}
		}

		/// <summary>
		/// Void NotifyMessage(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_NotifyMessage_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RNotifyMessage_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_NotifyMessage_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_NotifyMessage_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyMessage", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
					r_NotifyMessage_Boolean_IMessage_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_NotifyMessage_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 FindProperty(System.String)
		/// </summary>
		protected RMethod r_FindProperty_String;
		public virtual RMethod RFindProperty_String
		{
			get
			{
				if(r_FindProperty_String == null)
				{
					r_FindProperty_String = new(this, "FindProperty", 0, typeof(System.String));
					r_FindProperty_String.SetBelong(this.instance);
				}
				return r_FindProperty_String;
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


        public RDynamicPropertyCollection() : base("System.Runtime.Remoting.Contexts.DynamicPropertyCollection")
        {
        }

        public RDynamicPropertyCollection(System.Object instance) : base("System.Runtime.Remoting.Contexts.DynamicPropertyCollection")
		{
            SetInstance(instance);
		}

        public RDynamicPropertyCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDynamicPropertyCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RRegisterDynamicProperty_IDynamicProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnregisterDynamicProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RUnregisterDynamicProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void NotifyMessage(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @msg, @client_site, @async};
            var ___result = RNotifyMessage_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
