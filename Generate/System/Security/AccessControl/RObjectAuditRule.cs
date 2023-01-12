using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.ObjectAuditRule
	/// </summary>
    public partial class RObjectAuditRule : RMember //
    {

		/// <summary>
		/// System.Guid inherited_object_type
		/// </summary>
		protected RSystem.RGuid r_Finherited_object_type;
		public virtual RSystem.RGuid RFinherited_object_type
		{
			get
			{
				if(r_Finherited_object_type == null)
				{
					r_Finherited_object_type = new(this, "inherited_object_type");
					r_Finherited_object_type.SetBelong(this.instance);
				}
				return r_Finherited_object_type;
			}
		}

		/// <summary>
		/// System.Guid object_type
		/// </summary>
		protected RSystem.RGuid r_Fobject_type;
		public virtual RSystem.RGuid RFobject_type
		{
			get
			{
				if(r_Fobject_type == null)
				{
					r_Fobject_type = new(this, "object_type");
					r_Fobject_type.SetBelong(this.instance);
				}
				return r_Fobject_type;
			}
		}

		/// <summary>
		/// System.Guid InheritedObjectType
		/// </summary>
		protected RSystem.RGuid r_PInheritedObjectType;
		public virtual RSystem.RGuid RPInheritedObjectType
		{
			get
			{
				if(r_PInheritedObjectType == null)
				{
					r_PInheritedObjectType = new(this, "InheritedObjectType", -1);
					r_PInheritedObjectType.SetBelong(this.instance);
				}
				return r_PInheritedObjectType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ObjectAceFlags ObjectFlags
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RObjectAceFlags r_PObjectFlags;
		public virtual RSystem.RSecurity.RAccessControl.RObjectAceFlags RPObjectFlags
		{
			get
			{
				if(r_PObjectFlags == null)
				{
					r_PObjectFlags = new(this, "ObjectFlags", -1);
					r_PObjectFlags.SetBelong(this.instance);
				}
				return r_PObjectFlags;
			}
		}

		/// <summary>
		/// System.Guid ObjectType
		/// </summary>
		protected RSystem.RGuid r_PObjectType;
		public virtual RSystem.RGuid RPObjectType
		{
			get
			{
				if(r_PObjectType == null)
				{
					r_PObjectType = new(this, "ObjectType", -1);
					r_PObjectType.SetBelong(this.instance);
				}
				return r_PObjectType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditFlags AuditFlags
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RAuditFlags r_PAuditFlags;
		public virtual RSystem.RSecurity.RAccessControl.RAuditFlags RPAuditFlags
		{
			get
			{
				if(r_PAuditFlags == null)
				{
					r_PAuditFlags = new(this, "AuditFlags", -1);
					r_PAuditFlags.SetBelong(this.instance);
				}
				return r_PAuditFlags;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference IdentityReference
		/// </summary>
		protected RSystem.RSecurity.RPrincipal.RIdentityReference r_PIdentityReference;
		public virtual RSystem.RSecurity.RPrincipal.RIdentityReference RPIdentityReference
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
		protected RSystem.RSecurity.RAccessControl.RInheritanceFlags r_PInheritanceFlags;
		public virtual RSystem.RSecurity.RAccessControl.RInheritanceFlags RPInheritanceFlags
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
		protected RSystem.RBoolean r_PIsInherited;
		public virtual RSystem.RBoolean RPIsInherited
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
		protected RSystem.RSecurity.RAccessControl.RPropagationFlags r_PPropagationFlags;
		public virtual RSystem.RSecurity.RAccessControl.RPropagationFlags RPPropagationFlags
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
		protected RSystem.RInt32 r_PAccessMask;
		public virtual RSystem.RInt32 RPAccessMask
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


        public RObjectAuditRule() : base("System.Security.AccessControl.ObjectAuditRule")
        {
        }

        public RObjectAuditRule(System.Object instance) : base("System.Security.AccessControl.ObjectAuditRule")
		{
            SetInstance(instance);
		}

        public RObjectAuditRule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RObjectAuditRule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
