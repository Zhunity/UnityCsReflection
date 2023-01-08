using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.CADMethodCallMessage
	/// </summary>
    public partial class RCADMethodCallMessage : RMember //
    {

		/// <summary>
		/// System.String _uri
		/// </summary>
		protected RField r__uri;
		public virtual RField R_uri
		{
			get
			{
				if(r__uri == null)
				{
					r__uri = new(this, "_uri");
					r__uri.SetBelong(this.instance);
				}
				return r__uri;
			}
		}

		/// <summary>
		/// System.Object[] _args
		/// </summary>
		protected RFieldArray<RSystem.RObject> r__args;
		public virtual RFieldArray<RSystem.RObject> R_args
		{
			get
			{
				if(r__args == null)
				{
					r__args = new(this, "_args");
					r__args.SetBelong(this.instance);
				}
				return r__args;
			}
		}

		/// <summary>
		/// System.Byte[] _serializedArgs
		/// </summary>
		protected RFieldArray<RField> r__serializedArgs;
		public virtual RFieldArray<RField> R_serializedArgs
		{
			get
			{
				if(r__serializedArgs == null)
				{
					r__serializedArgs = new(this, "_serializedArgs");
					r__serializedArgs.SetBelong(this.instance);
				}
				return r__serializedArgs;
			}
		}

		/// <summary>
		/// System.Int32 _propertyCount
		/// </summary>
		protected RField r__propertyCount;
		public virtual RField R_propertyCount
		{
			get
			{
				if(r__propertyCount == null)
				{
					r__propertyCount = new(this, "_propertyCount");
					r__propertyCount.SetBelong(this.instance);
				}
				return r__propertyCount;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CADArgHolder _callContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RCADArgHolder r__callContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RCADArgHolder R_callContext
		{
			get
			{
				if(r__callContext == null)
				{
					r__callContext = new(this, "_callContext");
					r__callContext.SetBelong(this.instance);
				}
				return r__callContext;
			}
		}

		/// <summary>
		/// System.Byte[] serializedMethod
		/// </summary>
		protected RFieldArray<RField> r_serializedMethod;
		public virtual RFieldArray<RField> RserializedMethod
		{
			get
			{
				if(r_serializedMethod == null)
				{
					r_serializedMethod = new(this, "serializedMethod");
					r_serializedMethod.SetBelong(this.instance);
				}
				return r_serializedMethod;
			}
		}

		/// <summary>
		/// System.String Uri
		/// </summary>
		protected RProperty r_Uri;
		public virtual RProperty RUri
		{
			get
			{
				if(r_Uri == null)
				{
					r_Uri = new(this, "Uri", -1);
					r_Uri.SetBelong(this.instance);
				}
				return r_Uri;
			}
		}

		/// <summary>
		/// Int32 PropertiesCount
		/// </summary>
		protected RProperty r_PropertiesCount;
		public virtual RProperty RPropertiesCount
		{
			get
			{
				if(r_PropertiesCount == null)
				{
					r_PropertiesCount = new(this, "PropertiesCount", -1);
					r_PropertiesCount.SetBelong(this.instance);
				}
				return r_PropertiesCount;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CADMethodCallMessage Create(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected static RMethod r_Create_IMessage;
		public static RMethod RCreate_IMessage
		{
			get
			{
				if(r_Create_IMessage == null)
				{
					r_Create_IMessage = new( ReflectionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodCallMessage"), "Create", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_Create_IMessage.SetBelong(null);
				}
				return r_Create_IMessage;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList GetArguments()
		/// </summary>
		protected RMethod r_GetArguments;
		public virtual RMethod RGetArguments
		{
			get
			{
				if(r_GetArguments == null)
				{
					r_GetArguments = new(this, "GetArguments", 0);
					r_GetArguments.SetBelong(this.instance);
				}
				return r_GetArguments;
			}
		}

		/// <summary>
		/// System.Object[] GetArgs(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_GetArgs_ArrayList;
		public virtual RMethod RGetArgs_ArrayList
		{
			get
			{
				if(r_GetArgs_ArrayList == null)
				{
					r_GetArgs_ArrayList = new(this, "GetArgs", 0, typeof(System.Collections.ArrayList));
					r_GetArgs_ArrayList.SetBelong(this.instance);
				}
				return r_GetArgs_ArrayList;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethod()
		/// </summary>
		protected RMethod r_GetMethod;
		public virtual RMethod RGetMethod
		{
			get
			{
				if(r_GetMethod == null)
				{
					r_GetMethod = new(this, "GetMethod", 0);
					r_GetMethod.SetBelong(this.instance);
				}
				return r_GetMethod;
			}
		}

		/// <summary>
		/// System.Object MarshalArgument(System.Object, System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_MarshalArgument_Object_Ref_ArrayList;
		public virtual RMethod RMarshalArgument_Object_Ref_ArrayList
		{
			get
			{
				if(r_MarshalArgument_Object_Ref_ArrayList == null)
				{
					r_MarshalArgument_Object_Ref_ArrayList = new(this, "MarshalArgument", 0, typeof(System.Object), typeof(System.Collections.ArrayList).MakeByRefType());
					r_MarshalArgument_Object_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_MarshalArgument_Object_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Object UnmarshalArgument(System.Object, System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_UnmarshalArgument_Object_ArrayList;
		public virtual RMethod RUnmarshalArgument_Object_ArrayList
		{
			get
			{
				if(r_UnmarshalArgument_Object_ArrayList == null)
				{
					r_UnmarshalArgument_Object_ArrayList = new(this, "UnmarshalArgument", 0, typeof(System.Object), typeof(System.Collections.ArrayList));
					r_UnmarshalArgument_Object_ArrayList.SetBelong(this.instance);
				}
				return r_UnmarshalArgument_Object_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] MarshalArguments(System.Object[], System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_MarshalArguments_ObjectArray_Ref_ArrayList;
		public virtual RMethod RMarshalArguments_ObjectArray_Ref_ArrayList
		{
			get
			{
				if(r_MarshalArguments_ObjectArray_Ref_ArrayList == null)
				{
					r_MarshalArguments_ObjectArray_Ref_ArrayList = new(this, "MarshalArguments", 0, typeof(System.Object).MakeArrayType(), typeof(System.Collections.ArrayList).MakeByRefType());
					r_MarshalArguments_ObjectArray_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_MarshalArguments_ObjectArray_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] UnmarshalArguments(System.Object[], System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_UnmarshalArguments_ObjectArray_ArrayList;
		public virtual RMethod RUnmarshalArguments_ObjectArray_ArrayList
		{
			get
			{
				if(r_UnmarshalArguments_ObjectArray_ArrayList == null)
				{
					r_UnmarshalArguments_ObjectArray_ArrayList = new(this, "UnmarshalArguments", 0, typeof(System.Object).MakeArrayType(), typeof(System.Collections.ArrayList));
					r_UnmarshalArguments_ObjectArray_ArrayList.SetBelong(this.instance);
				}
				return r_UnmarshalArguments_ObjectArray_ArrayList;
			}
		}

		/// <summary>
		/// Void SaveLogicalCallContext(System.Runtime.Remoting.Messaging.IMethodMessage, System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_SaveLogicalCallContext_IMethodMessage_Ref_ArrayList;
		public virtual RMethod RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList
		{
			get
			{
				if(r_SaveLogicalCallContext_IMethodMessage_Ref_ArrayList == null)
				{
					r_SaveLogicalCallContext_IMethodMessage_Ref_ArrayList = new(this, "SaveLogicalCallContext", 0, typeof(System.Runtime.Remoting.Messaging.IMethodMessage), typeof(System.Collections.ArrayList).MakeByRefType());
					r_SaveLogicalCallContext_IMethodMessage_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_SaveLogicalCallContext_IMethodMessage_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext GetLogicalCallContext(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_GetLogicalCallContext_ArrayList;
		public virtual RMethod RGetLogicalCallContext_ArrayList
		{
			get
			{
				if(r_GetLogicalCallContext_ArrayList == null)
				{
					r_GetLogicalCallContext_ArrayList = new(this, "GetLogicalCallContext", 0, typeof(System.Collections.ArrayList));
					r_GetLogicalCallContext_ArrayList.SetBelong(this.instance);
				}
				return r_GetLogicalCallContext_ArrayList;
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

        public static System.Object Create(System.Runtime.Remoting.Messaging.IMessage  @callMsg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callMsg};
            var ___result = RCreate_IMessage.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.ArrayList GetArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetArguments.Invoke(___genericsType, ___parameters);

            return (System.Collections.ArrayList)___result;
        }


        public virtual System.Object[] GetArgs(System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RGetArgs_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.MethodBase GetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Object MarshalArgument(System.Object  @arg, ref System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @args};
            var ___result = RMarshalArgument_Object_Ref_ArrayList.Invoke(___genericsType, ___parameters);
			@args = (System.Collections.ArrayList)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Object UnmarshalArgument(System.Object  @arg, System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg, @args};
            var ___result = RUnmarshalArgument_Object_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object[] MarshalArguments(System.Object[]  @arguments, ref System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments, @args};
            var ___result = RMarshalArguments_ObjectArray_Ref_ArrayList.Invoke(___genericsType, ___parameters);
			@args = (System.Collections.ArrayList)___parameters[1];

            return (System.Object[])___result;
        }


        public virtual System.Object[] UnmarshalArguments(System.Object[]  @arguments, System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments, @args};
            var ___result = RUnmarshalArguments_ObjectArray_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual void SaveLogicalCallContext(System.Runtime.Remoting.Messaging.IMethodMessage  @msg, ref System.Collections.ArrayList  @serializeList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msg, @serializeList};
            var ___result = RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList.Invoke(___genericsType, ___parameters);
			@serializeList = (System.Collections.ArrayList)___parameters[1];

            
        }


        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext GetLogicalCallContext(System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RGetLogicalCallContext_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.LogicalCallContext)___result;
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
