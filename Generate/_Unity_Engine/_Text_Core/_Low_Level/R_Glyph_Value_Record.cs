
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphValueRecord
	/// </summary>
    public partial class RGlyphValueRecord : RMember //
    {

		/// <summary>
		/// System.Single m_XPlacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_XPlacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_XPlacement
		{
			get
			{
				if(r_Fm_XPlacement == null)
				{
					r_Fm_XPlacement = new(this, "m_XPlacement");
					r_Fm_XPlacement.SetBelong(this.instance);
				}
				return r_Fm_XPlacement;
			}
		}

		/// <summary>
		/// System.Single m_YPlacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_YPlacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_YPlacement
		{
			get
			{
				if(r_Fm_YPlacement == null)
				{
					r_Fm_YPlacement = new(this, "m_YPlacement");
					r_Fm_YPlacement.SetBelong(this.instance);
				}
				return r_Fm_YPlacement;
			}
		}

		/// <summary>
		/// System.Single m_XAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_XAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_XAdvance
		{
			get
			{
				if(r_Fm_XAdvance == null)
				{
					r_Fm_XAdvance = new(this, "m_XAdvance");
					r_Fm_XAdvance.SetBelong(this.instance);
				}
				return r_Fm_XAdvance;
			}
		}

		/// <summary>
		/// System.Single m_YAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_YAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_YAdvance
		{
			get
			{
				if(r_Fm_YAdvance == null)
				{
					r_Fm_YAdvance = new(this, "m_YAdvance");
					r_Fm_YAdvance.SetBelong(this.instance);
				}
				return r_Fm_YAdvance;
			}
		}

		/// <summary>
		/// Single xPlacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PxPlacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPxPlacement
		{
			get
			{
				if(r_PxPlacement == null)
				{
					r_PxPlacement = new(this, "xPlacement", -1);
					r_PxPlacement.SetBelong(this.instance);
				}
				return r_PxPlacement;
			}
		}

		/// <summary>
		/// Single yPlacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PyPlacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPyPlacement
		{
			get
			{
				if(r_PyPlacement == null)
				{
					r_PyPlacement = new(this, "yPlacement", -1);
					r_PyPlacement.SetBelong(this.instance);
				}
				return r_PyPlacement;
			}
		}

		/// <summary>
		/// Single xAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PxAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPxAdvance
		{
			get
			{
				if(r_PxAdvance == null)
				{
					r_PxAdvance = new(this, "xAdvance", -1);
					r_PxAdvance.SetBelong(this.instance);
				}
				return r_PxAdvance;
			}
		}

		/// <summary>
		/// Single yAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PyAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPyAdvance
		{
			get
			{
				if(r_PyAdvance == null)
				{
					r_PyAdvance = new(this, "yAdvance", -1);
					r_PyAdvance.SetBelong(this.instance);
				}
				return r_PyAdvance;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord, UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected static RMethod r_Mop_Addition_GlyphValueRecord_GlyphValueRecord;
		public static RMethod RMop_Addition_GlyphValueRecord_GlyphValueRecord
		{
			get
			{
				if(r_Mop_Addition_GlyphValueRecord_GlyphValueRecord == null)
				{
					r_Mop_Addition_GlyphValueRecord_GlyphValueRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Addition", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_Mop_Addition_GlyphValueRecord_GlyphValueRecord.SetBelong(null);
				}
				return r_Mop_Addition_GlyphValueRecord_GlyphValueRecord;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Multiply(UnityEngine.TextCore.LowLevel.GlyphValueRecord, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_GlyphValueRecord_Single;
		public static RMethod RMop_Multiply_GlyphValueRecord_Single
		{
			get
			{
				if(r_Mop_Multiply_GlyphValueRecord_Single == null)
				{
					r_Mop_Multiply_GlyphValueRecord_Single = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Multiply", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(System.Single));
					r_Mop_Multiply_GlyphValueRecord_Single.SetBelong(null);
				}
				return r_Mop_Multiply_GlyphValueRecord_Single;
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
		/// Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected RMethod r_MEquals_GlyphValueRecord;
		public virtual RMethod RMEquals_GlyphValueRecord
		{
			get
			{
				if(r_MEquals_GlyphValueRecord == null)
				{
					r_MEquals_GlyphValueRecord = new(this, "Equals", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_MEquals_GlyphValueRecord.SetBelong(this.instance);
				}
				return r_MEquals_GlyphValueRecord;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphValueRecord, UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected static RMethod r_Mop_Equality_GlyphValueRecord_GlyphValueRecord;
		public static RMethod RMop_Equality_GlyphValueRecord_GlyphValueRecord
		{
			get
			{
				if(r_Mop_Equality_GlyphValueRecord_GlyphValueRecord == null)
				{
					r_Mop_Equality_GlyphValueRecord_GlyphValueRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Equality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_Mop_Equality_GlyphValueRecord_GlyphValueRecord.SetBelong(null);
				}
				return r_Mop_Equality_GlyphValueRecord_GlyphValueRecord;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphValueRecord, UnityEngine.TextCore.LowLevel.GlyphValueRecord)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GlyphValueRecord_GlyphValueRecord;
		public static RMethod RMop_Inequality_GlyphValueRecord_GlyphValueRecord
		{
			get
			{
				if(r_Mop_Inequality_GlyphValueRecord_GlyphValueRecord == null)
				{
					r_Mop_Inequality_GlyphValueRecord_GlyphValueRecord = new(typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), "op_Inequality", 0, typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord), typeof(UnityEngine.TextCore.LowLevel.GlyphValueRecord));
					r_Mop_Inequality_GlyphValueRecord_GlyphValueRecord.SetBelong(null);
				}
				return r_Mop_Inequality_GlyphValueRecord_GlyphValueRecord;
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

        public static UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord @a, UnityEngine.TextCore.LowLevel.GlyphValueRecord @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_GlyphValueRecord_GlyphValueRecord.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.LowLevel.GlyphValueRecord)___result;
        }


        public static UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Multiply(UnityEngine.TextCore.LowLevel.GlyphValueRecord @a, System.Single @emScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @emScale};
            var ___result = RMop_Multiply_GlyphValueRecord_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TextCore.LowLevel.GlyphValueRecord)___result;
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


        public virtual System.Boolean Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_GlyphValueRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.LowLevel.GlyphValueRecord @lhs, UnityEngine.TextCore.LowLevel.GlyphValueRecord @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_GlyphValueRecord_GlyphValueRecord.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.LowLevel.GlyphValueRecord @lhs, UnityEngine.TextCore.LowLevel.GlyphValueRecord @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_GlyphValueRecord_GlyphValueRecord.Invoke(___genericsType, ___parameters);

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
