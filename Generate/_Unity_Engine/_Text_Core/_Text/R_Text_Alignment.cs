
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.TextAlignment
	/// </summary>
    public partial class RTextAlignment : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextAlignment");
            }
        }

        public RTextAlignment() : base("UnityEngine.TextCore.Text.TextAlignment")
        {
        }

        public RTextAlignment(System.Object instance) : base("UnityEngine.TextCore.Text.TextAlignment")
		{
            SetInstance(instance);
		}

        public RTextAlignment(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextAlignment(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment TopLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FTopLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFTopLeft
		{
			get
			{
				if(r_FTopLeft == null)
				{
					r_FTopLeft = new(Type, "TopLeft");
				}
				return r_FTopLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment TopCenter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FTopCenter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFTopCenter
		{
			get
			{
				if(r_FTopCenter == null)
				{
					r_FTopCenter = new(Type, "TopCenter");
				}
				return r_FTopCenter;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment TopRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FTopRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFTopRight
		{
			get
			{
				if(r_FTopRight == null)
				{
					r_FTopRight = new(Type, "TopRight");
				}
				return r_FTopRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment TopJustified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FTopJustified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFTopJustified
		{
			get
			{
				if(r_FTopJustified == null)
				{
					r_FTopJustified = new(Type, "TopJustified");
				}
				return r_FTopJustified;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment TopFlush
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FTopFlush;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFTopFlush
		{
			get
			{
				if(r_FTopFlush == null)
				{
					r_FTopFlush = new(Type, "TopFlush");
				}
				return r_FTopFlush;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment TopGeoAligned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FTopGeoAligned;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFTopGeoAligned
		{
			get
			{
				if(r_FTopGeoAligned == null)
				{
					r_FTopGeoAligned = new(Type, "TopGeoAligned");
				}
				return r_FTopGeoAligned;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MiddleLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMiddleLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMiddleLeft
		{
			get
			{
				if(r_FMiddleLeft == null)
				{
					r_FMiddleLeft = new(Type, "MiddleLeft");
				}
				return r_FMiddleLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MiddleCenter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMiddleCenter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMiddleCenter
		{
			get
			{
				if(r_FMiddleCenter == null)
				{
					r_FMiddleCenter = new(Type, "MiddleCenter");
				}
				return r_FMiddleCenter;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MiddleRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMiddleRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMiddleRight
		{
			get
			{
				if(r_FMiddleRight == null)
				{
					r_FMiddleRight = new(Type, "MiddleRight");
				}
				return r_FMiddleRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MiddleJustified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMiddleJustified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMiddleJustified
		{
			get
			{
				if(r_FMiddleJustified == null)
				{
					r_FMiddleJustified = new(Type, "MiddleJustified");
				}
				return r_FMiddleJustified;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MiddleFlush
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMiddleFlush;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMiddleFlush
		{
			get
			{
				if(r_FMiddleFlush == null)
				{
					r_FMiddleFlush = new(Type, "MiddleFlush");
				}
				return r_FMiddleFlush;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MiddleGeoAligned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMiddleGeoAligned;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMiddleGeoAligned
		{
			get
			{
				if(r_FMiddleGeoAligned == null)
				{
					r_FMiddleGeoAligned = new(Type, "MiddleGeoAligned");
				}
				return r_FMiddleGeoAligned;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BottomLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBottomLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBottomLeft
		{
			get
			{
				if(r_FBottomLeft == null)
				{
					r_FBottomLeft = new(Type, "BottomLeft");
				}
				return r_FBottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BottomCenter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBottomCenter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBottomCenter
		{
			get
			{
				if(r_FBottomCenter == null)
				{
					r_FBottomCenter = new(Type, "BottomCenter");
				}
				return r_FBottomCenter;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BottomRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBottomRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBottomRight
		{
			get
			{
				if(r_FBottomRight == null)
				{
					r_FBottomRight = new(Type, "BottomRight");
				}
				return r_FBottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BottomJustified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBottomJustified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBottomJustified
		{
			get
			{
				if(r_FBottomJustified == null)
				{
					r_FBottomJustified = new(Type, "BottomJustified");
				}
				return r_FBottomJustified;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BottomFlush
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBottomFlush;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBottomFlush
		{
			get
			{
				if(r_FBottomFlush == null)
				{
					r_FBottomFlush = new(Type, "BottomFlush");
				}
				return r_FBottomFlush;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BottomGeoAligned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBottomGeoAligned;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBottomGeoAligned
		{
			get
			{
				if(r_FBottomGeoAligned == null)
				{
					r_FBottomGeoAligned = new(Type, "BottomGeoAligned");
				}
				return r_FBottomGeoAligned;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BaselineLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBaselineLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBaselineLeft
		{
			get
			{
				if(r_FBaselineLeft == null)
				{
					r_FBaselineLeft = new(Type, "BaselineLeft");
				}
				return r_FBaselineLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BaselineCenter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBaselineCenter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBaselineCenter
		{
			get
			{
				if(r_FBaselineCenter == null)
				{
					r_FBaselineCenter = new(Type, "BaselineCenter");
				}
				return r_FBaselineCenter;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BaselineRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBaselineRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBaselineRight
		{
			get
			{
				if(r_FBaselineRight == null)
				{
					r_FBaselineRight = new(Type, "BaselineRight");
				}
				return r_FBaselineRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BaselineJustified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBaselineJustified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBaselineJustified
		{
			get
			{
				if(r_FBaselineJustified == null)
				{
					r_FBaselineJustified = new(Type, "BaselineJustified");
				}
				return r_FBaselineJustified;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BaselineFlush
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBaselineFlush;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBaselineFlush
		{
			get
			{
				if(r_FBaselineFlush == null)
				{
					r_FBaselineFlush = new(Type, "BaselineFlush");
				}
				return r_FBaselineFlush;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment BaselineGeoAligned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FBaselineGeoAligned;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFBaselineGeoAligned
		{
			get
			{
				if(r_FBaselineGeoAligned == null)
				{
					r_FBaselineGeoAligned = new(Type, "BaselineGeoAligned");
				}
				return r_FBaselineGeoAligned;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MidlineLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMidlineLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMidlineLeft
		{
			get
			{
				if(r_FMidlineLeft == null)
				{
					r_FMidlineLeft = new(Type, "MidlineLeft");
				}
				return r_FMidlineLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MidlineCenter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMidlineCenter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMidlineCenter
		{
			get
			{
				if(r_FMidlineCenter == null)
				{
					r_FMidlineCenter = new(Type, "MidlineCenter");
				}
				return r_FMidlineCenter;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MidlineRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMidlineRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMidlineRight
		{
			get
			{
				if(r_FMidlineRight == null)
				{
					r_FMidlineRight = new(Type, "MidlineRight");
				}
				return r_FMidlineRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MidlineJustified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMidlineJustified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMidlineJustified
		{
			get
			{
				if(r_FMidlineJustified == null)
				{
					r_FMidlineJustified = new(Type, "MidlineJustified");
				}
				return r_FMidlineJustified;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MidlineFlush
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMidlineFlush;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMidlineFlush
		{
			get
			{
				if(r_FMidlineFlush == null)
				{
					r_FMidlineFlush = new(Type, "MidlineFlush");
				}
				return r_FMidlineFlush;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment MidlineGeoAligned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FMidlineGeoAligned;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFMidlineGeoAligned
		{
			get
			{
				if(r_FMidlineGeoAligned == null)
				{
					r_FMidlineGeoAligned = new(Type, "MidlineGeoAligned");
				}
				return r_FMidlineGeoAligned;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment CaplineLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FCaplineLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFCaplineLeft
		{
			get
			{
				if(r_FCaplineLeft == null)
				{
					r_FCaplineLeft = new(Type, "CaplineLeft");
				}
				return r_FCaplineLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment CaplineCenter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FCaplineCenter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFCaplineCenter
		{
			get
			{
				if(r_FCaplineCenter == null)
				{
					r_FCaplineCenter = new(Type, "CaplineCenter");
				}
				return r_FCaplineCenter;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment CaplineRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FCaplineRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFCaplineRight
		{
			get
			{
				if(r_FCaplineRight == null)
				{
					r_FCaplineRight = new(Type, "CaplineRight");
				}
				return r_FCaplineRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment CaplineJustified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FCaplineJustified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFCaplineJustified
		{
			get
			{
				if(r_FCaplineJustified == null)
				{
					r_FCaplineJustified = new(Type, "CaplineJustified");
				}
				return r_FCaplineJustified;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment CaplineFlush
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FCaplineFlush;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFCaplineFlush
		{
			get
			{
				if(r_FCaplineFlush == null)
				{
					r_FCaplineFlush = new(Type, "CaplineFlush");
				}
				return r_FCaplineFlush;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAlignment CaplineGeoAligned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment r_FCaplineGeoAligned;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAlignment RFCaplineGeoAligned
		{
			get
			{
				if(r_FCaplineGeoAligned == null)
				{
					r_FCaplineGeoAligned = new(Type, "CaplineGeoAligned");
				}
				return r_FCaplineGeoAligned;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
