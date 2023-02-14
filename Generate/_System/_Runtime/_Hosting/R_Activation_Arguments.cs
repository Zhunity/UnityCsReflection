
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting
{
	/// <summary>
	/// System.Runtime.Hosting.ActivationArguments
	/// </summary>
    public partial class RActivationArguments : RMember //
    {

		/// <summary>
		/// System.ActivationContext _context
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RActivationContext r_F_context;
		public virtual Hvak.Editor.Refleaction.RSystem.RActivationContext RF_context
		{
			get
			{
				if(r_F_context == null)
				{
					r_F_context = new(this, "_context");
					r_F_context.SetBelong(this.instance);
				}
				return r_F_context;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity _identity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_F_identity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RF_identity
		{
			get
			{
				if(r_F_identity == null)
				{
					r_F_identity = new(this, "_identity");
					r_F_identity.SetBelong(this.instance);
				}
				return r_F_identity;
			}
		}

		/// <summary>
		/// System.String[] _data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_F_data;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RF_data
		{
			get
			{
				if(r_F_data == null)
				{
					r_F_data = new(this, "_data");
					r_F_data.SetBelong(this.instance);
				}
				return r_F_data;
			}
		}

		/// <summary>
		/// System.ActivationContext ActivationContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RActivationContext r_PActivationContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RActivationContext RPActivationContext
		{
			get
			{
				if(r_PActivationContext == null)
				{
					r_PActivationContext = new(this, "ActivationContext", -1);
					r_PActivationContext.SetBelong(this.instance);
				}
				return r_PActivationContext;
			}
		}

		/// <summary>
		/// System.String[] ActivationData
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PActivationData;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPActivationData
		{
			get
			{
				if(r_PActivationData == null)
				{
					r_PActivationData = new(this, "ActivationData", -1);
					r_PActivationData.SetBelong(this.instance);
				}
				return r_PActivationData;
			}
		}

		/// <summary>
		/// System.ApplicationIdentity ApplicationIdentity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RApplicationIdentity r_PApplicationIdentity;
		public virtual Hvak.Editor.Refleaction.RSystem.RApplicationIdentity RPApplicationIdentity
		{
			get
			{
				if(r_PApplicationIdentity == null)
				{
					r_PApplicationIdentity = new(this, "ApplicationIdentity", -1);
					r_PApplicationIdentity.SetBelong(this.instance);
				}
				return r_PApplicationIdentity;
			}
		}

		/// <summary>
		/// System.Security.Policy.EvidenceBase Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
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
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.EvidenceBase)___result;
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
