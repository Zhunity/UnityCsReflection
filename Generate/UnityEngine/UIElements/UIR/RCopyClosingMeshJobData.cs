using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.CopyClosingMeshJobData
	/// </summary>
    public partial class RCopyClosingMeshJobData : RMember //
    {

		/// <summary>
		/// System.IntPtr vertSrc
		/// </summary>
		protected RField r_vertSrc;
		public virtual RField RvertSrc
		{
			get
			{
				if(r_vertSrc == null)
				{
					r_vertSrc = new(this, "vertSrc");
					r_vertSrc.SetBelong(this.instance);
				}
				return r_vertSrc;
			}
		}

		/// <summary>
		/// System.IntPtr vertDst
		/// </summary>
		protected RField r_vertDst;
		public virtual RField RvertDst
		{
			get
			{
				if(r_vertDst == null)
				{
					r_vertDst = new(this, "vertDst");
					r_vertDst.SetBelong(this.instance);
				}
				return r_vertDst;
			}
		}

		/// <summary>
		/// System.Int32 vertCount
		/// </summary>
		protected RField r_vertCount;
		public virtual RField RvertCount
		{
			get
			{
				if(r_vertCount == null)
				{
					r_vertCount = new(this, "vertCount");
					r_vertCount.SetBelong(this.instance);
				}
				return r_vertCount;
			}
		}

		/// <summary>
		/// System.IntPtr indexSrc
		/// </summary>
		protected RField r_indexSrc;
		public virtual RField RindexSrc
		{
			get
			{
				if(r_indexSrc == null)
				{
					r_indexSrc = new(this, "indexSrc");
					r_indexSrc.SetBelong(this.instance);
				}
				return r_indexSrc;
			}
		}

		/// <summary>
		/// System.IntPtr indexDst
		/// </summary>
		protected RField r_indexDst;
		public virtual RField RindexDst
		{
			get
			{
				if(r_indexDst == null)
				{
					r_indexDst = new(this, "indexDst");
					r_indexDst.SetBelong(this.instance);
				}
				return r_indexDst;
			}
		}

		/// <summary>
		/// System.Int32 indexCount
		/// </summary>
		protected RField r_indexCount;
		public virtual RField RindexCount
		{
			get
			{
				if(r_indexCount == null)
				{
					r_indexCount = new(this, "indexCount");
					r_indexCount.SetBelong(this.instance);
				}
				return r_indexCount;
			}
		}

		/// <summary>
		/// System.Int32 indexOffset
		/// </summary>
		protected RField r_indexOffset;
		public virtual RField RindexOffset
		{
			get
			{
				if(r_indexOffset == null)
				{
					r_indexOffset = new(this, "indexOffset");
					r_indexOffset.SetBelong(this.instance);
				}
				return r_indexOffset;
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


        public RCopyClosingMeshJobData() : base("UnityEngine.UIElements.UIR.CopyClosingMeshJobData")
        {
        }

        public RCopyClosingMeshJobData(System.Object instance) : base("UnityEngine.UIElements.UIR.CopyClosingMeshJobData")
		{
            SetInstance(instance);
		}

        public RCopyClosingMeshJobData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCopyClosingMeshJobData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
