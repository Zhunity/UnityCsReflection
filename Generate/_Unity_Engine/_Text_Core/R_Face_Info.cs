
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.TextCore.FaceInfo
	/// </summary>
    public partial class RFaceInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.FaceInfo);
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


		/// <summary>
		/// System.Int32 m_FaceIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_FaceIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_FaceIndex
		{
			get
			{
				if(r_Fm_FaceIndex == null)
				{
					r_Fm_FaceIndex = new(this, "m_FaceIndex");
				}
				return r_Fm_FaceIndex;
			}
		}

		/// <summary>
		/// System.String m_FamilyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_FamilyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_FamilyName
		{
			get
			{
				if(r_Fm_FamilyName == null)
				{
					r_Fm_FamilyName = new(this, "m_FamilyName");
				}
				return r_Fm_FamilyName;
			}
		}

		/// <summary>
		/// System.String m_StyleName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_StyleName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_StyleName
		{
			get
			{
				if(r_Fm_StyleName == null)
				{
					r_Fm_StyleName = new(this, "m_StyleName");
				}
				return r_Fm_StyleName;
			}
		}

		/// <summary>
		/// System.Int32 m_PointSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_PointSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_PointSize
		{
			get
			{
				if(r_Fm_PointSize == null)
				{
					r_Fm_PointSize = new(this, "m_PointSize");
				}
				return r_Fm_PointSize;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Scale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Scale
		{
			get
			{
				if(r_Fm_Scale == null)
				{
					r_Fm_Scale = new(this, "m_Scale");
				}
				return r_Fm_Scale;
			}
		}

		/// <summary>
		/// System.Int32 m_UnitsPerEM
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_UnitsPerEM;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_UnitsPerEM
		{
			get
			{
				if(r_Fm_UnitsPerEM == null)
				{
					r_Fm_UnitsPerEM = new(this, "m_UnitsPerEM");
				}
				return r_Fm_UnitsPerEM;
			}
		}

		/// <summary>
		/// System.Single m_LineHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_LineHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_LineHeight
		{
			get
			{
				if(r_Fm_LineHeight == null)
				{
					r_Fm_LineHeight = new(this, "m_LineHeight");
				}
				return r_Fm_LineHeight;
			}
		}

		/// <summary>
		/// System.Single m_AscentLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_AscentLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_AscentLine
		{
			get
			{
				if(r_Fm_AscentLine == null)
				{
					r_Fm_AscentLine = new(this, "m_AscentLine");
				}
				return r_Fm_AscentLine;
			}
		}

		/// <summary>
		/// System.Single m_CapLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_CapLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_CapLine
		{
			get
			{
				if(r_Fm_CapLine == null)
				{
					r_Fm_CapLine = new(this, "m_CapLine");
				}
				return r_Fm_CapLine;
			}
		}

		/// <summary>
		/// System.Single m_MeanLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_MeanLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_MeanLine
		{
			get
			{
				if(r_Fm_MeanLine == null)
				{
					r_Fm_MeanLine = new(this, "m_MeanLine");
				}
				return r_Fm_MeanLine;
			}
		}

		/// <summary>
		/// System.Single m_Baseline
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Baseline;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Baseline
		{
			get
			{
				if(r_Fm_Baseline == null)
				{
					r_Fm_Baseline = new(this, "m_Baseline");
				}
				return r_Fm_Baseline;
			}
		}

		/// <summary>
		/// System.Single m_DescentLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_DescentLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_DescentLine
		{
			get
			{
				if(r_Fm_DescentLine == null)
				{
					r_Fm_DescentLine = new(this, "m_DescentLine");
				}
				return r_Fm_DescentLine;
			}
		}

		/// <summary>
		/// System.Single m_SuperscriptOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_SuperscriptOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_SuperscriptOffset
		{
			get
			{
				if(r_Fm_SuperscriptOffset == null)
				{
					r_Fm_SuperscriptOffset = new(this, "m_SuperscriptOffset");
				}
				return r_Fm_SuperscriptOffset;
			}
		}

		/// <summary>
		/// System.Single m_SuperscriptSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_SuperscriptSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_SuperscriptSize
		{
			get
			{
				if(r_Fm_SuperscriptSize == null)
				{
					r_Fm_SuperscriptSize = new(this, "m_SuperscriptSize");
				}
				return r_Fm_SuperscriptSize;
			}
		}

		/// <summary>
		/// System.Single m_SubscriptOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_SubscriptOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_SubscriptOffset
		{
			get
			{
				if(r_Fm_SubscriptOffset == null)
				{
					r_Fm_SubscriptOffset = new(this, "m_SubscriptOffset");
				}
				return r_Fm_SubscriptOffset;
			}
		}

		/// <summary>
		/// System.Single m_SubscriptSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_SubscriptSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_SubscriptSize
		{
			get
			{
				if(r_Fm_SubscriptSize == null)
				{
					r_Fm_SubscriptSize = new(this, "m_SubscriptSize");
				}
				return r_Fm_SubscriptSize;
			}
		}

		/// <summary>
		/// System.Single m_UnderlineOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_UnderlineOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_UnderlineOffset
		{
			get
			{
				if(r_Fm_UnderlineOffset == null)
				{
					r_Fm_UnderlineOffset = new(this, "m_UnderlineOffset");
				}
				return r_Fm_UnderlineOffset;
			}
		}

		/// <summary>
		/// System.Single m_UnderlineThickness
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_UnderlineThickness;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_UnderlineThickness
		{
			get
			{
				if(r_Fm_UnderlineThickness == null)
				{
					r_Fm_UnderlineThickness = new(this, "m_UnderlineThickness");
				}
				return r_Fm_UnderlineThickness;
			}
		}

		/// <summary>
		/// System.Single m_StrikethroughOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_StrikethroughOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_StrikethroughOffset
		{
			get
			{
				if(r_Fm_StrikethroughOffset == null)
				{
					r_Fm_StrikethroughOffset = new(this, "m_StrikethroughOffset");
				}
				return r_Fm_StrikethroughOffset;
			}
		}

		/// <summary>
		/// System.Single m_StrikethroughThickness
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_StrikethroughThickness;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_StrikethroughThickness
		{
			get
			{
				if(r_Fm_StrikethroughThickness == null)
				{
					r_Fm_StrikethroughThickness = new(this, "m_StrikethroughThickness");
				}
				return r_Fm_StrikethroughThickness;
			}
		}

		/// <summary>
		/// System.Single m_TabWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_TabWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_TabWidth
		{
			get
			{
				if(r_Fm_TabWidth == null)
				{
					r_Fm_TabWidth = new(this, "m_TabWidth");
				}
				return r_Fm_TabWidth;
			}
		}

		/// <summary>
		/// Int32 faceIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PfaceIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPfaceIndex
		{
			get
			{
				if(r_PfaceIndex == null)
				{
					r_PfaceIndex = new(this, "faceIndex", -1);
				}
				return r_PfaceIndex;
			}
		}

		/// <summary>
		/// System.String familyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PfamilyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPfamilyName
		{
			get
			{
				if(r_PfamilyName == null)
				{
					r_PfamilyName = new(this, "familyName", -1);
				}
				return r_PfamilyName;
			}
		}

		/// <summary>
		/// System.String styleName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PstyleName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPstyleName
		{
			get
			{
				if(r_PstyleName == null)
				{
					r_PstyleName = new(this, "styleName", -1);
				}
				return r_PstyleName;
			}
		}

		/// <summary>
		/// Int32 pointSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PpointSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpointSize
		{
			get
			{
				if(r_PpointSize == null)
				{
					r_PpointSize = new(this, "pointSize", -1);
				}
				return r_PpointSize;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pscale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
				}
				return r_Pscale;
			}
		}

		/// <summary>
		/// Int32 unitsPerEM
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PunitsPerEM;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPunitsPerEM
		{
			get
			{
				if(r_PunitsPerEM == null)
				{
					r_PunitsPerEM = new(this, "unitsPerEM", -1);
				}
				return r_PunitsPerEM;
			}
		}

		/// <summary>
		/// Single lineHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PlineHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPlineHeight
		{
			get
			{
				if(r_PlineHeight == null)
				{
					r_PlineHeight = new(this, "lineHeight", -1);
				}
				return r_PlineHeight;
			}
		}

		/// <summary>
		/// Single ascentLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PascentLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPascentLine
		{
			get
			{
				if(r_PascentLine == null)
				{
					r_PascentLine = new(this, "ascentLine", -1);
				}
				return r_PascentLine;
			}
		}

		/// <summary>
		/// Single capLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PcapLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPcapLine
		{
			get
			{
				if(r_PcapLine == null)
				{
					r_PcapLine = new(this, "capLine", -1);
				}
				return r_PcapLine;
			}
		}

		/// <summary>
		/// Single meanLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmeanLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmeanLine
		{
			get
			{
				if(r_PmeanLine == null)
				{
					r_PmeanLine = new(this, "meanLine", -1);
				}
				return r_PmeanLine;
			}
		}

		/// <summary>
		/// Single baseline
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pbaseline;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPbaseline
		{
			get
			{
				if(r_Pbaseline == null)
				{
					r_Pbaseline = new(this, "baseline", -1);
				}
				return r_Pbaseline;
			}
		}

		/// <summary>
		/// Single descentLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PdescentLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPdescentLine
		{
			get
			{
				if(r_PdescentLine == null)
				{
					r_PdescentLine = new(this, "descentLine", -1);
				}
				return r_PdescentLine;
			}
		}

		/// <summary>
		/// Single superscriptOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsuperscriptOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsuperscriptOffset
		{
			get
			{
				if(r_PsuperscriptOffset == null)
				{
					r_PsuperscriptOffset = new(this, "superscriptOffset", -1);
				}
				return r_PsuperscriptOffset;
			}
		}

		/// <summary>
		/// Single superscriptSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsuperscriptSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsuperscriptSize
		{
			get
			{
				if(r_PsuperscriptSize == null)
				{
					r_PsuperscriptSize = new(this, "superscriptSize", -1);
				}
				return r_PsuperscriptSize;
			}
		}

		/// <summary>
		/// Single subscriptOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsubscriptOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsubscriptOffset
		{
			get
			{
				if(r_PsubscriptOffset == null)
				{
					r_PsubscriptOffset = new(this, "subscriptOffset", -1);
				}
				return r_PsubscriptOffset;
			}
		}

		/// <summary>
		/// Single subscriptSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsubscriptSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsubscriptSize
		{
			get
			{
				if(r_PsubscriptSize == null)
				{
					r_PsubscriptSize = new(this, "subscriptSize", -1);
				}
				return r_PsubscriptSize;
			}
		}

		/// <summary>
		/// Single underlineOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PunderlineOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPunderlineOffset
		{
			get
			{
				if(r_PunderlineOffset == null)
				{
					r_PunderlineOffset = new(this, "underlineOffset", -1);
				}
				return r_PunderlineOffset;
			}
		}

		/// <summary>
		/// Single underlineThickness
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PunderlineThickness;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPunderlineThickness
		{
			get
			{
				if(r_PunderlineThickness == null)
				{
					r_PunderlineThickness = new(this, "underlineThickness", -1);
				}
				return r_PunderlineThickness;
			}
		}

		/// <summary>
		/// Single strikethroughOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PstrikethroughOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPstrikethroughOffset
		{
			get
			{
				if(r_PstrikethroughOffset == null)
				{
					r_PstrikethroughOffset = new(this, "strikethroughOffset", -1);
				}
				return r_PstrikethroughOffset;
			}
		}

		/// <summary>
		/// Single strikethroughThickness
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PstrikethroughThickness;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPstrikethroughThickness
		{
			get
			{
				if(r_PstrikethroughThickness == null)
				{
					r_PstrikethroughThickness = new(this, "strikethroughThickness", -1);
				}
				return r_PstrikethroughThickness;
			}
		}

		/// <summary>
		/// Single tabWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PtabWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtabWidth
		{
			get
			{
				if(r_PtabWidth == null)
				{
					r_PtabWidth = new(this, "tabWidth", -1);
				}
				return r_PtabWidth;
			}
		}

		/// <summary>
		/// Boolean Compare(UnityEngine.TextCore.FaceInfo)
		/// </summary>
		protected RMethod r_MCompare_FaceInfo;
		public virtual RMethod RMCompare_FaceInfo
		{
			get
			{
				if(r_MCompare_FaceInfo == null)
				{
					r_MCompare_FaceInfo = new(this, "Compare", 0, typeof(UnityEngine.TextCore.FaceInfo));
				}
				return r_MCompare_FaceInfo;
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


        public virtual System.Boolean Compare(UnityEngine.TextCore.FaceInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMCompare_FaceInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
