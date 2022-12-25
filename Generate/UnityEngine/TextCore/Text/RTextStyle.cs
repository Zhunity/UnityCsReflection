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
		protected static RUnityEngine.RTextCore.RText.RTextStyle r_k_NormalStyle;
		public static RUnityEngine.RTextCore.RText.RTextStyle Rk_NormalStyle
		{
			get
			{
				if(r_k_NormalStyle == null)
				{
					r_k_NormalStyle = new(typeof(UnityEngine.TextCore.Text.TextStyle), "k_NormalStyle");
					r_k_NormalStyle.SetBelong(null);
				}
				return r_k_NormalStyle;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected RField r_m_HashCode;
		public virtual RField Rm_HashCode
		{
			get
			{
				if(r_m_HashCode == null)
				{
					r_m_HashCode = new(this, "m_HashCode");
					r_m_HashCode.SetBelong(this.instance);
				}
				return r_m_HashCode;
			}
		}

		/// <summary>
		/// System.String m_OpeningDefinition
		/// </summary>
		protected RField r_m_OpeningDefinition;
		public virtual RField Rm_OpeningDefinition
		{
			get
			{
				if(r_m_OpeningDefinition == null)
				{
					r_m_OpeningDefinition = new(this, "m_OpeningDefinition");
					r_m_OpeningDefinition.SetBelong(this.instance);
				}
				return r_m_OpeningDefinition;
			}
		}

		/// <summary>
		/// System.String m_ClosingDefinition
		/// </summary>
		protected RField r_m_ClosingDefinition;
		public virtual RField Rm_ClosingDefinition
		{
			get
			{
				if(r_m_ClosingDefinition == null)
				{
					r_m_ClosingDefinition = new(this, "m_ClosingDefinition");
					r_m_ClosingDefinition.SetBelong(this.instance);
				}
				return r_m_ClosingDefinition;
			}
		}

		/// <summary>
		/// System.UInt32[] m_OpeningTagArray
		/// </summary>
		protected RFieldArray<RField> r_m_OpeningTagArray;
		public virtual RFieldArray<RField> Rm_OpeningTagArray
		{
			get
			{
				if(r_m_OpeningTagArray == null)
				{
					r_m_OpeningTagArray = new(this, "m_OpeningTagArray");
					r_m_OpeningTagArray.SetBelong(this.instance);
				}
				return r_m_OpeningTagArray;
			}
		}

		/// <summary>
		/// System.UInt32[] m_ClosingTagArray
		/// </summary>
		protected RFieldArray<RField> r_m_ClosingTagArray;
		public virtual RFieldArray<RField> Rm_ClosingTagArray
		{
			get
			{
				if(r_m_ClosingTagArray == null)
				{
					r_m_ClosingTagArray = new(this, "m_ClosingTagArray");
					r_m_ClosingTagArray.SetBelong(this.instance);
				}
				return r_m_ClosingTagArray;
			}
		}

		/// <summary>
		/// System.UInt32[] m_OpeningTagUnicodeArray
		/// </summary>
		protected RFieldArray<RField> r_m_OpeningTagUnicodeArray;
		public virtual RFieldArray<RField> Rm_OpeningTagUnicodeArray
		{
			get
			{
				if(r_m_OpeningTagUnicodeArray == null)
				{
					r_m_OpeningTagUnicodeArray = new(this, "m_OpeningTagUnicodeArray");
					r_m_OpeningTagUnicodeArray.SetBelong(this.instance);
				}
				return r_m_OpeningTagUnicodeArray;
			}
		}

		/// <summary>
		/// System.UInt32[] m_ClosingTagUnicodeArray
		/// </summary>
		protected RFieldArray<RField> r_m_ClosingTagUnicodeArray;
		public virtual RFieldArray<RField> Rm_ClosingTagUnicodeArray
		{
			get
			{
				if(r_m_ClosingTagUnicodeArray == null)
				{
					r_m_ClosingTagUnicodeArray = new(this, "m_ClosingTagUnicodeArray");
					r_m_ClosingTagUnicodeArray.SetBelong(this.instance);
				}
				return r_m_ClosingTagUnicodeArray;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextStyle NormalStyle
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RTextStyle r_NormalStyle;
		public static RUnityEngine.RTextCore.RText.RTextStyle RNormalStyle
		{
			get
			{
				if(r_NormalStyle == null)
				{
					r_NormalStyle = new(typeof(UnityEngine.TextCore.Text.TextStyle), "NormalStyle", -1);
					r_NormalStyle.SetBelong(null);
				}
				return r_NormalStyle;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected RProperty r_hashCode;
		public virtual RProperty RhashCode
		{
			get
			{
				if(r_hashCode == null)
				{
					r_hashCode = new(this, "hashCode", -1);
					r_hashCode.SetBelong(this.instance);
				}
				return r_hashCode;
			}
		}

		/// <summary>
		/// System.String styleOpeningDefinition
		/// </summary>
		protected RProperty r_styleOpeningDefinition;
		public virtual RProperty RstyleOpeningDefinition
		{
			get
			{
				if(r_styleOpeningDefinition == null)
				{
					r_styleOpeningDefinition = new(this, "styleOpeningDefinition", -1);
					r_styleOpeningDefinition.SetBelong(this.instance);
				}
				return r_styleOpeningDefinition;
			}
		}

		/// <summary>
		/// System.String styleClosingDefinition
		/// </summary>
		protected RProperty r_styleClosingDefinition;
		public virtual RProperty RstyleClosingDefinition
		{
			get
			{
				if(r_styleClosingDefinition == null)
				{
					r_styleClosingDefinition = new(this, "styleClosingDefinition", -1);
					r_styleClosingDefinition.SetBelong(this.instance);
				}
				return r_styleClosingDefinition;
			}
		}

		/// <summary>
		/// UInt32[] styleOpeningTagArray
		/// </summary>
		protected RPropertyArray<RProperty> r_styleOpeningTagArray;
		public virtual RPropertyArray<RProperty> RstyleOpeningTagArray
		{
			get
			{
				if(r_styleOpeningTagArray == null)
				{
					r_styleOpeningTagArray = new(this, "styleOpeningTagArray", -1);
					r_styleOpeningTagArray.SetBelong(this.instance);
				}
				return r_styleOpeningTagArray;
			}
		}

		/// <summary>
		/// UInt32[] styleClosingTagArray
		/// </summary>
		protected RPropertyArray<RProperty> r_styleClosingTagArray;
		public virtual RPropertyArray<RProperty> RstyleClosingTagArray
		{
			get
			{
				if(r_styleClosingTagArray == null)
				{
					r_styleClosingTagArray = new(this, "styleClosingTagArray", -1);
					r_styleClosingTagArray.SetBelong(this.instance);
				}
				return r_styleClosingTagArray;
			}
		}

		/// <summary>
		/// Void RefreshStyle()
		/// </summary>
		protected RMethod r_RRefreshStyle;
		public virtual RMethod RRefreshStyle
		{
			get
			{
				if(r_RRefreshStyle == null)
				{
					r_RRefreshStyle = new(this, "RefreshStyle", 0);
					r_RRefreshStyle.SetBelong(this.instance);
				}
				return r_RRefreshStyle;
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
            var ___result = RRefreshStyle.Invoke(___genericsType, ___parameters);

            
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
