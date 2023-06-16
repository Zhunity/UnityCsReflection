
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Globalization.CodePageDataItem
	/// </summary>
    public partial class RCodePageDataItem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Globalization.CodePageDataItem");
            }
        }

        public RCodePageDataItem() : base("System.Globalization.CodePageDataItem")
        {
        }

        public RCodePageDataItem(System.Object instance) : base("System.Globalization.CodePageDataItem")
		{
            SetInstance(instance);
		}

        public RCodePageDataItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCodePageDataItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 m_dataIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_dataIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_dataIndex
		{
			get
			{
				if(r_Fm_dataIndex == null)
				{
					r_Fm_dataIndex = new(this, "m_dataIndex");
				}
				return r_Fm_dataIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_uiFamilyCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_uiFamilyCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_uiFamilyCodePage
		{
			get
			{
				if(r_Fm_uiFamilyCodePage == null)
				{
					r_Fm_uiFamilyCodePage = new(this, "m_uiFamilyCodePage");
				}
				return r_Fm_uiFamilyCodePage;
			}
		}

		/// <summary>
		/// System.String m_webName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_webName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_webName
		{
			get
			{
				if(r_Fm_webName == null)
				{
					r_Fm_webName = new(this, "m_webName");
				}
				return r_Fm_webName;
			}
		}

		/// <summary>
		/// System.String m_headerName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_headerName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_headerName
		{
			get
			{
				if(r_Fm_headerName == null)
				{
					r_Fm_headerName = new(this, "m_headerName");
				}
				return r_Fm_headerName;
			}
		}

		/// <summary>
		/// System.String m_bodyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_bodyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_bodyName
		{
			get
			{
				if(r_Fm_bodyName == null)
				{
					r_Fm_bodyName = new(this, "m_bodyName");
				}
				return r_Fm_bodyName;
			}
		}

		/// <summary>
		/// System.UInt32 m_flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_flags
		{
			get
			{
				if(r_Fm_flags == null)
				{
					r_Fm_flags = new(this, "m_flags");
				}
				return r_Fm_flags;
			}
		}

		/// <summary>
		/// System.Char[] sep
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Fsep;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFsep
		{
			get
			{
				if(r_Fsep == null)
				{
					r_Fsep = new(Type, "sep");
				}
				return r_Fsep;
			}
		}

		/// <summary>
		/// System.String WebName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PWebName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPWebName
		{
			get
			{
				if(r_PWebName == null)
				{
					r_PWebName = new(this, "WebName", -1);
				}
				return r_PWebName;
			}
		}

		/// <summary>
		/// Int32 UIFamilyCodePage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUIFamilyCodePage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUIFamilyCodePage
		{
			get
			{
				if(r_PUIFamilyCodePage == null)
				{
					r_PUIFamilyCodePage = new(this, "UIFamilyCodePage", -1);
				}
				return r_PUIFamilyCodePage;
			}
		}

		/// <summary>
		/// System.String HeaderName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PHeaderName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPHeaderName
		{
			get
			{
				if(r_PHeaderName == null)
				{
					r_PHeaderName = new(this, "HeaderName", -1);
				}
				return r_PHeaderName;
			}
		}

		/// <summary>
		/// System.String BodyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PBodyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPBodyName
		{
			get
			{
				if(r_PBodyName == null)
				{
					r_PBodyName = new(this, "BodyName", -1);
				}
				return r_PBodyName;
			}
		}

		/// <summary>
		/// UInt32 Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPFlags
		{
			get
			{
				if(r_PFlags == null)
				{
					r_PFlags = new(this, "Flags", -1);
				}
				return r_PFlags;
			}
		}

		/// <summary>
		/// System.String CreateString(System.String, UInt32)
		/// </summary>
		protected static RMethod r_MCreateString_String_UInt32;
		public static RMethod RMCreateString_String_UInt32
		{
			get
			{
				if(r_MCreateString_String_UInt32 == null)
				{
					r_MCreateString_String_UInt32 = new(Type, "CreateString", 0, typeof(System.String), typeof(System.UInt32));
				}
				return r_MCreateString_String_UInt32;
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


        public static System.String CreateString(System.String @pStrings, System.UInt32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pStrings, @index};
            var ___result = RMCreateString_String_UInt32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
