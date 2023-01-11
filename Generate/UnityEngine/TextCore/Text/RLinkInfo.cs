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
		protected RSystem.RInt32 r_hashCode;
		public virtual RSystem.RInt32 RhashCode
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
		protected RSystem.RInt32 r_linkIdFirstCharacterIndex;
		public virtual RSystem.RInt32 RlinkIdFirstCharacterIndex
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
		protected RSystem.RInt32 r_linkIdLength;
		public virtual RSystem.RInt32 RlinkIdLength
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
		protected RSystem.RInt32 r_linkTextfirstCharacterIndex;
		public virtual RSystem.RInt32 RlinkTextfirstCharacterIndex
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
		protected RSystem.RInt32 r_linkTextLength;
		public virtual RSystem.RInt32 RlinkTextLength
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
		protected RFieldArray<RSystem.RChar> r_linkId;
		public virtual RFieldArray<RSystem.RChar> RlinkId
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
		protected RSystem.RString r_m_LinkIdString;
		public virtual RSystem.RString Rm_LinkIdString
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
		protected RSystem.RString r_m_LinkTextString;
		public virtual RSystem.RString Rm_LinkTextString
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
		protected RMethod r_SetLinkId_CharArray_Int32_Int32;
		public virtual RMethod RSetLinkId_CharArray_Int32_Int32
		{
			get
			{
				if(r_SetLinkId_CharArray_Int32_Int32 == null)
				{
					r_SetLinkId_CharArray_Int32_Int32 = new(this, "SetLinkId", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetLinkId_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetLinkId_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetLinkText(UnityEngine.TextCore.Text.TextInfo)
		/// </summary>
		protected RMethod r_GetLinkText_TextInfo;
		public virtual RMethod RGetLinkText_TextInfo
		{
			get
			{
				if(r_GetLinkText_TextInfo == null)
				{
					r_GetLinkText_TextInfo = new(this, "GetLinkText", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"));
					r_GetLinkText_TextInfo.SetBelong(this.instance);
				}
				return r_GetLinkText_TextInfo;
			}
		}

		/// <summary>
		/// System.String GetLinkId()
		/// </summary>
		protected RMethod r_GetLinkId;
		public virtual RMethod RGetLinkId
		{
			get
			{
				if(r_GetLinkId == null)
				{
					r_GetLinkId = new(this, "GetLinkId", 0);
					r_GetLinkId.SetBelong(this.instance);
				}
				return r_GetLinkId;
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

        public virtual void SetLinkId(System.Char[] @text, System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @startIndex, @length};
            var ___result = RSetLinkId_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetLinkText(RUnityEngine.RTextCore.RText.RTextInfo @textInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textInfo.Value};
            var ___result = RGetLinkText_TextInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetLinkId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLinkId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
