
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Remoting.Contexts.DynamicPropertyCollection
	/// </summary>
    public partial class RDynamicPropertyCollection : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Runtime.Remoting.Contexts.DynamicPropertyCollection");
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


		/// <summary>
		/// System.Collections.ArrayList _properties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_F_properties;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RF_properties
		{
			get
			{
				if(r_F_properties == null)
				{
					r_F_properties = new(this, "_properties");
				}
				return r_F_properties;
			}
		}

		/// <summary>
		/// Boolean HasProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasProperties
		{
			get
			{
				if(r_PHasProperties == null)
				{
					r_PHasProperties = new(this, "HasProperties", -1);
				}
				return r_PHasProperties;
			}
		}

		/// <summary>
		/// Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty)
		/// </summary>
		protected RMethod r_MRegisterDynamicProperty_IDynamicProperty;
		public virtual RMethod RMRegisterDynamicProperty_IDynamicProperty
		{
			get
			{
				if(r_MRegisterDynamicProperty_IDynamicProperty == null)
				{
					r_MRegisterDynamicProperty_IDynamicProperty = new(this, "RegisterDynamicProperty", 0, typeof(System.Runtime.Remoting.Contexts.IDynamicProperty));
				}
				return r_MRegisterDynamicProperty_IDynamicProperty;
			}
		}

		/// <summary>
		/// Boolean UnregisterDynamicProperty(System.String)
		/// </summary>
		protected RMethod r_MUnregisterDynamicProperty_String;
		public virtual RMethod RMUnregisterDynamicProperty_String
		{
			get
			{
				if(r_MUnregisterDynamicProperty_String == null)
				{
					r_MUnregisterDynamicProperty_String = new(this, "UnregisterDynamicProperty", 0, typeof(System.String));
				}
				return r_MUnregisterDynamicProperty_String;
			}
		}

		/// <summary>
		/// Void NotifyMessage(Boolean, System.Runtime.Remoting.Messaging.IMessage, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MNotifyMessage_Boolean_IMessage_Boolean_Boolean;
		public virtual RMethod RMNotifyMessage_Boolean_IMessage_Boolean_Boolean
		{
			get
			{
				if(r_MNotifyMessage_Boolean_IMessage_Boolean_Boolean == null)
				{
					r_MNotifyMessage_Boolean_IMessage_Boolean_Boolean = new(this, "NotifyMessage", 0, typeof(System.Boolean), typeof(System.Runtime.Remoting.Messaging.IMessage), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MNotifyMessage_Boolean_IMessage_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 FindProperty(System.String)
		/// </summary>
		protected RMethod r_MFindProperty_String;
		public virtual RMethod RMFindProperty_String
		{
			get
			{
				if(r_MFindProperty_String == null)
				{
					r_MFindProperty_String = new(this, "FindProperty", 0, typeof(System.String));
				}
				return r_MFindProperty_String;
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


        public virtual System.Boolean RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RMRegisterDynamicProperty_IDynamicProperty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnregisterDynamicProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMUnregisterDynamicProperty_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void NotifyMessage(System.Boolean @start, System.Runtime.Remoting.Messaging.IMessage @msg, System.Boolean @client_site, System.Boolean @async)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @msg, @client_site, @async};
            var ___result = RMNotifyMessage_Boolean_IMessage_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindProperty_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
