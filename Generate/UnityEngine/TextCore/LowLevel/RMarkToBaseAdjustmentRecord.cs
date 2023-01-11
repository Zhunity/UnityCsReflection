using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord
	/// </summary>
    public partial class RMarkToBaseAdjustmentRecord : RMember //
    {

		/// <summary>
		/// System.UInt32 m_BaseGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_m_BaseGlyphID;
		public virtual RSystem.RUInt32 Rm_BaseGlyphID
		{
			get
			{
				if(r_m_BaseGlyphID == null)
				{
					r_m_BaseGlyphID = new(this, "m_BaseGlyphID");
					r_m_BaseGlyphID.SetBelong(this.instance);
				}
				return r_m_BaseGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_m_BaseGlyphAnchorPoint;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint Rm_BaseGlyphAnchorPoint
		{
			get
			{
				if(r_m_BaseGlyphAnchorPoint == null)
				{
					r_m_BaseGlyphAnchorPoint = new(this, "m_BaseGlyphAnchorPoint");
					r_m_BaseGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_m_BaseGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// System.UInt32 m_MarkGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_m_MarkGlyphID;
		public virtual RSystem.RUInt32 Rm_MarkGlyphID
		{
			get
			{
				if(r_m_MarkGlyphID == null)
				{
					r_m_MarkGlyphID = new(this, "m_MarkGlyphID");
					r_m_MarkGlyphID.SetBelong(this.instance);
				}
				return r_m_MarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_m_MarkPositionAdjustment;
		public virtual RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment Rm_MarkPositionAdjustment
		{
			get
			{
				if(r_m_MarkPositionAdjustment == null)
				{
					r_m_MarkPositionAdjustment = new(this, "m_MarkPositionAdjustment");
					r_m_MarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_m_MarkPositionAdjustment;
			}
		}

		/// <summary>
		/// UInt32 baseGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_baseGlyphID;
		public virtual RSystem.RUInt32 RbaseGlyphID
		{
			get
			{
				if(r_baseGlyphID == null)
				{
					r_baseGlyphID = new(this, "baseGlyphID", -1);
					r_baseGlyphID.SetBelong(this.instance);
				}
				return r_baseGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseGlyphAnchorPoint
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_baseGlyphAnchorPoint;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint RbaseGlyphAnchorPoint
		{
			get
			{
				if(r_baseGlyphAnchorPoint == null)
				{
					r_baseGlyphAnchorPoint = new(this, "baseGlyphAnchorPoint", -1);
					r_baseGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_baseGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// UInt32 markGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_markGlyphID;
		public virtual RSystem.RUInt32 RmarkGlyphID
		{
			get
			{
				if(r_markGlyphID == null)
				{
					r_markGlyphID = new(this, "markGlyphID", -1);
					r_markGlyphID.SetBelong(this.instance);
				}
				return r_markGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment markPositionAdjustment
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_markPositionAdjustment;
		public virtual RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment RmarkPositionAdjustment
		{
			get
			{
				if(r_markPositionAdjustment == null)
				{
					r_markPositionAdjustment = new(this, "markPositionAdjustment", -1);
					r_markPositionAdjustment.SetBelong(this.instance);
				}
				return r_markPositionAdjustment;
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


        public RMarkToBaseAdjustmentRecord() : base("UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord")
        {
        }

        public RMarkToBaseAdjustmentRecord(System.Object instance) : base("UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord")
		{
            SetInstance(instance);
		}

        public RMarkToBaseAdjustmentRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMarkToBaseAdjustmentRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
