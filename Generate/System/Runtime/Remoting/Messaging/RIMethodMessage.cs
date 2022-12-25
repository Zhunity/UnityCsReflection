using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.IMethodMessage
	/// </summary>
    public partial class RIMethodMessage : RMember //
    {

		/// <summary>
		/// Int32 ArgCount
		/// </summary>
		protected RProperty r_ArgCount;
		public virtual RProperty RArgCount
		{
			get
			{
				if(r_ArgCount == null)
				{
					r_ArgCount = new(this, "ArgCount", -1);
					r_ArgCount.SetBelong(this.instance);
				}
				return r_ArgCount;
			}
		}

		/// <summary>
		/// System.Object[] Args
		/// </summary>
		protected RPropertyArray<RSystem.RObject> r_Args;
		public virtual RPropertyArray<RSystem.RObject> RArgs
		{
			get
			{
				if(r_Args == null)
				{
					r_Args = new(this, "Args", -1);
					r_Args.SetBelong(this.instance);
				}
				return r_Args;
			}
		}

		/// <summary>
		/// Boolean HasVarArgs
		/// </summary>
		protected RProperty r_HasVarArgs;
		public virtual RProperty RHasVarArgs
		{
			get
			{
				if(r_HasVarArgs == null)
				{
					r_HasVarArgs = new(this, "HasVarArgs", -1);
					r_HasVarArgs.SetBelong(this.instance);
				}
				return r_HasVarArgs;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_LogicalCallContext;
		public virtual RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RLogicalCallContext
		{
			get
			{
				if(r_LogicalCallContext == null)
				{
					r_LogicalCallContext = new(this, "LogicalCallContext", -1);
					r_LogicalCallContext.SetBelong(this.instance);
				}
				return r_LogicalCallContext;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase MethodBase
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_MethodBase;
		public virtual RSystem.RReflection.RMethodBase RMethodBase
		{
			get
			{
				if(r_MethodBase == null)
				{
					r_MethodBase = new(this, "MethodBase", -1);
					r_MethodBase.SetBelong(this.instance);
				}
				return r_MethodBase;
			}
		}

		/// <summary>
		/// System.String MethodName
		/// </summary>
		protected RProperty r_MethodName;
		public virtual RProperty RMethodName
		{
			get
			{
				if(r_MethodName == null)
				{
					r_MethodName = new(this, "MethodName", -1);
					r_MethodName.SetBelong(this.instance);
				}
				return r_MethodName;
			}
		}

		/// <summary>
		/// System.Object MethodSignature
		/// </summary>
		protected RSystem.RObject r_MethodSignature;
		public virtual RSystem.RObject RMethodSignature
		{
			get
			{
				if(r_MethodSignature == null)
				{
					r_MethodSignature = new(this, "MethodSignature", -1);
					r_MethodSignature.SetBelong(this.instance);
				}
				return r_MethodSignature;
			}
		}

		/// <summary>
		/// System.String TypeName
		/// </summary>
		protected RProperty r_TypeName;
		public virtual RProperty RTypeName
		{
			get
			{
				if(r_TypeName == null)
				{
					r_TypeName = new(this, "TypeName", -1);
					r_TypeName.SetBelong(this.instance);
				}
				return r_TypeName;
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
		/// System.Object GetArg(Int32)
		/// </summary>
		protected RMethod r_RGetArg_Int32;
		public virtual RMethod RGetArg_Int32
		{
			get
			{
				if(r_RGetArg_Int32 == null)
				{
					r_RGetArg_Int32 = new(this, "GetArg", 0, typeof(System.Int32));
					r_RGetArg_Int32.SetBelong(this.instance);
				}
				return r_RGetArg_Int32;
			}
		}

		/// <summary>
		/// System.String GetArgName(Int32)
		/// </summary>
		protected RMethod r_RGetArgName_Int32;
		public virtual RMethod RGetArgName_Int32
		{
			get
			{
				if(r_RGetArgName_Int32 == null)
				{
					r_RGetArgName_Int32 = new(this, "GetArgName", 0, typeof(System.Int32));
					r_RGetArgName_Int32.SetBelong(this.instance);
				}
				return r_RGetArgName_Int32;
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

        public virtual System.Object GetArg(System.Int32  @argNum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argNum};
            var ___result = RGetArg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetArgName(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetArgName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
