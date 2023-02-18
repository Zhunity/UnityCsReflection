
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{public partial class RLogicalCallContext
{
	
	/// <summary>
	/// System.Runtime.Remoting.Messaging.LogicalCallContext+Reader
	/// </summary>
    public partial class RReader : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext m_ctx
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext r_Fm_ctx;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging.RLogicalCallContext RFm_ctx
		{
			get
			{
				if(r_Fm_ctx == null)
				{
					r_Fm_ctx = new(this, "m_ctx");
					r_Fm_ctx.SetBelong(this.GetValue());
				}
				return r_Fm_ctx;
			}
		}

		/// <summary>
		/// Boolean IsNull
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNull;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNull
		{
			get
			{
				if(r_PIsNull == null)
				{
					r_PIsNull = new(this, "IsNull", -1);
					r_PIsNull.SetBelong(this.GetValue());
				}
				return r_PIsNull;
			}
		}

		/// <summary>
		/// Boolean HasInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasInfo
		{
			get
			{
				if(r_PHasInfo == null)
				{
					r_PHasInfo = new(this, "HasInfo", -1);
					r_PHasInfo.SetBelong(this.GetValue());
				}
				return r_PHasInfo;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal Principal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_PPrincipal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RPPrincipal
		{
			get
			{
				if(r_PPrincipal == null)
				{
					r_PPrincipal = new(this, "Principal", -1);
					r_PPrincipal.SetBelong(this.GetValue());
				}
				return r_PPrincipal;
			}
		}

		/// <summary>
		/// System.Object HostContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PHostContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPHostContext
		{
			get
			{
				if(r_PHostContext == null)
				{
					r_PHostContext = new(this, "HostContext", -1);
					r_PHostContext.SetBelong(this.GetValue());
				}
				return r_PHostContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Messaging.LogicalCallContext Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.GetValue());
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// System.Object GetData(System.String)
		/// </summary>
		protected RMethod r_MGetData_String;
		public virtual RMethod RMGetData_String
		{
			get
			{
				if(r_MGetData_String == null)
				{
					r_MGetData_String = new(this, "GetData", 0, typeof(System.String));
					r_MGetData_String.SetBelong(this.GetValue());
				}
				return r_MGetData_String;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RReader() : base("System.Runtime.Remoting.Messaging.LogicalCallContext+Reader")
        {
        }

        public RReader(System.Object instance) : base("System.Runtime.Remoting.Messaging.LogicalCallContext+Reader")
		{
            SetInstance(instance);
		}

        public RReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.Messaging.LogicalCallContext)___result;
        }


        public virtual System.Object GetData(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}