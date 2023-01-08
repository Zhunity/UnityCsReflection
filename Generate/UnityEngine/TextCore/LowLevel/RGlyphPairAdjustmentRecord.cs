using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord
	/// </summary>
    public partial class RGlyphPairAdjustmentRecord : RMember //
    {

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_m_FirstAdjustmentRecord;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord Rm_FirstAdjustmentRecord
		{
			get
			{
				if(r_m_FirstAdjustmentRecord == null)
				{
					r_m_FirstAdjustmentRecord = new(this, "m_FirstAdjustmentRecord");
					r_m_FirstAdjustmentRecord.SetBelong(this.instance);
				}
				return r_m_FirstAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_m_SecondAdjustmentRecord;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord Rm_SecondAdjustmentRecord
		{
			get
			{
				if(r_m_SecondAdjustmentRecord == null)
				{
					r_m_SecondAdjustmentRecord = new(this, "m_SecondAdjustmentRecord");
					r_m_SecondAdjustmentRecord.SetBelong(this.instance);
				}
				return r_m_SecondAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags
		/// </summary>
		protected RField r_m_FeatureLookupFlags;
		public virtual RField Rm_FeatureLookupFlags
		{
			get
			{
				if(r_m_FeatureLookupFlags == null)
				{
					r_m_FeatureLookupFlags = new(this, "m_FeatureLookupFlags");
					r_m_FeatureLookupFlags.SetBelong(this.instance);
				}
				return r_m_FeatureLookupFlags;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_firstAdjustmentRecord;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord RfirstAdjustmentRecord
		{
			get
			{
				if(r_firstAdjustmentRecord == null)
				{
					r_firstAdjustmentRecord = new(this, "firstAdjustmentRecord", -1);
					r_firstAdjustmentRecord.SetBelong(this.instance);
				}
				return r_firstAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord r_secondAdjustmentRecord;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAdjustmentRecord RsecondAdjustmentRecord
		{
			get
			{
				if(r_secondAdjustmentRecord == null)
				{
					r_secondAdjustmentRecord = new(this, "secondAdjustmentRecord", -1);
					r_secondAdjustmentRecord.SetBelong(this.instance);
				}
				return r_secondAdjustmentRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags featureLookupFlags
		/// </summary>
		protected RProperty r_featureLookupFlags;
		public virtual RProperty RfeatureLookupFlags
		{
			get
			{
				if(r_featureLookupFlags == null)
				{
					r_featureLookupFlags = new(this, "featureLookupFlags", -1);
					r_featureLookupFlags.SetBelong(this.instance);
				}
				return r_featureLookupFlags;
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
		/// Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord)
		/// </summary>
		protected RMethod r_Equals_GlyphPairAdjustmentRecord;
		public virtual RMethod REquals_GlyphPairAdjustmentRecord
		{
			get
			{
				if(r_Equals_GlyphPairAdjustmentRecord == null)
				{
					r_Equals_GlyphPairAdjustmentRecord = new(this, "Equals", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord));
					r_Equals_GlyphPairAdjustmentRecord.SetBelong(this.instance);
				}
				return r_Equals_GlyphPairAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord)
		/// </summary>
		protected static RMethod r_op_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
		public static RMethod Rop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord
		{
			get
			{
				if(r_op_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord == null)
				{
					r_op_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), "op_Equality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord));
					r_op_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord.SetBelong(null);
				}
				return r_op_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord)
		/// </summary>
		protected static RMethod r_op_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
		public static RMethod Rop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord
		{
			get
			{
				if(r_op_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord == null)
				{
					r_op_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), "op_Inequality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord));
					r_op_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord.SetBelong(null);
				}
				return r_op_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord;
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

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_GlyphPairAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord  @lhs, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord  @lhs, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_GlyphPairAdjustmentRecord_GlyphPairAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
