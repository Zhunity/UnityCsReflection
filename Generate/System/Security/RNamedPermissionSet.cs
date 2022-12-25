using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.NamedPermissionSet
	/// </summary>
    public partial class RNamedPermissionSet : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected RField r_description;
		public virtual RField Rdescription
		{
			get
			{
				if(r_description == null)
				{
					r_description = new(this, "description");
					r_description.SetBelong(this.instance);
				}
				return r_description;
			}
		}

		/// <summary>
		/// System.String Description
		/// </summary>
		protected RProperty r_Description;
		public virtual RProperty RDescription
		{
			get
			{
				if(r_Description == null)
				{
					r_Description = new(this, "Description", -1);
					r_Description.SetBelong(this.instance);
				}
				return r_Description;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
			}
		}

		/// <summary>
		/// Boolean DeclarativeSecurity
		/// </summary>
		protected RProperty r_DeclarativeSecurity;
		public virtual RProperty RDeclarativeSecurity
		{
			get
			{
				if(r_DeclarativeSecurity == null)
				{
					r_DeclarativeSecurity = new(this, "DeclarativeSecurity", -1);
					r_DeclarativeSecurity.SetBelong(this.instance);
				}
				return r_DeclarativeSecurity;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel Resolver
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RPolicyLevel r_Resolver;
		public virtual RSystem.RSecurity.RPolicy.RPolicyLevel Resolver
		{
			get
			{
				if(r_Resolver == null)
				{
					r_Resolver = new(this, "Resolver", -1);
					r_Resolver.SetBelong(this.instance);
				}
				return r_Resolver;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet Copy(System.String)
		/// </summary>
		protected RMethod r_RCopy_String;
		public virtual RMethod RCopy_String
		{
			get
			{
				if(r_RCopy_String == null)
				{
					r_RCopy_String = new(this, "Copy", 0, typeof(System.String));
					r_RCopy_String.SetBelong(this.instance);
				}
				return r_RCopy_String;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_RFromXml_SecurityElement;
		public virtual RMethod RFromXml_SecurityElement
		{
			get
			{
				if(r_RFromXml_SecurityElement == null)
				{
					r_RFromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_RFromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_RFromXml_SecurityElement;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_RToXml;
		public virtual RMethod RToXml
		{
			get
			{
				if(r_RToXml == null)
				{
					r_RToXml = new(this, "ToXml", 0);
					r_RToXml.SetBelong(this.instance);
				}
				return r_RToXml;
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
		/// System.Security.IPermission AddPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RAddPermission_IPermission;
		public virtual RMethod RAddPermission_IPermission
		{
			get
			{
				if(r_RAddPermission_IPermission == null)
				{
					r_RAddPermission_IPermission = new(this, "AddPermission", 0, typeof(System.Security.IPermission));
					r_RAddPermission_IPermission.SetBelong(this.instance);
				}
				return r_RAddPermission_IPermission;
			}
		}

		/// <summary>
		/// Void Assert()
		/// </summary>
		protected RMethod r_RAssert;
		public virtual RMethod RAssert
		{
			get
			{
				if(r_RAssert == null)
				{
					r_RAssert = new(this, "Assert", 0);
					r_RAssert.SetBelong(this.instance);
				}
				return r_RAssert;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_RCopyTo_Array_Int32 == null)
				{
					r_RCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_RDemand;
		public virtual RMethod RDemand
		{
			get
			{
				if(r_RDemand == null)
				{
					r_RDemand = new(this, "Demand", 0);
					r_RDemand.SetBelong(this.instance);
				}
				return r_RDemand;
			}
		}

		/// <summary>
		/// Void CasOnlyDemand(Int32)
		/// </summary>
		protected RMethod r_RCasOnlyDemand_Int32;
		public virtual RMethod RCasOnlyDemand_Int32
		{
			get
			{
				if(r_RCasOnlyDemand_Int32 == null)
				{
					r_RCasOnlyDemand_Int32 = new(this, "CasOnlyDemand", 0, typeof(System.Int32));
					r_RCasOnlyDemand_Int32.SetBelong(this.instance);
				}
				return r_RCasOnlyDemand_Int32;
			}
		}

		/// <summary>
		/// Void Deny()
		/// </summary>
		protected RMethod r_RDeny;
		public virtual RMethod RDeny
		{
			get
			{
				if(r_RDeny == null)
				{
					r_RDeny = new(this, "Deny", 0);
					r_RDeny.SetBelong(this.instance);
				}
				return r_RDeny;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RIsSubsetOf_PermissionSet;
		public virtual RMethod RIsSubsetOf_PermissionSet
		{
			get
			{
				if(r_RIsSubsetOf_PermissionSet == null)
				{
					r_RIsSubsetOf_PermissionSet = new(this, "IsSubsetOf", 0, typeof(System.Security.PermissionSet));
					r_RIsSubsetOf_PermissionSet.SetBelong(this.instance);
				}
				return r_RIsSubsetOf_PermissionSet;
			}
		}

		/// <summary>
		/// Void PermitOnly()
		/// </summary>
		protected RMethod r_RPermitOnly;
		public virtual RMethod RPermitOnly
		{
			get
			{
				if(r_RPermitOnly == null)
				{
					r_RPermitOnly = new(this, "PermitOnly", 0);
					r_RPermitOnly.SetBelong(this.instance);
				}
				return r_RPermitOnly;
			}
		}

		/// <summary>
		/// Boolean ContainsNonCodeAccessPermissions()
		/// </summary>
		protected RMethod r_RContainsNonCodeAccessPermissions;
		public virtual RMethod RContainsNonCodeAccessPermissions
		{
			get
			{
				if(r_RContainsNonCodeAccessPermissions == null)
				{
					r_RContainsNonCodeAccessPermissions = new(this, "ContainsNonCodeAccessPermissions", 0);
					r_RContainsNonCodeAccessPermissions.SetBelong(this.instance);
				}
				return r_RContainsNonCodeAccessPermissions;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermission(System.Type)
		/// </summary>
		protected RMethod r_RGetPermission_Type;
		public virtual RMethod RGetPermission_Type
		{
			get
			{
				if(r_RGetPermission_Type == null)
				{
					r_RGetPermission_Type = new(this, "GetPermission", 0, typeof(System.Type));
					r_RGetPermission_Type.SetBelong(this.instance);
				}
				return r_RGetPermission_Type;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Intersect(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RIntersect_PermissionSet;
		public virtual RMethod RIntersect_PermissionSet
		{
			get
			{
				if(r_RIntersect_PermissionSet == null)
				{
					r_RIntersect_PermissionSet = new(this, "Intersect", 0, typeof(System.Security.PermissionSet));
					r_RIntersect_PermissionSet.SetBelong(this.instance);
				}
				return r_RIntersect_PermissionSet;
			}
		}

		/// <summary>
		/// Void InternalIntersect(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "InternalIntersect", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
					r_RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.SetBelong(this.instance);
				}
				return r_RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_RIsEmpty;
		public virtual RMethod RIsEmpty
		{
			get
			{
				if(r_RIsEmpty == null)
				{
					r_RIsEmpty = new(this, "IsEmpty", 0);
					r_RIsEmpty.SetBelong(this.instance);
				}
				return r_RIsEmpty;
			}
		}

		/// <summary>
		/// Boolean IsUnrestricted()
		/// </summary>
		protected RMethod r_RIsUnrestricted;
		public virtual RMethod RIsUnrestricted
		{
			get
			{
				if(r_RIsUnrestricted == null)
				{
					r_RIsUnrestricted = new(this, "IsUnrestricted", 0);
					r_RIsUnrestricted.SetBelong(this.instance);
				}
				return r_RIsUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermission(System.Type)
		/// </summary>
		protected RMethod r_RRemovePermission_Type;
		public virtual RMethod RRemovePermission_Type
		{
			get
			{
				if(r_RRemovePermission_Type == null)
				{
					r_RRemovePermission_Type = new(this, "RemovePermission", 0, typeof(System.Type));
					r_RRemovePermission_Type.SetBelong(this.instance);
				}
				return r_RRemovePermission_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RSetPermission_IPermission;
		public virtual RMethod RSetPermission_IPermission
		{
			get
			{
				if(r_RSetPermission_IPermission == null)
				{
					r_RSetPermission_IPermission = new(this, "SetPermission", 0, typeof(System.Security.IPermission));
					r_RSetPermission_IPermission.SetBelong(this.instance);
				}
				return r_RSetPermission_IPermission;
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

		/// <summary>
		/// System.Security.PermissionSet Union(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RUnion_PermissionSet;
		public virtual RMethod RUnion_PermissionSet
		{
			get
			{
				if(r_RUnion_PermissionSet == null)
				{
					r_RUnion_PermissionSet = new(this, "Union", 0, typeof(System.Security.PermissionSet));
					r_RUnion_PermissionSet.SetBelong(this.instance);
				}
				return r_RUnion_PermissionSet;
			}
		}

		/// <summary>
		/// Void SetReadOnly(Boolean)
		/// </summary>
		protected RMethod r_RSetReadOnly_Boolean;
		public virtual RMethod RSetReadOnly_Boolean
		{
			get
			{
				if(r_RSetReadOnly_Boolean == null)
				{
					r_RSetReadOnly_Boolean = new(this, "SetReadOnly", 0, typeof(System.Boolean));
					r_RSetReadOnly_Boolean.SetBelong(this.instance);
				}
				return r_RSetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RAddPermissionImpl_IPermission;
		public virtual RMethod RAddPermissionImpl_IPermission
		{
			get
			{
				if(r_RAddPermissionImpl_IPermission == null)
				{
					r_RAddPermissionImpl_IPermission = new(this, "AddPermissionImpl", 0, typeof(System.Security.IPermission));
					r_RAddPermissionImpl_IPermission.SetBelong(this.instance);
				}
				return r_RAddPermissionImpl_IPermission;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumeratorImpl()
		/// </summary>
		protected RMethod r_RGetEnumeratorImpl;
		public virtual RMethod RGetEnumeratorImpl
		{
			get
			{
				if(r_RGetEnumeratorImpl == null)
				{
					r_RGetEnumeratorImpl = new(this, "GetEnumeratorImpl", 0);
					r_RGetEnumeratorImpl.SetBelong(this.instance);
				}
				return r_RGetEnumeratorImpl;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_RGetPermissionImpl_Type;
		public virtual RMethod RGetPermissionImpl_Type
		{
			get
			{
				if(r_RGetPermissionImpl_Type == null)
				{
					r_RGetPermissionImpl_Type = new(this, "GetPermissionImpl", 0, typeof(System.Type));
					r_RGetPermissionImpl_Type.SetBelong(this.instance);
				}
				return r_RGetPermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_RRemovePermissionImpl_Type;
		public virtual RMethod RRemovePermissionImpl_Type
		{
			get
			{
				if(r_RRemovePermissionImpl_Type == null)
				{
					r_RRemovePermissionImpl_Type = new(this, "RemovePermissionImpl", 0, typeof(System.Type));
					r_RRemovePermissionImpl_Type.SetBelong(this.instance);
				}
				return r_RRemovePermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_RSetPermissionImpl_IPermission;
		public virtual RMethod RSetPermissionImpl_IPermission
		{
			get
			{
				if(r_RSetPermissionImpl_IPermission == null)
				{
					r_RSetPermissionImpl_IPermission = new(this, "SetPermissionImpl", 0, typeof(System.Security.IPermission));
					r_RSetPermissionImpl_IPermission.SetBelong(this.instance);
				}
				return r_RSetPermissionImpl_IPermission;
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


        public RNamedPermissionSet() : base("System.Security.NamedPermissionSet")
        {
        }

        public RNamedPermissionSet(System.Object instance) : base("System.Security.NamedPermissionSet")
		{
            SetInstance(instance);
		}

        public RNamedPermissionSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNamedPermissionSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.PermissionSet Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual System.Security.NamedPermissionSet Copy(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCopy_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement  @et)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et};
            var ___result = RFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Security.IPermission AddPermission(System.Security.IPermission  @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RAddPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Assert()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAssert.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Demand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDemand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CasOnlyDemand(System.Int32  @skip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skip};
            var ___result = RCasOnlyDemand_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Deny()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeny.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean IsSubsetOf(System.Security.PermissionSet  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RIsSubsetOf_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PermitOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPermitOnly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsNonCodeAccessPermissions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RContainsNonCodeAccessPermissions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission GetPermission(System.Type  @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RGetPermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.PermissionSet Intersect(System.Security.PermissionSet  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersect_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void InternalIntersect(System.Security.PermissionSet  @intersect, System.Security.PermissionSet  @a, System.Security.PermissionSet  @b, System.Boolean  @unrestricted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intersect, @a, @b, @unrestricted};
            var ___result = RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsUnrestricted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsUnrestricted.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission RemovePermission(System.Type  @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RRemovePermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermission(System.Security.IPermission  @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RSetPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.PermissionSet Union(System.Security.PermissionSet  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RUnion_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void SetReadOnly(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.IPermission AddPermissionImpl(System.Security.IPermission  @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RAddPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumeratorImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumeratorImpl.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Security.IPermission GetPermissionImpl(System.Type  @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RGetPermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission RemovePermissionImpl(System.Type  @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RRemovePermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermissionImpl(System.Security.IPermission  @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RSetPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
