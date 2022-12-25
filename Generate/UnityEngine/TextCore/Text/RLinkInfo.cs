using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.LinkInfo
	/// </summary>
    public partial class RLinkInfo : RMember //
    {

		/// <summary>
		/// System.Int32 hashCode
		/// </summary>
		protected RField r_hashCode;
		public virtual RField RhashCode
		{
			get
			{
				if(r_hashCode == null)
				{
					r_hashCode = new(this, "hashCode");
					r_hashCode.SetBelong(this.instance);
				}
				return r_hashCode;
			}
		}

		/// <summary>
		/// System.Int32 linkIdFirstCharacterIndex
		/// </summary>
		protected RField r_linkIdFirstCharacterIndex;
		public virtual RField RlinkIdFirstCharacterIndex
		{
			get
			{
				if(r_linkIdFirstCharacterIndex == null)
				{
					r_linkIdFirstCharacterIndex = new(this, "linkIdFirstCharacterIndex");
					r_linkIdFirstCharacterIndex.SetBelong(this.instance);
				}
				return r_linkIdFirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 linkIdLength
		/// </summary>
		protected RField r_linkIdLength;
		public virtual RField RlinkIdLength
		{
			get
			{
				if(r_linkIdLength == null)
				{
					r_linkIdLength = new(this, "linkIdLength");
					r_linkIdLength.SetBelong(this.instance);
				}
				return r_linkIdLength;
			}
		}

		/// <summary>
		/// System.Int32 linkTextfirstCharacterIndex
		/// </summary>
		protected RField r_linkTextfirstCharacterIndex;
		public virtual RField RlinkTextfirstCharacterIndex
		{
			get
			{
				if(r_linkTextfirstCharacterIndex == null)
				{
					r_linkTextfirstCharacterIndex = new(this, "linkTextfirstCharacterIndex");
					r_linkTextfirstCharacterIndex.SetBelong(this.instance);
				}
				return r_linkTextfirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 linkTextLength
		/// </summary>
		protected RField r_linkTextLength;
		public virtual RField RlinkTextLength
		{
			get
			{
				if(r_linkTextLength == null)
				{
					r_linkTextLength = new(this, "linkTextLength");
					r_linkTextLength.SetBelong(this.instance);
				}
				return r_linkTextLength;
			}
		}

		/// <summary>
		/// System.Char[] linkId
		/// </summary>
		protected RFieldArray<RField> r_linkId;
		public virtual RFieldArray<RField> RlinkId
		{
			get
			{
				if(r_linkId == null)
				{
					r_linkId = new(this, "linkId");
					r_linkId.SetBelong(this.instance);
				}
				return r_linkId;
			}
		}

		/// <summary>
		/// System.String m_LinkIdString
		/// </summary>
		protected RField r_m_LinkIdString;
		public virtual RField Rm_LinkIdString
		{
			get
			{
				if(r_m_LinkIdString == null)
				{
					r_m_LinkIdString = new(this, "m_LinkIdString");
					r_m_LinkIdString.SetBelong(this.instance);
				}
				return r_m_LinkIdString;
			}
		}

		/// <summary>
		/// System.String m_LinkTextString
		/// </summary>
		protected RField r_m_LinkTextString;
		public virtual RField Rm_LinkTextString
		{
			get
			{
				if(r_m_LinkTextString == null)
				{
					r_m_LinkTextString = new(this, "m_LinkTextString");
					r_m_LinkTextString.SetBelong(this.instance);
				}
				return r_m_LinkTextString;
			}
		}

		/// <summary>
		/// Void SetLinkId(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetLinkId_CharArray_Int32_Int32;
		public virtual RMethod RSetLinkId_CharArray_Int32_Int32
		{
			get
			{
				if(r_RSetLinkId_CharArray_Int32_Int32 == null)
				{
					r_RSetLinkId_CharArray_Int32_Int32 = new(this, "SetLinkId", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetLinkId_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetLinkId_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetLinkText(UnityEngine.TextCore.Text.TextInfo)
		/// </summary>
		protected RMethod r_RGetLinkText_TextInfo;
		public virtual RMethod RGetLinkText_TextInfo
		{
			get
			{
				if(r_RGetLinkText_TextInfo == null)
				{
					r_RGetLinkText_TextInfo = new(this, "GetLinkText", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"));
					r_RGetLinkText_TextInfo.SetBelong(this.instance);
				}
				return r_RGetLinkText_TextInfo;
			}
		}

		/// <summary>
		/// System.String GetLinkId()
		/// </summary>
		protected RMethod r_RGetLinkId;
		public virtual RMethod RGetLinkId
		{
			get
			{
				if(r_RGetLinkId == null)
				{
					r_RGetLinkId = new(this, "GetLinkId", 0);
					r_RGetLinkId.SetBelong(this.instance);
				}
				return r_RGetLinkId;
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


        public RLinkInfo() : base("UnityEngine.TextCore.Text.LinkInfo")
        {
        }

        public RLinkInfo(System.Object instance) : base("UnityEngine.TextCore.Text.LinkInfo")
		{
            SetInstance(instance);
		}

        public RLinkInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLinkInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetLinkId(System.Char[]  @text, System.Int32  @startIndex, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @startIndex, @length};
            var ___result = RSetLinkId_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.String GetLinkId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLinkId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
