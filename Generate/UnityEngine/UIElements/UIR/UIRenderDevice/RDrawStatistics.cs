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
		protected RField r_currentFrameIndex;
		public virtual RField RcurrentFrameIndex
		{
			get
			{
				if(r_currentFrameIndex == null)
				{
					r_currentFrameIndex = new(this, "currentFrameIndex");
					r_currentFrameIndex.SetBelong(this.instance);
				}
				return r_currentFrameIndex;
			}
		}

		/// <summary>
		/// System.UInt32 totalIndices
		/// </summary>
		protected RField r_totalIndices;
		public virtual RField RtotalIndices
		{
			get
			{
				if(r_totalIndices == null)
				{
					r_totalIndices = new(this, "totalIndices");
					r_totalIndices.SetBelong(this.instance);
				}
				return r_totalIndices;
			}
		}

		/// <summary>
		/// System.UInt32 commandCount
		/// </summary>
		protected RField r_commandCount;
		public virtual RField RcommandCount
		{
			get
			{
				if(r_commandCount == null)
				{
					r_commandCount = new(this, "commandCount");
					r_commandCount.SetBelong(this.instance);
				}
				return r_commandCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawCommandCount
		/// </summary>
		protected RField r_drawCommandCount;
		public virtual RField RdrawCommandCount
		{
			get
			{
				if(r_drawCommandCount == null)
				{
					r_drawCommandCount = new(this, "drawCommandCount");
					r_drawCommandCount.SetBelong(this.instance);
				}
				return r_drawCommandCount;
			}
		}

		/// <summary>
		/// System.UInt32 materialSetCount
		/// </summary>
		protected RField r_materialSetCount;
		public virtual RField RmaterialSetCount
		{
			get
			{
				if(r_materialSetCount == null)
				{
					r_materialSetCount = new(this, "materialSetCount");
					r_materialSetCount.SetBelong(this.instance);
				}
				return r_materialSetCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawRangeCount
		/// </summary>
		protected RField r_drawRangeCount;
		public virtual RField RdrawRangeCount
		{
			get
			{
				if(r_drawRangeCount == null)
				{
					r_drawRangeCount = new(this, "drawRangeCount");
					r_drawRangeCount.SetBelong(this.instance);
				}
				return r_drawRangeCount;
			}
		}

		/// <summary>
		/// System.UInt32 drawRangeCallCount
		/// </summary>
		protected RField r_drawRangeCallCount;
		public virtual RField RdrawRangeCallCount
		{
			get
			{
				if(r_drawRangeCallCount == null)
				{
					r_drawRangeCallCount = new(this, "drawRangeCallCount");
					r_drawRangeCallCount.SetBelong(this.instance);
				}
				return r_drawRangeCallCount;
			}
		}

		/// <summary>
		/// System.UInt32 immediateDraws
		/// </summary>
		protected RField r_immediateDraws;
		public virtual RField RimmediateDraws
		{
			get
			{
				if(r_immediateDraws == null)
				{
					r_immediateDraws = new(this, "immediateDraws");
					r_immediateDraws.SetBelong(this.instance);
				}
				return r_immediateDraws;
			}
		}

		/// <summary>
		/// System.UInt32 stencilRefChanges
		/// </summary>
		protected RField r_stencilRefChanges;
		public virtual RField RstencilRefChanges
		{
			get
			{
				if(r_stencilRefChanges == null)
				{
					r_stencilRefChanges = new(this, "stencilRefChanges");
					r_stencilRefChanges.SetBelong(this.instance);
				}
				return r_stencilRefChanges;
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
}