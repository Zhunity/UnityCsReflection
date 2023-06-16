
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics
	/// </summary>
    public partial class RDrawStatistics : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+DrawStatistics");
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


		/// <summary>
		/// System.Int32 currentFrameIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrentFrameIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrentFrameIndex
		{
			get
			{
				if(r_FcurrentFrameIndex == null)
				{
					r_FcurrentFrameIndex = new(this, "currentFrameIndex");
				}
				return r_FcurrentFrameIndex;
			}
		}

		/// <summary>
		/// System.UInt32 totalIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FtotalIndices;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFtotalIndices
		{
			get
			{
				if(r_FtotalIndices == null)
				{
					r_FtotalIndices = new(this, "totalIndices");
				}
				return r_FtotalIndices;
			}
		}

		/// <summary>
		/// System.UInt32 commandCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FcommandCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcommandCount
		{
			get
			{
				if(r_FcommandCount == null)
				{
					r_FcommandCount = new(this, "commandCount");
				}
				return r_FcommandCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawCommandCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdrawCommandCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdrawCommandCount
		{
			get
			{
				if(r_FdrawCommandCount == null)
				{
					r_FdrawCommandCount = new(this, "drawCommandCount");
				}
				return r_FdrawCommandCount;
			}
		}

		/// <summary>
		/// System.UInt32 materialSetCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FmaterialSetCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFmaterialSetCount
		{
			get
			{
				if(r_FmaterialSetCount == null)
				{
					r_FmaterialSetCount = new(this, "materialSetCount");
				}
				return r_FmaterialSetCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawRangeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdrawRangeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdrawRangeCount
		{
			get
			{
				if(r_FdrawRangeCount == null)
				{
					r_FdrawRangeCount = new(this, "drawRangeCount");
				}
				return r_FdrawRangeCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawRangeCallCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FdrawRangeCallCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFdrawRangeCallCount
		{
			get
			{
				if(r_FdrawRangeCallCount == null)
				{
					r_FdrawRangeCallCount = new(this, "drawRangeCallCount");
				}
				return r_FdrawRangeCallCount;
			}
		}

		/// <summary>
		/// System.UInt32 immediateDraws
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FimmediateDraws;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFimmediateDraws
		{
			get
			{
				if(r_FimmediateDraws == null)
				{
					r_FimmediateDraws = new(this, "immediateDraws");
				}
				return r_FimmediateDraws;
			}
		}

		/// <summary>
		/// System.UInt32 stencilRefChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FstencilRefChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFstencilRefChanges
		{
			get
			{
				if(r_FstencilRefChanges == null)
				{
					r_FstencilRefChanges = new(this, "stencilRefChanges");
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
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
}