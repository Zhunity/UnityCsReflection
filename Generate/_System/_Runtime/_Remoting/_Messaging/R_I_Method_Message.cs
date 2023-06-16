
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Remoting.Messaging.IMethodMessage
	/// </summary>
    public partial class RIMethodMessage : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Remoting.Messaging.IMethodMessage);
            }
        }

        public RIMethodMessage() : base("System.Runtime.Remoting.Messaging.IMethodMessage")
        {
        }

        public RIMethodMessage(System.Object instance) : base("System.Runtime.Remoting.Messaging.IMethodMessage")
		{
            SetInstance(instance);
		}

        public RIMethodMessage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIMethodMessage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Int32 ArgCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PArgCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPArgCount
		{
			get
			{
				if(r_PArgCount == null)
				{
					r_PArgCount = new(this, "ArgCount", -1);
				}
				return r_PArgCount;
			}
		}

		/// <summary>
		/// System.Object[] Args
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RObject> r_PArgs;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RObject> RPArgs
		{
			get
			{
				if(r_PArgs == null)
				{
					r_PArgs = new(this, "Args", -1);
				}
				return r_PArgs;
			}
		}

		/// <summary>
		/// Boolean HasVarArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasVarArgs;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasVarArgs
		{
			get
			{
				if(r_PHasVarArgs == null)
				{
					r_PHasVarArgs = new(this, "HasVarArgs", -1);
				}
				return r_PHasVarArgs;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_PLogicalCallContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RPLogicalCallContext
		{
			get
			{
				if(r_PLogicalCallContext == null)
				{
					r_PLogicalCallContext = new(this, "LogicalCallContext", -1);
				}
				return r_PLogicalCallContext;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase MethodBase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase r_PMethodBase;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase RPMethodBase
		{
			get
			{
				if(r_PMethodBase == null)
				{
					r_PMethodBase = new(this, "MethodBase", -1);
				}
				return r_PMethodBase;
			}
		}

		/// <summary>
		/// System.String MethodName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PMethodName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPMethodName
		{
			get
			{
				if(r_PMethodName == null)
				{
					r_PMethodName = new(this, "MethodName", -1);
				}
				return r_PMethodName;
			}
		}

		/// <summary>
		/// System.Object MethodSignature
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PMethodSignature;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPMethodSignature
		{
			get
			{
				if(r_PMethodSignature == null)
				{
					r_PMethodSignature = new(this, "MethodSignature", -1);
				}
				return r_PMethodSignature;
			}
		}

		/// <summary>
		/// System.String TypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTypeName
		{
			get
			{
				if(r_PTypeName == null)
				{
					r_PTypeName = new(this, "TypeName", -1);
				}
				return r_PTypeName;
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
				}
				return r_PUri;
			}
		}

		/// <summary>
		/// System.Object GetArg(Int32)
		/// </summary>
		protected RMethod r_MGetArg_Int32;
		public virtual RMethod RMGetArg_Int32
		{
			get
			{
				if(r_MGetArg_Int32 == null)
				{
					r_MGetArg_Int32 = new(this, "GetArg", 0, typeof(System.Int32));
				}
				return r_MGetArg_Int32;
			}
		}

		/// <summary>
		/// System.String GetArgName(Int32)
		/// </summary>
		protected RMethod r_MGetArgName_Int32;
		public virtual RMethod RMGetArgName_Int32
		{
			get
			{
				if(r_MGetArgName_Int32 == null)
				{
					r_MGetArgName_Int32 = new(this, "GetArgName", 0, typeof(System.Int32));
				}
				return r_MGetArgName_Int32;
			}
		}


        public virtual System.Object GetArg(System.Int32 @argNum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argNum};
            var ___result = RMGetArg_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String GetArgName(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetArgName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
