using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.GenericAcl
	/// </summary>
    public partial class RGenericAcl : RMember //
    {

		/// <summary>
		/// System.Byte AclRevision
		/// </summary>
		protected static RSystem.RByte r_FAclRevision;
		public static RSystem.RByte RFAclRevision
		{
			get
			{
				if(r_FAclRevision == null)
				{
					r_FAclRevision = new(typeof(System.Security.AccessControl.GenericAcl), "AclRevision");
					r_FAclRevision.SetBelong(null);
				}
				return r_FAclRevision;
			}
		}

		/// <summary>
		/// System.Byte AclRevisionDS
		/// </summary>
		protected static RSystem.RByte r_FAclRevisionDS;
		public static RSystem.RByte RFAclRevisionDS
		{
			get
			{
				if(r_FAclRevisionDS == null)
				{
					r_FAclRevisionDS = new(typeof(System.Security.AccessControl.GenericAcl), "AclRevisionDS");
					r_FAclRevisionDS.SetBelong(null);
				}
				return r_FAclRevisionDS;
			}
		}

		/// <summary>
		/// System.Int32 MaxBinaryLength
		/// </summary>
		protected static RSystem.RInt32 r_FMaxBinaryLength;
		public static RSystem.RInt32 RFMaxBinaryLength
		{
			get
			{
				if(r_FMaxBinaryLength == null)
				{
					r_FMaxBinaryLength = new(typeof(System.Security.AccessControl.GenericAcl), "MaxBinaryLength");
					r_FMaxBinaryLength.SetBelong(null);
				}
				return r_FMaxBinaryLength;
			}
		}

		/// <summary>
		/// Int32 BinaryLength
		/// </summary>
		protected RSystem.RInt32 r_PBinaryLength;
		public virtual RSystem.RInt32 RPBinaryLength
		{
			get
			{
				if(r_PBinaryLength == null)
				{
					r_PBinaryLength = new(this, "BinaryLength", -1);
					r_PBinaryLength.SetBelong(this.instance);
				}
				return r_PBinaryLength;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RSystem.RInt32 r_PCount;
		public virtual RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.instance);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RSystem.RBoolean r_PIsSynchronized;
		public virtual RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
					r_PIsSynchronized.SetBelong(this.instance);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.GenericAce Item [Int32]
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RGenericAce r_PItem_Int32;
		public virtual RSystem.RSecurity.RAccessControl.RGenericAce RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Byte Revision
		/// </summary>
		protected RSystem.RByte r_PRevision;
		public virtual RSystem.RByte RPRevision
		{
			get
			{
				if(r_PRevision == null)
				{
					r_PRevision = new(this, "Revision", -1);
					r_PRevision.SetBelong(this.instance);
				}
				return r_PRevision;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_PSyncRoot;
		public virtual RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
					r_PSyncRoot.SetBelong(this.instance);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Security.AccessControl.GenericAce[], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_GenericAceArray_Int32;
		public virtual RMethod RMCopyTo_GenericAceArray_Int32
		{
			get
			{
				if(r_MCopyTo_GenericAceArray_Int32 == null)
				{
					r_MCopyTo_GenericAceArray_Int32 = new(this, "CopyTo", 0, typeof(System.Security.AccessControl.GenericAce).MakeArrayType(), typeof(System.Int32));
					r_MCopyTo_GenericAceArray_Int32.SetBelong(this.instance);
				}
				return r_MCopyTo_GenericAceArray_Int32;
			}
		}

		/// <summary>
		/// Void System.Collections.ICollection.CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
		public virtual RMethod RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32
		{
			get
			{
				if(r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32 == null)
				{
					r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32 = new(this, "System.Collections.ICollection.CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// Void GetBinaryForm(Byte[], Int32)
		/// </summary>
		protected RMethod r_MGetBinaryForm_ByteArray_Int32;
		public virtual RMethod RMGetBinaryForm_ByteArray_Int32
		{
			get
			{
				if(r_MGetBinaryForm_ByteArray_Int32 == null)
				{
					r_MGetBinaryForm_ByteArray_Int32 = new(this, "GetBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MGetBinaryForm_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MGetBinaryForm_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
					r_MGetEnumerator.SetBelong(this.instance);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// System.String GetSddlForm(System.Security.AccessControl.ControlFlags, Boolean)
		/// </summary>
		protected RMethod r_MGetSddlForm_ControlFlags_Boolean;
		public virtual RMethod RMGetSddlForm_ControlFlags_Boolean
		{
			get
			{
				if(r_MGetSddlForm_ControlFlags_Boolean == null)
				{
					r_MGetSddlForm_ControlFlags_Boolean = new(this, "GetSddlForm", 0, typeof(System.Security.AccessControl.ControlFlags), typeof(System.Boolean));
					r_MGetSddlForm_ControlFlags_Boolean.SetBelong(this.instance);
				}
				return r_MGetSddlForm_ControlFlags_Boolean;
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


        public RGenericAcl() : base("System.Security.AccessControl.GenericAcl")
        {
        }

        public RGenericAcl(System.Object instance) : base("System.Security.AccessControl.GenericAcl")
		{
            SetInstance(instance);
		}

        public RGenericAcl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGenericAcl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CopyTo(System.Security.AccessControl.GenericAce[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_GenericAceArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Collections__2__ICollection__2__CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMSystem__2__Collections__2__ICollection__2__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AceEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.ControlFlags @sdFlags, System.Boolean @isDacl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sdFlags, @isDacl};
            var ___result = RMGetSddlForm_ControlFlags_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
