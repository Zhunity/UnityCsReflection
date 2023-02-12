
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PArgCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPArgCount
		{
			get
			{
				if(r_PArgCount == null)
				{
					r_PArgCount = new(this, "ArgCount", -1);
					r_PArgCount.SetBelong(this.instance);
				}
				return r_PArgCount;
			}
		}

		/// <summary>
		/// System.Object[] Args
		/// </summary>
		protected SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RObject> r_PArgs;
		public virtual SMFrame.Editor.Refleaction.RPropertyArray<SMFrame.Editor.Refleaction.RSystem.RObject> RPArgs
		{
			get
			{
				if(r_PArgs == null)
				{
					r_PArgs = new(this, "Args", -1);
					r_PArgs.SetBelong(this.instance);
				}
				return r_PArgs;
			}
		}

		/// <summary>
		/// Boolean HasVarArgs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PHasVarArgs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPHasVarArgs
		{
			get
			{
				if(r_PHasVarArgs == null)
				{
					r_PHasVarArgs = new(this, "HasVarArgs", -1);
					r_PHasVarArgs.SetBelong(this.instance);
				}
				return r_PHasVarArgs;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_PLogicalCallContext;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RPLogicalCallContext
		{
			get
			{
				if(r_PLogicalCallContext == null)
				{
					r_PLogicalCallContext = new(this, "LogicalCallContext", -1);
					r_PLogicalCallContext.SetBelong(this.instance);
				}
				return r_PLogicalCallContext;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase MethodBase
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodBase r_PMethodBase;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodBase RPMethodBase
		{
			get
			{
				if(r_PMethodBase == null)
				{
					r_PMethodBase = new(this, "MethodBase", -1);
					r_PMethodBase.SetBelong(this.instance);
				}
				return r_PMethodBase;
			}
		}

		/// <summary>
		/// System.String MethodName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PMethodName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPMethodName
		{
			get
			{
				if(r_PMethodName == null)
				{
					r_PMethodName = new(this, "MethodName", -1);
					r_PMethodName.SetBelong(this.instance);
				}
				return r_PMethodName;
			}
		}

		/// <summary>
		/// System.Object MethodSignature
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PMethodSignature;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPMethodSignature
		{
			get
			{
				if(r_PMethodSignature == null)
				{
					r_PMethodSignature = new(this, "MethodSignature", -1);
					r_PMethodSignature.SetBelong(this.instance);
				}
				return r_PMethodSignature;
			}
		}

		/// <summary>
		/// System.String TypeName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PTypeName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPTypeName
		{
			get
			{
				if(r_PTypeName == null)
				{
					r_PTypeName = new(this, "TypeName", -1);
					r_PTypeName.SetBelong(this.instance);
				}
				return r_PTypeName;
			}
		}

		/// <summary>
		/// System.String Uri
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PUri;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPUri
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
					r_MGetArg_Int32.SetBelong(this.instance);
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
					r_MGetArgName_Int32.SetBelong(this.instance);
				}
				return r_MGetArgName_Int32;
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

        public virtual System.Object GetArg(System.Int32 @argNum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argNum};
            var ___result = RMGetArg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetArgName(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetArgName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
