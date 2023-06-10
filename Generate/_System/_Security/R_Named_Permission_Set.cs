
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.NamedPermissionSet
	/// </summary>
    public partial class RNamedPermissionSet : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.NamedPermissionSet);
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


		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fdescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdescription
		{
			get
			{
				if(r_Fdescription == null)
				{
					r_Fdescription = new(this, "description");
				}
				return r_Fdescription;
			}
		}

		/// <summary>
		/// System.String Description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDescription
		{
			get
			{
				if(r_PDescription == null)
				{
					r_PDescription = new(this, "Description", -1);
				}
				return r_PDescription;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSynchronized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSyncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// Boolean DeclarativeSecurity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PDeclarativeSecurity;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPDeclarativeSecurity
		{
			get
			{
				if(r_PDeclarativeSecurity == null)
				{
					r_PDeclarativeSecurity = new(this, "DeclarativeSecurity", -1);
				}
				return r_PDeclarativeSecurity;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel Resolver
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel r_PResolver;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyLevel RPResolver
		{
			get
			{
				if(r_PResolver == null)
				{
					r_PResolver = new(this, "Resolver", -1);
				}
				return r_PResolver;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet Copy(System.String)
		/// </summary>
		protected RMethod r_MCopy_String;
		public virtual RMethod RMCopy_String
		{
			get
			{
				if(r_MCopy_String == null)
				{
					r_MCopy_String = new(this, "Copy", 0, typeof(System.String));
				}
				return r_MCopy_String;
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
				}
				return r_MFromXml_SecurityElement;
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
				}
				return r_MToXml;
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
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MAddPermission_IPermission;
		public virtual RMethod RMAddPermission_IPermission
		{
			get
			{
				if(r_MAddPermission_IPermission == null)
				{
					r_MAddPermission_IPermission = new(this, "AddPermission", 0, typeof(System.Security.IPermission));
				}
				return r_MAddPermission_IPermission;
			}
		}

		/// <summary>
		/// Void Assert()
		/// </summary>
		protected RMethod r_MAssert;
		public virtual RMethod RMAssert
		{
			get
			{
				if(r_MAssert == null)
				{
					r_MAssert = new(this, "Assert", 0);
				}
				return r_MAssert;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int32;
		public virtual RMethod RMCopyTo_Array_Int32
		{
			get
			{
				if(r_MCopyTo_Array_Int32 == null)
				{
					r_MCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void Demand()
		/// </summary>
		protected RMethod r_MDemand;
		public virtual RMethod RMDemand
		{
			get
			{
				if(r_MDemand == null)
				{
					r_MDemand = new(this, "Demand", 0);
				}
				return r_MDemand;
			}
		}

		/// <summary>
		/// Void CasOnlyDemand(Int32)
		/// </summary>
		protected RMethod r_MCasOnlyDemand_Int32;
		public virtual RMethod RMCasOnlyDemand_Int32
		{
			get
			{
				if(r_MCasOnlyDemand_Int32 == null)
				{
					r_MCasOnlyDemand_Int32 = new(this, "CasOnlyDemand", 0, typeof(System.Int32));
				}
				return r_MCasOnlyDemand_Int32;
			}
		}

		/// <summary>
		/// Void Deny()
		/// </summary>
		protected RMethod r_MDeny;
		public virtual RMethod RMDeny
		{
			get
			{
				if(r_MDeny == null)
				{
					r_MDeny = new(this, "Deny", 0);
				}
				return r_MDeny;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// Boolean IsSubsetOf(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MIsSubsetOf_PermissionSet;
		public virtual RMethod RMIsSubsetOf_PermissionSet
		{
			get
			{
				if(r_MIsSubsetOf_PermissionSet == null)
				{
					r_MIsSubsetOf_PermissionSet = new(this, "IsSubsetOf", 0, typeof(System.Security.PermissionSet));
				}
				return r_MIsSubsetOf_PermissionSet;
			}
		}

		/// <summary>
		/// Void PermitOnly()
		/// </summary>
		protected RMethod r_MPermitOnly;
		public virtual RMethod RMPermitOnly
		{
			get
			{
				if(r_MPermitOnly == null)
				{
					r_MPermitOnly = new(this, "PermitOnly", 0);
				}
				return r_MPermitOnly;
			}
		}

		/// <summary>
		/// Boolean ContainsNonCodeAccessPermissions()
		/// </summary>
		protected RMethod r_MContainsNonCodeAccessPermissions;
		public virtual RMethod RMContainsNonCodeAccessPermissions
		{
			get
			{
				if(r_MContainsNonCodeAccessPermissions == null)
				{
					r_MContainsNonCodeAccessPermissions = new(this, "ContainsNonCodeAccessPermissions", 0);
				}
				return r_MContainsNonCodeAccessPermissions;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermission(System.Type)
		/// </summary>
		protected RMethod r_MGetPermission_Type;
		public virtual RMethod RMGetPermission_Type
		{
			get
			{
				if(r_MGetPermission_Type == null)
				{
					r_MGetPermission_Type = new(this, "GetPermission", 0, typeof(System.Type));
				}
				return r_MGetPermission_Type;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Intersect(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MIntersect_PermissionSet;
		public virtual RMethod RMIntersect_PermissionSet
		{
			get
			{
				if(r_MIntersect_PermissionSet == null)
				{
					r_MIntersect_PermissionSet = new(this, "Intersect", 0, typeof(System.Security.PermissionSet));
				}
				return r_MIntersect_PermissionSet;
			}
		}

		/// <summary>
		/// Void InternalIntersect(System.Security.PermissionSet, System.Security.PermissionSet, System.Security.PermissionSet, Boolean)
		/// </summary>
		protected RMethod r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
		public virtual RMethod RMInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean
		{
			get
			{
				if(r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean == null)
				{
					r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean = new(this, "InternalIntersect", 0, typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Security.PermissionSet), typeof(System.Boolean));
				}
				return r_MInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_MIsEmpty;
		public virtual RMethod RMIsEmpty
		{
			get
			{
				if(r_MIsEmpty == null)
				{
					r_MIsEmpty = new(this, "IsEmpty", 0);
				}
				return r_MIsEmpty;
			}
		}

		/// <summary>
		/// Boolean IsUnrestricted()
		/// </summary>
		protected RMethod r_MIsUnrestricted;
		public virtual RMethod RMIsUnrestricted
		{
			get
			{
				if(r_MIsUnrestricted == null)
				{
					r_MIsUnrestricted = new(this, "IsUnrestricted", 0);
				}
				return r_MIsUnrestricted;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermission(System.Type)
		/// </summary>
		protected RMethod r_MRemovePermission_Type;
		public virtual RMethod RMRemovePermission_Type
		{
			get
			{
				if(r_MRemovePermission_Type == null)
				{
					r_MRemovePermission_Type = new(this, "RemovePermission", 0, typeof(System.Type));
				}
				return r_MRemovePermission_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermission(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MSetPermission_IPermission;
		public virtual RMethod RMSetPermission_IPermission
		{
			get
			{
				if(r_MSetPermission_IPermission == null)
				{
					r_MSetPermission_IPermission = new(this, "SetPermission", 0, typeof(System.Security.IPermission));
				}
				return r_MSetPermission_IPermission;
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
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.Security.PermissionSet Union(System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MUnion_PermissionSet;
		public virtual RMethod RMUnion_PermissionSet
		{
			get
			{
				if(r_MUnion_PermissionSet == null)
				{
					r_MUnion_PermissionSet = new(this, "Union", 0, typeof(System.Security.PermissionSet));
				}
				return r_MUnion_PermissionSet;
			}
		}

		/// <summary>
		/// Void SetReadOnly(Boolean)
		/// </summary>
		protected RMethod r_MSetReadOnly_Boolean;
		public virtual RMethod RMSetReadOnly_Boolean
		{
			get
			{
				if(r_MSetReadOnly_Boolean == null)
				{
					r_MSetReadOnly_Boolean = new(this, "SetReadOnly", 0, typeof(System.Boolean));
				}
				return r_MSetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// System.Security.IPermission AddPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MAddPermissionImpl_IPermission;
		public virtual RMethod RMAddPermissionImpl_IPermission
		{
			get
			{
				if(r_MAddPermissionImpl_IPermission == null)
				{
					r_MAddPermissionImpl_IPermission = new(this, "AddPermissionImpl", 0, typeof(System.Security.IPermission));
				}
				return r_MAddPermissionImpl_IPermission;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumeratorImpl()
		/// </summary>
		protected RMethod r_MGetEnumeratorImpl;
		public virtual RMethod RMGetEnumeratorImpl
		{
			get
			{
				if(r_MGetEnumeratorImpl == null)
				{
					r_MGetEnumeratorImpl = new(this, "GetEnumeratorImpl", 0);
				}
				return r_MGetEnumeratorImpl;
			}
		}

		/// <summary>
		/// System.Security.IPermission GetPermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_MGetPermissionImpl_Type;
		public virtual RMethod RMGetPermissionImpl_Type
		{
			get
			{
				if(r_MGetPermissionImpl_Type == null)
				{
					r_MGetPermissionImpl_Type = new(this, "GetPermissionImpl", 0, typeof(System.Type));
				}
				return r_MGetPermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission RemovePermissionImpl(System.Type)
		/// </summary>
		protected RMethod r_MRemovePermissionImpl_Type;
		public virtual RMethod RMRemovePermissionImpl_Type
		{
			get
			{
				if(r_MRemovePermissionImpl_Type == null)
				{
					r_MRemovePermissionImpl_Type = new(this, "RemovePermissionImpl", 0, typeof(System.Type));
				}
				return r_MRemovePermissionImpl_Type;
			}
		}

		/// <summary>
		/// System.Security.IPermission SetPermissionImpl(System.Security.IPermission)
		/// </summary>
		protected RMethod r_MSetPermissionImpl_IPermission;
		public virtual RMethod RMSetPermissionImpl_IPermission
		{
			get
			{
				if(r_MSetPermissionImpl_IPermission == null)
				{
					r_MSetPermissionImpl_IPermission = new(this, "SetPermissionImpl", 0, typeof(System.Security.IPermission));
				}
				return r_MSetPermissionImpl_IPermission;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual System.Security.PermissionSet Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual System.Security.NamedPermissionSet Copy(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMCopy_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @et)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@et};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

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


        public virtual System.Security.IPermission AddPermission(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMAddPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual void Assert()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAssert.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Demand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDemand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CasOnlyDemand(System.Int32 @skip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skip};
            var ___result = RMCasOnlyDemand_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Deny()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeny.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean IsSubsetOf(System.Security.PermissionSet @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMIsSubsetOf_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PermitOnly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPermitOnly.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsNonCodeAccessPermissions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMContainsNonCodeAccessPermissions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission GetPermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMGetPermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.PermissionSet Intersect(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIntersect_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void InternalIntersect(System.Security.PermissionSet @intersect, System.Security.PermissionSet @a, System.Security.PermissionSet @b, System.Boolean @unrestricted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intersect, @a, @b, @unrestricted};
            var ___result = RMInternalIntersect_PermissionSet_PermissionSet_PermissionSet_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsUnrestricted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsUnrestricted.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.IPermission RemovePermission(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMRemovePermission_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermission(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMSetPermission_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.PermissionSet Union(System.Security.PermissionSet @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMUnion_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.PermissionSet)___result;
        }


        public virtual void SetReadOnly(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.IPermission AddPermissionImpl(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMAddPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Collections.IEnumerator GetEnumeratorImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumeratorImpl.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Security.IPermission GetPermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMGetPermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission RemovePermissionImpl(System.Type @permClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permClass};
            var ___result = RMRemovePermissionImpl_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
        }


        public virtual System.Security.IPermission SetPermissionImpl(System.Security.IPermission @perm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@perm};
            var ___result = RMSetPermissionImpl_IPermission.Invoke(___genericsType, ___parameters);

            return (System.Security.IPermission)___result;
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
