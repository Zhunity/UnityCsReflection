using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics
	/// </summary>
    public partial class RDrawStatistics : RMember //
    {

		/// <summary>
		/// System.Int32 currentFrameIndex
		/// </summary>
		protected RSystem.RInt32 r_FcurrentFrameIndex;
		public virtual RSystem.RInt32 RFcurrentFrameIndex
		{
			get
			{
				if(r_FcurrentFrameIndex == null)
				{
					r_FcurrentFrameIndex = new(this, "currentFrameIndex");
					r_FcurrentFrameIndex.SetBelong(this.instance);
				}
				return r_FcurrentFrameIndex;
			}
		}

		/// <summary>
		/// System.UInt32 totalIndices
		/// </summary>
		protected RSystem.RUInt32 r_FtotalIndices;
		public virtual RSystem.RUInt32 RFtotalIndices
		{
			get
			{
				if(r_FtotalIndices == null)
				{
					r_FtotalIndices = new(this, "totalIndices");
					r_FtotalIndices.SetBelong(this.instance);
				}
				return r_FtotalIndices;
			}
		}

		/// <summary>
		/// System.UInt32 commandCount
		/// </summary>
		protected RSystem.RUInt32 r_FcommandCount;
		public virtual RSystem.RUInt32 RFcommandCount
		{
			get
			{
				if(r_FcommandCount == null)
				{
					r_FcommandCount = new(this, "commandCount");
					r_FcommandCount.SetBelong(this.instance);
				}
				return r_FcommandCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawCommandCount
		/// </summary>
		protected RSystem.RUInt32 r_FdrawCommandCount;
		public virtual RSystem.RUInt32 RFdrawCommandCount
		{
			get
			{
				if(r_FdrawCommandCount == null)
				{
					r_FdrawCommandCount = new(this, "drawCommandCount");
					r_FdrawCommandCount.SetBelong(this.instance);
				}
				return r_FdrawCommandCount;
			}
		}

		/// <summary>
		/// System.UInt32 materialSetCount
		/// </summary>
		protected RSystem.RUInt32 r_FmaterialSetCount;
		public virtual RSystem.RUInt32 RFmaterialSetCount
		{
			get
			{
				if(r_FmaterialSetCount == null)
				{
					r_FmaterialSetCount = new(this, "materialSetCount");
					r_FmaterialSetCount.SetBelong(this.instance);
				}
				return r_FmaterialSetCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawRangeCount
		/// </summary>
		protected RSystem.RUInt32 r_FdrawRangeCount;
		public virtual RSystem.RUInt32 RFdrawRangeCount
		{
			get
			{
				if(r_FdrawRangeCount == null)
				{
					r_FdrawRangeCount = new(this, "drawRangeCount");
					r_FdrawRangeCount.SetBelong(this.instance);
				}
				return r_FdrawRangeCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawRangeCallCount
		/// </summary>
		protected RSystem.RUInt32 r_FdrawRangeCallCount;
		public virtual RSystem.RUInt32 RFdrawRangeCallCount
		{
			get
			{
				if(r_FdrawRangeCallCount == null)
				{
					r_FdrawRangeCallCount = new(this, "drawRangeCallCount");
					r_FdrawRangeCallCount.SetBelong(this.instance);
				}
				return r_FdrawRangeCallCount;
			}
		}

		/// <summary>
		/// System.UInt32 immediateDraws
		/// </summary>
		protected RSystem.RUInt32 r_FimmediateDraws;
		public virtual RSystem.RUInt32 RFimmediateDraws
		{
			get
			{
				if(r_FimmediateDraws == null)
				{
					r_FimmediateDraws = new(this, "immediateDraws");
					r_FimmediateDraws.SetBelong(this.instance);
				}
				return r_FimmediateDraws;
			}
		}

		/// <summary>
		/// System.UInt32 stencilRefChanges
		/// </summary>
		protected RSystem.RUInt32 r_FstencilRefChanges;
		public virtual RSystem.RUInt32 RFstencilRefChanges
		{
			get
			{
				if(r_FstencilRefChanges == null)
				{
					r_FstencilRefChanges = new(this, "stencilRefChanges");
					r_FstencilRefChanges.SetBelong(this.instance);
				}
				return r_FstencilRefChanges;
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


        public RDrawStatistics() : base("UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics")
        {
        }

        public RDrawStatistics(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics")
		{
            SetInstance(instance);
		}

        public RDrawStatistics(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDrawStatistics(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}