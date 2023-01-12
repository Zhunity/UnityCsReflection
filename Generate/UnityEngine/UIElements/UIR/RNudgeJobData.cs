using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.NudgeJobData
	/// </summary>
    public partial class RNudgeJobData : RMember //
    {

		/// <summary>
		/// System.IntPtr src
		/// </summary>
		protected RSystem.RIntPtr r_Fsrc;
		public virtual RSystem.RIntPtr RFsrc
		{
			get
			{
				if(r_Fsrc == null)
				{
					r_Fsrc = new(this, "src");
					r_Fsrc.SetBelong(this.instance);
				}
				return r_Fsrc;
			}
		}

		/// <summary>
		/// System.IntPtr dst
		/// </summary>
		protected RSystem.RIntPtr r_Fdst;
		public virtual RSystem.RIntPtr RFdst
		{
			get
			{
				if(r_Fdst == null)
				{
					r_Fdst = new(this, "dst");
					r_Fdst.SetBelong(this.instance);
				}
				return r_Fdst;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RSystem.RInt32 r_Fcount;
		public virtual RSystem.RInt32 RFcount
		{
			get
			{
				if(r_Fcount == null)
				{
					r_Fcount = new(this, "count");
					r_Fcount.SetBelong(this.instance);
				}
				return r_Fcount;
			}
		}

		/// <summary>
		/// System.IntPtr closingSrc
		/// </summary>
		protected RSystem.RIntPtr r_FclosingSrc;
		public virtual RSystem.RIntPtr RFclosingSrc
		{
			get
			{
				if(r_FclosingSrc == null)
				{
					r_FclosingSrc = new(this, "closingSrc");
					r_FclosingSrc.SetBelong(this.instance);
				}
				return r_FclosingSrc;
			}
		}

		/// <summary>
		/// System.IntPtr closingDst
		/// </summary>
		protected RSystem.RIntPtr r_FclosingDst;
		public virtual RSystem.RIntPtr RFclosingDst
		{
			get
			{
				if(r_FclosingDst == null)
				{
					r_FclosingDst = new(this, "closingDst");
					r_FclosingDst.SetBelong(this.instance);
				}
				return r_FclosingDst;
			}
		}

		/// <summary>
		/// System.Int32 closingCount
		/// </summary>
		protected RSystem.RInt32 r_FclosingCount;
		public virtual RSystem.RInt32 RFclosingCount
		{
			get
			{
				if(r_FclosingCount == null)
				{
					r_FclosingCount = new(this, "closingCount");
					r_FclosingCount.SetBelong(this.instance);
				}
				return r_FclosingCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Ftransform;
		public virtual RUnityEngine.RMatrix4x4 RFtransform
		{
			get
			{
				if(r_Ftransform == null)
				{
					r_Ftransform = new(this, "transform");
					r_Ftransform.SetBelong(this.instance);
				}
				return r_Ftransform;
			}
		}

		/// <summary>
		/// System.Int32 vertsBeforeUVDisplacement
		/// </summary>
		protected RSystem.RInt32 r_FvertsBeforeUVDisplacement;
		public virtual RSystem.RInt32 RFvertsBeforeUVDisplacement
		{
			get
			{
				if(r_FvertsBeforeUVDisplacement == null)
				{
					r_FvertsBeforeUVDisplacement = new(this, "vertsBeforeUVDisplacement");
					r_FvertsBeforeUVDisplacement.SetBelong(this.instance);
				}
				return r_FvertsBeforeUVDisplacement;
			}
		}

		/// <summary>
		/// System.Int32 vertsAfterUVDisplacement
		/// </summary>
		protected RSystem.RInt32 r_FvertsAfterUVDisplacement;
		public virtual RSystem.RInt32 RFvertsAfterUVDisplacement
		{
			get
			{
				if(r_FvertsAfterUVDisplacement == null)
				{
					r_FvertsAfterUVDisplacement = new(this, "vertsAfterUVDisplacement");
					r_FvertsAfterUVDisplacement.SetBelong(this.instance);
				}
				return r_FvertsAfterUVDisplacement;
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


        public RNudgeJobData() : base("UnityEngine.UIElements.UIR.NudgeJobData")
        {
        }

        public RNudgeJobData(System.Object instance) : base("UnityEngine.UIElements.UIR.NudgeJobData")
		{
            SetInstance(instance);
		}

        public RNudgeJobData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNudgeJobData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
