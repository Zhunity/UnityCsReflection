using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord
	/// </summary>
    public partial class RGlyphAdjustmentRecord : RMember //
    {

		/// <summary>
		/// System.UInt32 m_GlyphIndex
		/// </summary>
		protected RField r_m_GlyphIndex;
		public virtual RField Rm_GlyphIndex
		{
			get
			{
				if(r_m_GlyphIndex == null)
				{
					r_m_GlyphIndex = new(this, "m_GlyphIndex");
					r_m_GlyphIndex.SetBelong(this.instance);
				}
				return r_m_GlyphIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord r_m_GlyphValueRecord;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord Rm_GlyphValueRecord
		{
			get
			{
				if(r_m_GlyphValueRecord == null)
				{
					r_m_GlyphValueRecord = new(this, "m_GlyphValueRecord");
					r_m_GlyphValueRecord.SetBelong(this.instance);
				}
				return r_m_GlyphValueRecord;
			}
		}

		/// <summary>
		/// UInt32 glyphIndex
		/// </summary>
		protected RProperty r_glyphIndex;
		public virtual RProperty RglyphIndex
		{
			get
			{
				if(r_glyphIndex == null)
				{
					r_glyphIndex = new(this, "glyphIndex", -1);
					r_glyphIndex.SetBelong(this.instance);
				}
				return r_glyphIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord r_glyphValueRecord;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord RglyphValueRecord
		{
			get
			{
				if(r_glyphValueRecord == null)
				{
					r_glyphValueRecord = new(this, "glyphValueRecord", -1);
					r_glyphValueRecord.SetBelong(this.instance);
				}
				return r_glyphValueRecord;
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
		/// Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord)
		/// </summary>
		protected RMethod r_REquals_GlyphAdjustmentRecord;
		public virtual RMethod REquals_GlyphAdjustmentRecord
		{
			get
			{
				if(r_REquals_GlyphAdjustmentRecord == null)
				{
					r_REquals_GlyphAdjustmentRecord = new(this, "Equals", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord));
					r_REquals_GlyphAdjustmentRecord.SetBelong(this.instance);
				}
				return r_REquals_GlyphAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord)
		/// </summary>
		protected static RMethod r_Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
		public static RMethod Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord
		{
			get
			{
				if(r_Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord == null)
				{
					r_Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), "op_Equality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord));
					r_Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.SetBelong(null);
				}
				return r_Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord)
		/// </summary>
		protected static RMethod r_Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
		public static RMethod Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord
		{
			get
			{
				if(r_Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord == null)
				{
					r_Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), "op_Inequality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord));
					r_Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.SetBelong(null);
				}
				return r_Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
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


        public RGlyphAdjustmentRecord() : base("UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord")
        {
        }

        public RGlyphAdjustmentRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord")
		{
            SetInstance(instance);
		}

        public RGlyphAdjustmentRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphAdjustmentRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_GlyphAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord  @lhs, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord  @lhs, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.Invoke(___genericsType, ___parameters);

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
