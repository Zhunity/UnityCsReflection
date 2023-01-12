using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextStyle
	/// </summary>
    public partial class RTextStyle : RMember //
    {

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle k_NormalStyle
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RTextStyle r_Fk_NormalStyle;
		public static RUnityEngine.RTextCore.RText.RTextStyle RFk_NormalStyle
		{
			get
			{
				if(r_Fk_NormalStyle == null)
				{
					r_Fk_NormalStyle = new(typeof(UnityEngine.TextCore.Text.TextStyle), "k_NormalStyle");
					r_Fk_NormalStyle.SetBelong(null);
				}
				return r_Fk_NormalStyle;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RSystem.RString r_Fm_Name;
		public virtual RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected RSystem.RInt32 r_Fm_HashCode;
		public virtual RSystem.RInt32 RFm_HashCode
		{
			get
			{
				if(r_Fm_HashCode == null)
				{
					r_Fm_HashCode = new(this, "m_HashCode");
					r_Fm_HashCode.SetBelong(this.instance);
				}
				return r_Fm_HashCode;
			}
		}

		/// <summary>
		/// System.String m_OpeningDefinition
		/// </summary>
		protected RSystem.RString r_Fm_OpeningDefinition;
		public virtual RSystem.RString RFm_OpeningDefinition
		{
			get
			{
				if(r_Fm_OpeningDefinition == null)
				{
					r_Fm_OpeningDefinition = new(this, "m_OpeningDefinition");
					r_Fm_OpeningDefinition.SetBelong(this.instance);
				}
				return r_Fm_OpeningDefinition;
			}
		}

		/// <summary>
		/// System.String m_ClosingDefinition
		/// </summary>
		protected RSystem.RString r_Fm_ClosingDefinition;
		public virtual RSystem.RString RFm_ClosingDefinition
		{
			get
			{
				if(r_Fm_ClosingDefinition == null)
				{
					r_Fm_ClosingDefinition = new(this, "m_ClosingDefinition");
					r_Fm_ClosingDefinition.SetBelong(this.instance);
				}
				return r_Fm_ClosingDefinition;
			}
		}

		/// <summary>
		/// System.UInt32[] m_OpeningTagArray
		/// </summary>
		protected RFieldArray<RSystem.RUInt32> r_Fm_OpeningTagArray;
		public virtual RFieldArray<RSystem.RUInt32> RFm_OpeningTagArray
		{
			get
			{
				if(r_Fm_OpeningTagArray == null)
				{
					r_Fm_OpeningTagArray = new(this, "m_OpeningTagArray");
					r_Fm_OpeningTagArray.SetBelong(this.instance);
				}
				return r_Fm_OpeningTagArray;
			}
		}

		/// <summary>
		/// System.UInt32[] m_ClosingTagArray
		/// </summary>
		protected RFieldArray<RSystem.RUInt32> r_Fm_ClosingTagArray;
		public virtual RFieldArray<RSystem.RUInt32> RFm_ClosingTagArray
		{
			get
			{
				if(r_Fm_ClosingTagArray == null)
				{
					r_Fm_ClosingTagArray = new(this, "m_ClosingTagArray");
					r_Fm_ClosingTagArray.SetBelong(this.instance);
				}
				return r_Fm_ClosingTagArray;
			}
		}

		/// <summary>
		/// System.UInt32[] m_OpeningTagUnicodeArray
		/// </summary>
		protected RFieldArray<RSystem.RUInt32> r_Fm_OpeningTagUnicodeArray;
		public virtual RFieldArray<RSystem.RUInt32> RFm_OpeningTagUnicodeArray
		{
			get
			{
				if(r_Fm_OpeningTagUnicodeArray == null)
				{
					r_Fm_OpeningTagUnicodeArray = new(this, "m_OpeningTagUnicodeArray");
					r_Fm_OpeningTagUnicodeArray.SetBelong(this.instance);
				}
				return r_Fm_OpeningTagUnicodeArray;
			}
		}

		/// <summary>
		/// System.UInt32[] m_ClosingTagUnicodeArray
		/// </summary>
		protected RFieldArray<RSystem.RUInt32> r_Fm_ClosingTagUnicodeArray;
		public virtual RFieldArray<RSystem.RUInt32> RFm_ClosingTagUnicodeArray
		{
			get
			{
				if(r_Fm_ClosingTagUnicodeArray == null)
				{
					r_Fm_ClosingTagUnicodeArray = new(this, "m_ClosingTagUnicodeArray");
					r_Fm_ClosingTagUnicodeArray.SetBelong(this.instance);
				}
				return r_Fm_ClosingTagUnicodeArray;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle NormalStyle
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RTextStyle r_PNormalStyle;
		public static RUnityEngine.RTextCore.RText.RTextStyle RPNormalStyle
		{
			get
			{
				if(r_PNormalStyle == null)
				{
					r_PNormalStyle = new(typeof(UnityEngine.TextCore.Text.TextStyle), "NormalStyle", -1);
					r_PNormalStyle.SetBelong(null);
				}
				return r_PNormalStyle;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected RSystem.RInt32 r_PhashCode;
		public virtual RSystem.RInt32 RPhashCode
		{
			get
			{
				if(r_PhashCode == null)
				{
					r_PhashCode = new(this, "hashCode", -1);
					r_PhashCode.SetBelong(this.instance);
				}
				return r_PhashCode;
			}
		}

		/// <summary>
		/// System.String styleOpeningDefinition
		/// </summary>
		protected RSystem.RString r_PstyleOpeningDefinition;
		public virtual RSystem.RString RPstyleOpeningDefinition
		{
			get
			{
				if(r_PstyleOpeningDefinition == null)
				{
					r_PstyleOpeningDefinition = new(this, "styleOpeningDefinition", -1);
					r_PstyleOpeningDefinition.SetBelong(this.instance);
				}
				return r_PstyleOpeningDefinition;
			}
		}

		/// <summary>
		/// System.String styleClosingDefinition
		/// </summary>
		protected RSystem.RString r_PstyleClosingDefinition;
		public virtual RSystem.RString RPstyleClosingDefinition
		{
			get
			{
				if(r_PstyleClosingDefinition == null)
				{
					r_PstyleClosingDefinition = new(this, "styleClosingDefinition", -1);
					r_PstyleClosingDefinition.SetBelong(this.instance);
				}
				return r_PstyleClosingDefinition;
			}
		}

		/// <summary>
		/// UInt32[] styleOpeningTagArray
		/// </summary>
		protected RPropertyArray<RSystem.RUInt32> r_PstyleOpeningTagArray;
		public virtual RPropertyArray<RSystem.RUInt32> RPstyleOpeningTagArray
		{
			get
			{
				if(r_PstyleOpeningTagArray == null)
				{
					r_PstyleOpeningTagArray = new(this, "styleOpeningTagArray", -1);
					r_PstyleOpeningTagArray.SetBelong(this.instance);
				}
				return r_PstyleOpeningTagArray;
			}
		}

		/// <summary>
		/// UInt32[] styleClosingTagArray
		/// </summary>
		protected RPropertyArray<RSystem.RUInt32> r_PstyleClosingTagArray;
		public virtual RPropertyArray<RSystem.RUInt32> RPstyleClosingTagArray
		{
			get
			{
				if(r_PstyleClosingTagArray == null)
				{
					r_PstyleClosingTagArray = new(this, "styleClosingTagArray", -1);
					r_PstyleClosingTagArray.SetBelong(this.instance);
				}
				return r_PstyleClosingTagArray;
			}
		}

		/// <summary>
		/// Void RefreshStyle()
		/// </summary>
		protected RMethod r_MRefreshStyle;
		public virtual RMethod RMRefreshStyle
		{
			get
			{
				if(r_MRefreshStyle == null)
				{
					r_MRefreshStyle = new(this, "RefreshStyle", 0);
					r_MRefreshStyle.SetBelong(this.instance);
				}
				return r_MRefreshStyle;
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


        public RTextStyle() : base("UnityEngine.TextCore.Text.TextStyle")
        {
        }

        public RTextStyle(System.Object instance) : base("UnityEngine.TextCore.Text.TextStyle")
		{
            SetInstance(instance);
		}

        public RTextStyle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextStyle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void RefreshStyle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshStyle.Invoke(___genericsType, ___parameters);

            
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
