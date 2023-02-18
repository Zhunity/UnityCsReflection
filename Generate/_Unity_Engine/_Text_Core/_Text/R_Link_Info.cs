
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.LinkInfo
	/// </summary>
    public partial class RLinkInfo : RMember //
    {

		/// <summary>
		/// System.Int32 hashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FhashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFhashCode
		{
			get
			{
				if(r_FhashCode == null)
				{
					r_FhashCode = new(this, "hashCode");
				}
				return r_FhashCode;
			}
		}

		/// <summary>
		/// System.Int32 linkIdFirstCharacterIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlinkIdFirstCharacterIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlinkIdFirstCharacterIndex
		{
			get
			{
				if(r_FlinkIdFirstCharacterIndex == null)
				{
					r_FlinkIdFirstCharacterIndex = new(this, "linkIdFirstCharacterIndex");
				}
				return r_FlinkIdFirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 linkIdLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlinkIdLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlinkIdLength
		{
			get
			{
				if(r_FlinkIdLength == null)
				{
					r_FlinkIdLength = new(this, "linkIdLength");
				}
				return r_FlinkIdLength;
			}
		}

		/// <summary>
		/// System.Int32 linkTextfirstCharacterIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlinkTextfirstCharacterIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlinkTextfirstCharacterIndex
		{
			get
			{
				if(r_FlinkTextfirstCharacterIndex == null)
				{
					r_FlinkTextfirstCharacterIndex = new(this, "linkTextfirstCharacterIndex");
				}
				return r_FlinkTextfirstCharacterIndex;
			}
		}

		/// <summary>
		/// System.Int32 linkTextLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlinkTextLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlinkTextLength
		{
			get
			{
				if(r_FlinkTextLength == null)
				{
					r_FlinkTextLength = new(this, "linkTextLength");
				}
				return r_FlinkTextLength;
			}
		}

		/// <summary>
		/// System.Char[] linkId
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_FlinkId;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFlinkId
		{
			get
			{
				if(r_FlinkId == null)
				{
					r_FlinkId = new(this, "linkId");
				}
				return r_FlinkId;
			}
		}

		/// <summary>
		/// System.String m_LinkIdString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LinkIdString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LinkIdString
		{
			get
			{
				if(r_Fm_LinkIdString == null)
				{
					r_Fm_LinkIdString = new(this, "m_LinkIdString");
				}
				return r_Fm_LinkIdString;
			}
		}

		/// <summary>
		/// System.String m_LinkTextString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LinkTextString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LinkTextString
		{
			get
			{
				if(r_Fm_LinkTextString == null)
				{
					r_Fm_LinkTextString = new(this, "m_LinkTextString");
				}
				return r_Fm_LinkTextString;
			}
		}

		/// <summary>
		/// Void SetLinkId(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetLinkId_CharArray_Int32_Int32;
		public virtual RMethod RMSetLinkId_CharArray_Int32_Int32
		{
			get
			{
				if(r_MSetLinkId_CharArray_Int32_Int32 == null)
				{
					r_MSetLinkId_CharArray_Int32_Int32 = new(this, "SetLinkId", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetLinkId_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetLinkText(UnityEngine.TextCore.Text.TextInfo)
		/// </summary>
		protected RMethod r_MGetLinkText_TextInfo;
		public virtual RMethod RMGetLinkText_TextInfo
		{
			get
			{
				if(r_MGetLinkText_TextInfo == null)
				{
					r_MGetLinkText_TextInfo = new(this, "GetLinkText", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"));
				}
				return r_MGetLinkText_TextInfo;
			}
		}

		/// <summary>
		/// System.String GetLinkId()
		/// </summary>
		protected RMethod r_MGetLinkId;
		public virtual RMethod RMGetLinkId
		{
			get
			{
				if(r_MGetLinkId == null)
				{
					r_MGetLinkId = new(this, "GetLinkId", 0);
				}
				return r_MGetLinkId;
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
            var ___result = RMSetLinkId_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetLinkText(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo @textInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textInfo.Value};
            var ___result = RMGetLinkText_TextInfo.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetLinkId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLinkId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
