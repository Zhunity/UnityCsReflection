
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.UIR.NudgeJobData
	/// </summary>
    public partial class RNudgeJobData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.NudgeJobData");
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


		/// <summary>
		/// System.IntPtr src
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fsrc;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFsrc
		{
			get
			{
				if(r_Fsrc == null)
				{
					r_Fsrc = new(this, "src");
				}
				return r_Fsrc;
			}
		}

		/// <summary>
		/// System.IntPtr dst
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fdst;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFdst
		{
			get
			{
				if(r_Fdst == null)
				{
					r_Fdst = new(this, "dst");
				}
				return r_Fdst;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcount
		{
			get
			{
				if(r_Fcount == null)
				{
					r_Fcount = new(this, "count");
				}
				return r_Fcount;
			}
		}

		/// <summary>
		/// System.IntPtr closingSrc
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_FclosingSrc;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFclosingSrc
		{
			get
			{
				if(r_FclosingSrc == null)
				{
					r_FclosingSrc = new(this, "closingSrc");
				}
				return r_FclosingSrc;
			}
		}

		/// <summary>
		/// System.IntPtr closingDst
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_FclosingDst;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFclosingDst
		{
			get
			{
				if(r_FclosingDst == null)
				{
					r_FclosingDst = new(this, "closingDst");
				}
				return r_FclosingDst;
			}
		}

		/// <summary>
		/// System.Int32 closingCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FclosingCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFclosingCount
		{
			get
			{
				if(r_FclosingCount == null)
				{
					r_FclosingCount = new(this, "closingCount");
				}
				return r_FclosingCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_Ftransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFtransform
		{
			get
			{
				if(r_Ftransform == null)
				{
					r_Ftransform = new(this, "transform");
				}
				return r_Ftransform;
			}
		}

		/// <summary>
		/// System.Int32 vertsBeforeUVDisplacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvertsBeforeUVDisplacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvertsBeforeUVDisplacement
		{
			get
			{
				if(r_FvertsBeforeUVDisplacement == null)
				{
					r_FvertsBeforeUVDisplacement = new(this, "vertsBeforeUVDisplacement");
				}
				return r_FvertsBeforeUVDisplacement;
			}
		}

		/// <summary>
		/// System.Int32 vertsAfterUVDisplacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvertsAfterUVDisplacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvertsAfterUVDisplacement
		{
			get
			{
				if(r_FvertsAfterUVDisplacement == null)
				{
					r_FvertsAfterUVDisplacement = new(this, "vertsAfterUVDisplacement");
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
