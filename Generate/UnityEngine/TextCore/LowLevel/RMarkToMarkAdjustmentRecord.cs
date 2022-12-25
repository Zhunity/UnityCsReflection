using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord
	/// </summary>
    public partial class RMarkToMarkAdjustmentRecord : RMember //
    {

		/// <summary>
		/// System.UInt32 m_BaseMarkGlyphID
		/// </summary>
		protected RField r_m_BaseMarkGlyphID;
		public virtual RField Rm_BaseMarkGlyphID
		{
			get
			{
				if(r_m_BaseMarkGlyphID == null)
				{
					r_m_BaseMarkGlyphID = new(this, "m_BaseMarkGlyphID");
					r_m_BaseMarkGlyphID.SetBelong(this.instance);
				}
				return r_m_BaseMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_m_BaseMarkGlyphAnchorPoint;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint Rm_BaseMarkGlyphAnchorPoint
		{
			get
			{
				if(r_m_BaseMarkGlyphAnchorPoint == null)
				{
					r_m_BaseMarkGlyphAnchorPoint = new(this, "m_BaseMarkGlyphAnchorPoint");
					r_m_BaseMarkGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_m_BaseMarkGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// System.UInt32 m_CombiningMarkGlyphID
		/// </summary>
		protected RField r_m_CombiningMarkGlyphID;
		public virtual RField Rm_CombiningMarkGlyphID
		{
			get
			{
				if(r_m_CombiningMarkGlyphID == null)
				{
					r_m_CombiningMarkGlyphID = new(this, "m_CombiningMarkGlyphID");
					r_m_CombiningMarkGlyphID.SetBelong(this.instance);
				}
				return r_m_CombiningMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_m_CombiningMarkPositionAdjustment;
		public virtual RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment Rm_CombiningMarkPositionAdjustment
		{
			get
			{
				if(r_m_CombiningMarkPositionAdjustment == null)
				{
					r_m_CombiningMarkPositionAdjustment = new(this, "m_CombiningMarkPositionAdjustment");
					r_m_CombiningMarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_m_CombiningMarkPositionAdjustment;
			}
		}

		/// <summary>
		/// UInt32 baseMarkGlyphID
		/// </summary>
		protected RProperty r_baseMarkGlyphID;
		public virtual RProperty RbaseMarkGlyphID
		{
			get
			{
				if(r_baseMarkGlyphID == null)
				{
					r_baseMarkGlyphID = new(this, "baseMarkGlyphID", -1);
					r_baseMarkGlyphID.SetBelong(this.instance);
				}
				return r_baseMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseMarkGlyphAnchorPoint
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_baseMarkGlyphAnchorPoint;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint RbaseMarkGlyphAnchorPoint
		{
			get
			{
				if(r_baseMarkGlyphAnchorPoint == null)
				{
					r_baseMarkGlyphAnchorPoint = new(this, "baseMarkGlyphAnchorPoint", -1);
					r_baseMarkGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_baseMarkGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// UInt32 combiningMarkGlyphID
		/// </summary>
		protected RProperty r_combiningMarkGlyphID;
		public virtual RProperty RcombiningMarkGlyphID
		{
			get
			{
				if(r_combiningMarkGlyphID == null)
				{
					r_combiningMarkGlyphID = new(this, "combiningMarkGlyphID", -1);
					r_combiningMarkGlyphID.SetBelong(this.instance);
				}
				return r_combiningMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment combiningMarkPositionAdjustment
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_combiningMarkPositionAdjustment;
		public virtual RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment RcombiningMarkPositionAdjustment
		{
			get
			{
				if(r_combiningMarkPositionAdjustment == null)
				{
					r_combiningMarkPositionAdjustment = new(this, "combiningMarkPositionAdjustment", -1);
					r_combiningMarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_combiningMarkPositionAdjustment;
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


        public RMarkToMarkAdjustmentRecord() : base("UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord")
        {
        }

        public RMarkToMarkAdjustmentRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord")
		{
            SetInstance(instance);
		}

        public RMarkToMarkAdjustmentRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMarkToMarkAdjustmentRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
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
