using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.PolicyStatement
	/// </summary>
    public partial class RPolicyStatement : RMember //
    {

		/// <summary>
		/// System.Security.PermissionSet perms
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_Fperms;
		public virtual RSystem.RSecurity.RPermissionSet RFperms
		{
			get
			{
				if(r_Fperms == null)
				{
					r_Fperms = new(this, "perms");
					r_Fperms.SetBelong(this.instance);
				}
				return r_Fperms;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatementAttribute attrs
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyStatementAttribute r_Fattrs;
		public virtual RSystem.RSecurity.RPolicy.RPolicyStatementAttribute RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
					r_Fattrs.SetBelong(this.instance);
				}
				return r_Fattrs;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet PermissionSet
		/// </summary>
		protected RSystem.RSecurity.RPermissionSet r_PPermissionSet;
		public virtual RSystem.RSecurity.RPermissionSet RPPermissionSet
		{
			get
			{
				if(r_PPermissionSet == null)
				{
					r_PPermissionSet = new(this, "PermissionSet", -1);
					r_PPermissionSet.SetBelong(this.instance);
				}
				return r_PPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatementAttribute Attributes
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyStatementAttribute r_PAttributes;
		public virtual RSystem.RSecurity.RPolicy.RPolicyStatementAttribute RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// System.String AttributeString
		/// </summary>
		protected RSystem.RString r_PAttributeString;
		public virtual RSystem.RString RPAttributeString
		{
			get
			{
				if(r_PAttributeString == null)
				{
					r_PAttributeString = new(this, "AttributeString", -1);
					r_PAttributeString.SetBelong(this.instance);
				}
				return r_PAttributeString;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.instance);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement;
		public virtual RMethod RMFromXml_SecurityElement
		{
			get
			{
				if(r_MFromXml_SecurityElement == null)
				{
					r_MFromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_MFromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_MFromXml_SecurityElement;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement_PolicyLevel;
		public virtual RMethod RMFromXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_MFromXml_SecurityElement_PolicyLevel == null)
				{
					r_MFromXml_SecurityElement_PolicyLevel = new(this, "FromXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
					r_MFromXml_SecurityElement_PolicyLevel.SetBelong(this.instance);
				}
				return r_MFromXml_SecurityElement_PolicyLevel;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_MToXml;
		public virtual RMethod RMToXml
		{
			get
			{
				if(r_MToXml == null)
				{
					r_MToXml = new(this, "ToXml", 0);
					r_MToXml.SetBelong(this.instance);
				}
				return r_MToXml;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MToXml_PolicyLevel;
		public virtual RMethod RMToXml_PolicyLevel
		{
			get
			{
				if(r_MToXml_PolicyLevel == null)
				{
					r_MToXml_PolicyLevel = new(this, "ToXml", 0, typeof(System.Security.Policy.PolicyLevel));
					r_MToXml_PolicyLevel.SetBelong(this.instance);
				}
				return r_MToXml_PolicyLevel;
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
		/// System.Security.Policy.PolicyStatement Empty()
		/// </summary>
		protected static RMethod r_MEmpty;
		public static RMethod RMEmpty
		{
			get
			{
				if(r_MEmpty == null)
				{
					r_MEmpty = new(typeof(System.Security.Policy.PolicyStatement), "Empty", 0);
					r_MEmpty.SetBelong(null);
				}
				return r_MEmpty;
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


        public RPolicyStatement() : base("System.Security.Policy.PolicyStatement")
        {
        }

        public RPolicyStatement(System.Object instance) : base("System.Security.Policy.PolicyStatement")
		{
            SetInstance(instance);
		}

        public RPolicyStatement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPolicyStatement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.Policy.PolicyStatement Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @et)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @et, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et, @level};
            var ___result = RMFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RMToXml_PolicyLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
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


        public static System.Security.Policy.PolicyStatement Empty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEmpty.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
