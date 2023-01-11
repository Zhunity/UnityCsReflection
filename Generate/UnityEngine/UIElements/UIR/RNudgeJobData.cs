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
		protected RSystem.RIntPtr r_src;
		public virtual RSystem.RIntPtr Rsrc
		{
			get
			{
				if(r_src == null)
				{
					r_src = new(this, "src");
					r_src.SetBelong(this.instance);
				}
				return r_src;
			}
		}

		/// <summary>
		/// System.IntPtr dst
		/// </summary>
		protected RSystem.RIntPtr r_dst;
		public virtual RSystem.RIntPtr Rdst
		{
			get
			{
				if(r_dst == null)
				{
					r_dst = new(this, "dst");
					r_dst.SetBelong(this.instance);
				}
				return r_dst;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RSystem.RInt32 r_count;
		public virtual RSystem.RInt32 Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.IntPtr closingSrc
		/// </summary>
		protected RSystem.RIntPtr r_closingSrc;
		public virtual RSystem.RIntPtr RclosingSrc
		{
			get
			{
				if(r_closingSrc == null)
				{
					r_closingSrc = new(this, "closingSrc");
					r_closingSrc.SetBelong(this.instance);
				}
				return r_closingSrc;
			}
		}

		/// <summary>
		/// System.IntPtr closingDst
		/// </summary>
		protected RSystem.RIntPtr r_closingDst;
		public virtual RSystem.RIntPtr RclosingDst
		{
			get
			{
				if(r_closingDst == null)
				{
					r_closingDst = new(this, "closingDst");
					r_closingDst.SetBelong(this.instance);
				}
				return r_closingDst;
			}
		}

		/// <summary>
		/// System.Int32 closingCount
		/// </summary>
		protected RSystem.RInt32 r_closingCount;
		public virtual RSystem.RInt32 RclosingCount
		{
			get
			{
				if(r_closingCount == null)
				{
					r_closingCount = new(this, "closingCount");
					r_closingCount.SetBelong(this.instance);
				}
				return r_closingCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_transform;
		public virtual RUnityEngine.RMatrix4x4 Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform");
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// System.Int32 vertsBeforeUVDisplacement
		/// </summary>
		protected RSystem.RInt32 r_vertsBeforeUVDisplacement;
		public virtual RSystem.RInt32 RvertsBeforeUVDisplacement
		{
			get
			{
				if(r_vertsBeforeUVDisplacement == null)
				{
					r_vertsBeforeUVDisplacement = new(this, "vertsBeforeUVDisplacement");
					r_vertsBeforeUVDisplacement.SetBelong(this.instance);
				}
				return r_vertsBeforeUVDisplacement;
			}
		}

		/// <summary>
		/// System.Int32 vertsAfterUVDisplacement
		/// </summary>
		protected RSystem.RInt32 r_vertsAfterUVDisplacement;
		public virtual RSystem.RInt32 RvertsAfterUVDisplacement
		{
			get
			{
				if(r_vertsAfterUVDisplacement == null)
				{
					r_vertsAfterUVDisplacement = new(this, "vertsAfterUVDisplacement");
					r_vertsAfterUVDisplacement.SetBelong(this.instance);
				}
				return r_vertsAfterUVDisplacement;
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
