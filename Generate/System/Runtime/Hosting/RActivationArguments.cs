using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RHosting
{
	/// <summary>
	/// System.Runtime.Hosting.ActivationArguments
	/// </summary>
    public partial class RActivationArguments : RMember //
    {

		/// <summary>
		/// System.ActivationContext _context
		/// </summary>
		protected RSystem.RActivationContext r__context;
		public virtual RSystem.RActivationContext R_context
		{
			get
			{
				if(r__context == null)
				{
					r__context = new(this, "_context");
					r__context.SetBelong(this.instance);
				}
				return r__context;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity _identity
		/// </summary>
		protected RSystem.RApplicationIdentity r__identity;
		public virtual RSystem.RApplicationIdentity R_identity
		{
			get
			{
				if(r__identity == null)
				{
					r__identity = new(this, "_identity");
					r__identity.SetBelong(this.instance);
				}
				return r__identity;
			}
		}

		/// <summary>
		/// System.String[] _data
		/// </summary>
		protected RFieldArray<RField> r__data;
		public virtual RFieldArray<RField> R_data
		{
			get
			{
				if(r__data == null)
				{
					r__data = new(this, "_data");
					r__data.SetBelong(this.instance);
				}
				return r__data;
			}
		}

		/// <summary>
		/// System.ActivationContext ActivationContext
		/// </summary>
		protected RSystem.RActivationContext r_ActivationContext;
		public virtual RSystem.RActivationContext RActivationContext
		{
			get
			{
				if(r_ActivationContext == null)
				{
					r_ActivationContext = new(this, "ActivationContext", -1);
					r_ActivationContext.SetBelong(this.instance);
				}
				return r_ActivationContext;
			}
		}

		/// <summary>
		/// System.String[] ActivationData
		/// </summary>
		protected RPropertyArray<RProperty> r_ActivationData;
		public virtual RPropertyArray<RProperty> RActivationData
		{
			get
			{
				if(r_ActivationData == null)
				{
					r_ActivationData = new(this, "ActivationData", -1);
					r_ActivationData.SetBelong(this.instance);
				}
				return r_ActivationData;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity ApplicationIdentity
		/// </summary>
		protected RSystem.RApplicationIdentity r_ApplicationIdentity;
		public virtual RSystem.RApplicationIdentity RApplicationIdentity
		{
			get
			{
				if(r_ApplicationIdentity == null)
				{
					r_ApplicationIdentity = new(this, "ApplicationIdentity", -1);
					r_ApplicationIdentity.SetBelong(this.instance);
				}
				return r_ApplicationIdentity;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
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


        public RActivationArguments() : base("System.Runtime.Hosting.ActivationArguments")
        {
        }

        public RActivationArguments(System.Object instance) : base("System.Runtime.Hosting.ActivationArguments")
		{
            SetInstance(instance);
		}

        public RActivationArguments(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RActivationArguments(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.Policy.EvidenceBase Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
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
