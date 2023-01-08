using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphValueRecord
	/// </summary>
    public partial class RGlyphValueRecord : RMember //
    {

		/// <summary>
		/// System.Single m_XPlacement
		/// </summary>
		protected RField r_m_XPlacement;
		public virtual RField Rm_XPlacement
		{
			get
			{
				if(r_m_XPlacement == null)
				{
					r_m_XPlacement = new(this, "m_XPlacement");
					r_m_XPlacement.SetBelong(this.instance);
				}
				return r_m_XPlacement;
			}
		}

		/// <summary>
		/// System.Single m_YPlacement
		/// </summary>
		protected RField r_m_YPlacement;
		public virtual RField Rm_YPlacement
		{
			get
			{
				if(r_m_YPlacement == null)
				{
					r_m_YPlacement = new(this, "m_YPlacement");
					r_m_YPlacement.SetBelong(this.instance);
				}
				return r_m_YPlacement;
			}
		}

		/// <summary>
		/// System.Single m_XAdvance
		/// </summary>
		protected RField r_m_XAdvance;
		public virtual RField Rm_XAdvance
		{
			get
			{
				if(r_m_XAdvance == null)
				{
					r_m_XAdvance = new(this, "m_XAdvance");
					r_m_XAdvance.SetBelong(this.instance);
				}
				return r_m_XAdvance;
			}
		}

		/// <summary>
		/// System.Single m_YAdvance
		/// </summary>
		protected RField r_m_YAdvance;
		public virtual RField Rm_YAdvance
		{
			get
			{
				if(r_m_YAdvance == null)
				{
					r_m_YAdvance = new(this, "m_YAdvance");
					r_m_YAdvance.SetBelong(this.instance);
				}
				return r_m_YAdvance;
			}
		}

		/// <summary>
		/// Single xPlacement
		/// </summary>
		protected RProperty r_xPlacement;
		public virtual RProperty RxPlacement
		{
			get
			{
				if(r_xPlacement == null)
				{
					r_xPlacement = new(this, "xPlacement", -1);
					r_xPlacement.SetBelong(this.instance);
				}
				return r_xPlacement;
			}
		}

		/// <summary>
		/// Single yPlacement
		/// </summary>
		protected RProperty r_yPlacement;
		public virtual RProperty RyPlacement
		{
			get
			{
				if(r_yPlacement == null)
				{
					r_yPlacement = new(this, "yPlacement", -1);
					r_yPlacement.SetBelong(this.instance);
				}
				return r_yPlacement;
			}
		}

		/// <summary>
		/// Single xAdvance
		/// </summary>
		protected RProperty r_xAdvance;
		public virtual RProperty RxAdvance
		{
			get
			{
				if(r_xAdvance == null)
				{
					r_xAdvance = new(this, "xAdvance", -1);
					r_xAdvance.SetBelong(this.instance);
				}
				return r_xAdvance;
			}
		}

		/// <summary>
		/// Single yAdvance
		/// </summary>
		protected RProperty r_yAdvance;
		public virtual RProperty RyAdvance
		{
			get
			{
				if(r_yAdvance == null)
				{
					r_yAdvance = new(this, "yAdvance", -1);
					r_yAdvance.SetBelong(this.instance);
				}
				return r_yAdvance;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord, UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected static RMethod r_op_Addition_GlyphValueRecord_GlyphValueRecord;
		public static RMethod Rop_Addition_GlyphValueRecord_GlyphValueRecord
		{
			get
			{
				if(r_op_Addition_GlyphValueRecord_GlyphValueRecord == null)
				{
					r_op_Addition_GlyphValueRecord_GlyphValueRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Addition", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_op_Addition_GlyphValueRecord_GlyphValueRecord.SetBelong(null);
				}
				return r_op_Addition_GlyphValueRecord_GlyphValueRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Multiply(UnityEngine.TextCore.LowLevel.GlyphValueRecord, Single)
		/// </summary>
		protected static RMethod r_op_Multiply_GlyphValueRecord_Single;
		public static RMethod Rop_Multiply_GlyphValueRecord_Single
		{
			get
			{
				if(r_op_Multiply_GlyphValueRecord_Single == null)
				{
					r_op_Multiply_GlyphValueRecord_Single = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Multiply", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(System.Single));
					r_op_Multiply_GlyphValueRecord_Single.SetBelong(null);
				}
				return r_op_Multiply_GlyphValueRecord_Single;
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
		/// Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected RMethod r_Equals_GlyphValueRecord;
		public virtual RMethod REquals_GlyphValueRecord
		{
			get
			{
				if(r_Equals_GlyphValueRecord == null)
				{
					r_Equals_GlyphValueRecord = new(this, "Equals", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_Equals_GlyphValueRecord.SetBelong(this.instance);
				}
				return r_Equals_GlyphValueRecord;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphValueRecord, UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected static RMethod r_op_Equality_GlyphValueRecord_GlyphValueRecord;
		public static RMethod Rop_Equality_GlyphValueRecord_GlyphValueRecord
		{
			get
			{
				if(r_op_Equality_GlyphValueRecord_GlyphValueRecord == null)
				{
					r_op_Equality_GlyphValueRecord_GlyphValueRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Equality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_op_Equality_GlyphValueRecord_GlyphValueRecord.SetBelong(null);
				}
				return r_op_Equality_GlyphValueRecord_GlyphValueRecord;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphValueRecord, UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected static RMethod r_op_Inequality_GlyphValueRecord_GlyphValueRecord;
		public static RMethod Rop_Inequality_GlyphValueRecord_GlyphValueRecord
		{
			get
			{
				if(r_op_Inequality_GlyphValueRecord_GlyphValueRecord == null)
				{
					r_op_Inequality_GlyphValueRecord_GlyphValueRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Inequality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_op_Inequality_GlyphValueRecord_GlyphValueRecord.SetBelong(null);
				}
				return r_op_Inequality_GlyphValueRecord_GlyphValueRecord;
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


        public RGlyphValueRecord() : base("UnityEngine.TextCore.LowLevel.GlyphValueRecord")
        {
        }

        public RGlyphValueRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.GlyphValueRecord")
		{
            SetInstance(instance);
		}

        public RGlyphValueRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphValueRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord  @a, UnityEngine.TextCore.LowLevel.GlyphValueRecord  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_GlyphValueRecord_GlyphValueRecord.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.LowLevel.GlyphValueRecord)___result;
        }


        public static UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Multiply(UnityEngine.TextCore.LowLevel.GlyphValueRecord  @a, System.Single  @emScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @emScale};
            var ___result = Rop_Multiply_GlyphValueRecord_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.LowLevel.GlyphValueRecord)___result;
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


        public virtual System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_GlyphValueRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphValueRecord  @lhs, UnityEngine.TextCore.LowLevel.GlyphValueRecord  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_GlyphValueRecord_GlyphValueRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphValueRecord  @lhs, UnityEngine.TextCore.LowLevel.GlyphValueRecord  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_GlyphValueRecord_GlyphValueRecord.Invoke(___genericsType, ___parameters);

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
