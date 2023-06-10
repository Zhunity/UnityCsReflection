
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord
	/// </summary>
    public partial class RGlyphPairAdjustmentRecord : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord);
            }
        }

        public RGlyphPairAdjustmentRecord() : base("UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord")
        {
        }

        public RGlyphPairAdjustmentRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord")
		{
            SetInstance(instance);
		}

        public RGlyphPairAdjustmentRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphPairAdjustmentRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_Fm_FirstAdjustmentRecord;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord RFm_FirstAdjustmentRecord
		{
			get
			{
				if(r_Fm_FirstAdjustmentRecord == null)
				{
					r_Fm_FirstAdjustmentRecord = new(this, "m_FirstAdjustmentRecord");
				}
				return r_Fm_FirstAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_Fm_SecondAdjustmentRecord;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord RFm_SecondAdjustmentRecord
		{
			get
			{
				if(r_Fm_SecondAdjustmentRecord == null)
				{
					r_Fm_SecondAdjustmentRecord = new(this, "m_SecondAdjustmentRecord");
				}
				return r_Fm_SecondAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontFeatureLookupFlags r_Fm_FeatureLookupFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontFeatureLookupFlags RFm_FeatureLookupFlags
		{
			get
			{
				if(r_Fm_FeatureLookupFlags == null)
				{
					r_Fm_FeatureLookupFlags = new(this, "m_FeatureLookupFlags");
				}
				return r_Fm_FeatureLookupFlags;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_PfirstAdjustmentRecord;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord RPfirstAdjustmentRecord
		{
			get
			{
				if(r_PfirstAdjustmentRecord == null)
				{
					r_PfirstAdjustmentRecord = new(this, "firstAdjustmentRecord", -1);
				}
				return r_PfirstAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_PsecondAdjustmentRecord;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord RPsecondAdjustmentRecord
		{
			get
			{
				if(r_PsecondAdjustmentRecord == null)
				{
					r_PsecondAdjustmentRecord = new(this, "secondAdjustmentRecord", -1);
				}
				return r_PsecondAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags featureLookupFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontFeatureLookupFlags r_PfeatureLookupFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontFeatureLookupFlags RPfeatureLookupFlags
		{
			get
			{
				if(r_PfeatureLookupFlags == null)
				{
					r_PfeatureLookupFlags = new(this, "featureLookupFlags", -1);
				}
				return r_PfeatureLookupFlags;
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
		/// Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord)
		/// </summary>
		protected RMethod r_MEquals_GlyphPairAdjustmentRecord;
		public virtual RMethod RMEquals_GlyphPairAdjustmentRecord
		{
			get
			{
				if(r_MEquals_GlyphPairAdjustmentRecord == null)
				{
					r_MEquals_GlyphPairAdjustmentRecord = new(this, "Equals", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord));
				}
				return r_MEquals_GlyphPairAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord)
		/// </summary>
		protected static RMethod r_Mop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
		public static RMethod RMop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord
		{
			get
			{
				if(r_Mop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord == null)
				{
					r_Mop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), "op_Equality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord));
				}
				return r_Mop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
		public static RMethod RMop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord
		{
			get
			{
				if(r_Mop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord == null)
				{
					r_Mop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), "op_Inequality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord));
				}
				return r_Mop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_GlyphPairAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord @lhs, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord @lhs, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
