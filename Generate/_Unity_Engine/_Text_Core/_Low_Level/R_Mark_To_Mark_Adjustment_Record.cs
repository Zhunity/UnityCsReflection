
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
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_BaseMarkGlyphID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_BaseMarkGlyphID
		{
			get
			{
				if(r_Fm_BaseMarkGlyphID == null)
				{
					r_Fm_BaseMarkGlyphID = new(this, "m_BaseMarkGlyphID");
					r_Fm_BaseMarkGlyphID.SetBelong(this.instance);
				}
				return r_Fm_BaseMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_Fm_BaseMarkGlyphAnchorPoint;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint RFm_BaseMarkGlyphAnchorPoint
		{
			get
			{
				if(r_Fm_BaseMarkGlyphAnchorPoint == null)
				{
					r_Fm_BaseMarkGlyphAnchorPoint = new(this, "m_BaseMarkGlyphAnchorPoint");
					r_Fm_BaseMarkGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_Fm_BaseMarkGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// System.UInt32 m_CombiningMarkGlyphID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_CombiningMarkGlyphID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_CombiningMarkGlyphID
		{
			get
			{
				if(r_Fm_CombiningMarkGlyphID == null)
				{
					r_Fm_CombiningMarkGlyphID = new(this, "m_CombiningMarkGlyphID");
					r_Fm_CombiningMarkGlyphID.SetBelong(this.instance);
				}
				return r_Fm_CombiningMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_Fm_CombiningMarkPositionAdjustment;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment RFm_CombiningMarkPositionAdjustment
		{
			get
			{
				if(r_Fm_CombiningMarkPositionAdjustment == null)
				{
					r_Fm_CombiningMarkPositionAdjustment = new(this, "m_CombiningMarkPositionAdjustment");
					r_Fm_CombiningMarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_Fm_CombiningMarkPositionAdjustment;
			}
		}

		/// <summary>
		/// UInt32 baseMarkGlyphID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PbaseMarkGlyphID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPbaseMarkGlyphID
		{
			get
			{
				if(r_PbaseMarkGlyphID == null)
				{
					r_PbaseMarkGlyphID = new(this, "baseMarkGlyphID", -1);
					r_PbaseMarkGlyphID.SetBelong(this.instance);
				}
				return r_PbaseMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseMarkGlyphAnchorPoint
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint r_PbaseMarkGlyphAnchorPoint;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphAnchorPoint RPbaseMarkGlyphAnchorPoint
		{
			get
			{
				if(r_PbaseMarkGlyphAnchorPoint == null)
				{
					r_PbaseMarkGlyphAnchorPoint = new(this, "baseMarkGlyphAnchorPoint", -1);
					r_PbaseMarkGlyphAnchorPoint.SetBelong(this.instance);
				}
				return r_PbaseMarkGlyphAnchorPoint;
			}
		}

		/// <summary>
		/// UInt32 combiningMarkGlyphID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PcombiningMarkGlyphID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPcombiningMarkGlyphID
		{
			get
			{
				if(r_PcombiningMarkGlyphID == null)
				{
					r_PcombiningMarkGlyphID = new(this, "combiningMarkGlyphID", -1);
					r_PcombiningMarkGlyphID.SetBelong(this.instance);
				}
				return r_PcombiningMarkGlyphID;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment combiningMarkPositionAdjustment
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment r_PcombiningMarkPositionAdjustment;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkPositionAdjustment RPcombiningMarkPositionAdjustment
		{
			get
			{
				if(r_PcombiningMarkPositionAdjustment == null)
				{
					r_PcombiningMarkPositionAdjustment = new(this, "combiningMarkPositionAdjustment", -1);
					r_PcombiningMarkPositionAdjustment.SetBelong(this.instance);
				}
				return r_PcombiningMarkPositionAdjustment;
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
