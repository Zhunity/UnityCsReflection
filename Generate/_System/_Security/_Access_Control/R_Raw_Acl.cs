
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.RawAcl
	/// </summary>
    public partial class RRawAcl : RMember //
    {

		/// <summary>
		/// System.Byte revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Frevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFrevision
		{
			get
			{
				if(r_Frevision == null)
				{
					r_Frevision = new(this, "revision");
					r_Frevision.SetBelong(this.instance);
				}
				return r_Frevision;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Security.AccessControl.GenericAce] list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAce> r_Flist;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAce> RFlist
		{
			get
			{
				if(r_Flist == null)
				{
					r_Flist = new(this, "list");
					r_Flist.SetBelong(this.instance);
				}
				return r_Flist;
			}
		}

		/// <summary>
		/// Int32 BinaryLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PBinaryLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPBinaryLength
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
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
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
		/// System.Security.AccessControl.GenericAce Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAce r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RGenericAce RPItem_Int32
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
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PRevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPRevision
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
					r_PIsSynchronized.SetBelong(this.instance);
				}
				return r_PIsSynchronized;
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
					r_PSyncRoot.SetBelong(this.instance);
				}
				return r_PSyncRoot;
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
		/// Void InsertAce(Int32, System.Security.AccessControl.GenericAce)
		/// </summary>
		protected RMethod r_MInsertAce_Int32_GenericAce;
		public virtual RMethod RMInsertAce_Int32_GenericAce
		{
			get
			{
				if(r_MInsertAce_Int32_GenericAce == null)
				{
					r_MInsertAce_Int32_GenericAce = new(this, "InsertAce", 0, typeof(System.Int32), typeof(System.Security.AccessControl.GenericAce));
					r_MInsertAce_Int32_GenericAce.SetBelong(this.instance);
				}
				return r_MInsertAce_Int32_GenericAce;
			}
		}

		/// <summary>
		/// Void RemoveAce(Int32)
		/// </summary>
		protected RMethod r_MRemoveAce_Int32;
		public virtual RMethod RMRemoveAce_Int32
		{
			get
			{
				if(r_MRemoveAce_Int32 == null)
				{
					r_MRemoveAce_Int32 = new(this, "RemoveAce", 0, typeof(System.Int32));
					r_MRemoveAce_Int32.SetBelong(this.instance);
				}
				return r_MRemoveAce_Int32;
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
		/// System.Security.AccessControl.RawAcl ParseSddlForm(System.String, Boolean, System.Security.AccessControl.ControlFlags ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32;
		public static RMethod RMParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32
		{
			get
			{
				if(r_MParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32 == null)
				{
					r_MParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32 = new(typeof(System.Security.AccessControl.RawAcl), "ParseSddlForm", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Security.AccessControl.ControlFlags).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32.SetBelong(null);
				}
				return r_MParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32;
			}
		}

		/// <summary>
		/// Void ParseFlags(System.String, Boolean, System.Security.AccessControl.ControlFlags ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32;
		public static RMethod RMParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32
		{
			get
			{
				if(r_MParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32 == null)
				{
					r_MParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32 = new(typeof(System.Security.AccessControl.RawAcl), "ParseFlags", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Security.AccessControl.ControlFlags).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32.SetBelong(null);
				}
				return r_MParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32;
			}
		}

		/// <summary>
		/// Void WriteUShort(UInt16, Byte[], Int32)
		/// </summary>
		protected RMethod r_MWriteUShort_UInt16_ByteArray_Int32;
		public virtual RMethod RMWriteUShort_UInt16_ByteArray_Int32
		{
			get
			{
				if(r_MWriteUShort_UInt16_ByteArray_Int32 == null)
				{
					r_MWriteUShort_UInt16_ByteArray_Int32 = new(this, "WriteUShort", 0, typeof(System.UInt16), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MWriteUShort_UInt16_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MWriteUShort_UInt16_ByteArray_Int32;
			}
		}

		/// <summary>
		/// UInt16 ReadUShort(Byte[], Int32)
		/// </summary>
		protected RMethod r_MReadUShort_ByteArray_Int32;
		public virtual RMethod RMReadUShort_ByteArray_Int32
		{
			get
			{
				if(r_MReadUShort_ByteArray_Int32 == null)
				{
					r_MReadUShort_ByteArray_Int32 = new(this, "ReadUShort", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MReadUShort_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MReadUShort_ByteArray_Int32;
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


        public RRawAcl() : base("System.Security.AccessControl.RawAcl")
        {
        }

        public RRawAcl(System.Object instance) : base("System.Security.AccessControl.RawAcl")
		{
            SetInstance(instance);
		}

        public RRawAcl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRawAcl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetBinaryForm(System.Byte[] @binaryForm, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @offset};
            var ___result = RMGetBinaryForm_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertAce(System.Int32 @index, System.Security.AccessControl.GenericAce @ace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ace};
            var ___result = RMInsertAce_Int32_GenericAce.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAce(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAce_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetSddlForm(System.Security.AccessControl.ControlFlags @sdFlags, System.Boolean @isDacl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sdFlags, @isDacl};
            var ___result = RMGetSddlForm_ControlFlags_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.AccessControl.RawAcl ParseSddlForm(System.String @sddlForm, System.Boolean @isDacl, ref System.Security.AccessControl.ControlFlags @sdFlags, ref System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @isDacl, @sdFlags, @pos};
            var ___result = RMParseSddlForm_String_Boolean_Ref_ControlFlags_Ref_Int32.Invoke(___genericsType, ___parameters);
			@sdFlags = (System.Security.AccessControl.ControlFlags)___parameters[2];
			@pos = (System.Int32)___parameters[3];

            return (System.Security.AccessControl.RawAcl)___result;
        }


        public static void ParseFlags(System.String @sddlForm, System.Boolean @isDacl, ref System.Security.AccessControl.ControlFlags @sdFlags, ref System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @isDacl, @sdFlags, @pos};
            var ___result = RMParseFlags_String_Boolean_Ref_ControlFlags_Ref_Int32.Invoke(___genericsType, ___parameters);
			@sdFlags = (System.Security.AccessControl.ControlFlags)___parameters[2];
			@pos = (System.Int32)___parameters[3];

            
        }


        public virtual void WriteUShort(System.UInt16 @val, System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val, @buffer, @offset};
            var ___result = RMWriteUShort_UInt16_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt16 ReadUShort(System.Byte[] @buffer, System.Int32 @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset};
            var ___result = RMReadUShort_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual void CopyTo(System.Security.AccessControl.GenericAce[] @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_GenericAceArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AceEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AceEnumerator)___result;
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
