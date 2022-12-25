using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CodePageDataItem
	/// </summary>
    public partial class RCodePageDataItem : RMember //
    {

		/// <summary>
		/// System.Int32 m_dataIndex
		/// </summary>
		protected RField r_m_dataIndex;
		public virtual RField Rm_dataIndex
		{
			get
			{
				if(r_m_dataIndex == null)
				{
					r_m_dataIndex = new(this, "m_dataIndex");
					r_m_dataIndex.SetBelong(this.instance);
				}
				return r_m_dataIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_uiFamilyCodePage
		/// </summary>
		protected RField r_m_uiFamilyCodePage;
		public virtual RField Rm_uiFamilyCodePage
		{
			get
			{
				if(r_m_uiFamilyCodePage == null)
				{
					r_m_uiFamilyCodePage = new(this, "m_uiFamilyCodePage");
					r_m_uiFamilyCodePage.SetBelong(this.instance);
				}
				return r_m_uiFamilyCodePage;
			}
		}

		/// <summary>
		/// System.String m_webName
		/// </summary>
		protected RField r_m_webName;
		public virtual RField Rm_webName
		{
			get
			{
				if(r_m_webName == null)
				{
					r_m_webName = new(this, "m_webName");
					r_m_webName.SetBelong(this.instance);
				}
				return r_m_webName;
			}
		}

		/// <summary>
		/// System.String m_headerName
		/// </summary>
		protected RField r_m_headerName;
		public virtual RField Rm_headerName
		{
			get
			{
				if(r_m_headerName == null)
				{
					r_m_headerName = new(this, "m_headerName");
					r_m_headerName.SetBelong(this.instance);
				}
				return r_m_headerName;
			}
		}

		/// <summary>
		/// System.String m_bodyName
		/// </summary>
		protected RField r_m_bodyName;
		public virtual RField Rm_bodyName
		{
			get
			{
				if(r_m_bodyName == null)
				{
					r_m_bodyName = new(this, "m_bodyName");
					r_m_bodyName.SetBelong(this.instance);
				}
				return r_m_bodyName;
			}
		}

		/// <summary>
		/// System.UInt32 m_flags
		/// </summary>
		protected RField r_m_flags;
		public virtual RField Rm_flags
		{
			get
			{
				if(r_m_flags == null)
				{
					r_m_flags = new(this, "m_flags");
					r_m_flags.SetBelong(this.instance);
				}
				return r_m_flags;
			}
		}

		/// <summary>
		/// System.Char[] sep
		/// </summary>
		protected static RFieldArray<RField> r_sep;
		public static RFieldArray<RField> Rsep
		{
			get
			{
				if(r_sep == null)
				{
					r_sep = new( ReleactionUtils.GetType("System.Globalization.CodePageDataItem"), "sep");
					r_sep.SetBelong(null);
				}
				return r_sep;
			}
		}

		/// <summary>
		/// System.String WebName
		/// </summary>
		protected RProperty r_WebName;
		public virtual RProperty RWebName
		{
			get
			{
				if(r_WebName == null)
				{
					r_WebName = new(this, "WebName", -1);
					r_WebName.SetBelong(this.instance);
				}
				return r_WebName;
			}
		}

		/// <summary>
		/// Int32 UIFamilyCodePage
		/// </summary>
		protected RProperty r_UIFamilyCodePage;
		public virtual RProperty RUIFamilyCodePage
		{
			get
			{
				if(r_UIFamilyCodePage == null)
				{
					r_UIFamilyCodePage = new(this, "UIFamilyCodePage", -1);
					r_UIFamilyCodePage.SetBelong(this.instance);
				}
				return r_UIFamilyCodePage;
			}
		}

		/// <summary>
		/// System.String HeaderName
		/// </summary>
		protected RProperty r_HeaderName;
		public virtual RProperty RHeaderName
		{
			get
			{
				if(r_HeaderName == null)
				{
					r_HeaderName = new(this, "HeaderName", -1);
					r_HeaderName.SetBelong(this.instance);
				}
				return r_HeaderName;
			}
		}

		/// <summary>
		/// System.String BodyName
		/// </summary>
		protected RProperty r_BodyName;
		public virtual RProperty RBodyName
		{
			get
			{
				if(r_BodyName == null)
				{
					r_BodyName = new(this, "BodyName", -1);
					r_BodyName.SetBelong(this.instance);
				}
				return r_BodyName;
			}
		}

		/// <summary>
		/// UInt32 Flags
		/// </summary>
		protected RProperty r_Flags;
		public virtual RProperty RFlags
		{
			get
			{
				if(r_Flags == null)
				{
					r_Flags = new(this, "Flags", -1);
					r_Flags.SetBelong(this.instance);
				}
				return r_Flags;
			}
		}

		/// <summary>
		/// System.String CreateString(System.String, UInt32)
		/// </summary>
		protected static RMethod r_RCreateString_String_UInt32;
		public static RMethod RCreateString_String_UInt32
		{
			get
			{
				if(r_RCreateString_String_UInt32 == null)
				{
					r_RCreateString_String_UInt32 = new( ReleactionUtils.GetType("System.Globalization.CodePageDataItem"), "CreateString", 0, typeof(System.String), typeof(System.UInt32));
					r_RCreateString_String_UInt32.SetBelong(null);
				}
				return r_RCreateString_String_UInt32;
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

        public static System.String CreateString(System.String  @pStrings, System.UInt32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pStrings, @index};
            var ___result = RCreateString_String_UInt32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
