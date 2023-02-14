
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.CADMethodCallMessage
	/// </summary>
    public partial class RCADMethodCallMessage : RMember //
    {

		/// <summary>
		/// System.String _uri
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_uri;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_uri
		{
			get
			{
				if(r_F_uri == null)
				{
					r_F_uri = new(this, "_uri");
					r_F_uri.SetBelong(this.instance);
				}
				return r_F_uri;
			}
		}

		/// <summary>
		/// System.Object[] _args
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_F_args;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RF_args
		{
			get
			{
				if(r_F_args == null)
				{
					r_F_args = new(this, "_args");
					r_F_args.SetBelong(this.instance);
				}
				return r_F_args;
			}
		}

		/// <summary>
		/// System.Byte[] _serializedArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_F_serializedArgs;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RF_serializedArgs
		{
			get
			{
				if(r_F_serializedArgs == null)
				{
					r_F_serializedArgs = new(this, "_serializedArgs");
					r_F_serializedArgs.SetBelong(this.instance);
				}
				return r_F_serializedArgs;
			}
		}

		/// <summary>
		/// System.Int32 _propertyCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_propertyCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_propertyCount
		{
			get
			{
				if(r_F_propertyCount == null)
				{
					r_F_propertyCount = new(this, "_propertyCount");
					r_F_propertyCount.SetBelong(this.instance);
				}
				return r_F_propertyCount;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CADArgHolder _callContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADArgHolder r_F_callContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADArgHolder RF_callContext
		{
			get
			{
				if(r_F_callContext == null)
				{
					r_F_callContext = new(this, "_callContext");
					r_F_callContext.SetBelong(this.instance);
				}
				return r_F_callContext;
			}
		}

		/// <summary>
		/// System.Byte[] serializedMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_FserializedMethod;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFserializedMethod
		{
			get
			{
				if(r_FserializedMethod == null)
				{
					r_FserializedMethod = new(this, "serializedMethod");
					r_FserializedMethod.SetBelong(this.instance);
				}
				return r_FserializedMethod;
			}
		}

		/// <summary>
		/// System.String Uri
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PUri;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPUri
		{
			get
			{
				if(r_PUri == null)
				{
					r_PUri = new(this, "Uri", -1);
					r_PUri.SetBelong(this.instance);
				}
				return r_PUri;
			}
		}

		/// <summary>
		/// Int32 PropertiesCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PPropertiesCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPPropertiesCount
		{
			get
			{
				if(r_PPropertiesCount == null)
				{
					r_PPropertiesCount = new(this, "PropertiesCount", -1);
					r_PPropertiesCount.SetBelong(this.instance);
				}
				return r_PPropertiesCount;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CADMethodCallMessage Create(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected static RMethod r_MCreate_IMessage;
		public static RMethod RMCreate_IMessage
		{
			get
			{
				if(r_MCreate_IMessage == null)
				{
					r_MCreate_IMessage = new( ReflectionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodCallMessage"), "Create", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_MCreate_IMessage.SetBelong(null);
				}
				return r_MCreate_IMessage;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList GetArguments()
		/// </summary>
		protected RMethod r_MGetArguments;
		public virtual RMethod RMGetArguments
		{
			get
			{
				if(r_MGetArguments == null)
				{
					r_MGetArguments = new(this, "GetArguments", 0);
					r_MGetArguments.SetBelong(this.instance);
				}
				return r_MGetArguments;
			}
		}

		/// <summary>
		/// System.Object[] GetArgs(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_MGetArgs_ArrayList;
		public virtual RMethod RMGetArgs_ArrayList
		{
			get
			{
				if(r_MGetArgs_ArrayList == null)
				{
					r_MGetArgs_ArrayList = new(this, "GetArgs", 0, typeof(System.Collections.ArrayList));
					r_MGetArgs_ArrayList.SetBelong(this.instance);
				}
				return r_MGetArgs_ArrayList;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethod()
		/// </summary>
		protected RMethod r_MGetMethod;
		public virtual RMethod RMGetMethod
		{
			get
			{
				if(r_MGetMethod == null)
				{
					r_MGetMethod = new(this, "GetMethod", 0);
					r_MGetMethod.SetBelong(this.instance);
				}
				return r_MGetMethod;
			}
		}

		/// <summary>
		/// System.Object MarshalArgument(System.Object, System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_MMarshalArgument_Object_Ref_ArrayList;
		public virtual RMethod RMMarshalArgument_Object_Ref_ArrayList
		{
			get
			{
				if(r_MMarshalArgument_Object_Ref_ArrayList == null)
				{
					r_MMarshalArgument_Object_Ref_ArrayList = new(this, "MarshalArgument", 0, typeof(System.Object), typeof(System.Collections.ArrayList).MakeByRefType());
					r_MMarshalArgument_Object_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_MMarshalArgument_Object_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Object UnmarshalArgument(System.Object, System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_MUnmarshalArgument_Object_ArrayList;
		public virtual RMethod RMUnmarshalArgument_Object_ArrayList
		{
			get
			{
				if(r_MUnmarshalArgument_Object_ArrayList == null)
				{
					r_MUnmarshalArgument_Object_ArrayList = new(this, "UnmarshalArgument", 0, typeof(System.Object), typeof(System.Collections.ArrayList));
					r_MUnmarshalArgument_Object_ArrayList.SetBelong(this.instance);
				}
				return r_MUnmarshalArgument_Object_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] MarshalArguments(System.Object[], System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_MMarshalArguments_ObjectArray_Ref_ArrayList;
		public virtual RMethod RMMarshalArguments_ObjectArray_Ref_ArrayList
		{
			get
			{
				if(r_MMarshalArguments_ObjectArray_Ref_ArrayList == null)
				{
					r_MMarshalArguments_ObjectArray_Ref_ArrayList = new(this, "MarshalArguments", 0, typeof(System.Object).MakeArrayType(), typeof(System.Collections.ArrayList).MakeByRefType());
					r_MMarshalArguments_ObjectArray_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_MMarshalArguments_ObjectArray_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] UnmarshalArguments(System.Object[], System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_MUnmarshalArguments_ObjectArray_ArrayList;
		public virtual RMethod RMUnmarshalArguments_ObjectArray_ArrayList
		{
			get
			{
				if(r_MUnmarshalArguments_ObjectArray_ArrayList == null)
				{
					r_MUnmarshalArguments_ObjectArray_ArrayList = new(this, "UnmarshalArguments", 0, typeof(System.Object).MakeArrayType(), typeof(System.Collections.ArrayList));
					r_MUnmarshalArguments_ObjectArray_ArrayList.SetBelong(this.instance);
				}
				return r_MUnmarshalArguments_ObjectArray_ArrayList;
			}
		}

		/// <summary>
		/// Void SaveLogicalCallContext(System.Runtime.Remoting.Messaging.IMethodMessage, System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_MSaveLogicalCallContext_IMethodMessage_Ref_ArrayList;
		public virtual RMethod RMSaveLogicalCallContext_IMethodMessage_Ref_ArrayList
		{
			get
			{
				if(r_MSaveLogicalCallContext_IMethodMessage_Ref_ArrayList == null)
				{
					r_MSaveLogicalCallContext_IMethodMessage_Ref_ArrayList = new(this, "SaveLogicalCallContext", 0, typeof(System.Runtime.Remoting.Messaging.IMethodMessage), typeof(System.Collections.ArrayList).MakeByRefType());
					r_MSaveLogicalCallContext_IMethodMessage_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_MSaveLogicalCallContext_IMethodMessage_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext GetLogicalCallContext(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_MGetLogicalCallContext_ArrayList;
		public virtual RMethod RMGetLogicalCallContext_ArrayList
		{
			get
			{
				if(r_MGetLogicalCallContext_ArrayList == null)
				{
					r_MGetLogicalCallContext_ArrayList = new(this, "GetLogicalCallContext", 0, typeof(System.Collections.ArrayList));
					r_MGetLogicalCallContext_ArrayList.SetBelong(this.instance);
				}
				return r_MGetLogicalCallContext_ArrayList;
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


        public RCADMethodCallMessage() : base("System.Runtime.Remoting.Messaging.CADMethodCallMessage")
        {
        }

        public RCADMethodCallMessage(System.Object instance) : base("System.Runtime.Remoting.Messaging.CADMethodCallMessage")
		{
            SetInstance(instance);
		}

        public RCADMethodCallMessage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCADMethodCallMessage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADMethodCallMessage Create(System.Runtime.Remoting.Messaging.IMessage @callMsg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callMsg};
            var ___result = RMCreate_IMessage.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RCADMethodCallMessage(___result);
        }


        public virtual System.Collections.ArrayList GetArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetArguments.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Object[] GetArgs(System.Collections.ArrayList @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMGetArgs_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.MethodBase GetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Object MarshalArgument(System.Object @arg, ref System.Collections.ArrayList @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @args};
            var ___result = RMMarshalArgument_Object_Ref_ArrayList.Invoke(___genericsType, ___parameters);
			@args = (System.Collections.ArrayList)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Object UnmarshalArgument(System.Object @arg, System.Collections.ArrayList @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @args};
            var ___result = RMUnmarshalArgument_Object_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object[] MarshalArguments(System.Object[] @arguments, ref System.Collections.ArrayList @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments, @args};
            var ___result = RMMarshalArguments_ObjectArray_Ref_ArrayList.Invoke(___genericsType, ___parameters);
			@args = (System.Collections.ArrayList)___parameters[1];

            return (System.Object[])___result;
        }


        public virtual System.Object[] UnmarshalArguments(System.Object[] @arguments, System.Collections.ArrayList @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments, @args};
            var ___result = RMUnmarshalArguments_ObjectArray_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual void SaveLogicalCallContext(System.Runtime.Remoting.Messaging.IMethodMessage @msg, ref System.Collections.ArrayList @serializeList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg, @serializeList};
            var ___result = RMSaveLogicalCallContext_IMethodMessage_Ref_ArrayList.Invoke(___genericsType, ___parameters);
			@serializeList = (System.Collections.ArrayList)___parameters[1];

            
        }


        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext GetLogicalCallContext(System.Collections.ArrayList @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMGetLogicalCallContext_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.LogicalCallContext)___result;
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
