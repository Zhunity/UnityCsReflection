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
		protected RSystem.RUInt32 r_Fm_BaseGlyphID;
		public virtual RSystem.RUInt32 RFm_BaseGlyphID
		{
			get
			{
				if(r_Fm_BaseGlyphID == null)
				{
					r_Fm_BaseGlyphID = new(this, "m_BaseGlyphID");
					r_Fm_BaseGlyphID.SetBelong(this.instance);
				}
				return r_Fm_BaseGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_Fm_BaseGlyphAnchorPoint;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint RFm_BaseGlyphAnchorPoint
		{
			get
			{
				if(r_Fm_BaseGlyphAnchorPoint == null)
				{
					r_Fm_BaseGlyphAnchorPoint = new(this, "m_BaseGlyphAnchorPoint");
					r_Fm_BaseGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_Fm_BaseGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// System.UInt32 m_MarkGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_Fm_MarkGlyphID;
		public virtual RSystem.RUInt32 RFm_MarkGlyphID
		{
			get
			{
				if(r_Fm_MarkGlyphID == null)
				{
					r_Fm_MarkGlyphID = new(this, "m_MarkGlyphID");
					r_Fm_MarkGlyphID.SetBelong(this.instance);
				}
				return r_Fm_MarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_Fm_MarkPositionAdjustment;
		public virtual RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment RFm_MarkPositionAdjustment
		{
			get
			{
				if(r_Fm_MarkPositionAdjustment == null)
				{
					r_Fm_MarkPositionAdjustment = new(this, "m_MarkPositionAdjustment");
					r_Fm_MarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_Fm_MarkPositionAdjustment;
			}
		}

		/// <summary>
		/// UInt32 baseGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_PbaseGlyphID;
		public virtual RSystem.RUInt32 RPbaseGlyphID
		{
			get
			{
				if(r_PbaseGlyphID == null)
				{
					r_PbaseGlyphID = new(this, "baseGlyphID", -1);
					r_PbaseGlyphID.SetBelong(this.instance);
				}
				return r_PbaseGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseGlyphAnchorPoint
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_PbaseGlyphAnchorPoint;
		public virtual RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint RPbaseGlyphAnchorPoint
		{
			get
			{
				if(r_PbaseGlyphAnchorPoint == null)
				{
					r_PbaseGlyphAnchorPoint = new(this, "baseGlyphAnchorPoint", -1);
					r_PbaseGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_PbaseGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// UInt32 markGlyphID
		/// </summary>
		protected RSystem.RUInt32 r_PmarkGlyphID;
		public virtual RSystem.RUInt32 RPmarkGlyphID
		{
			get
			{
				if(r_PmarkGlyphID == null)
				{
					r_PmarkGlyphID = new(this, "markGlyphID", -1);
					r_PmarkGlyphID.SetBelong(this.instance);
				}
				return r_PmarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment markPositionAdjustment
		/// </summary>
		protected RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_PmarkPositionAdjustment;
		public virtual RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment RPmarkPositionAdjustment
		{
			get
			{
				if(r_PmarkPositionAdjustment == null)
				{
					r_PmarkPositionAdjustment = new(this, "markPositionAdjustment", -1);
					r_PmarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_PmarkPositionAdjustment;
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
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
