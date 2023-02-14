
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord
	/// </summary>
    public partial class RGlyphAdjustmentRecord : RMember //
    {

		/// <summary>
		/// System.UInt32 m_GlyphIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_GlyphIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_GlyphIndex
		{
			get
			{
				if(r_Fm_GlyphIndex == null)
				{
					r_Fm_GlyphIndex = new(this, "m_GlyphIndex");
					r_Fm_GlyphIndex.SetBelong(this.instance);
				}
				return r_Fm_GlyphIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord r_Fm_GlyphValueRecord;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord RFm_GlyphValueRecord
		{
			get
			{
				if(r_Fm_GlyphValueRecord == null)
				{
					r_Fm_GlyphValueRecord = new(this, "m_GlyphValueRecord");
					r_Fm_GlyphValueRecord.SetBelong(this.instance);
				}
				return r_Fm_GlyphValueRecord;
			}
		}

		/// <summary>
		/// UInt32 glyphIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PglyphIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPglyphIndex
		{
			get
			{
				if(r_PglyphIndex == null)
				{
					r_PglyphIndex = new(this, "glyphIndex", -1);
					r_PglyphIndex.SetBelong(this.instance);
				}
				return r_PglyphIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord r_PglyphValueRecord;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphValueRecord RPglyphValueRecord
		{
			get
			{
				if(r_PglyphValueRecord == null)
				{
					r_PglyphValueRecord = new(this, "glyphValueRecord", -1);
					r_PglyphValueRecord.SetBelong(this.instance);
				}
				return r_PglyphValueRecord;
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
		/// Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord)
		/// </summary>
		protected RMethod r_MEquals_GlyphAdjustmentRecord;
		public virtual RMethod RMEquals_GlyphAdjustmentRecord
		{
			get
			{
				if(r_MEquals_GlyphAdjustmentRecord == null)
				{
					r_MEquals_GlyphAdjustmentRecord = new(this, "Equals", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord));
					r_MEquals_GlyphAdjustmentRecord.SetBelong(this.instance);
				}
				return r_MEquals_GlyphAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord)
		/// </summary>
		protected static RMethod r_Mop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
		public static RMethod RMop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord
		{
			get
			{
				if(r_Mop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord == null)
				{
					r_Mop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), "op_Equality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord));
					r_Mop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.SetBelong(null);
				}
				return r_Mop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
		public static RMethod RMop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord
		{
			get
			{
				if(r_Mop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord == null)
				{
					r_Mop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), "op_Inequality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord));
					r_Mop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.SetBelong(null);
				}
				return r_Mop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord;
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


        public virtual System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_GlyphAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord @lhs, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord @lhs, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_GlyphAdjustmentRecord_GlyphAdjustmentRecord.Invoke(___genericsType, ___parameters);

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
