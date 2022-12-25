using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.CADMethodReturnMessage
	/// </summary>
    public partial class RCADMethodReturnMessage : RMember //
    {

		/// <summary>
		/// System.Object _returnValue
		/// </summary>
		protected RSystem.RObject r__returnValue;
		public virtual RSystem.RObject R_returnValue
		{
			get
			{
				if(r__returnValue == null)
				{
					r__returnValue = new(this, "_returnValue");
					r__returnValue.SetBelong(this.instance);
				}
				return r__returnValue;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.CADArgHolder _exception
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RCADArgHolder r__exception;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RCADArgHolder R_exception
		{
			get
			{
				if(r__exception == null)
				{
					r__exception = new(this, "_exception");
					r__exception.SetBelong(this.instance);
				}
				return r__exception;
			}
		}

		/// <summary>
		/// System.Type[] _sig
		/// </summary>
		protected RFieldArray<RSystem.RType> r__sig;
		public virtual RFieldArray<RSystem.RType> R_sig
		{
			get
			{
				if(r__sig == null)
				{
					r__sig = new(this, "_sig");
					r__sig.SetBelong(this.instance);
				}
				return r__sig;
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
		/// System.Runtime.Remoting.Messaging.CADMethodReturnMessage Create(System.Runtime.Remoting.Messaging.IMessage)
		/// </summary>
		protected static RMethod r_RCreate_IMessage;
		public static RMethod RCreate_IMessage
		{
			get
			{
				if(r_RCreate_IMessage == null)
				{
					r_RCreate_IMessage = new( ReleactionUtils.GetType("System.Runtime.Remoting.Messaging.CADMethodReturnMessage"), "Create", 0, typeof(System.Runtime.Remoting.Messaging.IMessage));
					r_RCreate_IMessage.SetBelong(null);
				}
				return r_RCreate_IMessage;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList GetArguments()
		/// </summary>
		protected RMethod r_RGetArguments;
		public virtual RMethod RGetArguments
		{
			get
			{
				if(r_RGetArguments == null)
				{
					r_RGetArguments = new(this, "GetArguments", 0);
					r_RGetArguments.SetBelong(this.instance);
				}
				return r_RGetArguments;
			}
		}

		/// <summary>
		/// System.Object[] GetArgs(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_RGetArgs_ArrayList;
		public virtual RMethod RGetArgs_ArrayList
		{
			get
			{
				if(r_RGetArgs_ArrayList == null)
				{
					r_RGetArgs_ArrayList = new(this, "GetArgs", 0, typeof(System.Collections.ArrayList));
					r_RGetArgs_ArrayList.SetBelong(this.instance);
				}
				return r_RGetArgs_ArrayList;
			}
		}

		/// <summary>
		/// System.Object GetReturnValue(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_RGetReturnValue_ArrayList;
		public virtual RMethod RGetReturnValue_ArrayList
		{
			get
			{
				if(r_RGetReturnValue_ArrayList == null)
				{
					r_RGetReturnValue_ArrayList = new(this, "GetReturnValue", 0, typeof(System.Collections.ArrayList));
					r_RGetReturnValue_ArrayList.SetBelong(this.instance);
				}
				return r_RGetReturnValue_ArrayList;
			}
		}

		/// <summary>
		/// System.Exception GetException(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_RGetException_ArrayList;
		public virtual RMethod RGetException_ArrayList
		{
			get
			{
				if(r_RGetException_ArrayList == null)
				{
					r_RGetException_ArrayList = new(this, "GetException", 0, typeof(System.Collections.ArrayList));
					r_RGetException_ArrayList.SetBelong(this.instance);
				}
				return r_RGetException_ArrayList;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethod()
		/// </summary>
		protected RMethod r_RGetMethod;
		public virtual RMethod RGetMethod
		{
			get
			{
				if(r_RGetMethod == null)
				{
					r_RGetMethod = new(this, "GetMethod", 0);
					r_RGetMethod.SetBelong(this.instance);
				}
				return r_RGetMethod;
			}
		}

		/// <summary>
		/// System.Object MarshalArgument(System.Object, System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_RMarshalArgument_Object_Ref_ArrayList;
		public virtual RMethod RMarshalArgument_Object_Ref_ArrayList
		{
			get
			{
				if(r_RMarshalArgument_Object_Ref_ArrayList == null)
				{
					r_RMarshalArgument_Object_Ref_ArrayList = new(this, "MarshalArgument", 0, typeof(System.Object), typeof(System.Collections.ArrayList).MakeByRefType());
					r_RMarshalArgument_Object_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_RMarshalArgument_Object_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Object UnmarshalArgument(System.Object, System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_RUnmarshalArgument_Object_ArrayList;
		public virtual RMethod RUnmarshalArgument_Object_ArrayList
		{
			get
			{
				if(r_RUnmarshalArgument_Object_ArrayList == null)
				{
					r_RUnmarshalArgument_Object_ArrayList = new(this, "UnmarshalArgument", 0, typeof(System.Object), typeof(System.Collections.ArrayList));
					r_RUnmarshalArgument_Object_ArrayList.SetBelong(this.instance);
				}
				return r_RUnmarshalArgument_Object_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] MarshalArguments(System.Object[], System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_RMarshalArguments_ObjectArray_Ref_ArrayList;
		public virtual RMethod RMarshalArguments_ObjectArray_Ref_ArrayList
		{
			get
			{
				if(r_RMarshalArguments_ObjectArray_Ref_ArrayList == null)
				{
					r_RMarshalArguments_ObjectArray_Ref_ArrayList = new(this, "MarshalArguments", 0, typeof(System.Object).MakeArrayType(), typeof(System.Collections.ArrayList).MakeByRefType());
					r_RMarshalArguments_ObjectArray_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_RMarshalArguments_ObjectArray_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Object[] UnmarshalArguments(System.Object[], System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_RUnmarshalArguments_ObjectArray_ArrayList;
		public virtual RMethod RUnmarshalArguments_ObjectArray_ArrayList
		{
			get
			{
				if(r_RUnmarshalArguments_ObjectArray_ArrayList == null)
				{
					r_RUnmarshalArguments_ObjectArray_ArrayList = new(this, "UnmarshalArguments", 0, typeof(System.Object).MakeArrayType(), typeof(System.Collections.ArrayList));
					r_RUnmarshalArguments_ObjectArray_ArrayList.SetBelong(this.instance);
				}
				return r_RUnmarshalArguments_ObjectArray_ArrayList;
			}
		}

		/// <summary>
		/// Void SaveLogicalCallContext(System.Runtime.Remoting.Messaging.IMethodMessage, System.Collections.ArrayList ByRef)
		/// </summary>
		protected RMethod r_RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList;
		public virtual RMethod RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList
		{
			get
			{
				if(r_RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList == null)
				{
					r_RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList = new(this, "SaveLogicalCallContext", 0, typeof(System.Runtime.Remoting.Messaging.IMethodMessage), typeof(System.Collections.ArrayList).MakeByRefType());
					r_RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList.SetBelong(this.instance);
				}
				return r_RSaveLogicalCallContext_IMethodMessage_Ref_ArrayList;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext GetLogicalCallContext(System.Collections.ArrayList)
		/// </summary>
		protected RMethod r_RGetLogicalCallContext_ArrayList;
		public virtual RMethod RGetLogicalCallContext_ArrayList
		{
			get
			{
				if(r_RGetLogicalCallContext_ArrayList == null)
				{
					r_RGetLogicalCallContext_ArrayList = new(this, "GetLogicalCallContext", 0, typeof(System.Collections.ArrayList));
					r_RGetLogicalCallContext_ArrayList.SetBelong(this.instance);
				}
				return r_RGetLogicalCallContext_ArrayList;
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


        public RCADMethodReturnMessage() : base("System.Runtime.Remoting.Messaging.CADMethodReturnMessage")
        {
        }

        public RCADMethodReturnMessage(System.Object instance) : base("System.Runtime.Remoting.Messaging.CADMethodReturnMessage")
		{
            SetInstance(instance);
		}

        public RCADMethodReturnMessage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCADMethodReturnMessage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.Object GetReturnValue(System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RGetReturnValue_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Exception GetException(System.Collections.ArrayList  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RGetException_ArrayList.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
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
			args = (System.Collections.ArrayList)___parameters[1];

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
			args = (System.Collections.ArrayList)___parameters[1];

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
			serializeList = (System.Collections.ArrayList)___parameters[1];

            
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
