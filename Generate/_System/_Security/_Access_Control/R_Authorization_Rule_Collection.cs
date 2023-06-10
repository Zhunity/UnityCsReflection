
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.AuthorizationRuleCollection
	/// </summary>
    public partial class RAuthorizationRuleCollection : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.AccessControl.AuthorizationRuleCollection);
            }
        }

        public RAuthorizationRuleCollection() : base("System.Security.AccessControl.AuthorizationRuleCollection")
        {
        }

        public RAuthorizationRuleCollection(System.Object instance) : base("System.Security.AccessControl.AuthorizationRuleCollection")
		{
            SetInstance(instance);
		}

        public RAuthorizationRuleCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAuthorizationRuleCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Security.AccessControl.AuthorizationRule Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAuthorizationRule r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAuthorizationRule RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList InnerList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_PInnerList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RPInnerList
		{
			get
			{
				if(r_PInnerList == null)
				{
					r_PInnerList = new(this, "InnerList", -1);
				}
				return r_PInnerList;
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
		/// Void AddRule(System.Security.AccessControl.AuthorizationRule)
		/// </summary>
		protected RMethod r_MAddRule_AuthorizationRule;
		public virtual RMethod RMAddRule_AuthorizationRule
		{
			get
			{
				if(r_MAddRule_AuthorizationRule == null)
				{
					r_MAddRule_AuthorizationRule = new(this, "AddRule", 0, typeof(System.Security.AccessControl.AuthorizationRule));
				}
				return r_MAddRule_AuthorizationRule;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Security.AccessControl.AuthorizationRule[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_AuthorizationRuleArray_Int32;
		public virtual RMethod RMCopyTo_AuthorizationRuleArray_Int32
		{
			get
			{
				if(r_MCopyTo_AuthorizationRuleArray_Int32 == null)
				{
					r_MCopyTo_AuthorizationRuleArray_Int32 = new(this, "CopyTo", 0, typeof(System.Security.AccessControl.AuthorizationRule).MakeArrayType(), typeof(System.Int32));
				}
				return r_MCopyTo_AuthorizationRuleArray_Int32;
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


        public virtual void AddRule(System.Security.AccessControl.AuthorizationRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMAddRule_AuthorizationRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Security.AccessControl.AuthorizationRule[] @rules, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rules, @index};
            var ___result = RMCopyTo_AuthorizationRuleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
