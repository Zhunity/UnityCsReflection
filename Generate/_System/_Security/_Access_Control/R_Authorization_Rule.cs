
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.AuthorizationRule
	/// </summary>
    public partial class RAuthorizationRule : RMember //
    {

		/// <summary>
		/// System.Security.Principal.IdentityReference identity
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIdentityReference r_Fidentity;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIdentityReference RFidentity
		{
			get
			{
				if(r_Fidentity == null)
				{
					r_Fidentity = new(this, "identity");
					r_Fidentity.SetBelong(this.instance);
				}
				return r_Fidentity;
			}
		}

		/// <summary>
		/// System.Int32 accessMask
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FaccessMask;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFaccessMask
		{
			get
			{
				if(r_FaccessMask == null)
				{
					r_FaccessMask = new(this, "accessMask");
					r_FaccessMask.SetBelong(this.instance);
				}
				return r_FaccessMask;
			}
		}

		/// <summary>
		/// System.Boolean isInherited
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisInherited;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFisInherited
		{
			get
			{
				if(r_FisInherited == null)
				{
					r_FisInherited = new(this, "isInherited");
					r_FisInherited.SetBelong(this.instance);
				}
				return r_FisInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags inheritanceFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags r_FinheritanceFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags RFinheritanceFlags
		{
			get
			{
				if(r_FinheritanceFlags == null)
				{
					r_FinheritanceFlags = new(this, "inheritanceFlags");
					r_FinheritanceFlags.SetBelong(this.instance);
				}
				return r_FinheritanceFlags;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags propagationFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags r_FpropagationFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags RFpropagationFlags
		{
			get
			{
				if(r_FpropagationFlags == null)
				{
					r_FpropagationFlags = new(this, "propagationFlags");
					r_FpropagationFlags.SetBelong(this.instance);
				}
				return r_FpropagationFlags;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference IdentityReference
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIdentityReference r_PIdentityReference;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIdentityReference RPIdentityReference
		{
			get
			{
				if(r_PIdentityReference == null)
				{
					r_PIdentityReference = new(this, "IdentityReference", -1);
					r_PIdentityReference.SetBelong(this.instance);
				}
				return r_PIdentityReference;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.InheritanceFlags InheritanceFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags r_PInheritanceFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RInheritanceFlags RPInheritanceFlags
		{
			get
			{
				if(r_PInheritanceFlags == null)
				{
					r_PInheritanceFlags = new(this, "InheritanceFlags", -1);
					r_PInheritanceFlags.SetBelong(this.instance);
				}
				return r_PInheritanceFlags;
			}
		}

		/// <summary>
		/// Boolean IsInherited
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsInherited;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsInherited
		{
			get
			{
				if(r_PIsInherited == null)
				{
					r_PIsInherited = new(this, "IsInherited", -1);
					r_PIsInherited.SetBelong(this.instance);
				}
				return r_PIsInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.PropagationFlags PropagationFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags r_PPropagationFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RPropagationFlags RPPropagationFlags
		{
			get
			{
				if(r_PPropagationFlags == null)
				{
					r_PPropagationFlags = new(this, "PropagationFlags", -1);
					r_PPropagationFlags.SetBelong(this.instance);
				}
				return r_PPropagationFlags;
			}
		}

		/// <summary>
		/// Int32 AccessMask
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PAccessMask;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPAccessMask
		{
			get
			{
				if(r_PAccessMask == null)
				{
					r_PAccessMask = new(this, "AccessMask", -1);
					r_PAccessMask.SetBelong(this.instance);
				}
				return r_PAccessMask;
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


        public RAuthorizationRule() : base("System.Security.AccessControl.AuthorizationRule")
        {
        }

        public RAuthorizationRule(System.Object instance) : base("System.Security.AccessControl.AuthorizationRule")
		{
            SetInstance(instance);
		}

        public RAuthorizationRule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAuthorizationRule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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