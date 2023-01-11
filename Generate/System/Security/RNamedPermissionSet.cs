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
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
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
		protected RSystem.RString r_description;
		public virtual RSystem.RString Rdescription
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
		protected RSystem.RString r_Description;
		public virtual RSystem.RString RDescription
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
		protected RSystem.RString r_Name;
		public virtual RSystem.RString RName
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
		protected RSystem.RInt32 r_Count;
		public virtual RSystem.RInt32 RCount
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
		protected RSystem.RBoolean r_IsSynchronized;
		public virtual RSystem.RBoolean RIsSynchronized
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
		protected RSystem.RBoolean r_IsReadOnly;
		public virtual RSystem.RBoolean RIsReadOnly
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
		protected RSystem.RBoolean r_DeclarativeSecurity;
		public virtual RSystem.RBoolean RDeclarativeSecurity
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
		public virtual RSystem.RSecurity.RPolicy.RPolicyLevel RResolver
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
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet Copy(System.String)
		/// </summary>
		protected RMethod r_Copy_String;
		public virtual RMethod RCopy_String
		{
			get
			{
				if(r_Copy_String == null)
				{
					r_Copy_String = new(this, "Copy", 0, typeof(System.String));
					r_Copy_String.SetBelong(this.instance);
				}
				return r_Copy_String;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_FromXml_SecurityElement;
		public virtual RMethod RFromXml_SecurityElement
		{
			get
			{
				if(r_FromXml_SecurityElement == null)
				{
					r_FromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_FromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_FromXml_SecurityElement;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_ToXml;
		public virtual RMethod RToXml
		{
			get
			{
				if(r_ToXml == null)
				{
					r_ToXml = new(this, "ToXml", 0);
					r_ToXml.SetBelong(this.instance);
				}
				return r_ToXml;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_AddPermission_IPermission;
		public virtual RMethod RAddPermission_IPermission
		{
			get
			{
				if(r_AddPermission_IPermission == null)
				{
					r_AddPermission_IPermission = new(this, "AddPermission", 0, typeof(System.Security.IPermission));
					r_AddPermission_IPermission.SetBelong(this.instance);
				}
				return r_AddPermission_IPermission;
			}
		}

		/// <summary>
		/// Void Assert()
		/// </summary>
		protected RMethod r_Assert;
		public virtual RMethod RAssert
		{
			get
			{
				if(r_Assert == null)
				{
					r_Assert = new(this, "Assert", 0);
					r_Assert.SetBelong(this.instance);
				}
				return r_Assert;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_CopyTo_Array_Int32 == null)
				{
					r_CopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_Demand;
		public virtual RMethod RDemand
		{
			get
			{
				if(r_Demand == null)
				{
					r_Demand = new(this, "Demand", 0);
					r_Demand.SetBelong(this.instance);
				}
				return r_Demand;
			}
		}

		/// <summary>
		/// Void CasOnlyDemand(Int32)
		/// </summary>
		protected RMethod r_CasOnlyDemand_Int32;
		public virtual RMethod RCasOnlyDemand_Int32
		{
			get
			{
				if(r_CasOnlyDemand_Int32 == null)
				{
					r_CasOnlyDemand_Int32 = new(this, "CasOnlyDemand", 0, typeof(System.Int32));
					r_CasOnlyDemand_Int32.SetBelong(this.instance);
				}
				return r_CasOnlyDemand_Int32;
			}
		}

		/// <summary>
		/// Void Deny()
		/// </summary>
		protected RMethod r_Deny;
		public virtual RMethod RDeny
		{
			get
			{
				if(r_Deny == null)
				{
					r_Deny = new(this, "Deny", 0);
					r_Deny.SetBelong(this.instance);
				}
				return r_Deny;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_IsSubsetOf_PermissionSet;
		public virtual RMethod RIsSubsetOf_PermissionSet
		{
			get
			{
				if(r_IsSubsetOf_PermissionSet == null)
				{
					r_IsSubsetOf_PermissionSet = new(this, "IsSubsetOf", 0, typeof(System.Security.PermissionSet));
					r_IsSubsetOf_PermissionSet.SetBelong(this.instance);
				}
				return r_IsSubsetOf_PermissionSet;
			}
		}

		/// <summary>
		/// Void PermitOnly()
		/// </summary>
		protected RMethod r_PermitOnly;
		public virtual RMethod RPermitOnly
		{
			get
			{
				if(r_PermitOnly == null)
				{
					r_PermitOnly = new(this, "PermitOnly", 0);
					r_PermitOnly.SetBelong(this.instance);
				}
				return r_PermitOnly;
			}
		}

		/// <summary>
		/// Boolean ContainsNonCodeAccessPermissions()
		/// </summary>
		protected RMethod r_ContainsNonCodeAccessPermissions;
		public virtual RMethod RContainsNonCodeAccessPermissions
		{
			get
			{
				if(r_ContainsNonCodeAccessPermissions == null)
				{
					r_ContainsNonCodeAccessPermissions = new(this, "ContainsNonCodeAccessPermissions", 0);
					r_ContainsNonCodeAccessPermissions.SetBelong(this.instance);
				}
				return r_ContainsNonCodeAccessPermissions;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermission(System.Type)
		/// </summary>
		protected RMethod r_GetPermission_Type;
		public virtual RMethod RGetPermission_Type
		{
			get
			{
				if(r_GetPermission_Type == null)
				{
					r_GetPermission_Type = new(this, "GetPermission", 0, typeof(System.Type));
					r_GetPermission_Type.SetBelong(this.instance);
				}
				return r_GetPermission_Type;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Intersect(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_Intersect_PermissionSet;
		public virtual RMethod RIntersect_PermissionSet
		{
			get
			{
				if(r_Intersect_PermissionSet == null)
				{
					r_Intersect_PermissionSet = new(this, "Intersect", 0, typeof(System.Security.PermissionSet));
					r_Intersect_PermissionSet.SetBelong(this.instance);
				}
				return r_Intersect_PermissionSet;
			}
		}

		/// <summary>
		/// Void InternalIntersect(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "InternalIntersect", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
					r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.SetBelong(this.instance);
				}
				return r_InternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_IsEmpty;
		public virtual RMethod RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", 0);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
			}
		}

		/// <summary>
		/// Boolean IsUnrestricted()
		/// </summary>
		protected RMethod r_IsUnrestricted;
		public virtual RMethod RIsUnrestricted
		{
			get
			{
				if(r_IsUnrestricted == null)
				{
					r_IsUnrestricted = new(this, "IsUnrestricted", 0);
					r_IsUnrestricted.SetBelong(this.instance);
				}
				return r_IsUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermission(System.Type)
		/// </summary>
		protected RMethod r_RemovePermission_Type;
		public virtual RMethod RRemovePermission_Type
		{
			get
			{
				if(r_RemovePermission_Type == null)
				{
					r_RemovePermission_Type = new(this, "RemovePermission", 0, typeof(System.Type));
					r_RemovePermission_Type.SetBelong(this.instance);
				}
				return r_RemovePermission_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_SetPermission_IPermission;
		public virtual RMethod RSetPermission_IPermission
		{
			get
			{
				if(r_SetPermission_IPermission == null)
				{
					r_SetPermission_IPermission = new(this, "SetPermission", 0, typeof(System.Security.IPermission));
					r_SetPermission_IPermission.SetBelong(this.instance);
				}
				return r_SetPermission_IPermission;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Union(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_Union_PermissionSet;
		public virtual RMethod RUnion_PermissionSet
		{
			get
			{
				if(r_Union_PermissionSet == null)
				{
					r_Union_PermissionSet = new(this, "Union", 0, typeof(System.Security.PermissionSet));
					r_Union_PermissionSet.SetBelong(this.instance);
				}
				return r_Union_PermissionSet;
			}
		}

		/// <summary>
		/// Void SetReadOnly(Boolean)
		/// </summary>
		protected RMethod r_SetReadOnly_Boolean;
		public virtual RMethod RSetReadOnly_Boolean
		{
			get
			{
				if(r_SetReadOnly_Boolean == null)
				{
					r_SetReadOnly_Boolean = new(this, "SetReadOnly", 0, typeof(System.Boolean));
					r_SetReadOnly_Boolean.SetBelong(this.instance);
				}
				return r_SetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_AddPermissionImpl_IPermission;
		public virtual RMethod RAddPermissionImpl_IPermission
		{
			get
			{
				if(r_AddPermissionImpl_IPermission == null)
				{
					r_AddPermissionImpl_IPermission = new(this, "AddPermissionImpl", 0, typeof(System.Security.IPermission));
					r_AddPermissionImpl_IPermission.SetBelong(this.instance);
				}
				return r_AddPermissionImpl_IPermission;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumeratorImpl()
		/// </summary>
		protected RMethod r_GetEnumeratorImpl;
		public virtual RMethod RGetEnumeratorImpl
		{
			get
			{
				if(r_GetEnumeratorImpl == null)
				{
					r_GetEnumeratorImpl = new(this, "GetEnumeratorImpl", 0);
					r_GetEnumeratorImpl.SetBelong(this.instance);
				}
				return r_GetEnumeratorImpl;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_GetPermissionImpl_Type;
		public virtual RMethod RGetPermissionImpl_Type
		{
			get
			{
				if(r_GetPermissionImpl_Type == null)
				{
					r_GetPermissionImpl_Type = new(this, "GetPermissionImpl", 0, typeof(System.Type));
					r_GetPermissionImpl_Type.SetBelong(this.instance);
				}
				return r_GetPermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_RemovePermissionImpl_Type;
		public virtual RMethod RRemovePermissionImpl_Type
		{
			get
			{
				if(r_RemovePermissionImpl_Type == null)
				{
					r_RemovePermissionImpl_Type = new(this, "RemovePermissionImpl", 0, typeof(System.Type));
					r_RemovePermissionImpl_Type.SetBelong(this.instance);
				}
				return r_RemovePermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_SetPermissionImpl_IPermission;
		public virtual RMethod RSetPermissionImpl_IPermission
		{
			get
			{
				if(r_SetPermissionImpl_IPermission == null)
				{
					r_SetPermissionImpl_IPermission = new(this, "SetPermissionImpl", 0, typeof(System.Security.IPermission));
					r_SetPermissionImpl_IPermission.SetBelong(this.instance);
				}
				return r_SetPermissionImpl_IPermission;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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


        public virtual System.Security.NamedPermissionSet Copy(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCopy_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @et)
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


        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.Security.IPermission AddPermission(System.Security.IPermission @perm)
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


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
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


        public virtual void CasOnlyDemand(System.Int32 @skip)
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


        public virtual System.Boolean IsSubsetOf(System.Security.PermissionSet @target)
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


        public virtual System.Security.IPermission GetPermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RGetPermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.PermissionSet Intersect(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIntersect_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void InternalIntersect(System.Security.PermissionSet @intersect, System.Security.PermissionSet @a, System.Security.PermissionSet @b, System.Boolean @unrestricted)
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


        public virtual System.Security.IPermission RemovePermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RRemovePermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermission(System.Security.IPermission @perm)
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


        public virtual System.Security.PermissionSet Union(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RUnion_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void SetReadOnly(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.IPermission AddPermissionImpl(System.Security.IPermission @perm)
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


        public virtual System.Security.IPermission GetPermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RGetPermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission RemovePermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RRemovePermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermissionImpl(System.Security.IPermission @perm)
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
