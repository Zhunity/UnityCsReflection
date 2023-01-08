using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
	/// UnityEngine.TextCore.FaceInfo
	/// </summary>
    public partial class RFaceInfo : RMember //
    {

		/// <summary>
		/// System.Int32 m_FaceIndex
		/// </summary>
		protected RField r_m_FaceIndex;
		public virtual RField Rm_FaceIndex
		{
			get
			{
				if(r_m_FaceIndex == null)
				{
					r_m_FaceIndex = new(this, "m_FaceIndex");
					r_m_FaceIndex.SetBelong(this.instance);
				}
				return r_m_FaceIndex;
			}
		}

		/// <summary>
		/// System.String m_FamilyName
		/// </summary>
		protected RField r_m_FamilyName;
		public virtual RField Rm_FamilyName
		{
			get
			{
				if(r_m_FamilyName == null)
				{
					r_m_FamilyName = new(this, "m_FamilyName");
					r_m_FamilyName.SetBelong(this.instance);
				}
				return r_m_FamilyName;
			}
		}

		/// <summary>
		/// System.String m_StyleName
		/// </summary>
		protected RField r_m_StyleName;
		public virtual RField Rm_StyleName
		{
			get
			{
				if(r_m_StyleName == null)
				{
					r_m_StyleName = new(this, "m_StyleName");
					r_m_StyleName.SetBelong(this.instance);
				}
				return r_m_StyleName;
			}
		}

		/// <summary>
		/// System.Int32 m_PointSize
		/// </summary>
		protected RField r_m_PointSize;
		public virtual RField Rm_PointSize
		{
			get
			{
				if(r_m_PointSize == null)
				{
					r_m_PointSize = new(this, "m_PointSize");
					r_m_PointSize.SetBelong(this.instance);
				}
				return r_m_PointSize;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected RField r_m_Scale;
		public virtual RField Rm_Scale
		{
			get
			{
				if(r_m_Scale == null)
				{
					r_m_Scale = new(this, "m_Scale");
					r_m_Scale.SetBelong(this.instance);
				}
				return r_m_Scale;
			}
		}

		/// <summary>
		/// System.Int32 m_UnitsPerEM
		/// </summary>
		protected RField r_m_UnitsPerEM;
		public virtual RField Rm_UnitsPerEM
		{
			get
			{
				if(r_m_UnitsPerEM == null)
				{
					r_m_UnitsPerEM = new(this, "m_UnitsPerEM");
					r_m_UnitsPerEM.SetBelong(this.instance);
				}
				return r_m_UnitsPerEM;
			}
		}

		/// <summary>
		/// System.Single m_LineHeight
		/// </summary>
		protected RField r_m_LineHeight;
		public virtual RField Rm_LineHeight
		{
			get
			{
				if(r_m_LineHeight == null)
				{
					r_m_LineHeight = new(this, "m_LineHeight");
					r_m_LineHeight.SetBelong(this.instance);
				}
				return r_m_LineHeight;
			}
		}

		/// <summary>
		/// System.Single m_AscentLine
		/// </summary>
		protected RField r_m_AscentLine;
		public virtual RField Rm_AscentLine
		{
			get
			{
				if(r_m_AscentLine == null)
				{
					r_m_AscentLine = new(this, "m_AscentLine");
					r_m_AscentLine.SetBelong(this.instance);
				}
				return r_m_AscentLine;
			}
		}

		/// <summary>
		/// System.Single m_CapLine
		/// </summary>
		protected RField r_m_CapLine;
		public virtual RField Rm_CapLine
		{
			get
			{
				if(r_m_CapLine == null)
				{
					r_m_CapLine = new(this, "m_CapLine");
					r_m_CapLine.SetBelong(this.instance);
				}
				return r_m_CapLine;
			}
		}

		/// <summary>
		/// System.Single m_MeanLine
		/// </summary>
		protected RField r_m_MeanLine;
		public virtual RField Rm_MeanLine
		{
			get
			{
				if(r_m_MeanLine == null)
				{
					r_m_MeanLine = new(this, "m_MeanLine");
					r_m_MeanLine.SetBelong(this.instance);
				}
				return r_m_MeanLine;
			}
		}

		/// <summary>
		/// System.Single m_Baseline
		/// </summary>
		protected RField r_m_Baseline;
		public virtual RField Rm_Baseline
		{
			get
			{
				if(r_m_Baseline == null)
				{
					r_m_Baseline = new(this, "m_Baseline");
					r_m_Baseline.SetBelong(this.instance);
				}
				return r_m_Baseline;
			}
		}

		/// <summary>
		/// System.Single m_DescentLine
		/// </summary>
		protected RField r_m_DescentLine;
		public virtual RField Rm_DescentLine
		{
			get
			{
				if(r_m_DescentLine == null)
				{
					r_m_DescentLine = new(this, "m_DescentLine");
					r_m_DescentLine.SetBelong(this.instance);
				}
				return r_m_DescentLine;
			}
		}

		/// <summary>
		/// System.Single m_SuperscriptOffset
		/// </summary>
		protected RField r_m_SuperscriptOffset;
		public virtual RField Rm_SuperscriptOffset
		{
			get
			{
				if(r_m_SuperscriptOffset == null)
				{
					r_m_SuperscriptOffset = new(this, "m_SuperscriptOffset");
					r_m_SuperscriptOffset.SetBelong(this.instance);
				}
				return r_m_SuperscriptOffset;
			}
		}

		/// <summary>
		/// System.Single m_SuperscriptSize
		/// </summary>
		protected RField r_m_SuperscriptSize;
		public virtual RField Rm_SuperscriptSize
		{
			get
			{
				if(r_m_SuperscriptSize == null)
				{
					r_m_SuperscriptSize = new(this, "m_SuperscriptSize");
					r_m_SuperscriptSize.SetBelong(this.instance);
				}
				return r_m_SuperscriptSize;
			}
		}

		/// <summary>
		/// System.Single m_SubscriptOffset
		/// </summary>
		protected RField r_m_SubscriptOffset;
		public virtual RField Rm_SubscriptOffset
		{
			get
			{
				if(r_m_SubscriptOffset == null)
				{
					r_m_SubscriptOffset = new(this, "m_SubscriptOffset");
					r_m_SubscriptOffset.SetBelong(this.instance);
				}
				return r_m_SubscriptOffset;
			}
		}

		/// <summary>
		/// System.Single m_SubscriptSize
		/// </summary>
		protected RField r_m_SubscriptSize;
		public virtual RField Rm_SubscriptSize
		{
			get
			{
				if(r_m_SubscriptSize == null)
				{
					r_m_SubscriptSize = new(this, "m_SubscriptSize");
					r_m_SubscriptSize.SetBelong(this.instance);
				}
				return r_m_SubscriptSize;
			}
		}

		/// <summary>
		/// System.Single m_UnderlineOffset
		/// </summary>
		protected RField r_m_UnderlineOffset;
		public virtual RField Rm_UnderlineOffset
		{
			get
			{
				if(r_m_UnderlineOffset == null)
				{
					r_m_UnderlineOffset = new(this, "m_UnderlineOffset");
					r_m_UnderlineOffset.SetBelong(this.instance);
				}
				return r_m_UnderlineOffset;
			}
		}

		/// <summary>
		/// System.Single m_UnderlineThickness
		/// </summary>
		protected RField r_m_UnderlineThickness;
		public virtual RField Rm_UnderlineThickness
		{
			get
			{
				if(r_m_UnderlineThickness == null)
				{
					r_m_UnderlineThickness = new(this, "m_UnderlineThickness");
					r_m_UnderlineThickness.SetBelong(this.instance);
				}
				return r_m_UnderlineThickness;
			}
		}

		/// <summary>
		/// System.Single m_StrikethroughOffset
		/// </summary>
		protected RField r_m_StrikethroughOffset;
		public virtual RField Rm_StrikethroughOffset
		{
			get
			{
				if(r_m_StrikethroughOffset == null)
				{
					r_m_StrikethroughOffset = new(this, "m_StrikethroughOffset");
					r_m_StrikethroughOffset.SetBelong(this.instance);
				}
				return r_m_StrikethroughOffset;
			}
		}

		/// <summary>
		/// System.Single m_StrikethroughThickness
		/// </summary>
		protected RField r_m_StrikethroughThickness;
		public virtual RField Rm_StrikethroughThickness
		{
			get
			{
				if(r_m_StrikethroughThickness == null)
				{
					r_m_StrikethroughThickness = new(this, "m_StrikethroughThickness");
					r_m_StrikethroughThickness.SetBelong(this.instance);
				}
				return r_m_StrikethroughThickness;
			}
		}

		/// <summary>
		/// System.Single m_TabWidth
		/// </summary>
		protected RField r_m_TabWidth;
		public virtual RField Rm_TabWidth
		{
			get
			{
				if(r_m_TabWidth == null)
				{
					r_m_TabWidth = new(this, "m_TabWidth");
					r_m_TabWidth.SetBelong(this.instance);
				}
				return r_m_TabWidth;
			}
		}

		/// <summary>
		/// Int32 faceIndex
		/// </summary>
		protected RProperty r_faceIndex;
		public virtual RProperty RfaceIndex
		{
			get
			{
				if(r_faceIndex == null)
				{
					r_faceIndex = new(this, "faceIndex", -1);
					r_faceIndex.SetBelong(this.instance);
				}
				return r_faceIndex;
			}
		}

		/// <summary>
		/// System.String familyName
		/// </summary>
		protected RProperty r_familyName;
		public virtual RProperty RfamilyName
		{
			get
			{
				if(r_familyName == null)
				{
					r_familyName = new(this, "familyName", -1);
					r_familyName.SetBelong(this.instance);
				}
				return r_familyName;
			}
		}

		/// <summary>
		/// System.String styleName
		/// </summary>
		protected RProperty r_styleName;
		public virtual RProperty RstyleName
		{
			get
			{
				if(r_styleName == null)
				{
					r_styleName = new(this, "styleName", -1);
					r_styleName.SetBelong(this.instance);
				}
				return r_styleName;
			}
		}

		/// <summary>
		/// Int32 pointSize
		/// </summary>
		protected RProperty r_pointSize;
		public virtual RProperty RpointSize
		{
			get
			{
				if(r_pointSize == null)
				{
					r_pointSize = new(this, "pointSize", -1);
					r_pointSize.SetBelong(this.instance);
				}
				return r_pointSize;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected RProperty r_scale;
		public virtual RProperty Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale", -1);
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// Int32 unitsPerEM
		/// </summary>
		protected RProperty r_unitsPerEM;
		public virtual RProperty RunitsPerEM
		{
			get
			{
				if(r_unitsPerEM == null)
				{
					r_unitsPerEM = new(this, "unitsPerEM", -1);
					r_unitsPerEM.SetBelong(this.instance);
				}
				return r_unitsPerEM;
			}
		}

		/// <summary>
		/// Single lineHeight
		/// </summary>
		protected RProperty r_lineHeight;
		public virtual RProperty RlineHeight
		{
			get
			{
				if(r_lineHeight == null)
				{
					r_lineHeight = new(this, "lineHeight", -1);
					r_lineHeight.SetBelong(this.instance);
				}
				return r_lineHeight;
			}
		}

		/// <summary>
		/// Single ascentLine
		/// </summary>
		protected RProperty r_ascentLine;
		public virtual RProperty RascentLine
		{
			get
			{
				if(r_ascentLine == null)
				{
					r_ascentLine = new(this, "ascentLine", -1);
					r_ascentLine.SetBelong(this.instance);
				}
				return r_ascentLine;
			}
		}

		/// <summary>
		/// Single capLine
		/// </summary>
		protected RProperty r_capLine;
		public virtual RProperty RcapLine
		{
			get
			{
				if(r_capLine == null)
				{
					r_capLine = new(this, "capLine", -1);
					r_capLine.SetBelong(this.instance);
				}
				return r_capLine;
			}
		}

		/// <summary>
		/// Single meanLine
		/// </summary>
		protected RProperty r_meanLine;
		public virtual RProperty RmeanLine
		{
			get
			{
				if(r_meanLine == null)
				{
					r_meanLine = new(this, "meanLine", -1);
					r_meanLine.SetBelong(this.instance);
				}
				return r_meanLine;
			}
		}

		/// <summary>
		/// Single baseline
		/// </summary>
		protected RProperty r_baseline;
		public virtual RProperty Rbaseline
		{
			get
			{
				if(r_baseline == null)
				{
					r_baseline = new(this, "baseline", -1);
					r_baseline.SetBelong(this.instance);
				}
				return r_baseline;
			}
		}

		/// <summary>
		/// Single descentLine
		/// </summary>
		protected RProperty r_descentLine;
		public virtual RProperty RdescentLine
		{
			get
			{
				if(r_descentLine == null)
				{
					r_descentLine = new(this, "descentLine", -1);
					r_descentLine.SetBelong(this.instance);
				}
				return r_descentLine;
			}
		}

		/// <summary>
		/// Single superscriptOffset
		/// </summary>
		protected RProperty r_superscriptOffset;
		public virtual RProperty RsuperscriptOffset
		{
			get
			{
				if(r_superscriptOffset == null)
				{
					r_superscriptOffset = new(this, "superscriptOffset", -1);
					r_superscriptOffset.SetBelong(this.instance);
				}
				return r_superscriptOffset;
			}
		}

		/// <summary>
		/// Single superscriptSize
		/// </summary>
		protected RProperty r_superscriptSize;
		public virtual RProperty RsuperscriptSize
		{
			get
			{
				if(r_superscriptSize == null)
				{
					r_superscriptSize = new(this, "superscriptSize", -1);
					r_superscriptSize.SetBelong(this.instance);
				}
				return r_superscriptSize;
			}
		}

		/// <summary>
		/// Single subscriptOffset
		/// </summary>
		protected RProperty r_subscriptOffset;
		public virtual RProperty RsubscriptOffset
		{
			get
			{
				if(r_subscriptOffset == null)
				{
					r_subscriptOffset = new(this, "subscriptOffset", -1);
					r_subscriptOffset.SetBelong(this.instance);
				}
				return r_subscriptOffset;
			}
		}

		/// <summary>
		/// Single subscriptSize
		/// </summary>
		protected RProperty r_subscriptSize;
		public virtual RProperty RsubscriptSize
		{
			get
			{
				if(r_subscriptSize == null)
				{
					r_subscriptSize = new(this, "subscriptSize", -1);
					r_subscriptSize.SetBelong(this.instance);
				}
				return r_subscriptSize;
			}
		}

		/// <summary>
		/// Single underlineOffset
		/// </summary>
		protected RProperty r_underlineOffset;
		public virtual RProperty RunderlineOffset
		{
			get
			{
				if(r_underlineOffset == null)
				{
					r_underlineOffset = new(this, "underlineOffset", -1);
					r_underlineOffset.SetBelong(this.instance);
				}
				return r_underlineOffset;
			}
		}

		/// <summary>
		/// Single underlineThickness
		/// </summary>
		protected RProperty r_underlineThickness;
		public virtual RProperty RunderlineThickness
		{
			get
			{
				if(r_underlineThickness == null)
				{
					r_underlineThickness = new(this, "underlineThickness", -1);
					r_underlineThickness.SetBelong(this.instance);
				}
				return r_underlineThickness;
			}
		}

		/// <summary>
		/// Single strikethroughOffset
		/// </summary>
		protected RProperty r_strikethroughOffset;
		public virtual RProperty RstrikethroughOffset
		{
			get
			{
				if(r_strikethroughOffset == null)
				{
					r_strikethroughOffset = new(this, "strikethroughOffset", -1);
					r_strikethroughOffset.SetBelong(this.instance);
				}
				return r_strikethroughOffset;
			}
		}

		/// <summary>
		/// Single strikethroughThickness
		/// </summary>
		protected RProperty r_strikethroughThickness;
		public virtual RProperty RstrikethroughThickness
		{
			get
			{
				if(r_strikethroughThickness == null)
				{
					r_strikethroughThickness = new(this, "strikethroughThickness", -1);
					r_strikethroughThickness.SetBelong(this.instance);
				}
				return r_strikethroughThickness;
			}
		}

		/// <summary>
		/// Single tabWidth
		/// </summary>
		protected RProperty r_tabWidth;
		public virtual RProperty RtabWidth
		{
			get
			{
				if(r_tabWidth == null)
				{
					r_tabWidth = new(this, "tabWidth", -1);
					r_tabWidth.SetBelong(this.instance);
				}
				return r_tabWidth;
			}
		}

		/// <summary>
		/// Boolean Compare(UnityEngine.TextCore.FaceInfo)
		/// </summary>
		protected RMethod r_Compare_FaceInfo;
		public virtual RMethod RCompare_FaceInfo
		{
			get
			{
				if(r_Compare_FaceInfo == null)
				{
					r_Compare_FaceInfo = new(this, "Compare", 0, typeof(UnityEngine.TextCore.FaceInfo));
					r_Compare_FaceInfo.SetBelong(this.instance);
				}
				return r_Compare_FaceInfo;
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


        public RFaceInfo() : base("UnityEngine.TextCore.FaceInfo")
        {
        }

        public RFaceInfo(System.Object instance) : base("UnityEngine.TextCore.FaceInfo")
		{
            SetInstance(instance);
		}

        public RFaceInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFaceInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Compare(UnityEngine.TextCore.FaceInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompare_FaceInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
